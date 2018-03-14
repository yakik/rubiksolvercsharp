using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRubikSolver
{



public class RubikFileReader {
    StreamReader c_fileReader;
    bool c_fileIsOK;

        public RubikFileReader() {
    }

        public RubikFileReader(String p_fileLocation) {
        try {
            c_fileReader = new StreamReader(p_fileLocation);
            c_fileIsOK = true;
        } catch (IOException ex) {
                Console.WriteLine(ex.Message);
                c_fileIsOK = false;
        }
    }

        public virtual int read() {
        if (!c_fileIsOK)
            return -1;
        else
            try {
                return c_fileReader.Read();
            } catch (IOException ex) {
                    Console.WriteLine(ex.Message);
                    return -1;
            }

    }

        public void close(){
        try {
        c_fileReader.Close();
        } catch (IOException ex) { Console.WriteLine(ex.Message); }
    }
}
}

