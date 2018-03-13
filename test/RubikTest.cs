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
    class RubikTest {

    [TestMethod]
    void setPermutationTest() {
        Permutation myPermutation = new Permutation();
        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.U), new Location(Face.F, Face.U), new Position(Face.U, Face.F)));
        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.R), new Location(Face.F, Face.R), new Position(Face.U, Face.F)));
        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.L), new Location(Face.F, Face.L), new Position(Face.U, Face.F)));
        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.D), new Location(Face.F, Face.D), new Position(Face.U, Face.F)));
        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.B, Face.U), new Location(Face.B, Face.U), new Position(Face.U, Face.F)));
        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.B, Face.R), new Location(Face.B, Face.R), new Position(Face.U, Face.F)));
        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.B, Face.L), new Location(Face.B, Face.L), new Position(Face.U, Face.F)));
        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.B, Face.D), new Location(Face.B, Face.D), new Position(Face.U, Face.F)));
        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.U, Face.R), new Location(Face.U, Face.R), new Position(Face.U, Face.F)));
        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.U, Face.L), new Location(Face.U, Face.L), new Position(Face.U, Face.F)));
        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.D, Face.R), new Location(Face.D, Face.R), new Position(Face.U, Face.F)));
        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.D, Face.L), new Location(Face.D, Face.L), new Position(Face.U, Face.F)));
        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.U, Face.R), new Location(Face.F, Face.U, Face.R), new Position(Face.U, Face.F)));
        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.U, Face.L), new Location(Face.F, Face.U, Face.L), new Position(Face.U, Face.F)));
        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.D, Face.R), new Location(Face.F, Face.D, Face.R), new Position(Face.U, Face.F)));
        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.D, Face.L), new Location(Face.F, Face.D, Face.L), new Position(Face.U, Face.F)));
        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.B, Face.U, Face.R), new Location(Face.B, Face.U, Face.R), new Position(Face.U, Face.F)));
        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.B, Face.U, Face.L), new Location(Face.B, Face.U, Face.L), new Position(Face.U, Face.F)));
        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.B, Face.D, Face.R), new Location(Face.B, Face.D, Face.R), new Position(Face.U, Face.F)));
        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.B, Face.D, Face.L), new Location(Face.B, Face.D, Face.L), new Position(Face.U, Face.F)));

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

        myRubik.setPermutation(myPermutation);
        AssistAssertRubik.checkEntireCube(myRubik);


    }
    [TestMethod]
    void testChangesOnlyInThirdFloor_partII(){
        Permutation myPermutation = new Permutation();
        Rubik myCube = new Rubik();

        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.U)
                , new Location(Face.F, Face.R), new Position(Face.U, Face.B)));
        assertEquals(true, myCube.changesOnlyInThirdFloor(myPermutation),"one");

        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.D)
                , new Location(Face.F, Face.L), new Position(Face.U, Face.B)));
        assertEquals(false, myCube.changesOnlyInThirdFloor(myPermutation),"two");
    }


    [TestMethod]
    void testChangesOnlyInThirdFloor_partI(){
        Permutation myPermutation = new Permutation();
        Rubik myCube = new Rubik();

        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.U)
                , new Location(Face.F, Face.R), new Position(Face.U, Face.B)));
        assertEquals(true, myCube.changesOnlyInThirdFloor(myPermutation),"one");

        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.L)
                , new Location(Face.F, Face.L), new Position(Face.U, Face.B)));
        assertEquals(false, myCube.changesOnlyInThirdFloor(myPermutation),"two");
        }

    [TestMethod]
    void testIsDifferentItemsOnlyInSecondFloorLessThanThree_partI(){
        Permutation myPermutation = new Permutation();
        Rubik myCube = new Rubik();

        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.R)
                , new Location(Face.F, Face.R), new Position(Face.U, Face.B)));
        assertEquals(true, myCube.isDifferentItemsOnlyInSecondFloorLessThanThree(myPermutation),"one");

        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.L)
                , new Location(Face.F, Face.L), new Position(Face.U, Face.B)));
        assertEquals(true, myCube.isDifferentItemsOnlyInSecondFloorLessThanThree(myPermutation),"two");

        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.B, Face.L)
                , new Location(Face.B, Face.R), new Position(Face.U, Face.F)));
        assertEquals(false, myCube.isDifferentItemsOnlyInSecondFloorLessThanThree(myPermutation),"three");

            }

    [TestMethod]
    void testIsDifferentItemsOnlyInSecondFloorLessThanThree_partII(){
        Permutation myPermutation = new Permutation();
        Rubik myCube = new Rubik();

        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.R)
                , new Location(Face.F, Face.R), new Position(Face.U, Face.B)));
        assertEquals(true, myCube.isDifferentItemsOnlyInSecondFloorLessThanThree(myPermutation),"one");

        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.L)
                , new Location(Face.F, Face.L), new Position(Face.U, Face.B)));
        assertEquals(true, myCube.isDifferentItemsOnlyInSecondFloorLessThanThree(myPermutation),"two");

        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.B, Face.D)
                , new Location(Face.B, Face.R), new Position(Face.U, Face.F)));
        assertEquals(false, myCube.isDifferentItemsOnlyInSecondFloorLessThanThree(myPermutation),"three");

    }


    [TestMethod]
    void testIsDifferentItemsInFirstFloorLessThanThree(){
        Permutation myPermutation = new Permutation();
        Rubik myCube = new Rubik();

        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.D)
                , new Location(Face.F, Face.U), new Position(Face.U, Face.F)));
        assertEquals(true, myCube.isDifferentItemsInFirstFloorLessThanThree(myPermutation),"one");

        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.D, Face.R)
                , new Location(Face.F, Face.D, Face.R), new Position(Face.U, Face.B)));
        assertEquals(true, myCube.isDifferentItemsInFirstFloorLessThanThree(myPermutation),"two");

        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.D, Face.L)
                , new Location(Face.F, Face.D, Face.L), new Position(Face.U, Face.F)));
        assertEquals(true, myCube.isDifferentItemsInFirstFloorLessThanThree(myPermutation),"three");

        myPermutation.addCubicleData(new CubeCubicle(new Location(Face.B, Face.D, Face.L)
                , new Location(Face.B, Face.D, Face.L), new Position(Face.U, Face.B)));
        assertEquals(false, myCube.isDifferentItemsInFirstFloorLessThanThree(myPermutation),"four");
    }


    [TestMethod]
    void constuctorTest() {
        Rubik myRubik = new Rubik();
        int numberOfAssertions = 0;
        for (Face firstFaceDimension : Face.values()) {
            for (Face secondFaceDimension : Face.values()) {
                if (firstFaceDimension != secondFaceDimension
                        && firstFaceDimension.getOpposite() != secondFaceDimension
//                        && firstFaceDimension != Face.NOTDEFINED
//                        && secondFaceDimension != Face.NOTDEFINED
                        ) {
                    assertEquals(true,
                            (new Location(firstFaceDimension, secondFaceDimension))
                                    .equals(myRubik.getOriginalLocationOfCurrentCubicleInLocation(new Location(firstFaceDimension, secondFaceDimension))));
                    numberOfAssertions++;
                }
            }
        }
        assertEquals(24, numberOfAssertions);

    }


    [TestMethod]
    void positionTest() {
        Rubik myRubik = new Rubik();
        myRubik.rotateFace(new Rotation(Face.U, Direction.CW));
        assertEquals(true, myRubik
                .getPositionOfCubicleOfCubiclePlace(new Location(Face.D, Face.F))
                .equals(new Position(Face.U, Face.F)), "1");

        myRubik.rotateFace(new Rotation(Face.R, Direction.CW));
        assertEquals(true, myRubik
                .getPositionOfCubicleOfCubiclePlace(new Location(Face.D, Face.F))
                .equals(new Position(Face.U, Face.F)), "2");

        myRubik.rotateFace(new Rotation(Face.L, Direction.CW));
        assertEquals(true, myRubik
                .getPositionOfCubicleOfCubiclePlace(new Location(Face.D, Face.F))
                .equals(new Position(Face.U, Face.F)), "3");

        Position yaki = myRubik.getPositionOfCubicleOfCubiclePlace(new Location(Face.D, Face.L));

        myRubik.rotateFace(new Rotation(Face.D, Direction.CW));
        yaki = myRubik.getPositionOfCubicleOfCubiclePlace(new Location(Face.D, Face.F));
        assertEquals(true, myRubik
                .getPositionOfCubicleOfCubiclePlace(new Location(Face.D, Face.F))
                .equals(new Position(Face.B, Face.L)), "4");


    }

    [TestMethod]
    void positionTest2() {
        Rubik myRubik = new Rubik();


        myRubik.rotateFace(new Rotation(Face.L, Direction.CW));
        assertEquals(true, myRubik
                .getPositionOfCubicleOfCubiclePlace(new Location(Face.D, Face.F))
                .equals(new Position(Face.U, Face.F)), "3");

        assertEquals(true, myRubik
                .getPositionOfCubicleOfCubiclePlace(new Location(Face.D, Face.L))
                .equals(new Position(Face.B, Face.U)), "3");

        myRubik.rotateFace(new Rotation(Face.D, Direction.CW));
        Position yaki = myRubik.getPositionOfCubicleOfCubiclePlace(new Location(Face.D, Face.F));
        assertEquals(true, myRubik
                .getPositionOfCubicleOfCubiclePlace(new Location(Face.D, Face.F))
                .equals(new Position(Face.B, Face.L)), "4");


    }


    [TestMethod]
    void rotateTest1() {
        Rubik myRubik = new Rubik();
        myRubik.rotateFace(new Rotation(Face.F, Direction.CW));
        assertEquals(true, (new Location(Face.F, Face.D))
                .equals(myRubik.getOriginalLocationOfCurrentCubicleInLocation(new Location(Face.F, Face.L))));

    }

    [TestMethod]
    void rotateTest2() {
        Rubik myRubik = new Rubik();
        myRubik.rotateFace(new Rotation(Face.D, Direction.CCW));
        assertEquals(true, (new Location(Face.D, Face.R))
                .equals(myRubik.getOriginalLocationOfCurrentCubicleInLocation(new Location(Face.D, Face.F))));
    }

    [TestMethod]
    void rotateTest3() {
        Rubik myRubik = new Rubik();
        myRubik.rotateFace(new Rotation(Face.D, Direction.CCW));
        assertEquals(true, (new Location(Face.D, Face.R, Face.B))
                .equals(myRubik.getOriginalLocationOfCurrentCubicleInLocation(new Location(Face.D, Face.R, Face.F))));
    }

    [TestMethod]
    void TestgetOriginalLocationOfCurrentCubicleInLocation() {
        Rubik myRubik = new Rubik();
        myRubik.rotateFace(new Rotation(Face.F, Direction.CW));
        Location yaki = myRubik.getOriginalLocationOfCurrentCubicleInLocation(new Location(Face.D, Face.F));
        assertEquals(true, (new Location(Face.F, Face.R))
                .equals(myRubik.getOriginalLocationOfCurrentCubicleInLocation(new Location(Face.D, Face.F))));
    }


}
}