using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRubikSolver
{

    public enum Face {
        U, D, R, L, F, B/*, NOTDEFINED('Z', 9)*/ //don't change this sequence, for Rubik's sake!

    }

  
     public static class FaceMethods
    {

        public static int getIntOfChar(this Face face) {              // Getter
            switch (face)
            {
                case Face.U:
                    return '0';
                case Face.D:
                    return '1';
                case Face.R:
                    return '2';
                case Face.L:
                    return '3';
                case Face.F:
                    return '4';
                case Face.B:
                    return '5';
                default:
                    return '9';
            }
        }

   public static  char getChar(this Face face)
        {
            switch (face)
            {
                case Face.U:
                    return '0';
                case Face.D:
                    return '1';
                case Face.R:
                    return '2';
                case Face.L:
                    return '3';
                case Face.F:
                    return '4';
                case Face.B:
                    return '5';
                default:
                    return '9';
            }
        }

    public static int getInt(this Face face) {              // Getter
            switch (face)
            {
                case Face.U:
                    return 0;
                case Face.D:
                    return 1;
                case Face.R:
                    return 2;
                case Face.L:
                    return 3;
                case Face.F:
                    return 4;
                case Face.B:
                    return 5;
                default:
                    return 9;
            }
        }

        public static Face getOpposite(this Face face) {
        switch (face) {
            case Face.L:
                return Face.R;
            case Face.R:
                return Face.L;
            case Face.U:
                return Face.D;
            case Face.D:
                return Face.U;
            case Face.F:
                return Face.B;
            case Face.B:
                return Face.F;
//            case NOTDEFINED:
//                return NOTDEFINED;
            default:
                return Face.U;
        }
    }
}
}

