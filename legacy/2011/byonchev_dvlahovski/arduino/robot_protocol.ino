#include <L293DN.h>

L293DN_MotorController motors(5,6, 10, 11, 2);

void setup()
{
  Serial.begin(9600);
}

void executeCommand(char command)
{
  /* To which motor is the command */
  int motor = (command >> 6) & 0xff;
  
  /* Forward/Backward/Stop/Skip */
  int movement = (command >> 4) & 0xff;
  
  /* If the rotation flag is set, first 4 bits are ignored */
  bool rotate = (command >> 3) & 0xf;
  
  /* Left or right rotation */
  int rotateDirection = (command >> 2) & 0xf;
  
  if (rotate)
  {
    if (rotateDirection == 1)
    {
      motors.rotateLeft();
    }
    else
    {
      motors.rotateRight();
    }
  }
  else
  {
    switch(motor)
    {
      case 0: return;
      case 1:
      {
        if (movement == 1)
        {
          motors.moveBBackward();
        }
        else if (movement == 2)
        {
          motors.moveBForward();
        }
        else if (movement == 3)
        {
          motors.stopB();
        }
        
        break;
      }
      
      case 2:
      {
        if (movement == 1)
        {
          motors.moveABackward();
        }
        else if (movement == 2)
        {
          motors.moveAForward();
        }
        else if (movement == 3)
        {
          motors.stopA();
        }
        
        break;
      }
      
      case 3:
      {
        if (movement == 1)
        {
          motors.moveBothBackward();
        }
        else if (movement == 2)
        {
          motors.moveBothForward();
        }
        else if (movement == 3)
        {
          motors.stopBoth();
        }
        
        break;
      }
    }
  }
  
}

void loop()
{
  if (Serial.available())
  {
    executeCommand(Serial.read());
  }
}

