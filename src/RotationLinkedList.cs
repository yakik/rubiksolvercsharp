using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRubikSolver {


    public class RotationLinkedList {

        private ArrayList c_array = new ArrayList();

        public RotationLinkedList() {
            c_array.Clear();
        }


        private RotationLinkedList(ArrayList p_arrayList) {
            c_array = p_arrayList;

        }

        public void print() {

            foreach (var l_itr in c_array)

                (l_itr as Rotation).print();
            Console.Write("\n");
        }

        public void addRotation(Rotation p_rotation) {
            c_array.Add(p_rotation);
        }

        public void removeRotation() {
            c_array.RemoveAt(c_array.Count - 1);
        }

        public bool isRedundant(Rotation p_rotation) {
            bool l_returnValue = false;

            Face l_lastFace;
            Direction l_lastDirection;
            if (c_array.Count > 0) {
                l_lastFace = (c_array[c_array.Count - 1] as Rotation).getFace();
                l_lastDirection = (c_array[c_array.Count - 1] as Rotation).getDirection();
                // new rotation is opposite to previous
                if ((c_array[c_array.Count - 1] as Rotation).getReverse().equals(p_rotation))
                    l_returnValue = true;
                // previous face was opposite and previous face greater then current face
                if ((p_rotation.getFace() == l_lastFace.getOpposite()) && (l_lastFace.getInt() > p_rotation.getFace().getInt()))
                    l_returnValue = true;
                // two clockwise rotation of same face
                if ((p_rotation.getFace() == l_lastFace) && (l_lastDirection == Direction.CW) &&
                        (p_rotation.getDirection() == Direction.CW))
                    l_returnValue = true;
                //no three counter clockwise rotations
                if (c_array.Count > 1) {
                    if ((p_rotation.getFace() == l_lastFace) && (l_lastDirection == Direction.CCW) &&
                            (p_rotation.getDirection() == Direction.CCW) &&
                            ((c_array[c_array.Count - 2] as Rotation).getFace() == l_lastFace) && (l_lastDirection == Direction.CCW) &&
                            ((c_array[c_array.Count - 2] as Rotation).getDirection() == Direction.CCW))
                        l_returnValue = true;
                }
            } else
                l_returnValue = false;
            return l_returnValue;

        }

        public void writeToFile(RubikFileWriter p_writer) {
            foreach (var l_itr in c_array)

                (l_itr as Rotation).writeToFile(p_writer);

            p_writer.write("\n");


        }
        public bool readFromFile(RubikFileReader p_reader) {
            Rotation l_rotation = new Rotation();

            c_array.Clear();
            while (l_rotation.readFromFile(p_reader))
                c_array.Add((new Rotation(l_rotation.getFace(), l_rotation.getDirection())));
            return !(c_array.Count == 0);
        }

        public RotationLinkedList getSubRotationLinkedList() {
            return new RotationLinkedList(new ArrayList(c_array.GetRange(1, c_array.Count)));
        }

        public int size() {
            return c_array.Count;
        }

        public Rotation getFirstRotation() {
            return c_array[0] as Rotation;
        }
        public Rotation get(int p_index) {
            return c_array[p_index] as Rotation;
        }
        public bool isNotEmpty() {

            return (c_array.Count > 0);
        }

        public RotationLinkedList getCopy() {
            RotationLinkedList l_rotationLinkedList = new RotationLinkedList();
            foreach (var l_itr in c_array)

                l_rotationLinkedList.addRotation(l_itr as Rotation);

            return l_rotationLinkedList;
        }

        public void applyToRubik(Rubik p_rubik) {

            foreach (var l_itr in c_array)

                p_rubik.rotateFace(l_itr as Rotation);

        }
    }
}

