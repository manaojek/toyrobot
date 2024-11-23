using NUnit.Framework;
using ToyRobotChallenge;

namespace ToyRobotChallengeTest
{
    [TestFixture]
    public class ToyRobotTests
    {
        private ToyRobot robot;

        [SetUp]
        public void Setup()
        {
            robot = new ToyRobot();
        }

        [Test]
        public void TestInitialReport()
        {
            Assert.AreEqual("Robot is not yet placed.", robot.Report());
        }

        [Test]
        public void TestValidPlaceAndReport()
        {
            robot.Place(2, 3, Direction.NORTH);
            Assert.AreEqual("2,3,NORTH", robot.Report());
        }

        [Test]
        public void TestInvalidPlace()
        {
            robot.Place(-1, 0, Direction.EAST);
            Assert.AreEqual("Robot is not yet placed.", robot.Report());
        }

        [Test]
        public void TestMoveWithinBounds()
        {
            robot.Place(0, 0, Direction.NORTH);
            robot.Move();
            Assert.AreEqual("0,1,NORTH", robot.Report());
        }

        [Test]
        public void TestMoveOutOfBounds()
        {
            robot.Place(0, 4, Direction.NORTH);
            robot.Move();
            Assert.AreEqual("0,4,NORTH", robot.Report());
        }

        [Test]
        public void TestLeftRotation()
        {
            robot.Place(1, 1, Direction.NORTH);
            robot.Left();
            Assert.AreEqual("1,1,WEST", robot.Report());
        }

        [Test]
        public void TestRightRotation()
        {
            robot.Place(1, 1, Direction.NORTH);
            robot.Right();
            Assert.AreEqual("1,1,EAST", robot.Report());
        }

        [Test]
        public void TestSequentialCommands()
        {
            robot.Place(1, 1, Direction.NORTH);
            robot.Move();
            robot.Right();
            robot.Move();
            Assert.AreEqual("2,2,EAST", robot.Report());
        }

        [Test]
        public void TestWrongSequentialCommands()
        {
            robot.Move();
            robot.Place(1, 1, Direction.NORTH);
            robot.Right();
            robot.Move();
            Assert.AreEqual("2,1,EAST", robot.Report());
        }

        [Test]
        public void TestWrongPlace()
        {
        
            robot.Place(5, 1, Direction.NORTH);
            robot.Right();
            robot.Move();
            Assert.AreEqual("Robot is not yet placed.", robot.Report());
        }

        
    }
}
