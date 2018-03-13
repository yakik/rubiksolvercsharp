using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRubikSolver
{

public class Solution {


    private Permutation c_permutation;
    private RotationLinkedList c_rotationLinkedList;
    private Solution c_prevSolution;


        public Solution(RotationLinkedList p_rotationLinkedList, Permutation p_permutation, Solution p_prevSolution) {
        c_rotationLinkedList = p_rotationLinkedList.getCopy();
        c_permutation = p_permutation.getCopy();
        c_prevSolution = p_prevSolution;
    }

        public Permutation getPermutation() {
        return c_permutation;
    }

        public RotationLinkedList getRotationLinkedList() {
        return c_rotationLinkedList;
    }

        public Solution getPrevSolution() {
        return c_prevSolution;
    }

        public bool equals(Solution p_solution)

    {
        return (c_permutation == (p_solution.getPermutation()));
    }

        public void print() {
        if (c_prevSolution != null)
            c_prevSolution.print();
        c_rotationLinkedList.print();
        Console.Write("\n");
    }

        public void applyToRubik(Rubik p_rubik) {
        if (c_prevSolution != null)
            c_prevSolution.applyToRubik(p_rubik);
        c_rotationLinkedList.applyToRubik(p_rubik);

    }
}
}
