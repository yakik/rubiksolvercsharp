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
    class DirectionFactoryTest {

    [TestMethod]
    void getDirectionByInt() {
        DirectionFactory myFactory = new DirectionFactory();
        assertEquals(Direction.CW, DirectionFactory.getDirectionByInt(0));
        assertEquals(Direction.CCW, DirectionFactory.getDirectionByInt(1));
    }
}
}