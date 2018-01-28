namespace ProefExamen
{
    public interface IRobot
    {
        /// <summary>
        ///  Move in a straight line
        /// </summary>
        /// <param name="distance">meters.
        /// Positive = forward, Negative = backward
        /// </param>
        void Move(double distance);

        /// <summary>
        /// Turn the robot on or off
        /// </summary>
        /// <param name="angle">angle in degrees.
        /// positive = clockwise, negative = counterclockwise
        /// </param>
        void Turn(double angle);

        /// <summary>
        /// Turn the robot on or off.
        /// </summary>
        /// <param name="state">on(true) or off (false)</param>
        void OnOff(bool state);

        /// <summary>
        /// asks the robot if it is on
        /// </summary>
        /// <returns>true if on</returns>
        bool IsOn();
    }
}
