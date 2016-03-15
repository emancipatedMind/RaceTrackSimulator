﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceTrack_Simulator {
    class Guy {

        private Label guyInfo; // My label.
        private Label bettingSlipView; // Info label.
        private Bet bettingSlip; // An instance of Bet that has his bet.
        private int cash; // On hand cash.
        private bool isSlipFilledOut = false; // Is the slip filled out for next bet?

        public string Name { get; private set; } // Name property.
        public bool IsSlipFilledOut { get { return isSlipFilledOut; } } // Reports slip is filled out.
        public int Cash { get { return cash; } } // Allows wallet to be checked.

        public Guy(string name, int cash, Label guyInfo, Label bettingSlipView) {
            // Initialize the things needed, and report cash.
            Name = name;
            this.cash = cash;
            this.guyInfo = guyInfo;
            this.bettingSlipView = bettingSlipView;
            this.bettingSlip = new Bet(this);
            UpdateCashView();
        }

        public void ClearBettingSlip() {
            // Erase betting slip.
            isSlipFilledOut = false;
            bettingSlip.ClearSlip();
            if (guyInfo != null) guyInfo.Text = bettingSlip.ReadSlip();
        }

        public bool PlaceBet(int betAmount, int lane) {
            // Place a new bet and store it in my bet field.
            // Return true if the guy had enough money to bet, and 
            // bet exceeds minimum amount.
            if (betAmount > cash) return false;
            isSlipFilledOut = bettingSlip.FillOutSlip(betAmount, lane);
            if (guyInfo != null) guyInfo.Text = bettingSlip.ReadSlip();
            return isSlipFilledOut;
        }

        public void RedeemTicket(int winnersLane) {
            // Ask my bet to pay out, clear my bet, and update my labels.
            cash += bettingSlip.PayOut(winnersLane);
            ClearBettingSlip();
            UpdateCashView();
        }

        private void UpdateCashView() {
            // Update cash.
            bettingSlipView.Text = Name + " has " + cash + " bucks.";
        }

    }
}
