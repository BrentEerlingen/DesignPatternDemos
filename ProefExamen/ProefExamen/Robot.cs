using System;
namespace ProefExamen
{
    public class Robot : IRobot
    {
        private Boolean activated;
        private double position;
        private double angle;
        public Robot()
        {
            this.activated = false;
            this.position = 0.0;
            this.angle = 0.0;
            showPosition();
        }

        public bool IsOn()
        {
            if(this.activated){
                return true;
            }else{
                return false;
            }
        }

        public void Move(double distance)
        {
            if(this.activated){
                this.position += distance;
            }
            else{
                throw new InvalidOperationException();
            }
            showPosition();
        }

        public void OnOff(bool state)
        {
            if(state){
                this.activated = true;
            }else{
                this.activated = false;
            }
            showPosition();
        }

        public void Turn(double angle)
        {
            if (this.activated)
            {
                this.angle += angle;
            }
            else
            {
                throw new InvalidOperationException();
            }
            showPosition();
        }

        private void showPosition(){
            
            Console.WriteLine(String.Format("On: {0}, Location: {1}, Angle: {2}", this.activated, this.position, this.angle));
        }


    }
}
