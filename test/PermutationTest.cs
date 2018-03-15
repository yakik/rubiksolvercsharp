using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpRubikSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpRubikSolverUTests {


    [TestClass]
    public class PermutationTest {

        [TestMethod]
        public void getValue() {
            Rubik myRubik = new Rubik();
            myRubik.rotateFace(new Rotation(Face.F, Direction.CW));
            Permutation myPermutation = myRubik.getPermutation();
            Assert.AreEqual(10, myPermutation.getValue(1), "first floor");
            Assert.AreEqual(14, myPermutation.getValue(2), "second floor");
            Assert.AreEqual(24, myPermutation.getValue(3), "third floor");

        }

        [TestMethod]
        public void testEqualsEqual() {
            Permutation Apermutation = new Permutation();
            Permutation Bpermutation = new Permutation();

            for (int i = 0; i < 20; i++) {
                Apermutation.addCubicleData(new CubeCubicle(new Location(Face.D, Face.R)
                        , new Location(Face.D, Face.R), new Position(Face.U, Face.F)));
                Bpermutation.addCubicleData(new CubeCubicle(new Location(Face.D, Face.R)
                        , new Location(Face.D, Face.R), new Position(Face.U, Face.F)));
            }

            Assert.AreEqual(true, Apermutation.equals(Bpermutation));

        }
        [TestMethod]
        public void testEqualsFirstFloor() {
            Permutation Apermutation = new Permutation();
            Permutation Bpermutation = new Permutation();

            for (int i = 0; i < 19; i++) {
                Apermutation.addCubicleData(new CubeCubicle(new Location(Face.D, Face.R)
                        , new Location(Face.D, Face.R), new Position(Face.U, Face.F)));
                Bpermutation.addCubicleData(new CubeCubicle(new Location(Face.D, Face.R)
                        , new Location(Face.D, Face.R), new Position(Face.U, Face.F)));
            }
            Apermutation.addCubicleData(new CubeCubicle(new Location(Face.U, Face.R)
                    , new Location(Face.U, Face.R), new Position(Face.U, Face.F)));
            Bpermutation.addCubicleData(new CubeCubicle(new Location(Face.U, Face.R)
                    , new Location(Face.U, Face.L), new Position(Face.U, Face.F)));

            Assert.AreEqual(false, Apermutation.equals(Bpermutation), "first floor");
            Assert.AreEqual(false, Apermutation.equals(Bpermutation), "third floor");

        }
    }
}