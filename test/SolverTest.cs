using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpRubikSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpRubikSolverUTests {

    [TestClass]
    public class SolverTest {


        [TestMethod]
        public void simpleRotations() {
            Rubik myRubik = new Rubik();
            for (int i = 0; i < 20; i++) {
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
            for (int i = 0; i < 20; i++) {
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
        public void simpleSolver() {
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
            Solution mySolution = mySolver.solve(myRubik, myTree, myTree, myTree);
            mySolution.applyToRubik(myRubik);
            mySolution.print();
            myRubik.getPermutation().print();
            AssistAssertRubik.checkEntireCube(myRubik);

        }


    }
}