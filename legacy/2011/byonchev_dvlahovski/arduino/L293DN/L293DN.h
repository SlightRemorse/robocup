#ifndef L293DN_H
#define L293DN_H

class L293DN_MotorController
{
	private:
		const int inputA1Pin;
		const int inputA2Pin;
		const int inputB1Pin;
		const int inputB2Pin;	
		
		const int enablePin;	

	public:
		L293DN_MotorController(int inputA1, int inputA2, int inputB1, int inputB2, int enable);
		
		void enable();
		void disable();
		
		void moveAForward(int time = -1, bool breakPreviousCommand = true, int speed = 255);
		void moveABackward(int time = -1, bool breakPreviousCommand = true, int speed = 255);
		void stopA();
		
		void moveBForward(int time = -1, bool breakPreviousCommand = true, int speed = 255);
		void moveBBackward(int time = -1, bool breakPreviousCommand = true, int speed = 255);
		void stopB();
		
		void moveBothForward(int time = -1, int speed = 255);
		void moveBothBackward(int time = -1, int speed = 255);						
		void stopBoth();
		
		void rotateLeft(int time = -1, bool breakPreviousCommand = true, int speed = 255);
		void rotateRight(int time = -1, bool breakPreviousCommand = true, int speed = 255);
};

#endif;