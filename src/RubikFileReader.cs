using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRubikSolver
{

import java.io.FileReader;
import java.io.IOException;

public class RubikFileReader {
    FileReader c_fileReader;
    boolean c_fileIsOK;

    RubikFileReader() {
    }

    RubikFileReader(String p_fileLocation) {
        try {
            c_fileReader = new FileReader(p_fileLocation);
            c_fileIsOK = true;
        } catch (IOException ex) {
            c_fileIsOK = false;
        }
    }

    int read() {
        if (!c_fileIsOK)
            return -1;
        else
            try {
                return c_fileReader.read();
            } catch (IOException ex) {
                return -1;
            }

    }

    void close(){
        try {
        c_fileReader.close();
        } catch (IOException ex) {}
    }
}
}

