#define ARRAY_SIZE 5

// motor A
int dir1PinA = 13;
int dir2PinA = 12;
int speedPinA = 10;
int calibA = 28;

// motor B
int dir1PinB = 11;
int dir2PinB = 8;
int speedPinB = 9;
int calibB = 0;

int ledR = 3;
int ledG = 5;
int ledB = 4;

const int pingPin = 7;

char temp[ARRAY_SIZE] = {0,0,0,0,0};

unsigned long time;
unsigned int received;
unsigned long speed;
unsigned long command;

int leftSpeed=0;
int rightSpeed=0;
int dir;

void setup() {
  Serial.begin(9600);
  motorsInit();
  pinMode(pingPin, OUTPUT);
  time = millis();
  speed = 0;
  dir = 1;
  while(!Serial.available()){
    blinkR(2);
  }
}

void loop(){
  delay(70);
  if(Serial.available() == 5){
    received=0;
    for(int k=0; k<ARRAY_SIZE; k++){
       temp[k]=0;
    }
    
    temp[0] = Serial.read();
    temp[1] = Serial.read();
    temp[2] = Serial.read();
    temp[3] = Serial.read();
    temp[4] = Serial.read();
    
    received = 10000*fixInt(int(temp[0])) +
                1000*fixInt(int(temp[1])) + 
                 100*fixInt(int(temp[2])) + 
                  10*fixInt(int(temp[3])) +
                   1*fixInt(int(temp[4]));
    speed =      100*fixInt(int(temp[2])) + 
                  10*fixInt(int(temp[3])) +
                   1*fixInt(int(temp[4]));
    command =  fixInt(int(temp[1]));
    
      Serial.println(received);
      //Serial.println(speed);
      //Serial.println(command);
      switch(received / 10000){
      case 1: //Two tracks, same direction
              switch(command){
                case 0: forward();
                        analogWrite(speedPinA, speed - calibA);
                        analogWrite(speedPinB, speed - calibB);
                        blinkG(2);
                        break;
                case 1: backwards();
                        analogWrite(speedPinA, speed - calibA);
                        analogWrite(speedPinB, speed - calibB);
                        blinkG(2);
                        break;
              }
              break;
      case 2: //Two tracks, opposite directions
              switch(command){
                case 0: toLeft();
                        analogWrite(speedPinA, speed);
                        analogWrite(speedPinB, speed);
                        blinkB(2);
                        break;
                case 1: toRight();
                        analogWrite(speedPinA, speed);
                        analogWrite(speedPinB, speed);
                        blinkB(2);
                        break;
              }
              break;
      case 3: //Stop all action
              setStop();
              stopLight();
              break;
      case 4: switch(command){
                case 0: Serial.print(distance());
                        break;
                case 1: 
                        break;
              }
              distance();
              break;
      case 5: break;   }
    
    
  } else Serial.flush();  
}

void motorsInit(){
  pinMode(dir1PinA, OUTPUT);
  pinMode(dir2PinA, OUTPUT);
  pinMode(speedPinA, OUTPUT);
  pinMode(dir1PinB, OUTPUT);
  pinMode(dir2PinB, OUTPUT);
  pinMode(speedPinB, OUTPUT);
  pinMode(ledR, OUTPUT);
  pinMode(ledG, OUTPUT);
  pinMode(ledB, OUTPUT);
} 

void forward(){
    digitalWrite(dir1PinA, HIGH);
    digitalWrite(dir2PinA, LOW);
    digitalWrite(dir1PinB, LOW);
    digitalWrite(dir2PinB, HIGH);
}

void backwards(){
    digitalWrite(dir1PinA, LOW);
    digitalWrite(dir2PinA, HIGH);
    digitalWrite(dir1PinB, HIGH);
    digitalWrite(dir2PinB, LOW);
}

void toLeft(){
    digitalWrite(dir1PinA, LOW);
    digitalWrite(dir2PinA, HIGH);
    digitalWrite(dir1PinB, LOW);
    digitalWrite(dir2PinB, HIGH);
}

void toRight(){
    digitalWrite(dir1PinA, HIGH);
    digitalWrite(dir2PinA, LOW);
    digitalWrite(dir1PinB, HIGH);
    digitalWrite(dir2PinB, LOW);
}

void setStop(){
    digitalWrite(dir1PinA, LOW);
    digitalWrite(dir2PinA, LOW);
    digitalWrite(dir1PinB, LOW);
    digitalWrite(dir2PinB, LOW);
  }

unsigned long distance(){
  long duration, cm;
  pinMode(pingPin, OUTPUT);
  digitalWrite(pingPin, LOW);
  delayMicroseconds(2);
  digitalWrite(pingPin, HIGH);
  delayMicroseconds(5);
  digitalWrite(pingPin, LOW);
  pinMode(pingPin, INPUT);
  duration = pulseIn(pingPin, HIGH); 
  cm = microsecondsToCentimeters(duration);
  return cm;
}

long microsecondsToCentimeters(long microseconds){
  return microseconds / 29 / 2;
}

int fixInt(int in){
 int out = in-48;
 return out; 
}

void blinkR(int times){
  int i;
  for(i=0;i<times;i++){
    digitalWrite(ledR, HIGH);
    delay(40);
    digitalWrite(ledR,LOW);
    delay(40);
  }  
}

void blinkG(int times){
  int i;
  for(i=0;i<times;i++){
    digitalWrite(ledG, HIGH);
    delay(40);
    digitalWrite(ledG,LOW);
    delay(40);
  }  
}

void blinkB(int times){
  int i;
  for(i=0;i<times;i++){
    digitalWrite(ledB, HIGH);
    delay(40);
    digitalWrite(ledB,LOW);
    delay(40);
  }  
}

void stopLight(){
  for(int i=255; i>=0; i--){
   analogWrite(ledR, i); 
    delay(1);
  }
}
