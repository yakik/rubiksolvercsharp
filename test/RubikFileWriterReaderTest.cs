using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpRubikSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpRubikSolver
{


    [TestClass]
    class RubikFileWriterReaderTest {

    [TestMethod]
    void write() {
        RubikFileWriter myWriter = new RubikFileWriter("Test.txt");
       
        myWriter.write("testWrite");
        myWriter.close();
        RubikFileReader myReader = new RubikFileReader(("Test.txt"));
        int l_int;
        String l_readString = "";
        while ((l_int = myReader.read())!=-1)
            l_readString+=(char)l_int;
        Assert.Equals("testWrite",l_readString);



    }
}
}