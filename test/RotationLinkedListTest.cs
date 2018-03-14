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
    public class RotationLinkedListTest {

    [TestMethod]
        public void isRedundantCW() {
        RotationLinkedList myList = new RotationLinkedList();
                myList.addRotation(new Rotation(Face.F,Direction.CW));
        Assert.AreEqual(true,myList.isRedundant(new Rotation(Face.F, Direction.CW)));


    }

    [TestMethod]
        public void testWriteRead() {
        RotationLinkedList myList = new RotationLinkedList();
        myList.addRotation(new Rotation(Face.F,Direction.CW));
        myList.addRotation(new Rotation(Face.U,Direction.CCW));
        RubikFileWriter myWriter = new RubikFileWriter("writeLinked.txt");
        myList.writeToFile(myWriter);
        myWriter.close();
        RubikFileReader myReader = new RubikFileReader("writeLinked.txt");
        RotationLinkedList mySecondList = new RotationLinkedList();
        mySecondList.readFromFile(myReader);
        Assert.AreEqual(true,myList.get(0).equals(mySecondList.get(0)),"first");
        Assert.AreEqual(true,myList.get(1).equals(mySecondList.get(1)),"first");
    }



    [TestMethod]
        public void isRedundantCCW() {
        RotationLinkedList myList = new RotationLinkedList();
        myList.addRotation(new Rotation(Face.F,Direction.CCW));
        myList.addRotation(new Rotation(Face.F,Direction.CCW));
        Assert.AreEqual(true,myList.isRedundant(new Rotation(Face.F, Direction.CCW)));


    }
}
}