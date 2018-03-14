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
    class FaceTest {
    [TestMethod]
    void testFaceGetIntGetChar() {
        Face myFace = Face.D;
        Assert.AreEqual(1, myFace.getInt());
        Assert.AreEqual('D', myFace.getIntOfChar());
        myFace = Face.F;
        Assert.AreEqual(4, myFace.getInt());
        Assert.AreEqual('F', myFace.getIntOfChar());
        myFace = Face.R;
        Assert.AreEqual(2, myFace.getInt());
        Assert.AreEqual('R', myFace.getIntOfChar());
        myFace = Face.U;
        Assert.AreEqual(0, myFace.getInt());
        Assert.AreEqual('U', myFace.getIntOfChar());
        myFace = Face.B;
        Assert.AreEqual(5, myFace.getInt());
        Assert.AreEqual('B', myFace.getIntOfChar());
        myFace = Face.L;
        Assert.AreEqual(3, myFace.getInt());
        Assert.AreEqual('L', myFace.getIntOfChar());
    }

    [TestMethod]
    void testFaceEquals() {
        Face myFace = Face.D;
        Assert.AreEqual(Face.D, myFace);
        Assert.AreEqual(true, myFace==Face.D);
    }

    [TestMethod]
    void testFaceGetOpposite() {
        Face myFace = Face.D;
        Assert.AreEqual(Face.U, myFace.getOpposite());
        myFace = Face.F;
        Assert.AreEqual(Face.B, myFace.getOpposite());
        myFace = Face.R;
        Assert.AreEqual(Face.L, myFace.getOpposite());
        myFace = Face.U;
        Assert.AreEqual(Face.D, myFace.getOpposite());
        myFace = Face.B;
        Assert.AreEqual(Face.F, myFace.getOpposite());
        myFace = Face.L;
        Assert.AreEqual(Face.R, myFace.getOpposite());
    }

}
}