<h1>Toy robot simulator for SS&C</h1>
<p>
  This console application is used for presenting the technical exercise to SS&C.
The application is a simulation of a toy robot moving on a square table top, of dimensions 5 units x 5 units.
There are no other obstructions on the table surface. The robot is free to roam around the surface of the
table, but must be prevented from falling to destruction. Any movement that would result in the robot
falling from the table must be prevented and validated movement commands.
</p>
<h2>How to setup and run the app</h2>
<p>
  This application is built by using C# in Visual Studio. You are able to clone this repository and open it on Visual Studio. Once you have cloned the repository.
  You will see 2 projects in this solution as following.
<ol>
<li>
  ToyRobotChallenge is the project to develop the toy robot simulation on grid 5 x 5.
</li>
<li>ToyRobotChallengeTest is the project to develop the unit test of toy robot.
</li>
</ol>
<h3>Set up and run ToyRobotChallenge</h3>
<p>
  You will see the program.cs in ToyRobotChallenge project.You can run it from Visual Studio or you are able to build the project and publish it to the folder and run it.Once you have run it. You will see the display like below.
<b>
</br>
</br>Let's go my robot.
</br>Please using below commands to control the robot.
</br>X and Y should be number from 0 to 4.
</br>F must be NORTH,SOUTH,WEST and EAST
</br>PLACE X,Y,F
</br>MOVE
</br>LEFT
</br>RIGHT
</br>REPORT
</br>CTRL C to stop the program.
</b>
</p>
<h3>Set up and run ToyRobotChallengeTest</h3>
<p>
  You will see the ToyRobotTests.cs in ToyRobotChallengeTest project.Firstly you should build it. You are able to run unit test by right clicking on ToyRobotTests.cs then you will see <b>Run Tests</b> menu. Once you have done it,you will see the test resulst in <b>Test Results</b> console.
</p>
</p>

