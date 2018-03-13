using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRubikSolver
{
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.FileWriter;

public class RubikFileWriter {

    BufferedWriter c_fileWriter;
    boolean c_fileIsOK;


    RubikFileWriter(String p_fileLocation) {
        try {
            c_fileWriter = new BufferedWriter(new FileWriter(p_fileLocation));
            c_fileIsOK = true;
        } catch (IOException ex) {
            c_fileIsOK = false;
        }
    }

    void write(String p_string) {
            try {
                c_fileWriter.write(p_string);
            } catch (IOException ex) {}

    }

    void close(){
        try {
            c_fileWriter.close();
        } catch (IOException ex) {}
    }
}
}
