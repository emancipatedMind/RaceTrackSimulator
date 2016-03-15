using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceTrack_Simulator {
    class Greyhound {
        static private int racetrackLength = 895; // How long the racetrack is.
        static private int startingPosition = 85; // Where myPictureBox starts.
        static private int endingPosition = 980; // Ending of racetrack.

        // If racetrack length is changed, new race endpoint must be established.
        static public int RacetrackLength {
            get { return racetrackLength; }
            set {
                racetrackLength = value;
                endingPosition = startingPosition + racetrackLength;
            }
        }

        // If starting position is changed, new race endpoint must be established.
        static public int StartingPosition {
            get { return startingPosition; }
            set {
                startingPosition = value;
                endingPosition = startingPosition + racetrackLength;
            }
        }

        private PictureBox myPictureBox; // PictureBox object.
        private Random randomizer; // An instance of Random.
        private bool crossedFinishLine = false; // Has dog crossed finish line?

        public bool CrossedFinishLine { get { return crossedFinishLine; } } // Did dog cross finish line with last step?

        public Greyhound(PictureBox myPictureBox, Random randomizer) {
            this.myPictureBox = myPictureBox;
            this.randomizer = randomizer;
        }

        public bool Run() {
            // Move forward either 5, 10, 15, or 20 spaces at random.
            // Return true if finish line crossed.
            int nextStep = randomizer.Next(1, 4) * 5;
            myPictureBox.Left += nextStep;
            crossedFinishLine = myPictureBox.Left >= Greyhound.endingPosition;
            return crossedFinishLine;
        }

        public void TakeStartingPosition() {
            // Reset location by setting myPictureBox.Left to starting position.
            myPictureBox.Left = startingPosition;
        }
    }
}