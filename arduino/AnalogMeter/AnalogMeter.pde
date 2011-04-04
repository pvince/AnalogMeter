#define MAX_VALUE    180 // Max value to write to the analog display.
#define WRITE_DELAY  500 // Delay between updates to the analog display.  I see this is flawed now.
#define INLENGTH     16  // Max length of a single input string before it is auto-terminated.
#define INTERMINATOR 126 // ~

/*
I think I am going to update the comm protocal:
[Type][Value][Terminator]
    L1.67~  -- System Load for Unix
    M98~    -- Memory % used for Unix / Windows
    C35~    -- CPU % used

Maybe extend "Type" to include setting variables?
One issue is if "load" gets too high, it just sits at max.
If we could change Load, via a "Set" command, like "SL4~".
 */
char inString[INLENGTH+1];
int inCount;

int ledPin = 9;    // LED connected to digital pin 9
int currentValue = 0;

void setup()  {
  Serial.begin(9600);
  analogWrite(ledPin, currentValue);
} 

void loop()  {
/*
Idea for here, implement a kind of simple command queue.
- Increase length of input string to 128 or so
- Read input until we are out of serial data or hit 128
Fall through to a parse section
- Process the string
  1. check character 0 for command type
  2. Read contents until we hit ~ or end of string.
  2.1. If we hit ~ then depending on char0, execute the appropriate command,
       then return to input read waiting.
  2.2. If we hit end of string, return to input read waiting.

*/

  inCount = 0;
  do {
    while (!Serial.available());             // wait for input
    inString[inCount] = Serial.read();       // get it
    if (inString [inCount] == INTERMINATOR) {
      Serial.flush();
      break;
    }
  } while (++inCount < INLENGTH);
  inString[inCount] = 0;                     // null terminate the string
  if(inString[0] == 'C') {
    // CPU standard 100%
  } else if (inString[0] == 'L') {
    // Load, we render from 0 to 3
  } else if (inString[0] == 'M') {
    // Memory % - 0 to 100
  }
  float test = atof(inString);
  Serial.print(inString);
  Serial.print(" - ");
  Serial.println(test);
  //gotoValue(test*53.33 );
  gotoValue(test*0.9 );
}

void gotoValue(int target) {
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
    analogWrite(ledPin, i);
    delay(5);
  }
}

