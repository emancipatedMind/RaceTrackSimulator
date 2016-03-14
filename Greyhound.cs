using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceTrack_Simulator {
    class Greyhound {
        public int StartingPosition; // Where myPictureBox starts.
        public int RacetrackLength; // How long the racetrack is.
        public PictureBox MyPictureBox; // PictureBox object.
        public int Location = 0; // My location on the racetrack.
        public Random Randomizer; // An instance of Random.

        public bool Run() {
            // Move forward either 1, 2, 3, or 4 spaces at random.
            // Update the position of myPictureBox on the form like this:
            //    MyPictureBox.Left = StartingPosition + Location;
            // Return true if I won the race.
            return false;
        }

        public void TakeStartingPosition() {
            // Reset my location to 0, and myPictureBox to starting position.
        }

    }
}
