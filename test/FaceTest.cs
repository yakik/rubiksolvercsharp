using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpRubikSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpRubikSolverUTests {


    [TestClass]
    public class FaceTest {
        [TestMethod]
        public void testFaceGetIntGetChar() {
            Face myFace = Face.D;
            Assert.AreEqual(1, myFace.getInt());
            Assert.AreEqual('D', myFace.getChar());
            myFace = Face.F;
            Assert.AreEqual(4, myFace.getInt());
            Assert.AreEqual('F', myFace.getChar());
            myFace = Face.R;
            Assert.AreEqual(2, myFace.getInt());
            Assert.AreEqual('R', myFace.getChar());
            myFace = Face.U;
            Assert.AreEqual(0, myFace.getInt());
            Assert.AreEqual('U', myFace.getChar());
            myFace = Face.B;
            Assert.AreEqual(5, myFace.getInt());
            Assert.AreEqual('B', myFace.getChar());
            myFace = Face.L;
            Assert.AreEqual(3, myFace.getInt());
            Assert.AreEqual('L', myFace.getChar());
        }

        [TestMethod]
        public void testFaceEquals() {
            Face myFace = Face.D;
            Assert.AreEqual(Face.D, myFace);
            Assert.AreEqual(true, myFace == Face.D);
        }

        [TestMethod]
        public void testFaceGetOpposite() {
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