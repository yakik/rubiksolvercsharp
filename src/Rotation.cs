using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRubikSolver
{

public class Rotation {

    private Face c_face;
    private Direction c_direction;
    public Rotation() {
    }


    public Rotation(Face p_face, Direction p_direction) {
        c_face = p_face;
        c_direction = p_direction;
    }



    public Rotation(int p_value) {
        if (p_value > 5) {
            c_direction = DirectionFactory.getDirectionByInt(1);
            c_face = FaceFactory.getFaceByInt(p_value - 6);
        } else {
            c_direction = DirectionFactory.getDirectionByInt(0);
            c_face = FaceFactory.getFaceByInt(p_value);
        }
    }

    public void writeToFile(RubikFileWriter p_write){
        String l_toWrite = String.Format(" ({0},{1})",c_face.getInt(),c_direction.getInt());
        p_write.write(l_toWrite);
    }

    public bool readFromFile(RubikFileReader p_reader) {
        int l_int;
        l_int = p_reader.read();
        while ((l_int == ' ') || (l_int == 10))
            l_int = p_reader.read();
        if ((l_int == '\n') || (l_int == -1 /*EOF*/) || (l_int != '('))
            return false;
        else {

            c_face = FaceFactory.getFaceByInt((int)Char.GetNumericValue((char)(p_reader.read())));
            p_reader.read();
            c_direction = DirectionFactory.getDirectionByInt((int)Char.GetNumericValue((char)(p_reader.read())));
            p_reader.read();
            return true;
        }
    }


    public int getValue() {
        return (c_face.getInt() + c_direction.getInt() * 6);
    }

    public Face getFace() {
        return c_face;
    }

    public Direction getDirection() {
        return c_direction;
    }

    public void print() {
        Console.Write("({0},{1})", c_face.getChar(), c_direction.getString());
    }

    public Rotation getReverse() {
        return new Rotation(c_face, c_direction.getOpposite());
    }

    public bool equals(
            Rotation p_rotation)

    {
        return ((c_face == p_rotation.c_face) &&
                (c_direction == p_rotation.c_direction));
    }

    
   
}
}
