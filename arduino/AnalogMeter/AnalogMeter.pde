#define MAX_VALUE    210  // Max value to write to the analog display.
#define WRITE_DELAY  500  // Delay between updates to the analog display.  I see this is flawed now.
#define NEEDLE_SPD   3    // Speed for needle movement.  (0 - 10)

#define INLENGTH     128  //Length of a single input string before it is auto-terminated.
#define INTERMINATOR 126  // ~

#define DISP_PIN_1  9     // 3v Circular Analog display
#define DISP_PIN_2  10    // 3v Circular Analog display
#define DISP_PIN_3  11    // Unused...
#define DISP_PIN_4  12    // Unused...

#define MULT_200    0.9   // (Deprecated) Used for 200% outputs (Linux CPU) 
#define MULT_100    0.45  // (Deprecated) Used for 100% outputs (CPU, Memory)
#define MULT_4      53.3  // (Deprecated) Used for system load. (Set for 4 threads max)
float MULT_64 = MAX_VALUE / 64;
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

char inString[INLENGTH+1];
int inCount = 0;
char cmdStr[INLENGTH+1];
int cmdCnt = 0;

int currentValue = 0;
char currentCmd = 0;

void setup()  {
  Serial.begin(9600);
  analogWrite(DISP_PIN_1, currentValue);
} 

void loop() {
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

void loop2()  {
	gotoValue(32);
	delay(1000);
	gotoValue(64);
	delay(1000);
	gotoValue(0);
	delay(1000);
	gotoValue(0);
	
}

void gotoValue(int target) {
  gotoValue(target, DISP_PIN_1);
}

void gotoValue(int target, int dispPin) {
  target *= MULT_64;
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
  for(int i = currentValue; i != target; i = i + (dir * 1)) {
    currentValue = i;
    analogWrite(targetPin, i);
    delay(NEEDLE_SPD);
  }
}

