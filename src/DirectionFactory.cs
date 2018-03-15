using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRubikSolver {

    public class DirectionFactory {
        public static Direction getDirectionByInt(int intValue) {
            switch (intValue) {
                case 0:
                    return Direction.CW;
                case 1:
                    return Direction.CCW;
                default:
                    return Direction.CW;
            }
        }
    }
}
