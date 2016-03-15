using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceTrack_Simulator {
    class Guy {

        private Label myLabel; // My label.
        private Label infoLabel; // Info label.
        private Bet bettingSlip; // An instance of Bet that has his bet.
        private int cash; // On hand cash.
        private bool isSlipFilledOut = false;

        public string Name { get; private set; } // Name property.
        public bool IsSlipFilledOut { get { return isSlipFilledOut; } }

        public Guy(string name, int cash, Label label, Label infoLabel) {
            Name = name;
            this.cash = cash;
            myLabel = label;
            this.infoLabel = infoLabel;
            bettingSlip = new Bet(this); // An instance of Bet that has his bet.
            UpdateInfoLabel();
        }

        public void ClearBettingSlip() {
            isSlipFilledOut = false;
            bettingSlip.ClearSlip();
            myLabel.Text = bettingSlip.ReadSlip();
        }

        public bool PlaceBet(int betAmount, int lane) {
            // Place a new bet and store it in my bet field.
            // Return true if the guy had enough money to bet.
            if (betAmount > cash) return false;
            isSlipFilledOut = bettingSlip.FillOutSlip(betAmount, lane);
            myLabel.Text = bettingSlip.ReadSlip();
            return isSlipFilledOut;
        }

        public void Collect(int winnersLane) {
            // Ask my bet to pay out, clear my bet, and update my labels.
            cash += bettingSlip.PayOut(winnersLane);
            ClearBettingSlip();
            UpdateInfoLabel();
        }

        private void UpdateInfoLabel() {
            infoLabel.Text = Name + " has " + cash + " bucks.";
        }

    }
}
