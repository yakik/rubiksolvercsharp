using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRubikSolver
{

public class Solver {

        public Solver() {
    }

        public Solution solve(Rubik p_rubik, RotationTree p_firstTree, RotationTree p_secondTree, RotationTree p_thirdTree) {

        int l_numberOfCubicleInPlace;
        Permutation l_permutation = p_rubik.getPermutation();
        SolutionManager l_solutionManager = new SolutionManager();
        Solution l_solutionToDev;

        RotationLinkedList l_rotationLinkedList = new RotationLinkedList();

        int l_floor = getTargetFloor(l_permutation);
        l_numberOfCubicleInPlace = l_permutation.getValue(l_floor);

        l_solutionManager.addSolution(l_rotationLinkedList, l_permutation, null, l_numberOfCubicleInPlace,l_floor);
        while ((l_solutionToDev = l_solutionManager.getBestUndeveloped()) != null &&
                l_solutionManager.getBestValue() < 40) {
            int targetFloor = getTargetFloor(l_solutionToDev.getPermutation());
           Console.Write("Searching %d",l_solutionToDev.getPermutation().getValue(targetFloor));
            if (l_solutionManager.getBestValue()>l_solutionToDev.getPermutation().getValue(targetFloor)+14)
            {
                Console.WriteLine("Couldn't Find a Solution");
                return l_solutionManager.getBest();
            }
            if (targetFloor == 1)
                findBetterSolution(l_solutionToDev, p_firstTree, l_solutionManager,targetFloor );
            if (targetFloor == 2)
                findBetterSolution(l_solutionToDev, p_secondTree, l_solutionManager,targetFloor );
            if (targetFloor == 3)
                findBetterSolution(l_solutionToDev, p_thirdTree, l_solutionManager,targetFloor );

            l_floor = getTargetFloor(l_solutionManager.getBestValue());

            Console.Write("Floor=%d, Best yet:%d\n", l_floor, l_solutionManager.getBestValue());
            // l_solutionManager.getBest().print();


        }

        return l_solutionManager.getBest();

    }

    public int getTargetFloor(Permutation p_permutation) {
        if (p_permutation.getValue(1) >= 16) {
            if (p_permutation.getValue(2) < 24) {
                return 2;
            } else {
                return 3;
            }
        } else {
            return 1;
        }
    }

    public int getTargetFloor(int p_value) {
        if (p_value >= 16) {
            if (p_value < 24) {
                return 2;
            } else {
                return 3;
            }
        } else {
            return 1;
        }
    }




    private void findBetterSolution(Solution p_solution, RotationTree p_tree, SolutionManager p_solutionManager,
                                    int p_floor) {
        Rubik l_rubik = new Rubik();
        Permutation l_permutation = p_solution.getPermutation().getCopy();
        RotationLinkedList l_rotationLinkedList = new RotationLinkedList();
        int l_minimumValue = l_permutation.getValue(p_floor);

//	if (l_minimumValue < 8)
//		l_minimumValue = 8;
        l_rubik.setPermutation(l_permutation);
        searchTree(l_minimumValue-4, p_tree, l_rubik, p_solutionManager,
                p_solution, p_floor, 0);
    }


    public void searchTree(int p_minimumValue, RotationTree p_tree,
                           Rubik p_rubik,SolutionManager p_solutionManager,
                           Solution p_prevSolution, int p_floor, int depth) {
        if (p_minimumValue<2) p_minimumValue = 2;
        Permutation l_permutation = p_rubik.getPermutation().getCopy();
        Rubik l_rubik = new Rubik();
        for (int i=0;i<p_tree.getSize();i++){
            RotationLinkedList l_rotationLinkedList = p_tree.getRotationLinkedList(i);
            if (l_rotationLinkedList != null) {
                l_rubik.setPermutation(l_permutation);
                for (int j=0;j<l_rotationLinkedList.size();j++)
                    l_rubik.rotateFace(l_rotationLinkedList.get(j));
                Permutation l_resultPermutation = l_rubik.getPermutation().getCopy();

                if (l_resultPermutation.getValue(p_floor) >= p_minimumValue) {
                    p_solutionManager.addSolution(l_rotationLinkedList, l_resultPermutation, p_prevSolution, l_resultPermutation.getValue(p_floor), p_floor);
               //     if (depth == 1) Console.Write("Hi,value=%d\n",l_resultPermutation.getValue(p_floor));
                }
                if (p_floor==3 && depth==0) {
                  //  Console.WriteLine("Hi");
                    searchTree(p_minimumValue, p_tree, l_rubik, p_solutionManager,
                            new Solution(l_rotationLinkedList, l_resultPermutation, p_prevSolution), p_floor, 1);

                }
            }
        }
    }



}
}
