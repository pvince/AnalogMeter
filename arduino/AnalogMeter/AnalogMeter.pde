#define MAX_VALUE   180
#define WRITE_DELAY 500
#define INLENGTH 16
#define INTERMINATOR 126

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
    if (inString [inCount] == INTERMINATOR) {
      Serial.flush();
      break;
    }
  } while (++inCount < INLENGTH);
  inString[inCount] = 0;                     // null terminate the string
  float test = atof(inString);
  Serial.print(inString);
  Serial.print(" - ");
  Serial.println(test);
  gotoValue(test*53.33 );
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

