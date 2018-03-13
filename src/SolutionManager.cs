using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRubikSolver
{

import java.util.ArrayList;

public class SolutionManager {

    private ArrayList<ArrayList<SolutionNode>> c_solutionList = new ArrayList<ArrayList<SolutionNode>>();


    SolutionManager() {
        int i;
        for (i = 0; i < 41; i++)
            c_solutionList.add(new ArrayList<SolutionNode>());
    }

    void addSolution(RotationLinkedList p_rotationLinkedList, Permutation p_permutation, Solution p_prevSolution,
                     int p_value, int p_floor) {

           if (/*(p_value>=32 && getBestValue()>=36) ||*/ c_solutionList.get(p_value).size() < 40) {
            c_solutionList.get(p_value).add(new SolutionNode(new Solution(p_rotationLinkedList.getCopy(), p_permutation.getCopy(), p_prevSolution)));

   //         Console.Write("Added Solution Value=%d, Index=%d\n", p_value, p_value);
        }



    }


    Solution getBestUndeveloped() {
        int i = 40;
        Solution l_bestSolution = null;
        while (i >= 0 && l_bestSolution == null) {
            if (c_solutionList.get(i).size() > 0) {
                int j = 0;
                while (j < c_solutionList.get(i).size() && l_bestSolution == null) {
                    SolutionNode l_node = c_solutionList.get(i).get(j++);
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

    Solution getBest() {
        int i = 40;
        Solution l_returnValue = null;
        while (i >= 0 && l_returnValue == null) {
            if (c_solutionList.get(i).size()>0)
                l_returnValue = c_solutionList.get(i).get(0).getSolution();
            i--;
        }
        return l_returnValue;
    }

    int getBestValue() {
        int i = 40;
        int l_returnValue = 0;
        while (i >= 0 && l_returnValue == 0) {
            if (c_solutionList.get(i).size()>0)
                l_returnValue = i;
            i--;
        }
        return l_returnValue;
    }

    private class SolutionNode {
        private Solution c_solution;
        private boolean c_isDeveloped;

        SolutionNode(Solution p_solution) {
            c_isDeveloped = false;
            c_solution = p_solution;
        }

        Solution getSolution() {
            return c_solution;
        }


        boolean isDeveloped() {
            return c_isDeveloped;
        }

        void setDeveloped() {
            c_isDeveloped = true;
        }


    }
}
}