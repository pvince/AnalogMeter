#define MAX_VALUE    180
// Max value to write to the analog display.
#define NEEDLE_SPD   3    // Speed for needle movement.  (0 - 10)

#define DISP_PIN_1  14    // 3v Circular Analog display
#define DISP_PIN_2  15    // 3v Circular Analog display
#define DISP_PIN_3  11    // Unused...
#define DISP_PIN_4  12    // Unused...

float MULT_64 = MAX_VALUE / 64.0
;
int currentValue = 0;
/*
Protocol:
- 1 Byte in size.
- [00]   [00 0000]
   ID#   Data Bits

ID#
- Display ID#, 0-3
- Allows for 4 displays.
Data
- Value to set the display too, 0-64
- Gives us 64 positions on an analog display.
 */

void setup()  {
  Serial.begin(9600);
  
  // Setup display pins
  pinMode(DISP_PIN_1, OUTPUT);
  pinMode(DISP_PIN_2, OUTPUT);
  
  Serial.print("MULT_64 = ");
  Serial.println(MULT_64);
  analogWrite(DISP_PIN_1, currentValue);
} 

void loop3() {
  while(!Serial.available()); // Wait until data is available.
  byte curCmd = 0; 
  if( Serial.available() ) {
    curCmd = Serial.read();
	Serial.print(curCmd);
    int dispID = (curCmd & 192) >> 6; // Grab upper 2 bits
    int dispValue = (curCmd & 63); // Grab lower 6 bits
	Serial.print(dispID);
	Serial.print(dispValue);
    gotoValue(dispValue, dispID); // Set the display to the value.
  }
}

void loop()  {
  gotoValue(32, 1);
  gotoValue(32, 2);
  Serial.println("Loop: Goto 32");
  delay(1000);
  gotoValue(64, 1);
  gotoValue(64, 2);
  Serial.println("Loop: Goto 64");
  delay(1000);
  gotoValue(32, 1);
  gotoValue(32, 2);
  Serial.println("Loop: Goto 32");
  delay(1000);
  gotoValue(0, 1);
  gotoValue(0, 2);
  Serial.println("Loop: Goto 0");
  delay(1000);
  
	
}

void gotoValue(int target) {
  gotoValue(target, DISP_PIN_1);
}

void gotoValue(int target, int dispPin) {
  target *= MULT_64;
  Serial.print(" - gotoValue: target - ");
  Serial.println(target);
  
  int targetPin = DISP_PIN_1;
  switch(dispPin) {
    case 1:
      targetPin = DISP_PIN_1;
      break;
    case 2:
      targetPin = DISP_PIN_2;
      break;
    case 3:
      targetPin = DISP_PIN_3;
      break;
    case 4:
      targetPin = DISP_PIN_4;
      break;
  }

  // Do a quick sanity check on the target value.
  if(target > MAX_VALUE)
    target = MAX_VALUE;
  if(target < 0)
    target = 0;
    
  // Establish if we are counting up or down.
  int dir = 1;
  if(currentValue > target)
    dir = -1;
    
  // Loop until we have hit the target value.
  int startValue = currentValue;
  for(int i = startValue; i != target; i = i + (dir * 1)) {
    currentValue = i;
    analogWrite(targetPin, i);
    delay(NEEDLE_SPD);
  }
}

