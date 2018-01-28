
using Xunit;

namespace UnitTestProefExamen
{
    
    public class UnitTest1
    {
        [Fact]
        public void RobotShouldThrowAnExceptionWhenTheRobotIsNotOn()
        {
            var newRemote = A.Fake<RobotRemote>();
            newRemote.TurnOff();
            newRemote.JoystickLeft();
        }

        [Theory]
        public void RobotShouldTurnOn()
        {
            var robot = A.Fake<IRobot>(); 
            A.CallTo(() => robot.IsOn()).Returns(true);
            Assert.IsTrue(robot.IsOn());
        }

        [Theory]
        public void RobotShouldTurnRight()
        {
            var newRemote = A.Fake<RobotRemote>();
            newRemote.JoystickRight();
            Assert.AreEqual(newRemote.PrintMessages(), 90.0);
        }


        [Theory]
        public void RobotShouldTurnLeft()
        {
            var newRemote = A.Fake<RobotRemote>();
            newRemote.JoystickLeft();
            Assert.AreEqual(newRemote.PrintMessages(), -90.0);
        }

        [Theory]
        public void RobotShouldMoveForward()
        {
            var newRemote = A.Fake<RobotRemote>();
            newRemote.JoystickUp();
            Assert.AreEqual(newRemote.PrintMessages(), 0.3);
        }

        [Theory]
        public void RobotShouldMoveBackwards()
        {
            var newRemote = A.Fake<RobotRemote>();
            newRemote.JoystickDown();
            Assert.AreEqual(newRemote.PrintMessages(), -0.3);
        }

        [Theory]
        public void RobotShouldMakeATour_TourIsEqualsToDistanceZero()
        {
            var newRemote = A.Fake<RobotRemote>();
            newRemote.ButtonA_Click();
            Assert.AreEqual(newRemote.PrintMessages(), 0.0);
        }

        [TestMethod]
        public void RobotShouldMakeTurnLeftWithLeftHand_TegenovergesteldeVanLinks()
        {
            var newRemote = A.Fake<RobotRemote>();
            newRemote.SetHandLinks();
            newRemote.JoystickLeft();
            Assert.AreEqual(newRemote.PrintMessages(), 90);
        }

        [TestMethod]
        public void RobotShouldMakeTurnRightWithLeftHand_TegenovergesteldeVanRechts()
        {
            var newRemote = A.Fake<RobotRemote>();
            newRemote.SetHandLinks();
            newRemote.JoystickRight();
            Assert.AreEqual(newRemote.PrintMessages(), -90);
        }

        [TestMethod]
        public void RobotShouldMakeMoveForwardWithLeftHand_TegenovergesteldeVanDown()
        {
            var newRemote = A.Fake<RobotRemote>();
            newRemote.SetHandLinks();
            newRemote.JoystickUp();
            Assert.AreEqual(newRemote.PrintMessages(), -0.3);
        }

        [TestMethod]
        public void RobotShouldMakeMoveBackwardsWithLeftHand_TegenovergesteldeVanUp()
        {
            var newRemote = A.Fake<RobotRemote>();
            newRemote.SetHandLinks();
            newRemote.JoystickDown();
            Assert.AreEqual(newRemote.PrintMessages(), 0.3);
        }

        [TestMethod]
        public void RobotShouldMakeATour_TourIsEqualsToDistanceZero_WithLeftHand()
        {
            var newRemote = A.Fake<RobotRemote>();
            newRemote.SetHandLinks();
            newRemote.ButtonA_Click();
            Assert.AreEqual(newRemote.PrintMessages(), 0);
        }
    }