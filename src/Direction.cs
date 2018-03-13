using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRubikSolver
{

    public enum Direction
    {
        CW, CCW
    }

    static class DirectionMethods
    {



        public static String getString(this Direction dir)
        {              // Getter
            switch (dir)
            {
                case Direction.CW:
                    return "CW";
                case Direction.CCW:
                    return "CCW";
                default:
                    return "ERROR";
            }

        }

        public static int getInt(this Direction dir)
        {              // Getter
            if (dir == Direction.CW)
                return 0;
            else
                return 1;

        }

        public static Direction getOpposite(this Direction dir)
        {
            if (dir == Direction.CW)
                return Direction.CCW;
            else
                return Direction.CW;
        }
    }
}

