using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpRubikSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpRubikSolverUTests
{

    public class forTestRubikFileReader : RubikFileReader {

    private String c_stringToReturn;
    private int indexRead = 0;

    public forTestRubikFileReader(String p_returnString) {
        c_stringToReturn = p_returnString;
    }


    public override int read() {
        if (indexRead < c_stringToReturn.Length)
            return c_stringToReturn[indexRead++];
        else
            return -1;
    }

}
}
