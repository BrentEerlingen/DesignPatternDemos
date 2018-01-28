namespace ProefExamen
{
    public class RobotRemote : IRemote
    {
        private Robot newRobot = new Robot();

        public RobotRemote()
        {
            newRobot.IsOn();
            //standaard rechtshandig ofanders krijgen we problemen als we vergeten welke hand het is.
            newRobot.Hand = new RechtsHandig();

        }
        public void JoystickUp()
        {
            newRobot.Move(0.30);
        }

        public void JoystickDown()
        {
            newRobot.Move(-0.30);
        }

        public void JoystickLeft()
        {
            newRobot.Move(-90.0);
        }

        public void JoystickRight()
        {
            newRobot.Move(90.0);
        }

        public void ButtonA_Click()
        {
            JoystickUp();
            JoystickRight();
            JoystickDown();
            JoystickLeft();
        }

        public void TurnOff()
        {
            newRobot.OnOff(false);
        }

        public double PrintMessages()
        {
            return newRobot.Distance;
        }

        public void SetHandRechts()
        {
            newRobot.Hand = new RechtsHandig();
        }

        public void SetHandLinks()
        {
            newRobot.Hand = new LinksHandig();
        }
    }
}
