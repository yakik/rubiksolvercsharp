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
    class LocationTest {

    [TestMethod]
    void isEdge() {
        Location myLocation = new Location(Face.D,Face.L, Face.F);
        assertEquals(false,myLocation.isEdge());
        myLocation = new Location(Face.D,Face.L);
        assertEquals(true,myLocation.isEdge());
    }

    [TestMethod]
    void getFaces() {
        Location myLocation = new Location(Face.D,Face.L, Face.F);
        //taking into account facecs are sorted according to int value
        assertEquals(Face.D,myLocation.getFace0());
        assertEquals(Face.L,myLocation.getFace1());
        assertEquals(Face.F,myLocation.getFace2());
    }

    [TestMethod]
    void equals() {
        Location myLocation = new Location(Face.D,Face.L, Face.F);
        Location mySecondLocation = new Location(Face.L,Face.F, Face.D);
        Location myThirdLocation = new Location(Face.R, Face.F, Face.D);
        assertEquals(true,mySecondLocation.equals(myLocation));
        assertEquals(false, mySecondLocation.equals(myThirdLocation));
    }

    [TestMethod]
    void testGetFloor() {
        assertEquals(3, new Location(Face.U,Face.L, Face.F).getFloor(),"1");
        assertEquals(3, new Location(Face.U,Face.L, Face.B).getFloor(),"2");
        assertEquals(3, new Location(Face.U,Face.R, Face.F).getFloor(),"3");
        assertEquals(3, new Location(Face.U,Face.R, Face.B).getFloor(),"4");
        assertEquals(1, new Location(Face.D,Face.L, Face.F).getFloor(),"5");
        assertEquals(1, new Location(Face.D,Face.L, Face.B).getFloor(),"6");
        assertEquals(1, new Location(Face.D,Face.R, Face.F).getFloor(),"7");
        assertEquals(1, new Location(Face.D,Face.R, Face.B).getFloor(),"8");

        assertEquals(3, new Location(Face.U,Face.F).getFloor(),"10");
        assertEquals(3, new Location(Face.U,Face.B).getFloor(),"11");
        assertEquals(3, new Location(Face.U,Face.L).getFloor(),"12");
        assertEquals(3, new Location(Face.U,Face.R).getFloor(),"13");

        assertEquals(2, new Location(Face.F,Face.L).getFloor(),"14");
        assertEquals(2, new Location(Face.F,Face.R).getFloor(),"15");
        assertEquals(2, new Location(Face.B,Face.L).getFloor(),"16");
        assertEquals(2, new Location(Face.B,Face.R).getFloor(),"17");

        assertEquals(1, new Location(Face.D,Face.L).getFloor(),"18");
        assertEquals(1, new Location(Face.D,Face.R).getFloor(),"19");
        assertEquals(1, new Location(Face.F,Face.D).getFloor(),"20");
        assertEquals(1, new Location(Face.B,Face.D).getFloor(),"21");


    }

    [TestMethod]
    void getString() {
        Location myLocation = new Location(Face.D,Face.L, Face.F);
        assertEquals("D, L, F", myLocation.getString());
        myLocation = new Location(Face.D,Face.L);
        assertEquals("D, L",myLocation.getString());

    }
}
}