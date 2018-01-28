using System;
namespace ProefExamen
{
    public abstract class RobotRemote : IRemote
    {
        protected RobotRemote(Robot robot){}

        public RobotRemote switchRemote(RobotRemote remote){
            if(remote.GetType() == typeof(RightRemote)){
                return remote = new LeftRemote(remote.getRobot());
            }else{
                return remote = new RightRemote(remote.getRobot());
            }
        }
        public abstract void ButtonA_Click();

        public abstract void JoystickDown();


        public abstract void JoystickLeft();

        public abstract void JoystickRight();

        public abstract void JoystickUp();

        public abstract Robot getRobot();
    }
}
