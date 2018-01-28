namespace ProefExamen
{
    class Program
    {
        static void Main(string[] args)
        {
            IRemote newRemote = new RobotRemote();
            newRemote.JoystickUp();
            newRemote.JoystickRight();
            newRemote.JoystickDown();
            newRemote.JoystickLeft();
            newRemote.ButtonA_Click();
            newRemote.PrintMessages();

            //Ik heb gekozen voor Command design pattern en Strategy pattern
            //Command pattern =  je voert allemaal commandos uit.
            //Strategy pattern = je moet een gedrag kunnen implementeren. Dit gedrag kan je ook dynamisch aanpassen.
           
        }
    }
}
