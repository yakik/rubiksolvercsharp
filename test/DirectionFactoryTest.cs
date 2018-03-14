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
    class DirectionFactoryTest {

    [TestMethod]
    void getDirectionByInt() {
        DirectionFactory myFactory = new DirectionFactory();
        Assert.AreEqual(Direction.CW, DirectionFactory.getDirectionByInt(0));
        Assert.AreEqual(Direction.CCW, DirectionFactory.getDirectionByInt(1));
    }
}
}