using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRubikSolver
{

public class Location {
    bool c_isEdge;
    private Face c_face0;
    private Face c_face1;
    private Face c_face2;

    public Location() {
    }

    public bool containsFace(Face p_face) {
        if (p_face == c_face0 || p_face == c_face1 || (!c_isEdge && (p_face == c_face2)))
            return true;
        else
            return false;
    }

    public Location getCopy() {
        if (isEdge())
            return new Location(c_face0, c_face1);
        else
            return new Location(c_face0, c_face1, c_face2);
    }

    public Location(Face p_face0, Face p_face1, Face p_face2) {
        Face l_tmp;
        c_isEdge = false;
        c_face0 = p_face0;
        c_face1 = p_face1;
        c_face2 = p_face2;
// bubble sort to keep order within faces		
        if (c_face0.getInt() > c_face1.getInt()) {
            l_tmp = c_face1;
            c_face1 = c_face0;
            c_face0 = l_tmp;
        }
        if (c_face1.getInt() > c_face2.getInt()) {
            l_tmp = c_face2;
            c_face2 = c_face1;
            c_face1 = l_tmp;
        }
        if (c_face0.getInt() > c_face1.getInt()) {
            l_tmp = c_face1;
            c_face1 = c_face0;
            c_face0 = l_tmp;
        }

    }

    public Location(Face p_face0, Face p_face1) {
        c_isEdge = true;
        //       c_face2 = Face.NOTDEFINED;
        c_face0 = p_face0;
        c_face1 = p_face1;
        if (p_face0.getInt() > p_face1.getInt()) {
            c_face1 = p_face0;
            c_face0 = p_face1;
        } else {
            c_face0 = p_face0;
            c_face1 = p_face1;
        }
    }

    public bool isEdge() {
        return c_isEdge;
    }

        public Face getFace0() {
        return c_face0;
    }

        public Face getFace1() {
        return c_face1;
    }

        public int getFloor() {
        if (this.equals(new Location(Face.U, Face.L, Face.F))) return 3;
        if (this.equals(new Location(Face.U, Face.L, Face.B))) return 3;
        if (this.equals(new Location(Face.U, Face.R, Face.F))) return 3;
        if (this.equals(new Location(Face.U, Face.R, Face.B))) return 3;
        if (this.equals(new Location(Face.D, Face.L, Face.F))) return 1;
        if (this.equals(new Location(Face.D, Face.L, Face.B))) return 1;
        if (this.equals(new Location(Face.D, Face.R, Face.F))) return 1;
        if (this.equals(new Location(Face.D, Face.R, Face.B))) return 1;

        if (this.equals(new Location(Face.U, Face.F))) return 3;
        if (this.equals(new Location(Face.U, Face.B))) return 3;
        if (this.equals(new Location(Face.U, Face.L))) return 3;
        if (this.equals(new Location(Face.U, Face.R))) return 3;

        if (this.equals(new Location(Face.F, Face.L))) return 2;
        if (this.equals(new Location(Face.F, Face.R))) return 2;
        if (this.equals(new Location(Face.B, Face.L))) return 2;
        if (this.equals(new Location(Face.B, Face.R))) return 2;

        if (this.equals(new Location(Face.D, Face.L))) return 1;
        if (this.equals(new Location(Face.D, Face.R))) return 1;
        if (this.equals(new Location(Face.F, Face.D))) return 1;
        if (this.equals(new Location(Face.B, Face.D))) return 1;
        return 0;
    }

        public Face getFace2() {
//        if (isEdge())
//            return Face.NOTDEFINED;
//        else
        return c_face2;
    }

        //	int getValue() {
        //		return (getFace0() * 1 + getFace1() * 6 + getFace2() * 36 + isEdge() * 216);
        //	}

        public bool equals(Location p_location) {
        return ((c_face0 == p_location.c_face0) &&
                (c_face1 == p_location.c_face1) &&
                (c_face2 == p_location.c_face2) &&
                (c_isEdge == p_location.c_isEdge));
    }


    public String getString() {
        if (c_isEdge)
            return String.Format("{0}, {1}", c_face0.getChar() , c_face1.getChar());
        else {
            return String.Format("{0}, {1}, {2}", c_face0.getChar(), c_face1.getChar(), c_face2.getChar());
        }
    }

}
}