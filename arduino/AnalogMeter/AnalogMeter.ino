#define DEBUG 0

#define MAX_VALUE    180
// Max value to write to the analog display.
#define NEEDLE_SPD   3    // Speed for needle movement.  (0 - 10)

#define DISP_PIN_1  14    // 3v Circular Analog display
#define DISP_PIN_2  15    // 3v Circular Analog display
#define DISP_PIN_3  11    // Unused...
#define DISP_PIN_4  12    // Unused...

float MULT_64 = MAX_VALUE / 64.0;

int currentD1Value = 0;
int currentD2Value = 0;
/*
Protocol:
- 1 Byte in size.
- [00]   [00 0000]
   ID#   Data Bits

ID#
- Display ID#, 0-3
- Allows for 4 displays.
Data
- Value to set the display too, 0-63
- Gives us 64 positions on an analog display.
 */

void setup()  {
  Serial.begin(9600);
  
  // Setup display pins
  pinMode(DISP_PIN_1, OUTPUT);
  pinMode(DISP_PIN_2, OUTPUT);
  
  //Serial.print("MULT_64 = ");
  //Serial.println(MULT_64);
  analogWrite(DISP_PIN_1, currentD1Value);
  analogWrite(DISP_PIN_2, currentD2Value);
} 

void loop() {
  while(!Serial.available()); // Wait until data is available.
  byte curCmd = 0; 
  if( Serial.available() ) {
    curCmd = Serial.read();
    if(DEBUG) {
      Serial.write(curCmd);
      Serial.write(255);
    }
    int dispID = curCmd >> 6; // Grab upper 2 bits
    int dispValue = (curCmd & 63); // Grab lower 6 bits
    if(DEBUG) {
      Serial.write(dispID);
      Serial.write(255);
      Serial.write(dispValue);
    }
    gotoValue(dispValue, dispID); // Set the display to the value.
  }
}

void gotoValue(int target, int dispID) {
  target *= MULT_64;
  //Serial.print(" - gotoValue: target - ");
  //Serial.println(target);
  int currentValue = 0;
	
  int targetPin = DISP_PIN_3;
  switch(dispID) {
    case 0:
      targetPin = DISP_PIN_1;
			currentValue = currentD1Value;
      break;
    case 1:
      targetPin = DISP_PIN_2;
			currentValue = currentD2Value;
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
	
  switch(dispID) {
    case 0:
			currentD1Value = currentValue;
      break;
    case 1:
			currentD2Value = currentValue;
      break;
  }
}

