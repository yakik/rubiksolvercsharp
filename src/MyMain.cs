using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRubikSolver {


    public class MyMain {

        public static void Main(String[] args) {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Rubik myRubik = new Rubik();
            myRubik.rotateFace(new Rotation(Face.R, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.B, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.R, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.B, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.L, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.F, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.R, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.B, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.R, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.B, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.L, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.F, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.R, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.B, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.R, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.B, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.L, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.F, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.R, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.B, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.R, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.B, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.L, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.F, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.R, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.B, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.R, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.B, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.L, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.F, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.R, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.B, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.R, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.B, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.L, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.F, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.R, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.B, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.R, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.B, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.L, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.F, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.R, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.B, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.R, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.B, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.L, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.F, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.R, Direction.CW));
            Solver mySolver = new Solver();
            RotationTree firstFloorTree = new RotationTree();
            RotationTree secondFloorTree = new RotationTree();
            RotationTree thirdFloorTree = new RotationTree();
            RubikFileReader readFirstFloor = new RubikFileReader("FirstFloor.txt");
            RubikFileReader readSecondFloor = new RubikFileReader("SecondFloor.txt");
            RubikFileReader readThirdFloor = new RubikFileReader("ThirdFloor.txt");
            RotationTreeLoader.loadRotationTreeFromFile(readFirstFloor, firstFloorTree);
            RotationTreeLoader.loadRotationTreeFromFile(readSecondFloor, secondFloorTree);
            RotationTreeLoader.loadRotationTreeFromFile(readThirdFloor, thirdFloorTree);

            Solution mySolution = mySolver.solve(myRubik, firstFloorTree, secondFloorTree, thirdFloorTree);
            mySolution.applyToRubik(myRubik);
            mySolution.print();
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            Console.Write("Elapsed Time={0} seconds", elapsedTime);
            //27-12-2017: started 11:39 PM, Failed
            myRubik.getPermutation().print();
        }
    }
}
