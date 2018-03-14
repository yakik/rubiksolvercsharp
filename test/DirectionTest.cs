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
    class DirectionTest {
    [TestMethod]
    void testDirectionGetIntGetChar() {
        Direction myDirection = Direction.CW;
        Assert.AreEqual(0, myDirection.getInt());
        Assert.AreEqual("CW", myDirection.getString());
        myDirection = Direction.CCW;
        Assert.AreEqual(1, myDirection.getInt());
        Assert.AreEqual("CCW", myDirection.getString());
           }

    [TestMethod]
    void testDirectionEquals() {
        Direction myDirection = Direction.CW;
        Assert.AreEqual(Direction.CW, myDirection);
        Assert.AreEqual(true, myDirection==Direction.CW);
    }
    [TestMethod]
    void DirectionOpposite() {
        Direction myDirection = Direction.CW;
        Assert.AreEqual(Direction.CCW, myDirection.getOpposite());
        myDirection = Direction.CCW;
        Assert.AreEqual(Direction.CW, myDirection.getOpposite());
    }

}
}