using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GameHub
{
    partial class frmSnake
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
            pnlSnakeBoard = new Panel();
            lblBoardPlaceholder = new Label();
            pnlInfo = new Panel();
            lblSnakeScoreCaption = new Label();
            lblSnakeScore = new Label();
            lblLengthCaption = new Label();
            lblSnakeLength = new Label();
            lblSnakeBestCaption = new Label();
            lblSnakeBest = new Label();
            btnStartSnake = new Button();
            btnPauseSnake = new Button();
            pnlSnakeBoard.SuspendLayout();
            pnlInfo.SuspendLayout();
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
            lblIcon.Text = "🐍";
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
            lblTitle.Text = "Snake";
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
            lblSubtitle.Text = "Eat food, grow longer and avoid the walls.";
            // 
            // pnlSnakeBoard
            // 
            pnlSnakeBoard.BackColor = Color.FromArgb(20, 28, 44);
            pnlSnakeBoard.Controls.Add(lblBoardPlaceholder);
            pnlSnakeBoard.Location = new Point(34, 207);
            pnlSnakeBoard.Margin = new Padding(3, 4, 3, 4);
            pnlSnakeBoard.Name = "pnlSnakeBoard";
            pnlSnakeBoard.Size = new Size(857, 647);
            pnlSnakeBoard.TabIndex = 4;
            // 
            // lblBoardPlaceholder
            // 
            lblBoardPlaceholder.BackColor = Color.Transparent;
            lblBoardPlaceholder.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBoardPlaceholder.ForeColor = Color.FromArgb(150, 160, 180);
            lblBoardPlaceholder.Location = new Point(57, 213);
            lblBoardPlaceholder.Name = "lblBoardPlaceholder";
            lblBoardPlaceholder.Size = new Size(743, 160);
            lblBoardPlaceholder.TabIndex = 0;
            lblBoardPlaceholder.Text = "SNAKE GAME BOARD\r\n\r\nUse the arrow keys or W A S D to move.";
            lblBoardPlaceholder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInfo
            // 
            pnlInfo.BackColor = Color.FromArgb(20, 28, 44);
            pnlInfo.Controls.Add(lblSnakeScoreCaption);
            pnlInfo.Controls.Add(lblSnakeScore);
            pnlInfo.Controls.Add(lblLengthCaption);
            pnlInfo.Controls.Add(lblSnakeLength);
            pnlInfo.Controls.Add(lblSnakeBestCaption);
            pnlInfo.Controls.Add(lblSnakeBest);
            pnlInfo.Controls.Add(btnStartSnake);
            pnlInfo.Controls.Add(btnPauseSnake);
            pnlInfo.Location = new Point(920, 207);
            pnlInfo.Margin = new Padding(3, 4, 3, 4);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(257, 647);
            pnlInfo.TabIndex = 5;
            // 
            // lblSnakeScoreCaption
            // 
            lblSnakeScoreCaption.BackColor = Color.Transparent;
            lblSnakeScoreCaption.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSnakeScoreCaption.ForeColor = Color.FromArgb(150, 160, 180);
            lblSnakeScoreCaption.Location = new Point(23, 40);
            lblSnakeScoreCaption.Name = "lblSnakeScoreCaption";
            lblSnakeScoreCaption.Size = new Size(211, 32);
            lblSnakeScoreCaption.TabIndex = 0;
            lblSnakeScoreCaption.Text = "SCORE";
            lblSnakeScoreCaption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSnakeScore
            // 
            lblSnakeScore.BackColor = Color.Transparent;
            lblSnakeScore.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblSnakeScore.ForeColor = Color.White;
            lblSnakeScore.Location = new Point(23, 83);
            lblSnakeScore.Name = "lblSnakeScore";
            lblSnakeScore.Size = new Size(211, 64);
            lblSnakeScore.TabIndex = 1;
            lblSnakeScore.Text = "0";
            lblSnakeScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLengthCaption
            // 
            lblLengthCaption.BackColor = Color.Transparent;
            lblLengthCaption.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLengthCaption.ForeColor = Color.FromArgb(150, 160, 180);
            lblLengthCaption.Location = new Point(23, 187);
            lblLengthCaption.Name = "lblLengthCaption";
            lblLengthCaption.Size = new Size(211, 32);
            lblLengthCaption.TabIndex = 2;
            lblLengthCaption.Text = "LENGTH";
            lblLengthCaption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSnakeLength
            // 
            lblSnakeLength.BackColor = Color.Transparent;
            lblSnakeLength.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblSnakeLength.ForeColor = Color.White;
            lblSnakeLength.Location = new Point(23, 229);
            lblSnakeLength.Name = "lblSnakeLength";
            lblSnakeLength.Size = new Size(211, 64);
            lblSnakeLength.TabIndex = 3;
            lblSnakeLength.Text = "3";
            lblSnakeLength.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSnakeBestCaption
            // 
            lblSnakeBestCaption.BackColor = Color.Transparent;
            lblSnakeBestCaption.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSnakeBestCaption.ForeColor = Color.FromArgb(150, 160, 180);
            lblSnakeBestCaption.Location = new Point(23, 333);
            lblSnakeBestCaption.Name = "lblSnakeBestCaption";
            lblSnakeBestCaption.Size = new Size(211, 32);
            lblSnakeBestCaption.TabIndex = 4;
            lblSnakeBestCaption.Text = "BEST";
            lblSnakeBestCaption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSnakeBest
            // 
            lblSnakeBest.BackColor = Color.Transparent;
            lblSnakeBest.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblSnakeBest.ForeColor = Color.White;
            lblSnakeBest.Location = new Point(23, 376);
            lblSnakeBest.Name = "lblSnakeBest";
            lblSnakeBest.Size = new Size(211, 64);
            lblSnakeBest.TabIndex = 5;
            lblSnakeBest.Text = "0";
            lblSnakeBest.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStartSnake
            // 
            btnStartSnake.BackColor = Color.FromArgb(92, 63, 235);
            btnStartSnake.Cursor = Cursors.Hand;
            btnStartSnake.FlatAppearance.BorderSize = 0;
            btnStartSnake.FlatStyle = FlatStyle.Flat;
            btnStartSnake.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnStartSnake.ForeColor = Color.White;
            btnStartSnake.Location = new Point(23, 500);
            btnStartSnake.Margin = new Padding(3, 4, 3, 4);
            btnStartSnake.Name = "btnStartSnake";
            btnStartSnake.Size = new Size(211, 56);
            btnStartSnake.TabIndex = 6;
            btnStartSnake.Text = "START GAME";
            btnStartSnake.UseVisualStyleBackColor = false;
            // 
            // btnPauseSnake
            // 
            btnPauseSnake.BackColor = Color.FromArgb(15, 23, 40);
            btnPauseSnake.Cursor = Cursors.Hand;
            btnPauseSnake.FlatAppearance.BorderSize = 0;
            btnPauseSnake.FlatStyle = FlatStyle.Flat;
            btnPauseSnake.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPauseSnake.ForeColor = Color.White;
            btnPauseSnake.Location = new Point(23, 567);
            btnPauseSnake.Margin = new Padding(3, 4, 3, 4);
            btnPauseSnake.Name = "btnPauseSnake";
            btnPauseSnake.Size = new Size(211, 47);
            btnPauseSnake.TabIndex = 7;
            btnPauseSnake.Text = "PAUSE";
            btnPauseSnake.UseVisualStyleBackColor = false;
            // 
            // frmSnake
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 13, 24);
            ClientSize = new Size(1211, 933);
            Controls.Add(lblBack);
            Controls.Add(lblIcon);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(pnlSnakeBoard);
            Controls.Add(pnlInfo);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimumSize = new Size(1227, 970);
            Name = "frmSnake";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameHub — Snake";
            pnlSnakeBoard.ResumeLayout(false);
            pnlInfo.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Label lblBack;
        private Label lblIcon;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlSnakeBoard;
        private Panel pnlInfo;
        private Label lblBoardPlaceholder;
        private Label lblSnakeScoreCaption;
        private Label lblSnakeScore;
        private Label lblLengthCaption;
        private Label lblSnakeLength;
        private Label lblSnakeBestCaption;
        private Label lblSnakeBest;
        private Button btnStartSnake;
        private Button btnPauseSnake;
    }
}
