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
    class RotationTest {

    void rotationReadTest(String stringToRead, Face expectedFace, Direction expectedDirection){
        Rotation testRotation = new Rotation();
        forTestRubikFileReader myTestReader = new forTestRubikFileReader(stringToRead);
        testRotation.readFromFile(myTestReader);

        assertEquals(expectedFace, testRotation.getFace());
        assertEquals(expectedDirection, testRotation.getDirection());

    }


    [TestMethod]
    void testRotationEquals() {
        Rotation myRotation = new Rotation(Face.F, Direction.CW);
        assertEquals(true, myRotation.equals((new Rotation(Face.F, Direction.CW))));
    }
    [TestMethod]
    void rotationRead_B_CCW() {
        rotationReadTest (" (5,1) ", Face.B,Direction.CCW);
    }

    [TestMethod]
    void rotationRead_D_CW() {
        rotationReadTest (" (1,0) ", Face.D,Direction.CW);

    }
}
}