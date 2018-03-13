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
    class FaceFactoryTest {

    [TestMethod]
    void getFaceByInt() {
        FaceFactory myFactory = new FaceFactory();
        assertEquals(Face.L, FaceFactory.getFaceByInt(3));
        assertEquals(Face.R, FaceFactory.getFaceByInt(2));
        assertEquals(Face.U, FaceFactory.getFaceByInt(0));
        assertEquals(Face.D, FaceFactory.getFaceByInt(1));
        assertEquals(Face.F, FaceFactory.getFaceByInt(4));
        assertEquals(Face.B, FaceFactory.getFaceByInt(5));


    }
}
}