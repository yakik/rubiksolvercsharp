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
    class RotationTreeLoaderTest {

    [TestMethod]
    void loadSearchTree() {
//
    }

    [TestMethod]
    void numberNodesRotationTree() {
        RotationLinkedList l_rotationLinkedList = new RotationLinkedList();
        RotationTree l_tree = new RotationTree();
        RotationTreeLoader.loadRotationTreeFromStandard(l_tree, l_rotationLinkedList, 4);
     //   int numberOfNodes = l_tree.getNumberOfNodes();
     //   Assert.AreEqual(11205, numberOfNodes);


    }

    [TestMethod]
    void loadRotationTreeFromFile() {
        RotationLinkedList l_rotationLinkedList = new RotationLinkedList();
        RotationTree l_tree = new RotationTree();
        forTestRubikFileReader myTestReader = new forTestRubikFileReader("(5,1) (3,1) (1,0) (3,0) (4,0) (3,0) (4,1) (1,1) \n" +
                "(5,1) (3,1) (1,0) (3,0) (5,0) \n");
        RotationTreeLoader.loadRotationTreeFromFile(myTestReader, l_tree);
        Assert.AreEqual(Direction.CCW,l_tree.getRotationLinkedList(1).get(0).getDirection());
    }

    [TestMethod]
    void writeToFileXLevelsSecondAndThird() {
        RotationTreeLoader.findGoodRotationLinks("tstFirstFloor.txt", "tstSecondFloor.txt"
        ,"tstThirdFloor.txt",2);
        RotationTree firstFloorTree = new RotationTree();
        RotationTree secondFloorTree = new RotationTree();
        RotationTree thirdFloorTree = new RotationTree();
        RubikFileReader readFirstFloor = new RubikFileReader("tstFirstFloor.txt");
        RubikFileReader readSecondFloor = new RubikFileReader("tstSecondFloor.txt");
        RubikFileReader readThirdFloor = new RubikFileReader("tstThirdFloor.txt");
        RotationTreeLoader.loadRotationTreeFromFile(readFirstFloor,firstFloorTree);
        RotationTreeLoader.loadRotationTreeFromFile(readSecondFloor, secondFloorTree);
        RotationTreeLoader.loadRotationTreeFromFile(readThirdFloor,thirdFloorTree);


    }




    [TestMethod]
    void loadRotationTreeFromStandard() {
        RotationLinkedList l_rotationLinkedList = new RotationLinkedList();
        RotationTree l_tree = new RotationTree();
        RotationTreeLoader.loadRotationTreeFromStandard(l_tree, l_rotationLinkedList, 1);
        int i=-1;
        foreach (Face face in Enum.GetValues(typeof(Face)))
            foreach (Direction direction in Enum.GetValues(typeof(Direction))) {
            i++;
                int rotationValue = (new Rotation(face,direction)).getValue();
                Assert.AreEqual(face, l_tree.getRotationLinkedList(i).get(0).getFace());
                Assert.AreEqual(direction, l_tree.getRotationLinkedList(i).get(0).getDirection());
            }
    }
}
}