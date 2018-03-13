using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRubikSolver
{

public class Position {

    private Face g_faceOrder[][] = {
            {Face.F, Face.L, Face.B, Face.R}, {Face.R, Face.B, Face.L, Face.F
    }, {Face.U, Face.B, Face.D, Face.F
    }, {Face.U, Face.F, Face.D, Face.B
    }, {Face.U, Face.R, Face.D, Face.L
    }, {Face.U, Face.L, Face.D, Face.R
    }
    };
    private Face c_currentUp;
    private Face c_currentFront;

    Position(Face p_Up, Face p_Front) {
        c_currentUp = p_Up;
        c_currentFront = p_Front;
    }

    Position() {
        c_currentUp = Face.U;
        c_currentFront = Face.F;
    }

    String getString() {
        return String.format("%c, %c", c_currentUp.getIntOfChar(), c_currentFront.getIntOfChar());
    }

    void rotate(Rotation p_rotation) {
        Face l_temp;
        Face l_face = p_rotation.getFace();
        Direction l_direction = p_rotation.getDirection();
        if (l_face == Face.U)
            if (l_direction == Direction.CW)
                c_currentFront = getFace(Face.R);
            else
                c_currentFront = getFace(Face.L);
        else if (l_face == Face.R)
            if (l_direction == Direction.CW) {
                l_temp = c_currentFront;
                c_currentFront = getFace(Face.D);
                c_currentUp = l_temp;
            } else {
                l_temp = getFace(Face.B);
                c_currentFront = c_currentUp;
                c_currentUp = l_temp;
            }
        else if (l_face == Face.F)
            if (l_direction == Direction.CW)
                c_currentUp = getFace(Face.L);
            else
                c_currentUp = getFace(Face.R);
        else
            rotate(new Rotation(l_face.getOpposite(), l_direction.getOpposite()));

    }

public Position getCopy(){
        return new Position(c_currentUp,c_currentFront);
}
    Face getFace(Face p_viewpoint) {
        if (p_viewpoint == Face.U)
            return c_currentUp;
        else if (p_viewpoint == Face.D)
            return c_currentUp.getOpposite();
        else
            return getHorizonalFacebyVirtual(p_viewpoint);
    }


    Face getHorizonalFacebyVirtual(Face p_viewpoint) {
        int i = 0;

        while (g_faceOrder[c_currentUp.getInt()][i] != c_currentFront && i < 4)
            i++;
        switch (p_viewpoint) {
            case F:
                return g_faceOrder[c_currentUp.getInt()][i];

            case L:
                return g_faceOrder[c_currentUp.getInt()][(i + 1) % 4];

            case B:
                return g_faceOrder[c_currentUp.getInt()][(i + 2) % 4];

            case R:
                return g_faceOrder[c_currentUp.getInt()][(i + 3) % 4];

            default:
                return Face.U;

        }
    }

    boolean equals(Position p_position) {
        return ((c_currentUp == p_position.c_currentUp) &&
                (c_currentFront == p_position.c_currentFront));
    }

//	int operator !=(
//	Position p_position)
//
//	{
//		return !(equals(p_position));
//	}

}
}