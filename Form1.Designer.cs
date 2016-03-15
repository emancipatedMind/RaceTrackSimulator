namespace RaceTrack_Simulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dog0 = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bettingWindowBox = new System.Windows.Forms.GroupBox();
            this.removeBetButton = new System.Windows.Forms.Button();
            this.placeBetButton = new System.Windows.Forms.Button();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.selectDog = new System.Windows.Forms.ComboBox();
            this.selectBettor = new System.Windows.Forms.ComboBox();
            this.selectBettorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.raceButton = new System.Windows.Forms.Button();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.alInfo = new System.Windows.Forms.Label();
            this.bobInfo = new System.Windows.Forms.Label();
            this.joeInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.raceTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.bettingWindowBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1184, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dog0
            // 
            this.dog0.Image = ((System.Drawing.Image)(resources.GetObject("dog0.Image")));
            this.dog0.Location = new System.Drawing.Point(85, 19);
            this.dog0.Name = "dog0";
            this.dog0.Size = new System.Drawing.Size(100, 50);
            this.dog0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog0.TabIndex = 1;
            this.dog0.TabStop = false;
            // 
            // dog1
            // 
            this.dog1.Image = ((System.Drawing.Image)(resources.GetObject("dog1.Image")));
            this.dog1.Location = new System.Drawing.Point(85, 104);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(100, 50);
            this.dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog1.TabIndex = 2;
            this.dog1.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = ((System.Drawing.Image)(resources.GetObject("dog3.Image")));
            this.dog3.Location = new System.Drawing.Point(85, 278);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(100, 50);
            this.dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog3.TabIndex = 4;
            this.dog3.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.Image = ((System.Drawing.Image)(resources.GetObject("dog2.Image")));
            this.dog2.Location = new System.Drawing.Point(85, 193);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(100, 50);
            this.dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog2.TabIndex = 3;
            this.dog2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bettingWindowBox);
            this.groupBox1.Controls.Add(this.raceButton);
            this.groupBox1.Controls.Add(this.alBetLabel);
            this.groupBox1.Controls.Add(this.bobBetLabel);
            this.groupBox1.Controls.Add(this.joeBetLabel);
            this.groupBox1.Controls.Add(this.alInfo);
            this.groupBox1.Controls.Add(this.bobInfo);
            this.groupBox1.Controls.Add(this.joeInfo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1183, 238);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // bettingWindowBox
            // 
            this.bettingWindowBox.Controls.Add(this.removeBetButton);
            this.bettingWindowBox.Controls.Add(this.placeBetButton);
            this.bettingWindowBox.Controls.Add(this.betAmount);
            this.bettingWindowBox.Controls.Add(this.selectDog);
            this.bettingWindowBox.Controls.Add(this.selectBettor);
            this.bettingWindowBox.Controls.Add(this.selectBettorLabel);
            this.bettingWindowBox.Controls.Add(this.label2);
            this.bettingWindowBox.Controls.Add(this.label4);
            this.bettingWindowBox.Controls.Add(this.label3);
            this.bettingWindowBox.Controls.Add(this.minimumBetLabel);
            this.bettingWindowBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bettingWindowBox.Location = new System.Drawing.Point(471, 20);
            this.bettingWindowBox.Name = "bettingWindowBox";
            this.bettingWindowBox.Size = new System.Drawing.Size(364, 212);
            this.bettingWindowBox.TabIndex = 10;
            this.bettingWindowBox.TabStop = false;
            this.bettingWindowBox.Text = "Betting Window";
            // 
            // removeBetButton
            // 
            this.removeBetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBetButton.Location = new System.Drawing.Point(188, 135);
            this.removeBetButton.Name = "removeBetButton";
            this.removeBetButton.Size = new System.Drawing.Size(122, 34);
            this.removeBetButton.TabIndex = 12;
            this.removeBetButton.Text = "Remove Bet";
            this.removeBetButton.UseVisualStyleBackColor = true;
            this.removeBetButton.Click += new System.EventHandler(this.removeBetButton_Click);
            // 
            // placeBetButton
            // 
            this.placeBetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeBetButton.Location = new System.Drawing.Point(60, 135);
            this.placeBetButton.Name = "placeBetButton";
            this.placeBetButton.Size = new System.Drawing.Size(122, 34);
            this.placeBetButton.TabIndex = 12;
            this.placeBetButton.Text = "Place Bet";
            this.placeBetButton.UseVisualStyleBackColor = true;
            this.placeBetButton.Click += new System.EventHandler(this.placeBetButton_Click);
            // 
            // betAmount
            // 
            this.betAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betAmount.Location = new System.Drawing.Point(80, 91);
            this.betAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(84, 23);
            this.betAmount.TabIndex = 11;
            this.betAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.betAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // selectDog
            // 
            this.selectDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDog.FormattingEnabled = true;
            this.selectDog.Items.AddRange(new object[] {
            "Dog 1",
            "Dog 2",
            "Dog 3",
            "Dog 4"});
            this.selectDog.Location = new System.Drawing.Point(199, 90);
            this.selectDog.Name = "selectDog";
            this.selectDog.Size = new System.Drawing.Size(119, 24);
            this.selectDog.TabIndex = 11;
            this.selectDog.Text = "Select Dog";
            // 
            // selectBettor
            // 
            this.selectBettor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBettor.FormattingEnabled = true;
            this.selectBettor.Items.AddRange(new object[] {
            "Joe",
            "Bob",
            "Al"});
            this.selectBettor.Location = new System.Drawing.Point(128, 46);
            this.selectBettor.Name = "selectBettor";
            this.selectBettor.Size = new System.Drawing.Size(119, 24);
            this.selectBettor.TabIndex = 11;
            this.selectBettor.Text = "Select Bettor";
            this.selectBettor.SelectedIndexChanged += new System.EventHandler(this.selectBettor_SelectedIndexChanged);
            // 
            // selectBettorLabel
            // 
            this.selectBettorLabel.AutoSize = true;
            this.selectBettorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBettorLabel.Location = new System.Drawing.Point(132, 26);
            this.selectBettorLabel.Name = "selectBettorLabel";
            this.selectBettorLabel.Size = new System.Drawing.Size(111, 17);
            this.selectBettorLabel.TabIndex = 9;
            this.selectBettorLabel.Text = "Bettor at window";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "on";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Minimum Bet:";
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(205, 180);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(59, 19);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "5 bucks";
            // 
            // raceButton
            // 
            this.raceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceButton.Location = new System.Drawing.Point(841, 28);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(336, 204);
            this.raceButton.TabIndex = 12;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alBetLabel.Location = new System.Drawing.Point(155, 143);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(300, 19);
            this.alBetLabel.TabIndex = 7;
            this.alBetLabel.Text = "Al\'s slip is empty...";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bobBetLabel.Location = new System.Drawing.Point(155, 114);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(300, 19);
            this.bobBetLabel.TabIndex = 6;
            this.bobBetLabel.Text = "Bob\'s slip is empty...";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joeBetLabel.Location = new System.Drawing.Point(155, 87);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(300, 19);
            this.joeBetLabel.TabIndex = 5;
            this.joeBetLabel.Text = "Joe\'s slip is empty...";
            // 
            // alInfo
            // 
            this.alInfo.AutoSize = true;
            this.alInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alInfo.Location = new System.Drawing.Point(20, 144);
            this.alInfo.Name = "alInfo";
            this.alInfo.Size = new System.Drawing.Size(104, 16);
            this.alInfo.TabIndex = 4;
            this.alInfo.Text = "Al has 45 bucks.";
            // 
            // bobInfo
            // 
            this.bobInfo.AutoSize = true;
            this.bobInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bobInfo.Location = new System.Drawing.Point(20, 115);
            this.bobInfo.Name = "bobInfo";
            this.bobInfo.Size = new System.Drawing.Size(117, 16);
            this.bobInfo.TabIndex = 4;
            this.bobInfo.Text = "Bob has 75 bucks.";
            // 
            // joeInfo
            // 
            this.joeInfo.AutoSize = true;
            this.joeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joeInfo.Location = new System.Drawing.Point(20, 88);
            this.joeInfo.Name = "joeInfo";
            this.joeInfo.Size = new System.Drawing.Size(115, 16);
            this.joeInfo.TabIndex = 4;
            this.joeInfo.Text = "Joe has 50 bucks.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Betting Slips";
            // 
            // raceTimer
            // 
            this.raceTimer.Interval = 10;
            this.raceTimer.Tick += new System.EventHandler(this.raceTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 607);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.dog0);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.bettingWindowBox.ResumeLayout(false);
            this.bettingWindowBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox dog0;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox bettingWindowBox;
        private System.Windows.Forms.Label selectBettorLabel;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label alInfo;
        private System.Windows.Forms.Label bobInfo;
        private System.Windows.Forms.Label joeInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.ComboBox selectBettor;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removeBetButton;
        private System.Windows.Forms.Button placeBetButton;
        private System.Windows.Forms.ComboBox selectDog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.Timer raceTimer;
    }
}

