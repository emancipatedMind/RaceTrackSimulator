using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack_Simulator {
    class Bet {

        // Minimum bet allowed by bet slip.
        static private int minimumBet = 5;
        static public int MinimumBet {
            get { return minimumBet; }
            set { minimumBet = value; }
        }

        private int amount; // The amount of cash that was bet.
        private int lane; // The number of the dog the bet is on.
        private Guy bettor; // The guy who placed the bet.

        public Bet(Guy bettor) {
            this.bettor = bettor;
        }

        public string ReadSlip() {
            // Return a string that says who placed the bet, how much
            // cash was bet, and which dog he bet on ("Joe bets 8 on
            // dog #4"). If the amount is zero, no bet was placed
            // ("Joe's slip is empty...").
            if (amount == 0) return bettor.Name + "'s slip is empty...";
            string description = bettor.Name + " has bet $" + amount + " on dog " + lane + ".";
            return description;
        } 

        public int PayOut(int winnersLane) {
            // The parameter is the winner of the race. If the dog won,
            // return the amount bet. Otherwise, return the negative of
            // the amount bet.
            if (winnersLane == lane) return amount;
            else return -1 * amount;
        }

        public bool FillOutSlip(int amount, int lane)  {
            // Fills out slip. If amount is lower than minimum bet allowed,
            // returns false.
            if (amount < minimumBet) return false;
            this.amount = amount;
            this.lane = lane;
            return true;
        }

        public void ClearSlip() {
            // Betting slip is cleared by setting amount, and lane to 0.
            amount = 0;
            lane = 0;
        }
    }
}
