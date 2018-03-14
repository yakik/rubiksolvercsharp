using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpRubikSolver
{



public class SolutionManager {

    private ArrayList c_solutionList = new ArrayList();


        public SolutionManager() {
        int i;
        for (i = 0; i < 41; i++)
            c_solutionList.Add(new ArrayList());
    }

        public void addSolution(RotationLinkedList p_rotationLinkedList, Permutation p_permutation, Solution p_prevSolution,
                     int p_value, int p_floor) {

           if (/*(p_value>=32 && getBestValue()>=36) ||*/ (c_solutionList[p_value] as ArrayList).Count < 40) {
            (c_solutionList[p_value] as ArrayList).Add(new SolutionNode(new Solution(p_rotationLinkedList.getCopy(), p_permutation.getCopy(), p_prevSolution)));

   //         Console.Write("Added Solution Value={0}, Index={0}\n", p_value, p_value);
        }



    }


        public Solution getBestUndeveloped() {
        int i = 40;
        Solution l_bestSolution = null;
        while (i >= 0 && l_bestSolution == null) {
            if ((c_solutionList[i] as ArrayList).Count > 0) {
                int j = 0;
                while (j < (c_solutionList[i] as ArrayList).Count && l_bestSolution == null) {
                    SolutionNode l_node = ((c_solutionList[i] as ArrayList)[j++] as SolutionNode);
                    if (!(l_node.isDeveloped())) {
                        l_bestSolution = l_node.getSolution();
                        l_node.setDeveloped();
                    }
                }
            }
            i--;
        }
        return l_bestSolution;
    }

        public Solution getBest() {
        int i = 40;
        Solution l_returnValue = null;
        while (i >= 0 && l_returnValue == null) {
            if ((c_solutionList[i] as ArrayList).Count>0)
                l_returnValue = ((c_solutionList[i] as ArrayList)[0] as SolutionNode).getSolution();
            i--;
        }
        return l_returnValue;
    }

        public int getBestValue() {
        int i = 40;
        int l_returnValue = 0;
        while (i >= 0 && l_returnValue == 0) {
            if ((c_solutionList[i] as ArrayList).Count>0)
                l_returnValue = i;
            i--;
        }
        return l_returnValue;
    }

         private class SolutionNode {
        private Solution c_solution;
        private bool c_isDeveloped;

            public SolutionNode(Solution p_solution) {
            c_isDeveloped = false;
            c_solution = p_solution;
        }

            public Solution getSolution() {
            return c_solution;
        }


            public bool isDeveloped() {
            return c_isDeveloped;
        }

            public void setDeveloped() {
            c_isDeveloped = true;
        }


    }
}
}