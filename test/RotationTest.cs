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
    public class RotationTest {

        public void rotationReadTest(String stringToRead, Face expectedFace, Direction expectedDirection){
        Rotation testRotation = new Rotation();
        forTestRubikFileReader myTestReader = new forTestRubikFileReader(stringToRead);
        testRotation.readFromFile(myTestReader);

        Assert.AreEqual(expectedFace, testRotation.getFace());
        Assert.AreEqual(expectedDirection, testRotation.getDirection());

    }


    [TestMethod]
        public void testRotationEquals() {
        Rotation myRotation = new Rotation(Face.F, Direction.CW);
        Assert.AreEqual(true, myRotation.equals((new Rotation(Face.F, Direction.CW))));
    }
    [TestMethod]
        public void rotationRead_B_CCW() {
        rotationReadTest (" (5,1) ", Face.B,Direction.CCW);
    }

    [TestMethod]
        public void rotationRead_D_CW() {
        rotationReadTest (" (1,0) ", Face.D,Direction.CW);

    }
}
}