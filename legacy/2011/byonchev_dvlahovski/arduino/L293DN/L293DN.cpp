/* Arduino SDK common library */
#if defined(ARDUINO) && ARDUINO >= 100
#include "Arduino.h"
#else
#include "WProgram.h"
#endif

#include "L293DN.h"

L293DN_MotorController::L293DN_MotorController(int inputA1, int inputA2, int inputB1, int inputB2, int enable)
:	inputA1Pin(inputA1),
	inputA2Pin(inputA2),
	inputB1Pin(inputB1),
	inputB2Pin(inputB2),
	enablePin(enable)
{
	pinMode(inputA1, OUTPUT);
	pinMode(inputA2, OUTPUT);
	pinMode(inputB1, OUTPUT);
	pinMode(inputB2, OUTPUT);
	pinMode(enable, OUTPUT);
	
	this->enable();
}

void L293DN_MotorController::enable()
{
	digitalWrite(enablePin, HIGH);
}

void L293DN_MotorController::disable()
{
	digitalWrite(enablePin, LOW);
}

void L293DN_MotorController::moveAForward(int time, bool breakPreviousCommand, int speed)
{
	if (breakPreviousCommand)
	{
		stopB();
	}

	stopA();
	
	if (speed == 255)
	{
		digitalWrite(inputA1Pin, HIGH);
		digitalWrite(inputA2Pin, LOW);
	}
	else
	{
		analogWrite(inputA1Pin, speed);
		digitalWrite(inputA2Pin, LOW);
	}

	if (time > 0)
	{
		delay(time);
		stopA();
	}
}

void L293DN_MotorController::moveABackward(int time, bool breakPreviousCommand, int speed)
{
	if (breakPreviousCommand)
	{
		stopB();
	}

	stopA();
	
	if (speed == 255)
	{
		digitalWrite(inputA1Pin, LOW);
		digitalWrite(inputA2Pin, HIGH);
	}
	else
	{
		digitalWrite(inputA1Pin, LOW);
		analogWrite(inputA2Pin, speed);
	}

	if (time > 0)
	{
		delay(time);
		stopA();
	}
}

void L293DN_MotorController::stopA()
{
	digitalWrite(inputA1Pin, LOW);
	digitalWrite(inputA2Pin, LOW);
}

void L293DN_MotorController::moveBForward(int time, bool breakPreviousCommand, int speed)
{
	if (breakPreviousCommand)
	{
		stopA();
	}

	stopB();
	
	if (speed == 255)
	{
		digitalWrite(inputB1Pin, HIGH);
		digitalWrite(inputB2Pin, LOW);
	}
	else
	{
		analogWrite(inputB1Pin, speed);
		digitalWrite(inputB2Pin, LOW);
	}

	if (time > 0)
	{
		delay(time);
		stopB();
	}
}

void L293DN_MotorController::moveBBackward(int time, bool breakPreviousCommand, int speed)
{
	if (breakPreviousCommand)
	{
		stopA();
	}

	stopB();
	
	if (speed == 255)
	{
		digitalWrite(inputB1Pin, LOW);
		digitalWrite(inputB2Pin, HIGH);
	}
	else
	{
		digitalWrite(inputB1Pin, LOW);
		analogWrite(inputB2Pin, speed);
	}

	if (time > 0)
	{
		delay(time);
		stopB();
	}
}

void L293DN_MotorController::stopB()
{
	digitalWrite(inputB1Pin, LOW);
	digitalWrite(inputB2Pin, LOW);
}

void L293DN_MotorController::moveBothForward(int time, int speed)
{	
	stopBoth();
	
	moveAForward(-1, false, speed);
	moveBForward(-1, false, speed);

	if (time > 0)
	{
		delay(time);
		stopBoth();
	}
}

void L293DN_MotorController::moveBothBackward(int time, int speed)
{
	stopBoth();

	moveABackward(-1, false, speed);
	moveBBackward(-1, false, speed);

	if (time > 0)
	{
		delay(time);
		stopBoth();
	}
}

void L293DN_MotorController::stopBoth()
{
	stopA();
	stopB();
}

void L293DN_MotorController::rotateLeft(int time, bool breakPreviousCommand, int speed)
{
	if (breakPreviousCommand)
	{
		stopBoth();
	}
	
	moveBForward(-1, false, speed);
	moveABackward(-1, false, speed);
	
	if (time > 0)
	{
		delay(time);
		stopBoth();
	}
}

void L293DN_MotorController::rotateRight(int time, bool breakPreviousCommand, int speed)
{
	if (breakPreviousCommand)
	{
		stopBoth();
	}
	
	moveAForward(-1, false, speed);
	moveBBackward(-1, false, speed);
	
	if (time > 0)
	{
		delay(time);
		stopBoth();
	}
}