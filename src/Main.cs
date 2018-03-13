using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRubikSolver
{


public class Main {

    public static void main(String[] args) {
        long beginningTime = System.nanoTime();
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
        RotationTreeLoader.loadRotationTreeFromFile(readFirstFloor,firstFloorTree);
        RotationTreeLoader.loadRotationTreeFromFile(readSecondFloor, secondFloorTree);
        RotationTreeLoader.loadRotationTreeFromFile(readThirdFloor,thirdFloorTree);

        Solution mySolution = mySolver.solve(myRubik,firstFloorTree, secondFloorTree, thirdFloorTree);
        mySolution.applyToRubik(myRubik);
        mySolution.print();
        long endTime = System.nanoTime();
        Console.Write("Elapsed Time=%d seconds", ((endTime - beginningTime) / 1000000000));
//27-12-2017: started 11:39 PM, Failed
        myRubik.getPermutation().print();
    }
}
}
