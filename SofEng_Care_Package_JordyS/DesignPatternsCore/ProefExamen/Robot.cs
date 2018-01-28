using System;

namespace ProefExamen
{
    public class Robot : IRobot
    {
        public double Distance { get; set; }
        public double Angle { get; set; }
        public bool State { get; set; }
        public IHand Hand { get; set; }

        public void Move(double distance)
        {
            if (State)
            {
                Distance += (distance)*Hand.Hand();
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public void Turn(double angle)
        {
            if (State)
            {
                Distance += (angle)*Hand.Hand();
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public void OnOff(bool state)
        {
            State = state;
        }

        public bool IsOn()
        {
            State = true;
            return true;
        }
    }
}
