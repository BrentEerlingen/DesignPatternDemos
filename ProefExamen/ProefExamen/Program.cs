using System;

namespace ProefExamen
{
    class Program
    {
        protected static void Main(string[] args)
        {
            RobotRemote remote = new RightRemote(new Robot());
            Console.WriteLine("Booting...!");
            remote.getRobot().OnOff(true);
            remote.ButtonA_Click();
            Console.WriteLine("---SWITCHING----");
            remote = remote.switchRemote(remote);
            remote.ButtonA_Click();
            Console.WriteLine("---SWITCHING----");
            remote = remote.switchRemote(remote);
            remote.ButtonA_Click();


        }
    }
}
