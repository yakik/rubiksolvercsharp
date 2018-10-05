using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRubikSolver {



    public class RotationTree {
        ArrayList c_array = new ArrayList();
        public RotationTree() {
        }

        public void addRotationLinkedList(RotationLinkedList p_list) {

            c_array.Add(p_list.getCopy());
        }

        public int getSize() {
            return c_array.Count;
        }

        public RotationLinkedList getRotationLinkedList(int p_index) {
            return c_array[p_index] as RotationLinkedList;
        }
    }
}
