using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GameHub
{
    partial class frmGuessNumber
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblBack = new Label();
            lblIcon = new Label();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlGame = new Panel();
            lblRange = new Label();
            lblRangeValue = new Label();
            txtGuess = new TextBox();
            btnCheckGuess = new Button();
            lblHint = new Label();
            btnNewGame = new Button();
            pnlStats = new Panel();
            lblStatsTitle = new Label();
            lblAttemptsCaption = new Label();
            lblAttempts = new Label();
            lblBestCaption = new Label();
            lblBestScore = new Label();
            lblTip = new Label();
            pnlGame.SuspendLayout();
            pnlStats.SuspendLayout();
            SuspendLayout();
            // 
            // lblBack
            // 
            lblBack.BackColor = Color.Transparent;
            lblBack.Cursor = Cursors.Hand;
            lblBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBack.ForeColor = Color.FromArgb(167, 139, 250);
            lblBack.Location = new Point(34, 29);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(229, 37);
            lblBack.TabIndex = 0;
            lblBack.Text = "‹  Back to GameHub";
            lblBack.Click += lblBack_Click;
            // 
            // lblIcon
            // 
            lblIcon.BackColor = Color.Transparent;
            lblIcon.Font = new Font("Segoe UI", 30F);
            lblIcon.ForeColor = Color.White;
            lblIcon.Location = new Point(34, 91);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(74, 80);
            lblIcon.TabIndex = 1;
            lblIcon.Text = "❓";
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(120, 93);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(869, 53);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Guess the Number";
            // 
            // lblSubtitle
            // 
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(150, 160, 180);
            lblSubtitle.Location = new Point(123, 147);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(869, 35);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "Use higher and lower hints to find the secret number.";
            // 
            // pnlGame
            // 
            pnlGame.BackColor = Color.FromArgb(20, 28, 44);
            pnlGame.Controls.Add(lblRange);
            pnlGame.Controls.Add(lblRangeValue);
            pnlGame.Controls.Add(txtGuess);
            pnlGame.Controls.Add(btnCheckGuess);
            pnlGame.Controls.Add(lblHint);
            pnlGame.Controls.Add(btnNewGame);
            pnlGame.Location = new Point(34, 207);
            pnlGame.Margin = new Padding(3, 4, 3, 4);
            pnlGame.Name = "pnlGame";
            pnlGame.Size = new Size(743, 647);
            pnlGame.TabIndex = 4;
            // 
            // lblRange
            // 
            lblRange.BackColor = Color.Transparent;
            lblRange.Font = new Font("Segoe UI", 11F);
            lblRange.ForeColor = Color.FromArgb(150, 160, 180);
            lblRange.Location = new Point(46, 60);
            lblRange.Name = "lblRange";
            lblRange.Size = new Size(651, 35);
            lblRange.TabIndex = 0;
            lblRange.Text = "I am thinking of a number between";
            lblRange.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRangeValue
            // 
            lblRangeValue.BackColor = Color.Transparent;
            lblRangeValue.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblRangeValue.ForeColor = Color.FromArgb(167, 139, 250);
            lblRangeValue.Location = new Point(46, 104);
            lblRangeValue.Name = "lblRangeValue";
            lblRangeValue.Size = new Size(651, 73);
            lblRangeValue.TabIndex = 1;
            lblRangeValue.Text = "1 and 100";
            lblRangeValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtGuess
            // 
            txtGuess.BackColor = Color.FromArgb(15, 23, 40);
            txtGuess.BorderStyle = BorderStyle.FixedSingle;
            txtGuess.Font = new Font("Segoe UI", 11F);
            txtGuess.ForeColor = Color.FromArgb(150, 160, 180);
            txtGuess.Location = new Point(177, 220);
            txtGuess.Margin = new Padding(3, 4, 3, 4);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(388, 32);
            txtGuess.TabIndex = 2;
            txtGuess.Text = "Enter your guess";
            // 
            // btnCheckGuess
            // 
            btnCheckGuess.BackColor = Color.FromArgb(92, 63, 235);
            btnCheckGuess.Cursor = Cursors.Hand;
            btnCheckGuess.FlatAppearance.BorderSize = 0;
            btnCheckGuess.FlatStyle = FlatStyle.Flat;
            btnCheckGuess.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCheckGuess.ForeColor = Color.White;
            btnCheckGuess.Location = new Point(177, 293);
            btnCheckGuess.Margin = new Padding(3, 4, 3, 4);
            btnCheckGuess.Name = "btnCheckGuess";
            btnCheckGuess.Size = new Size(389, 60);
            btnCheckGuess.TabIndex = 3;
            btnCheckGuess.Text = "CHECK GUESS";
            btnCheckGuess.UseVisualStyleBackColor = false;
            btnCheckGuess.Click += btnCheckGuess_Click;
            // 
            // lblHint
            // 
            lblHint.BackColor = Color.Transparent;
            lblHint.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHint.ForeColor = Color.FromArgb(150, 160, 180);
            lblHint.Location = new Point(51, 393);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(640, 67);
            lblHint.TabIndex = 4;
            lblHint.Text = "Higher or lower hints will appear here.";
            lblHint.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNewGame
            // 
            btnNewGame.BackColor = Color.FromArgb(15, 23, 40);
            btnNewGame.Cursor = Cursors.Hand;
            btnNewGame.FlatAppearance.BorderSize = 0;
            btnNewGame.FlatStyle = FlatStyle.Flat;
            btnNewGame.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNewGame.ForeColor = Color.White;
            btnNewGame.Location = new Point(269, 520);
            btnNewGame.Margin = new Padding(3, 4, 3, 4);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(206, 56);
            btnNewGame.TabIndex = 5;
            btnNewGame.Text = "NEW GAME";
            btnNewGame.UseVisualStyleBackColor = false;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // pnlStats
            // 
            pnlStats.BackColor = Color.FromArgb(20, 28, 44);
            pnlStats.Controls.Add(lblStatsTitle);
            pnlStats.Controls.Add(lblAttemptsCaption);
            pnlStats.Controls.Add(lblAttempts);
            pnlStats.Controls.Add(lblBestCaption);
            pnlStats.Controls.Add(lblBestScore);
            pnlStats.Controls.Add(lblTip);
            pnlStats.Location = new Point(806, 207);
            pnlStats.Margin = new Padding(3, 4, 3, 4);
            pnlStats.Name = "pnlStats";
            pnlStats.Size = new Size(371, 647);
            pnlStats.TabIndex = 5;
            // 
            // lblStatsTitle
            // 
            lblStatsTitle.BackColor = Color.Transparent;
            lblStatsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStatsTitle.ForeColor = Color.White;
            lblStatsTitle.Location = new Point(29, 33);
            lblStatsTitle.Name = "lblStatsTitle";
            lblStatsTitle.Size = new Size(309, 40);
            lblStatsTitle.TabIndex = 0;
            lblStatsTitle.Text = "GAME STATS";
            // 
            // lblAttemptsCaption
            // 
            lblAttemptsCaption.BackColor = Color.Transparent;
            lblAttemptsCaption.Font = new Font("Segoe UI", 10F);
            lblAttemptsCaption.ForeColor = Color.FromArgb(150, 160, 180);
            lblAttemptsCaption.Location = new Point(29, 113);
            lblAttemptsCaption.Name = "lblAttemptsCaption";
            lblAttemptsCaption.Size = new Size(149, 33);
            lblAttemptsCaption.TabIndex = 1;
            lblAttemptsCaption.Text = "Attempts";
            // 
            // lblAttempts
            // 
            lblAttempts.BackColor = Color.Transparent;
            lblAttempts.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblAttempts.ForeColor = Color.White;
            lblAttempts.Location = new Point(29, 149);
            lblAttempts.Name = "lblAttempts";
            lblAttempts.Size = new Size(309, 51);
            lblAttempts.TabIndex = 2;
            lblAttempts.Text = "0 / 10";
            // 
            // lblBestCaption
            // 
            lblBestCaption.BackColor = Color.Transparent;
            lblBestCaption.Font = new Font("Segoe UI", 10F);
            lblBestCaption.ForeColor = Color.FromArgb(150, 160, 180);
            lblBestCaption.Location = new Point(29, 240);
            lblBestCaption.Name = "lblBestCaption";
            lblBestCaption.Size = new Size(149, 33);
            lblBestCaption.TabIndex = 3;
            lblBestCaption.Text = "Best score";
            // 
            // lblBestScore
            // 
            lblBestScore.BackColor = Color.Transparent;
            lblBestScore.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblBestScore.ForeColor = Color.White;
            lblBestScore.Location = new Point(29, 276);
            lblBestScore.Name = "lblBestScore";
            lblBestScore.Size = new Size(309, 51);
            lblBestScore.TabIndex = 4;
            lblBestScore.Text = "—";
            // 
            // lblTip
            // 
            lblTip.BackColor = Color.Transparent;
            lblTip.Font = new Font("Segoe UI", 10F);
            lblTip.ForeColor = Color.FromArgb(150, 160, 180);
            lblTip.Location = new Point(29, 393);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(309, 120);
            lblTip.TabIndex = 5;
            lblTip.Text = "TIP\r\nUse the feedback to narrow the possible range.";
            // 
            // frmGuessNumber
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 13, 24);
            ClientSize = new Size(1211, 933);
            Controls.Add(lblBack);
            Controls.Add(lblIcon);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(pnlGame);
            Controls.Add(pnlStats);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimumSize = new Size(1227, 970);
            Name = "frmGuessNumber";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameHub — Guess the Number";
            pnlGame.ResumeLayout(false);
            pnlGame.PerformLayout();
            pnlStats.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Label lblBack;
        private Label lblIcon;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlGame;
        private Panel pnlStats;
        private Label lblRange;
        private Label lblRangeValue;
        private TextBox txtGuess;
        private Button btnCheckGuess;
        private Label lblHint;
        private Button btnNewGame;
        private Label lblStatsTitle;
        private Label lblAttemptsCaption;
        private Label lblAttempts;
        private Label lblBestCaption;
        private Label lblBestScore;
        private Label lblTip;
    }
}
