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
    class RotationLinkedListTest {

    [TestMethod]
    void isRedundantCW() {
        RotationLinkedList myList = new RotationLinkedList();
                myList.addRotation(new Rotation(Face.F,Direction.CW));
        assertEquals(true,myList.isRedundant(new Rotation(Face.F, Direction.CW)));


    }

    [TestMethod]
    void testWriteRead() {
        RotationLinkedList myList = new RotationLinkedList();
        myList.addRotation(new Rotation(Face.F,Direction.CW));
        myList.addRotation(new Rotation(Face.U,Direction.CCW));
        RubikFileWriter myWriter = new RubikFileWriter("writeLinked.txt");
        myList.writeToFile(myWriter);
        myWriter.close();
        RubikFileReader myReader = new RubikFileReader("writeLinked.txt");
        RotationLinkedList mySecondList = new RotationLinkedList();
        mySecondList.readFromFile(myReader);
        assertEquals(true,myList.get(0).equals(mySecondList.get(0)),"first");
        assertEquals(true,myList.get(1).equals(mySecondList.get(1)),"first");
    }



    [TestMethod]
    void isRedundantCCW() {
        RotationLinkedList myList = new RotationLinkedList();
        myList.addRotation(new Rotation(Face.F,Direction.CCW));
        myList.addRotation(new Rotation(Face.F,Direction.CCW));
        assertEquals(true,myList.isRedundant(new Rotation(Face.F, Direction.CCW)));


    }
}
}