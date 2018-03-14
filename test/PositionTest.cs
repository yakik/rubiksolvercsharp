using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpRubikSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpRubikSolver
{


    [TestClass]
    class PositionTest {

    [TestMethod]
    void getString() {
        Position myPosition = new Position(Face.U,Face.F);
        Assert.AreEqual("U, F",myPosition.getString());
    }

    [TestMethod]
    void rotateCW_U() {
        Position myPosition = new Position(Face.U, Face.F);
        myPosition.rotate(new Rotation(Face.F, Direction.CW));
        Assert.AreEqual(Face.L,myPosition.getFace(Face.U));
    }

    [TestMethod]
    void rotateCW_D() {
        Position myPosition = new Position(Face.U, Face.F);
        myPosition.rotate(new Rotation(Face.F, Direction.CW));
        Assert.AreEqual(Face.R,myPosition.getFace(Face.D));
    }

    [TestMethod]
    void rotateCCW() {
        Position myPosition = new Position(Face.U, Face.F);
        myPosition.rotate(new Rotation(Face.F, Direction.CCW));
        Assert.AreEqual(Face.R,myPosition.getFace(Face.U));
    }

    [TestMethod]
    void rotateCCW_D() {
        Position myPosition = new Position(Face.U, Face.F);
        myPosition.rotate(new Rotation(Face.F, Direction.CCW));
        Assert.AreEqual(Face.L,myPosition.getFace(Face.D));
    }

    [TestMethod]
    void moreRotationTests() {
        Position myPosition = new Position(Face.U, Face.F);
        myPosition.rotate(new Rotation(Face.L, Direction.CW));
        Assert.AreEqual(true,myPosition.equals(new Position(Face.B,Face.U)));
        myPosition.rotate(new Rotation(Face.D, Direction.CW));
        Assert.AreEqual(true,myPosition.equals(new Position(Face.B,Face.L)));
        myPosition.rotate(new Rotation(Face.D, Direction.CCW));
        Assert.AreEqual(true,myPosition.equals(new Position(Face.B,Face.U)));
    }

    [TestMethod]
    void rotateCCW_DD() {
        Position myPosition = new Position(Face.U, Face.F);
        myPosition.rotate(new Rotation(Face.D, Direction.CCW));
        Assert.AreEqual(Face.D,myPosition.getFace(Face.D));
    }
    [TestMethod]
    void getFace() {
    }

    [TestMethod]
    void getHorizonalFacebyVirtual() {
    }

    [TestMethod]
    void equals() {
    }

    [TestMethod]
    void rotate1() {
    }
}
}