using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpRubikSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpRubikSolverUTests {


    [TestClass]
    public class RubikTest {

        [TestMethod]
        public void setPermutationTest() {
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
        public void testChangesOnlyInThirdFloor_partII() {
            Permutation myPermutation = new Permutation();
            Rubik myCube = new Rubik();

            myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.U)
                    , new Location(Face.F, Face.R), new Position(Face.U, Face.B)));
            Assert.AreEqual(true, myCube.changesOnlyInThirdFloor(myPermutation), "one");

            myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.D)
                    , new Location(Face.F, Face.L), new Position(Face.U, Face.B)));
            Assert.AreEqual(false, myCube.changesOnlyInThirdFloor(myPermutation), "two");
        }


        [TestMethod]
        public void testChangesOnlyInThirdFloor_partI() {
            Permutation myPermutation = new Permutation();
            Rubik myCube = new Rubik();

            myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.U)
                    , new Location(Face.F, Face.R), new Position(Face.U, Face.B)));
            Assert.AreEqual(true, myCube.changesOnlyInThirdFloor(myPermutation), "one");

            myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.L)
                    , new Location(Face.F, Face.L), new Position(Face.U, Face.B)));
            Assert.AreEqual(false, myCube.changesOnlyInThirdFloor(myPermutation), "two");
        }

        [TestMethod]
        public void testIsDifferentItemsOnlyInSecondFloorLessThanThree_partI() {
            Permutation myPermutation = new Permutation();
            Rubik myCube = new Rubik();

            myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.R)
                    , new Location(Face.F, Face.R), new Position(Face.U, Face.B)));
            Assert.AreEqual(true, myCube.isDifferentItemsOnlyInSecondFloorLessThanThree(myPermutation), "one");

            myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.L)
                    , new Location(Face.F, Face.L), new Position(Face.U, Face.B)));
            Assert.AreEqual(true, myCube.isDifferentItemsOnlyInSecondFloorLessThanThree(myPermutation), "two");

            myPermutation.addCubicleData(new CubeCubicle(new Location(Face.B, Face.L)
                    , new Location(Face.B, Face.R), new Position(Face.U, Face.F)));
            Assert.AreEqual(false, myCube.isDifferentItemsOnlyInSecondFloorLessThanThree(myPermutation), "three");

        }

        [TestMethod]
        public void testIsDifferentItemsOnlyInSecondFloorLessThanThree_partII() {
            Permutation myPermutation = new Permutation();
            Rubik myCube = new Rubik();

            myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.R)
                    , new Location(Face.F, Face.R), new Position(Face.U, Face.B)));
            Assert.AreEqual(true, myCube.isDifferentItemsOnlyInSecondFloorLessThanThree(myPermutation), "one");

            myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.L)
                    , new Location(Face.F, Face.L), new Position(Face.U, Face.B)));
            Assert.AreEqual(true, myCube.isDifferentItemsOnlyInSecondFloorLessThanThree(myPermutation), "two");

            myPermutation.addCubicleData(new CubeCubicle(new Location(Face.B, Face.D)
                    , new Location(Face.B, Face.R), new Position(Face.U, Face.F)));
            Assert.AreEqual(false, myCube.isDifferentItemsOnlyInSecondFloorLessThanThree(myPermutation), "three");

        }


        [TestMethod]
        public void testIsDifferentItemsInFirstFloorLessThanThree() {
            Permutation myPermutation = new Permutation();
            Rubik myCube = new Rubik();

            myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.D)
                    , new Location(Face.F, Face.U), new Position(Face.U, Face.F)));
            Assert.AreEqual(true, myCube.isDifferentItemsInFirstFloorLessThanThree(myPermutation), "one");

            myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.D, Face.R)
                    , new Location(Face.F, Face.D, Face.R), new Position(Face.U, Face.B)));
            Assert.AreEqual(true, myCube.isDifferentItemsInFirstFloorLessThanThree(myPermutation), "two");

            myPermutation.addCubicleData(new CubeCubicle(new Location(Face.F, Face.D, Face.L)
                    , new Location(Face.F, Face.D, Face.L), new Position(Face.U, Face.F)));
            Assert.AreEqual(true, myCube.isDifferentItemsInFirstFloorLessThanThree(myPermutation), "three");

            myPermutation.addCubicleData(new CubeCubicle(new Location(Face.B, Face.D, Face.L)
                    , new Location(Face.B, Face.D, Face.L), new Position(Face.U, Face.B)));
            Assert.AreEqual(false, myCube.isDifferentItemsInFirstFloorLessThanThree(myPermutation), "four");
        }


        [TestMethod]
        public void constuctorTest() {
            Rubik myRubik = new Rubik();
            int numberOfAssertions = 0;
            foreach (Face firstFaceDimension in Enum.GetValues(typeof(Face))) {
                foreach (Face secondFaceDimension in Enum.GetValues(typeof(Face))) {
                    if (firstFaceDimension != secondFaceDimension
                            && firstFaceDimension.getOpposite() != secondFaceDimension
                            //                        && firstFaceDimension != Face.NOTDEFINED
                            //                        && secondFaceDimension != Face.NOTDEFINED
                            ) {
                        Assert.AreEqual(true,
                                (new Location(firstFaceDimension, secondFaceDimension))
                                        .equals(myRubik.getOriginalLocationOfCurrentCubicleInLocation(new Location(firstFaceDimension, secondFaceDimension))));
                        numberOfAssertions++;
                    }
                }
            }
            Assert.AreEqual(24, numberOfAssertions);

        }


        [TestMethod]
        public void positionTest() {
            Rubik myRubik = new Rubik();
            myRubik.rotateFace(new Rotation(Face.U, Direction.CW));
            Assert.AreEqual(true, myRubik
                    .getPositionOfCubicleOfCubiclePlace(new Location(Face.D, Face.F))
                    .equals(new Position(Face.U, Face.F)), "1");

            myRubik.rotateFace(new Rotation(Face.R, Direction.CW));
            Assert.AreEqual(true, myRubik
                    .getPositionOfCubicleOfCubiclePlace(new Location(Face.D, Face.F))
                    .equals(new Position(Face.U, Face.F)), "2");

            myRubik.rotateFace(new Rotation(Face.L, Direction.CW));
            Assert.AreEqual(true, myRubik
                    .getPositionOfCubicleOfCubiclePlace(new Location(Face.D, Face.F))
                    .equals(new Position(Face.U, Face.F)), "3");

            Position yaki = myRubik.getPositionOfCubicleOfCubiclePlace(new Location(Face.D, Face.L));

            myRubik.rotateFace(new Rotation(Face.D, Direction.CW));
            yaki = myRubik.getPositionOfCubicleOfCubiclePlace(new Location(Face.D, Face.F));
            Assert.AreEqual(true, myRubik
                    .getPositionOfCubicleOfCubiclePlace(new Location(Face.D, Face.F))
                    .equals(new Position(Face.B, Face.L)), "4");


        }

        [TestMethod]
        public void positionTest2() {
            Rubik myRubik = new Rubik();


            myRubik.rotateFace(new Rotation(Face.L, Direction.CW));
            Assert.AreEqual(true, myRubik
                    .getPositionOfCubicleOfCubiclePlace(new Location(Face.D, Face.F))
                    .equals(new Position(Face.U, Face.F)), "3");

            Assert.AreEqual(true, myRubik
                    .getPositionOfCubicleOfCubiclePlace(new Location(Face.D, Face.L))
                    .equals(new Position(Face.B, Face.U)), "3");

            myRubik.rotateFace(new Rotation(Face.D, Direction.CW));
            Position yaki = myRubik.getPositionOfCubicleOfCubiclePlace(new Location(Face.D, Face.F));
            Assert.AreEqual(true, myRubik
                    .getPositionOfCubicleOfCubiclePlace(new Location(Face.D, Face.F))
                    .equals(new Position(Face.B, Face.L)), "4");


        }


        [TestMethod]
        public void rotateTest1() {
            Rubik myRubik = new Rubik();
            myRubik.rotateFace(new Rotation(Face.F, Direction.CW));
            Assert.AreEqual(true, (new Location(Face.F, Face.D))
                    .equals(myRubik.getOriginalLocationOfCurrentCubicleInLocation(new Location(Face.F, Face.L))));

        }

        [TestMethod]
        public void rotateTest2() {
            Rubik myRubik = new Rubik();
            myRubik.rotateFace(new Rotation(Face.D, Direction.CCW));
            Assert.AreEqual(true, (new Location(Face.D, Face.R))
                    .equals(myRubik.getOriginalLocationOfCurrentCubicleInLocation(new Location(Face.D, Face.F))));
        }

        [TestMethod]
        public void rotateTest3() {
            Rubik myRubik = new Rubik();
            myRubik.rotateFace(new Rotation(Face.D, Direction.CCW));
            Assert.AreEqual(true, (new Location(Face.D, Face.R, Face.B))
                    .equals(myRubik.getOriginalLocationOfCurrentCubicleInLocation(new Location(Face.D, Face.R, Face.F))));
        }

        [TestMethod]
        public void TestgetOriginalLocationOfCurrentCubicleInLocation() {
            Rubik myRubik = new Rubik();
            myRubik.rotateFace(new Rotation(Face.F, Direction.CW));
            Location yaki = myRubik.getOriginalLocationOfCurrentCubicleInLocation(new Location(Face.D, Face.F));
            Assert.AreEqual(true, (new Location(Face.F, Face.R))
                    .equals(myRubik.getOriginalLocationOfCurrentCubicleInLocation(new Location(Face.D, Face.F))));
        }


    }
}