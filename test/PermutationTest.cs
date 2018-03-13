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
    class PermutationTest {

    [TestMethod]
    void getValue() {
        Rubik myRubik = new Rubik();
        myRubik.rotateFace(new Rotation(Face.F, Direction.CW));
        Permutation myPermutation = myRubik.getPermutation();
        assertEquals(10, myPermutation.getValue(1), "first floor");
        assertEquals(14, myPermutation.getValue(2), "second floor");
        assertEquals(24, myPermutation.getValue(3), "third floor");

    }

    [TestMethod]
    void testEqualsEqual() {
        Permutation Apermutation = new Permutation();
        Permutation Bpermutation = new Permutation();

        for (int i=0;i<20;i++){
            Apermutation.addCubicleData(new CubeCubicle(new Location(Face.D, Face.R)
                    , new Location(Face.D, Face.R), new Position(Face.U, Face.F)));
            Bpermutation.addCubicleData(new CubeCubicle(new Location(Face.D, Face.R)
                    , new Location(Face.D, Face.R), new Position(Face.U, Face.F)));
        }

        assertEquals(true, Apermutation.equals(Bpermutation));

    }
    [TestMethod]
    void testEqualsFirstFloor() {
        Permutation Apermutation = new Permutation();
        Permutation Bpermutation = new Permutation();

        for (int i=0;i<19;i++){
            Apermutation.addCubicleData(new CubeCubicle(new Location(Face.D, Face.R)
                    , new Location(Face.D, Face.R), new Position(Face.U, Face.F)));
            Bpermutation.addCubicleData(new CubeCubicle(new Location(Face.D, Face.R)
                    , new Location(Face.D, Face.R), new Position(Face.U, Face.F)));
        }
        Apermutation.addCubicleData(new CubeCubicle(new Location(Face.U, Face.R)
                , new Location(Face.U, Face.R), new Position(Face.U, Face.F)));
        Bpermutation.addCubicleData(new CubeCubicle(new Location(Face.U, Face.R)
                , new Location(Face.U, Face.L), new Position(Face.U, Face.F)));

        assertEquals(false, Apermutation.equals(Bpermutation),"first floor");
        assertEquals(false, Apermutation.equals(Bpermutation),"third floor");

    }
}
}