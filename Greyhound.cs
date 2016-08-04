using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceTrack_Simulator {
    class Greyhound {
        static private int racetrackLength; // How long the racetrack is.
        static private int startingPosition; // Where myPictureBox starts.
        static private int endingPosition; // Ending of racetrack.

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

        static Greyhound() {
            racetrackLength = 895;
            startingPosition = 85;
            endingPosition = 980;
        }

        private PictureBox myPictureBox; // PictureBox object.
        private Random randomizer; // An instance of Random.

        public bool CrossedFinishLine { get; private set; } = false; // Did dog cross finish line with last step?

        public Greyhound(PictureBox myPictureBox, Random randomizer) {
            this.myPictureBox = myPictureBox;
            this.randomizer = randomizer;
        }

        public bool Run() {
            // Move forward either 5, 10, 15, or 20 spaces at random.
            // Return true if finish line crossed.
            int nextStep = randomizer.Next(1, 4) * 5;
            myPictureBox.Left += nextStep;
            CrossedFinishLine = myPictureBox.Left >= Greyhound.endingPosition;
            return CrossedFinishLine;
        }

        public void TakeStartingPosition() {
            // Reset location by setting myPictureBox.Left to starting position.
            myPictureBox.Left = startingPosition;
        }
    }
}