using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpRubikSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpRubikSolverUTests
{


    [TestClass]
    public class PositionTest {

    [TestMethod]
        public void getString() {
        Position myPosition = new Position(Face.U,Face.F);
        Assert.AreEqual("U, F",myPosition.getString());
    }

    [TestMethod]
        public void rotateCW_U() {
        Position myPosition = new Position(Face.U, Face.F);
        myPosition.rotate(new Rotation(Face.F, Direction.CW));
        Assert.AreEqual(Face.L,myPosition.getFace(Face.U));
    }

    [TestMethod]
        public void rotateCW_D() {
        Position myPosition = new Position(Face.U, Face.F);
        myPosition.rotate(new Rotation(Face.F, Direction.CW));
        Assert.AreEqual(Face.R,myPosition.getFace(Face.D));
    }

    [TestMethod]
        public void rotateCCW() {
        Position myPosition = new Position(Face.U, Face.F);
        myPosition.rotate(new Rotation(Face.F, Direction.CCW));
        Assert.AreEqual(Face.R,myPosition.getFace(Face.U));
    }

    [TestMethod]
        public void rotateCCW_D() {
        Position myPosition = new Position(Face.U, Face.F);
        myPosition.rotate(new Rotation(Face.F, Direction.CCW));
        Assert.AreEqual(Face.L,myPosition.getFace(Face.D));
    }

    [TestMethod]
        public void moreRotationTests() {
        Position myPosition = new Position(Face.U, Face.F);
        myPosition.rotate(new Rotation(Face.L, Direction.CW));
        Assert.AreEqual(true,myPosition.equals(new Position(Face.B,Face.U)));
        myPosition.rotate(new Rotation(Face.D, Direction.CW));
        Assert.AreEqual(true,myPosition.equals(new Position(Face.B,Face.L)));
        myPosition.rotate(new Rotation(Face.D, Direction.CCW));
        Assert.AreEqual(true,myPosition.equals(new Position(Face.B,Face.U)));
    }

    [TestMethod]
        public void rotateCCW_DD() {
        Position myPosition = new Position(Face.U, Face.F);
        myPosition.rotate(new Rotation(Face.D, Direction.CCW));
        Assert.AreEqual(Face.D,myPosition.getFace(Face.D));
    }
    [TestMethod]
        public void getFace() {
    }

    [TestMethod]
        public void getHorizonalFacebyVirtual() {
    }

    [TestMethod]
        public void equals() {
    }

    [TestMethod]
        public void rotate1() {
    }
}
}