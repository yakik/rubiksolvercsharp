using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpRubikSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpRubikSolverTester
{


    [TestClass]
    class RubikFileWriterReaderTest {

    [TestMethod]
    void write() {
        RubikFileWriter myWriter = new RubikFileWriter("Test.txt");
        long myNano = System.nanoTime();
        String myNanoString = String.format("%d",myNano);
        myWriter.write(myNanoString);
        myWriter.close();
        RubikFileReader myReader = new RubikFileReader(("Test.txt"));
        int l_int;
        String l_readString = "";
        while ((l_int = myReader.read())!=-1)
            l_readString+=(char)l_int;
        assertEquals(myNanoString,l_readString);



    }
}
}