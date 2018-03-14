using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpRubikSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpRubikSolverUTests
{



public class AssistAssertRubik {
    static void myAssertEdge(Face p_firstFace, Face p_secondFace, Rubik p_rubik){
        Assert.AreEqual(true, (new Location(p_firstFace, p_secondFace))
                        .equals(p_rubik.getOriginalLocationOfCurrentCubicleInLocation(new Location(p_firstFace, p_secondFace)))
                ,"Problem with edge "+Char.ToString(p_firstFace.getChar())
                        +" / " +Char.ToString(p_secondFace.getChar()));
    }

    static void myAssertCorner(Face p_firstFace, Face p_secondFace, Face p_thirdFace, Rubik p_rubik){
        Assert.AreEqual(true, (new Location(p_firstFace, p_secondFace, p_thirdFace))
                        .equals(p_rubik.getOriginalLocationOfCurrentCubicleInLocation(new Location(p_firstFace, p_secondFace, p_thirdFace)))
                ,"Problem with corner "+Char.ToString(p_firstFace.getChar())
                        +" / " +Char.ToString(p_secondFace.getChar())
                        +" / " +Char.ToString(p_thirdFace.getChar()));
    }

    public static void checkEntireCube(Rubik p_rubik){
        myAssertEdge(Face.U, Face.L, p_rubik);
        myAssertEdge(Face.U, Face.R, p_rubik);
        myAssertEdge(Face.U, Face.F, p_rubik);
        myAssertEdge(Face.U, Face.B, p_rubik);

        myAssertEdge(Face.D, Face.L, p_rubik);
        myAssertEdge(Face.D, Face.R, p_rubik);
        myAssertEdge(Face.D, Face.F, p_rubik);
        myAssertEdge(Face.D, Face.B, p_rubik);

        myAssertEdge(Face.F, Face.L, p_rubik);
        myAssertEdge(Face.F, Face.R, p_rubik);
        myAssertEdge(Face.B, Face.L, p_rubik);
        myAssertEdge(Face.B, Face.R, p_rubik);

        myAssertCorner(Face.D, Face.L, Face.B, p_rubik);
        myAssertCorner(Face.D, Face.L, Face.F, p_rubik);
        myAssertCorner(Face.D, Face.R, Face.B, p_rubik);
        myAssertCorner(Face.D, Face.R, Face.F, p_rubik);

        myAssertCorner(Face.U, Face.L, Face.B, p_rubik);
        myAssertCorner(Face.U, Face.L, Face.F, p_rubik);
        myAssertCorner(Face.U, Face.R, Face.B, p_rubik);
        myAssertCorner(Face.U, Face.R, Face.F, p_rubik);
    }

}
}
