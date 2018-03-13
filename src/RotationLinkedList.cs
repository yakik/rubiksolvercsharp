using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRubikSolver
{


//import java.io.IOException;

public class RotationLinkedList {

    private ArrayList<Rotation> c_array = new ArrayList<Rotation>();

    RotationLinkedList() {
        c_array.clear();
    }


    private  RotationLinkedList(ArrayList<Rotation> p_arrayList) {
        c_array = p_arrayList;

    }

    void print() {
        ListIterator<Rotation> l_itr = null;
        l_itr=c_array.listIterator();
         while(l_itr.hasNext())
            l_itr.next().print();
        Console.Write("\n");
    }

    void addRotation(Rotation p_rotation) {
        c_array.add(p_rotation);
    }

    void removeRotation() {
        c_array.remove(c_array.size()-1);
    }

    boolean isRedundant(Rotation p_rotation) {
        boolean l_returnValue = false;

        Face l_lastFace;
        Direction l_lastDirection;
        if (c_array.size() > 0) {
            l_lastFace = c_array.get(c_array.size()-1).getFace();
            l_lastDirection = c_array.get(c_array.size()-1).getDirection();
            // new rotation is opposite to previous
            if (c_array.get(c_array.size()-1).getReverse().equals(p_rotation))
                l_returnValue = true;
            // previous face was opposite and previous face greater then current face
            if ((p_rotation.getFace() == l_lastFace.getOpposite()) && (l_lastFace.getInt() > p_rotation.getFace().getInt()))
                l_returnValue = true;
            // two clockwise rotation of same face
            if ((p_rotation.getFace() == l_lastFace) && (l_lastDirection == Direction.CW) &&
                    (p_rotation.getDirection() == Direction.CW))
                l_returnValue = true;
            //no three counter clockwise rotations
            if (c_array.size()>1) {
                if ((p_rotation.getFace() == l_lastFace) && (l_lastDirection == Direction.CCW) &&
                        (p_rotation.getDirection() == Direction.CCW) &&
                        (c_array.get(c_array.size()-2).getFace() == l_lastFace) && (l_lastDirection == Direction.CCW) &&
                        (c_array.get(c_array.size()-2).getDirection() == Direction.CCW))
                    l_returnValue = true;
            }
        } else
            l_returnValue = false;
        return l_returnValue;

    }

    void writeToFile(RubikFileWriter p_writer){
        ListIterator<Rotation> l_itr = null;
        l_itr=c_array.listIterator();
        while(l_itr.hasNext())
            l_itr.next().writeToFile(p_writer);
        p_writer.write("\n");


    }
    boolean readFromFile(RubikFileReader p_reader) {
        Rotation l_rotation = new Rotation();

        c_array.clear();
        while (l_rotation.readFromFile(p_reader))
            c_array.add((new Rotation(l_rotation.getFace(),l_rotation.getDirection())));
        return !(c_array.size()==0);
    }

    RotationLinkedList getSubRotationLinkedList() {
        return new RotationLinkedList(new ArrayList<>(c_array.subList(1, c_array.size())));
    }

    int size(){
        return c_array.size();
    }

    Rotation getFirstRotation() {
        return c_array.get(0);
    }
Rotation get(int p_index){
        return c_array.get(p_index);
}
    boolean isNotEmpty() {

        return (c_array.size()>0);
    }

    RotationLinkedList getCopy() {
        RotationLinkedList l_rotationLinkedList = new RotationLinkedList();
        ListIterator<Rotation> l_itr=c_array.listIterator();

        while(l_itr.hasNext())
            l_rotationLinkedList.addRotation(l_itr.next());

        return l_rotationLinkedList;
    }

    void applyToRubik(Rubik p_rubik) {
        ListIterator<Rotation> l_itr=c_array.listIterator();

        while(l_itr.hasNext())

            p_rubik.rotateFace(l_itr.next());

    }
}
}

