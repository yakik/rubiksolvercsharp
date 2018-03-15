using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRubikSolver {

    public class CubeCubicle {

        Location c_locationInCube;
        Location c_currentCubieOriginalLocation;
        Position c_currentPosition;

        public Location C_locationInCube { get => c_locationInCube; set => c_locationInCube = value; }
        public Location C_currentCubieOriginalLocation { get => c_currentCubieOriginalLocation; set => c_currentCubieOriginalLocation = value; }
        public Position C_currentPosition { get => c_currentPosition; set => c_currentPosition = value; }

        public void rotateFrom(Rotation p_rotation, CubeCubicle p_source) {
            C_currentCubieOriginalLocation = p_source.getCurrentCubieOriginalLocation();
            C_currentPosition = p_source.getCubiePosition();
            C_currentPosition.rotate(p_rotation);
        }

        public CubeCubicle() {
        }

        public Location getCurrentCubieOriginalLocation() {
            return C_currentCubieOriginalLocation;
        }
        public CubeCubicle(Location p_location, Location p_cubieLocation, Position p_cubiePosition) {
            C_locationInCube = p_location;
            C_currentCubieOriginalLocation = p_cubieLocation;
            C_currentPosition = p_cubiePosition;
        }

        public Location getLocation() {
            return C_locationInCube;
        }

        public Location currentCubieOriginalLocation() {
            return C_currentCubieOriginalLocation;
        }

        public Position getCubiePosition() {
            return C_currentPosition;
        }

        public bool inPlaceAndPosition() {
            return (this.getLocation().equals(this.currentCubieOriginalLocation()))
                    && this.getCubiePosition().equals(new Position(Face.U, Face.F));
        }



        public bool equals(
            CubeCubicle p_cubicleData) {
            return (C_locationInCube.equals(p_cubicleData.C_locationInCube) &&
                    C_currentCubieOriginalLocation.equals(p_cubicleData.C_currentCubieOriginalLocation) &&
                    C_currentPosition.equals(p_cubicleData.C_currentPosition));
        }
    }
}