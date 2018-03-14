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
    public class DirectionTest {
    [TestMethod]
        public void testDirectionGetIntGetChar() {
        Direction myDirection = Direction.CW;
        Assert.AreEqual(0, myDirection.getInt());
        Assert.AreEqual("CW", myDirection.getString());
        myDirection = Direction.CCW;
        Assert.AreEqual(1, myDirection.getInt());
        Assert.AreEqual("CCW", myDirection.getString());
           }

    [TestMethod]
        public void testDirectionEquals() {
        Direction myDirection = Direction.CW;
        Assert.AreEqual(Direction.CW, myDirection);
        Assert.AreEqual(true, myDirection==Direction.CW);
    }
    [TestMethod]
        public void DirectionOpposite() {
        Direction myDirection = Direction.CW;
        Assert.AreEqual(Direction.CCW, myDirection.getOpposite());
        myDirection = Direction.CCW;
        Assert.AreEqual(Direction.CW, myDirection.getOpposite());
    }

}
}