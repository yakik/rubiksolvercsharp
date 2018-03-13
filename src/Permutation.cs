using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpRubikSolver
{
    

public class Permutation {
    CubeCubicle[] c_Cube_cubicle = new CubeCubicle[20];
    short c_cubicles;

        public Permutation() {
        c_cubicles = -1;
    }

        public CubeCubicle getCubeCubicale(Location p_location){
             for (int i=0;i<12;i++)
                if (c_Cube_cubicle[i]!=null)
                    if (c_Cube_cubicle[i].C_locationInCube.equals(p_location))
                        return c_Cube_cubicle[i];
             return null;

        }

        public CubeCubicle getCubicleData(int p_index) {
        return c_Cube_cubicle[p_index];
    }

        public void addCubicleData(CubeCubicle p_cubicleData) {
        c_cubicles++;
        c_Cube_cubicle[c_cubicles] = p_cubicleData;
    }

        //    bool isPartRubik(Rubik p_rubik) {
        //        int i;
        //        for (i = 0; i < c_cubicles; i++)
        //            if ((p_rubik.getCubicleCubieLocation(c_Cube_cubicle[i].getLocation()) !=
        //                    c_Cube_cubicle[i].currentCubieOriginalLocation()) ||
        //                    (p_rubik.getPositionOfCubicleOfCubiclePlace(c_Cube_cubicle[i].getLocation()) !=
        //                            c_Cube_cubicle[i].getCubiePosition()))
        //                return false;
        //        return true;
        //    }

        public int getDifferece(Rubik p_rubik) {
        int i, l_counter = 0;
        for (i = 0; i < c_cubicles; i++) {
            if ((p_rubik.getOriginalLocationOfCurrentCubicleInLocation(c_Cube_cubicle[i].getLocation()) !=
                    c_Cube_cubicle[i].currentCubieOriginalLocation()) ||
                    (p_rubik.getPositionOfCubicleOfCubiclePlace(c_Cube_cubicle[i].getLocation()) !=
                            c_Cube_cubicle[i].getCubiePosition()))
                l_counter++;
        }
        return l_counter;
    }

        public void print() {
        int i;
        Console.Write("\nnumber of cubicles is %d\n", c_cubicles + 1);
        for (i = 0; i <= c_cubicles; i++) {
            Console.Write("CubiclePlace Location:%s", c_Cube_cubicle[i].getLocation().getString());
            Console.Write(" Cubicle Location:%s", c_Cube_cubicle[i].currentCubieOriginalLocation().getString());
            Console.Write(" Cubicle Position:%s\n", c_Cube_cubicle[i].getCubiePosition().getString());
        }
    }

        public void load(StreamReader p_reader) {
        // reading order is: 12 edges first, then 8 corners
        // reading order: cubicle, current cubie location, current cubie position
        int i;
        Location l_cubicleLocation, l_currCubicleLocation;
        Position l_position;
        FaceFactory l_faceFactory = new FaceFactory();
        try {
            for (i = 0; i < 12; i++) {

                Face l_cubicleFace0, l_cubicleFace1;
                Face l_currCubicleFace0, l_currCubicleFace1;
                Face l_up, l_front;

                l_cubicleFace0 = FaceFactory.getFaceByInt(p_reader.Read());
                l_cubicleFace1 = FaceFactory.getFaceByInt(p_reader.Read());
                p_reader.Read();
                l_currCubicleFace0 = FaceFactory.getFaceByInt(p_reader.Read());
                l_currCubicleFace1 = FaceFactory.getFaceByInt(p_reader.Read());
                p_reader.Read();
                l_up = FaceFactory.getFaceByInt(p_reader.Read());
                l_front = FaceFactory.getFaceByInt(p_reader.Read());
                p_reader.Read();
                l_cubicleLocation = new Location(l_cubicleFace0, l_cubicleFace1);
                l_currCubicleLocation = new Location(l_currCubicleFace0, l_currCubicleFace1);
                l_position = new Position(l_up, l_front);
                addCubicleData(new CubeCubicle(l_cubicleLocation, l_currCubicleLocation, l_position));
            }
            for (i = 0; i < 8; i++) {
                Face l_cubicleFace0, l_cubicleFace1, l_cubicleFace2;
                Face l_currCubicleFace0, l_currCubicleFace1, l_currCubicleFace2;
                Face l_up, l_front;

                l_cubicleFace0 = FaceFactory.getFaceByInt(p_reader.Read());
                l_cubicleFace1 = FaceFactory.getFaceByInt(p_reader.Read());
                l_cubicleFace2 = FaceFactory.getFaceByInt(p_reader.Read());
                p_reader.Read();
                l_currCubicleFace0 = FaceFactory.getFaceByInt(p_reader.Read());
                l_currCubicleFace1 = FaceFactory.getFaceByInt(p_reader.Read());
                l_currCubicleFace2 = FaceFactory.getFaceByInt(p_reader.Read());
                p_reader.Read();
                l_up = FaceFactory.getFaceByInt(p_reader.Read());
                l_front = FaceFactory.getFaceByInt(p_reader.Read());
                p_reader.Read();
                l_cubicleLocation = new Location(l_cubicleFace0, l_cubicleFace1, l_cubicleFace2);
                l_currCubicleLocation = new Location(l_currCubicleFace0, l_currCubicleFace1, l_currCubicleFace2);
                l_position = new Position(l_up, l_front);
                addCubicleData(new CubeCubicle(l_cubicleLocation, l_currCubicleLocation, l_position));
            }
        } catch (IOException ex) {
                Console.WriteLine(ex.Message);
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

        public bool equals( Permutation p_permutation) {
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