using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceTrack_Simulator {
    public partial class Form1 : Form {

        Random randomizer;
        List<Greyhound> racingDogs;
        Dictionary<string, Guy> guys;
        Guy bettorAtWindow;

        public Form1() {
            InitializeComponent();

            randomizer = new Random();
            racingDogs =  new List<Greyhound> {
                new Greyhound(dog0, randomizer),
                new Greyhound(dog1, randomizer),
                new Greyhound(dog2, randomizer),
                new Greyhound(dog3, randomizer),
            };
            guys = new Dictionary<string, Guy> {
                { "Joe", new Guy("Joe", 50, joeBetLabel, joeInfo) },
                { "Bob", new Guy("Bob", 75, bobBetLabel, bobInfo) },
                { "Al", new Guy("Al", 45, alBetLabel, alInfo) },
            };

            placeBetButton.Visible = false;
            removeBetButton.Visible = false;
        }

        private void raceTimer_Tick(object sender, EventArgs e) {
            // At an interval, have each dog take a step, and then determine if that
            // dog crossed the finish line. Once any dog has crossed the finish line, the winner
            // is declared. If no dog crossed the finish line, restart timer.
            raceTimer.Enabled = false;
            bool finishLineHasBeenCrossed = false;

            foreach(Greyhound greyhound in racingDogs) {
                if (greyhound.Run()) finishLineHasBeenCrossed = true;
            }

            if (finishLineHasBeenCrossed) { 
                DeclareWinner();
                return;
            }

            raceTimer.Enabled = true;
        }

        private void DeclareWinner() {
            // Determine winner, and let the crowd know! If there's a close finish, we'll let the crowd know who the dogs were 
            // before reviewing the footage, and determining who the winning dog was.
            List<int> winningDogLanes = new List<int>();
            int winningDogLane;
            string tieBreakerMessage = "";

            for (int i = 0; i < racingDogs.Count; i++) {
                int lane = i + 1;
                if (racingDogs[i].CrossedFinishLine) winningDogLanes.Add(lane);
            }

            if (winningDogLanes.Count != 1) {
                winningDogLane = winningDogLanes[randomizer.Next(winningDogLanes.Count)];
                tieBreakerMessage = "There was a very close finish, ladies and gentlemen! A truly exciting race! Dogs in lanes ";
                for (int i = 0; i < winningDogLanes.Count; i++) {
                    int j = i + 1;
                    if (j == winningDogLanes.Count) tieBreakerMessage += "& ";
                    tieBreakerMessage += winningDogLanes[i]; 
                    if (j != winningDogLanes.Count) tieBreakerMessage += ", ";
                } 
                tieBreakerMessage += " seemed to finish at almost the same moment!  We have reviewed the footage and have your winner! ";
            }
            else winningDogLane = winningDogLanes[0];

            MessageBox.Show(tieBreakerMessage + "Dog in lane " + winningDogLane + " has won the race!", "The announcer says...");

            // Now that a winner has been determined, pay out bets.
            PayOutBets(winningDogLane); 

            // Re-open betting window.
            raceButton.Visible = true;
            selectBettor.Text = "Select Bettor";
        }

        private void PayOutBets(int winningDogLane) {
            // Each bettor's ticket is checked. If the bettor was correct, the amount of the bet is paid out.
            // If the bettor was incorrect, then he must pay up.
            foreach (Guy guy in guys.Values) {
                guy.Collect(winningDogLane);
            }
        }

        private void raceButton_Click(object sender, EventArgs e) {
            // Place dogs at starting position, close betting window, and let the race begin!
            foreach(Greyhound greyhound in racingDogs) {
                greyhound.TakeStartingPosition();
            }
            raceTimer.Enabled = true;
            raceButton.Visible = false;
            placeBetButton.Visible = false;
            removeBetButton.Visible = false;
            selectBettor.Text = "Window Closed";
        }

        private void placeBetButton_Click(object sender, EventArgs e) {
            if (selectDog.Text == "Select Dog") {
                MessageBox.Show("Sir, please select a dog...", "The window attendant says...");
                return;
            }
            int lane = selectDog.SelectedIndex + 1;
            int betAmount = (int) this.betAmount.Value;
            if (bettorAtWindow.PlaceBet(betAmount, lane)) removeBetButton.Visible = true;
        }

        private void selectBettor_SelectedIndexChanged(object sender, EventArgs e) {
            bettorAtWindow = guys[selectBettor.Text];
            if (bettorAtWindow.IsSlipFilledOut) removeBetButton.Visible = true;
            else removeBetButton.Visible = false;
            placeBetButton.Visible = true;
        }

        private void removeBetButton_Click(object sender, EventArgs e) {
            bettorAtWindow.ClearBettingSlip();
            removeBetButton.Visible = false;
        }
    }
}
