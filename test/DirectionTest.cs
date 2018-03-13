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
    class DirectionTest {
    [TestMethod]
    void testDirectionGetIntGetChar() {
        Direction myDirection = Direction.CW;
        assertEquals(0, myDirection.getInt());
        assertEquals("CW", myDirection.getString());
        myDirection = Direction.CCW;
        assertEquals(1, myDirection.getInt());
        assertEquals("CCW", myDirection.getString());
           };

    [TestMethod]
    void testDirectionEquals() {
        Direction myDirection = Direction.CW;
        assertEquals(Direction.CW, myDirection);
        assertEquals(true, myDirection==Direction.CW);
    }
    [TestMethod]
    void Direction() {
        Direction myDirection = Direction.CW;
        assertEquals(Direction.CCW, myDirection.getOpposite());
        myDirection = Direction.CCW;
        assertEquals(Direction.CW, myDirection.getOpposite());
    }

}
}