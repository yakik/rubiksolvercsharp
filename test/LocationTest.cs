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
    public class LocationTest {

    [TestMethod]
        public void isEdge() {
        Location myLocation = new Location(Face.D,Face.L, Face.F);
        Assert.AreEqual(false,myLocation.isEdge());
        myLocation = new Location(Face.D,Face.L);
        Assert.AreEqual(true,myLocation.isEdge());
    }

    [TestMethod]
        public void getFaces() {
        Location myLocation = new Location(Face.D,Face.L, Face.F);
        //taking into account facecs are sorted according to int value
        Assert.AreEqual(Face.D,myLocation.getFace0());
        Assert.AreEqual(Face.L,myLocation.getFace1());
        Assert.AreEqual(Face.F,myLocation.getFace2());
    }

    [TestMethod]
        public void equals() {
        Location myLocation = new Location(Face.D,Face.L, Face.F);
        Location mySecondLocation = new Location(Face.L,Face.F, Face.D);
        Location myThirdLocation = new Location(Face.R, Face.F, Face.D);
        Assert.AreEqual(true,mySecondLocation.equals(myLocation));
        Assert.AreEqual(false, mySecondLocation.equals(myThirdLocation));
    }

    [TestMethod]
        public void testGetFloor() {
        Assert.AreEqual(3, new Location(Face.U,Face.L, Face.F).getFloor(),"1");
        Assert.AreEqual(3, new Location(Face.U,Face.L, Face.B).getFloor(),"2");
        Assert.AreEqual(3, new Location(Face.U,Face.R, Face.F).getFloor(),"3");
        Assert.AreEqual(3, new Location(Face.U,Face.R, Face.B).getFloor(),"4");
        Assert.AreEqual(1, new Location(Face.D,Face.L, Face.F).getFloor(),"5");
        Assert.AreEqual(1, new Location(Face.D,Face.L, Face.B).getFloor(),"6");
        Assert.AreEqual(1, new Location(Face.D,Face.R, Face.F).getFloor(),"7");
        Assert.AreEqual(1, new Location(Face.D,Face.R, Face.B).getFloor(),"8");

        Assert.AreEqual(3, new Location(Face.U,Face.F).getFloor(),"10");
        Assert.AreEqual(3, new Location(Face.U,Face.B).getFloor(),"11");
        Assert.AreEqual(3, new Location(Face.U,Face.L).getFloor(),"12");
        Assert.AreEqual(3, new Location(Face.U,Face.R).getFloor(),"13");

        Assert.AreEqual(2, new Location(Face.F,Face.L).getFloor(),"14");
        Assert.AreEqual(2, new Location(Face.F,Face.R).getFloor(),"15");
        Assert.AreEqual(2, new Location(Face.B,Face.L).getFloor(),"16");
        Assert.AreEqual(2, new Location(Face.B,Face.R).getFloor(),"17");

        Assert.AreEqual(1, new Location(Face.D,Face.L).getFloor(),"18");
        Assert.AreEqual(1, new Location(Face.D,Face.R).getFloor(),"19");
        Assert.AreEqual(1, new Location(Face.F,Face.D).getFloor(),"20");
        Assert.AreEqual(1, new Location(Face.B,Face.D).getFloor(),"21");


    }

    [TestMethod]
        public void getString() {
        Location myLocation = new Location(Face.D,Face.L, Face.F);
        Assert.AreEqual("D, L, F", myLocation.getString());
        myLocation = new Location(Face.D,Face.L);
        Assert.AreEqual("D, L",myLocation.getString());

    }
}
}