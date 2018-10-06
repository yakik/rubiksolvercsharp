using System;

namespace CSharpRubikSolver {


    public class Permutation {
        CubeCubicle[] c_Cube_cubicle = new CubeCubicle[20];
        short c_cubicles;

        public Permutation() {
            c_cubicles = -1;
        }

        public CubeCubicle getCubicleData(int p_index) {
            return c_Cube_cubicle[p_index];
        }

        public void addCubicleData(CubeCubicle p_cubicleData) {
            c_cubicles++;
            c_Cube_cubicle[c_cubicles] = p_cubicleData;
        }

        public void print() {
            int i;
            Console.Write("\nnumber of cubicles is {0}\n", c_cubicles + 1);
            for (i = 0; i <= c_cubicles; i++) {
                Console.Write("CubiclePlace Location:{0}", c_Cube_cubicle[i].getLocation().getString());
                Console.Write(" Cubicle Location:{0}", c_Cube_cubicle[i].currentCubieOriginalLocation().getString());
                Console.Write(" Cubicle Position:{0}\n", c_Cube_cubicle[i].getCubiePosition().getString());
            }
        }

        public int getValue(int p_highestFloor) {
            int i, l_value = 0;
            for (i = 0; i < 20; i++) {
                Location l_currLocation = c_Cube_cubicle[i].getLocation();
                if (l_currLocation.getFloor() <= p_highestFloor)
                    if (c_Cube_cubicle[i].getLocation().equals(c_Cube_cubicle[i].currentCubieOriginalLocation())
                            && (c_Cube_cubicle[i].getCubiePosition().equals(new Position(Face.U, Face.F)))
                            )
                        l_value += 2;

            }
            return l_value;
        }

        public Permutation getCopy() {
            Permutation l_permutation = new Permutation();
            int i;
            for (i = 0; i < 20; i++)
                l_permutation.addCubicleData(getCubicleData(i));
            return l_permutation;
        }

        public bool equals(Permutation p_permutation) {
            bool l_answer = true;
            int i;
            for (i = 0; i < 20; i++)
                if (!(getCubicleData(i).equals(p_permutation.getCubicleData(i))))
                    return false;
                else
                    l_answer = true;
            return l_answer;
        }
    }
}