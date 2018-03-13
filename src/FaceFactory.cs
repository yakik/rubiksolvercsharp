using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRubikSolver
{

public class FaceFactory {
    public static Face getFaceByInt(int intValue) {
        switch (intValue) {
            case 3:
                return Face.L;
            case 2:
                return Face.R;
            case 0:
                return Face.U;
            case 1:
                return Face.D;
            case 4:
                return Face.F;
            case 5:
                return Face.B;
            default:
                return Face.U;
        }
    }
}
}
