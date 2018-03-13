using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRubikSolver
{

import java.util.ArrayList;

public class RotationTree {
    ArrayList<RotationLinkedList> c_array = new ArrayList<RotationLinkedList>();
    RotationTree (){
    }

    void addRotationLinkedList(RotationLinkedList p_list){

        c_array.add(p_list.getCopy());
    }

    int getSize(){
        return c_array.size();
    }

    RotationLinkedList getRotationLinkedList(int p_index){
        return c_array.get(p_index);
    }
}
}
