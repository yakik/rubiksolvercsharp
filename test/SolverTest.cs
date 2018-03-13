using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpRubikSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpRubikSolverTester
{

    [TestClass]
    class SolverTest {


    [TestMethod]
    void simpleRotations() {
        Rubik myRubik = new Rubik();
        for (int i=0;i<20;i++) {
            myRubik.rotateFace(new Rotation(Face.U, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.R, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.L, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.D, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.R, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.U, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.R, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.B, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.L, Direction.CW));
            myRubik.rotateFace(new Rotation(Face.F, Direction.CW));
        }
        for (int i=0;i<20;i++) {
            myRubik.rotateFace(new Rotation(Face.F, Direction.CCW));
            myRubik.rotateFace(new Rotation(Face.L, Direction.CCW));
            myRubik.rotateFace(new Rotation(Face.B, Direction.CCW));
            myRubik.rotateFace(new Rotation(Face.R, Direction.CCW));
            myRubik.rotateFace(new Rotation(Face.U, Direction.CCW));
            myRubik.rotateFace(new Rotation(Face.R, Direction.CCW));
            myRubik.rotateFace(new Rotation(Face.D, Direction.CCW));
            myRubik.rotateFace(new Rotation(Face.L, Direction.CCW));
            myRubik.rotateFace(new Rotation(Face.R, Direction.CCW));
            myRubik.rotateFace(new Rotation(Face.U, Direction.CCW));
        }
        myRubik.rotateFace(new Rotation(Face.F, Direction.CW));
        myRubik.rotateFace(new Rotation(Face.F, Direction.CCW));
        AssistAssertRubik.checkEntireCube(myRubik);

    }



    [TestMethod]
    void simpleSolver() {
        Rubik myRubik = new Rubik();

        myRubik.rotateFace(new Rotation(Face.U, Direction.CW));
        myRubik.rotateFace(new Rotation(Face.R, Direction.CW));
        myRubik.rotateFace(new Rotation(Face.L, Direction.CW));
        myRubik.rotateFace(new Rotation(Face.D, Direction.CW));
        RotationTree myTree = new RotationTree();
        RotationLinkedList myRotationLinkedList = new RotationLinkedList();
        myRotationLinkedList.addRotation(new Rotation(Face.U, Direction.CCW));
        myTree.addRotationLinkedList(myRotationLinkedList);

        myRotationLinkedList = new RotationLinkedList();
        myRotationLinkedList.addRotation(new Rotation(Face.R, Direction.CCW));
        myTree.addRotationLinkedList(myRotationLinkedList);

        myRotationLinkedList = new RotationLinkedList();
        myRotationLinkedList.addRotation(new Rotation(Face.L, Direction.CCW));
        myTree.addRotationLinkedList(myRotationLinkedList);

        myRotationLinkedList = new RotationLinkedList();
        myRotationLinkedList.addRotation(new Rotation(Face.D, Direction.CCW));
        myTree.addRotationLinkedList(myRotationLinkedList);

        Solver mySolver = new Solver();
        Solution mySolution = mySolver.solve(myRubik,myTree,myTree,myTree);
        mySolution.applyToRubik(myRubik);
        mySolution.print();
        myRubik.getPermutation().print();
        AssistAssertRubik.checkEntireCube(myRubik);

    }

    [TestMethod]
    void complexSolver() {
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
        AssistAssertRubik.checkEntireCube(myRubik);

    }


}
}