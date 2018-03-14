using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRubikSolver
{

public class RotationTreeLoader {
    static RotationTree loadSearchTree() {
        RotationLinkedList l_rotationLinkedList = new RotationLinkedList();
        RotationTree l_tree = new RotationTree();

        RubikFileReader l_fileReader = new RubikFileReader("C:\\DevProj\\RubikSolver\\permRubik.txt");
        loadRotationTreeFromFile(l_fileReader, l_tree);
        loadRotationTreeFromStandard(l_tree, l_rotationLinkedList, 7);
        l_fileReader.close();

        return l_tree;
    }


    public static void loadRotationTreeFromFile(RubikFileReader p_File, RotationTree p_tree) {
        RotationLinkedList l_rotationLinkedList = new RotationLinkedList();
        while (l_rotationLinkedList.readFromFile(p_File)) {
            p_tree.addRotationLinkedList(l_rotationLinkedList);
        }

    }

    public static void loadRotationTreeFromStandard(RotationTree p_tree, RotationLinkedList p_rotationLinkedList, int p_depth) {
        if (p_depth == 0) return;
            foreach (Face face in Enum.GetValues(typeof(Face)))
               
                foreach (Direction direction in Enum.GetValues(typeof(Direction))) { 
              
                Rotation newRotation = new Rotation(face,direction);
                if (p_rotationLinkedList.isRedundant(newRotation))
                    continue;
                p_rotationLinkedList.addRotation(newRotation);
                p_tree.addRotationLinkedList(p_rotationLinkedList);
                loadRotationTreeFromStandard(p_tree, p_rotationLinkedList, p_depth - 1);
                p_rotationLinkedList.removeRotation();
            }
    }

    public static void findGoodRotationLinks(String p_firstFloorFile
            , String p_secondFloorFile, String p_thirdFloorFile, int p_levels) {
        RubikFileWriter l_firstWriter = new RubikFileWriter(p_firstFloorFile);
        RubikFileWriter l_secondWriter = new RubikFileWriter(p_secondFloorFile);
        RubikFileWriter l_thirdWriter = new RubikFileWriter(p_thirdFloorFile);
        Rubik l_rubik = new Rubik();
        Permutation l_initialPermutation = l_rubik.getPermutation();
        RotationLinkedList l_rotationLinkedList = new RotationLinkedList();
        BuildFilesForRotation(l_firstWriter,l_secondWriter,l_thirdWriter
                ,l_rubik, l_initialPermutation, l_rotationLinkedList, p_levels,"");
        l_firstWriter.close();
        l_secondWriter.close();
        l_thirdWriter.close();

    }

    public static void BuildFilesForRotation(RubikFileWriter p_firstFloorFile, RubikFileWriter p_secondFloorFile, RubikFileWriter p_thirdFloorFile
                                             , Rubik p_rubik
            , Permutation p_initialPermutation, RotationLinkedList p_rotationLinkedList, int p_level, String p_progressString){

        if (p_level == 0) return;
        if (p_level>5) Console.WriteLine(p_progressString);
        int i=0;
            foreach (Face face in Enum.GetValues(typeof(Face)))

                foreach (Direction direction in Enum.GetValues(typeof(Direction)))
                {
            i++;
            String myProgressString = p_progressString+String.Format(".{0}",i);
                Rotation newRotation = new Rotation(face,direction);
                if (p_rotationLinkedList.isRedundant(newRotation))
                    continue;
                p_rotationLinkedList.addRotation(newRotation);
                p_rubik.rotateFace(newRotation);
                if (p_rubik.isDifferentItemsInFirstFloorLessThanThree(p_initialPermutation))
                    p_rotationLinkedList.writeToFile(p_firstFloorFile);
                if (p_rubik.isDifferentItemsOnlyInSecondFloorLessThanThree(p_initialPermutation))
                    p_rotationLinkedList.writeToFile((p_secondFloorFile));
                if (p_rubik.changesOnlyInThirdFloor(p_initialPermutation))
                    p_rotationLinkedList.writeToFile(p_thirdFloorFile);

                BuildFilesForRotation(p_firstFloorFile,p_secondFloorFile,p_thirdFloorFile,
                       p_rubik,p_initialPermutation, p_rotationLinkedList,p_level-1,myProgressString);
                p_rotationLinkedList.removeRotation();
                p_rubik.rotateFace(newRotation.getReverse());
            }
    }



}
}
