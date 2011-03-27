                   /*
 Fading
 
 This example shows how to fade an LED using the analogWrite() function.
 
 The circuit:
 * LED attached from digital pin 9 to ground.
 
 Created 1 Nov 2008
 By David A. Mellis
 Modified 17 June 2009
 By Tom Igoe
 
 http://arduino.cc/en/Tutorial/Fading
 
 This example code is in the public domain.
          
 */
#define MAX_VALUE   160
#define WRITE_DELAY 500
#define INLENGTH 16
#define INTERMINATOR 13

char inString[INLENGTH+1];
int inCount;

int ledPin = 9;    // LED connected to digital pin 9
int currentValue = 0;

void setup()  {
  Serial.begin(9600);
  analogWrite(ledPin, currentValue);
} 

void loop()  {
  inCount = 0;
  do {
    while (!Serial.available());             // wait for input
    inString[inCount] = Serial.read();       // get it
    if (inString [inCount] == INTERMINATOR) break;
  } while (++inCount < INLENGTH);
  inString[inCount] = 0;                     // null terminate the string
  Serial.println(inString);
  /*
  gotoValue(MAX_VALUE);
  delay(WRITE_DELAY);
  gotoValue(MAX_VALUE * .5);
  delay(WRITE_DELAY);
  gotoValue(MAX_VALUE * .25);
  delay(WRITE_DELAY);
  gotoValue(MAX_VALUE * .5);
  delay(WRITE_DELAY);
  gotoValue(MAX_VALUE);
  delay(WRITE_DELAY);
  gotoValue(MAX_VALUE * .25);
  delay(WRITE_DELAY);
  gotoValue(MAX_VALUE * .75);
  delay(WRITE_DELAY);*/
}

void gotoValue(int target) {
  int dir = 1;
  if(currentValue > target) {
    dir = -1;
  }
  for(int i = currentValue; i != target; i = i + (dir * 1)) {
    currentValue = i;
    analogWrite(ledPin, i);
    delay(5);
  }
}

