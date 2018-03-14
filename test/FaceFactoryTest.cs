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
    class FaceFactoryTest {

    [TestMethod]
    void getFaceByInt() {
        FaceFactory myFactory = new FaceFactory();
        Assert.AreEqual(Face.L, FaceFactory.getFaceByInt(3));
        Assert.AreEqual(Face.R, FaceFactory.getFaceByInt(2));
        Assert.AreEqual(Face.U, FaceFactory.getFaceByInt(0));
        Assert.AreEqual(Face.D, FaceFactory.getFaceByInt(1));
        Assert.AreEqual(Face.F, FaceFactory.getFaceByInt(4));
        Assert.AreEqual(Face.B, FaceFactory.getFaceByInt(5));


    }
}
}