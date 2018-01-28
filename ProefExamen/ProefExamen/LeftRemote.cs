using System;
namespace ProefExamen
{
    public class LeftRemote : RobotRemote
    {
        private Robot robot;

        public LeftRemote(Robot robot) : base(robot)
        {
            this.robot = robot;
        }

        public override void ButtonA_Click()
        {
            this.JoystickRight();
            this.JoystickDown();
            this.JoystickLeft();
            this.JoystickUp();
        }

        public override void JoystickDown()
        {
            this.robot.Move(-0.30);
        }

        public override void JoystickLeft()
        {
            this.robot.Turn(90.0);
        }

        public override void JoystickRight()
        {
            this.robot.Turn(-90.0);
        }

        public override void JoystickUp()
        {
            this.robot.Move(0.30);
        }

        public override Robot getRobot(){
            return this.robot;
        }
    }
}
