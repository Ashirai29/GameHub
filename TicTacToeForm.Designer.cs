using System.ComponentModel;
using System.Windows.Forms;

namespace GameHub
{
    partial class frmTicTacToe
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblBack = new Label();
            lblIcon = new Label();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlBoard = new Panel();
            btnCell1 = new Button();
            btnCell2 = new Button();
            btnCell3 = new Button();
            btnCell4 = new Button();
            btnCell5 = new Button();
            btnCell6 = new Button();
            btnCell7 = new Button();
            btnCell8 = new Button();
            btnCell9 = new Button();
            pnlInfo = new Panel();
            lblTurnCaption = new Label();
            lblCurrentTurn = new Label();
            lblStatus = new Label();
            lblScoreTitle = new Label();
            lblMatchScore = new Label();
            btnResetBoard = new Button();
            pnlBoard.SuspendLayout();
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
            lblBack.TextAlign = ContentAlignment.MiddleLeft;
            lblBack.Click += lblBack_Click;
            // 
            // lblIcon
            // 
            lblIcon.BackColor = Color.Transparent;
            lblIcon.Font = new Font("Segoe UI Emoji", 30F);
            lblIcon.ForeColor = Color.White;
            lblIcon.Location = new Point(34, 91);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(74, 80);
            lblIcon.TabIndex = 1;
            lblIcon.Text = "⭕";
            lblIcon.TextAlign = ContentAlignment.MiddleCenter;
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
            lblTitle.Text = "Tic Tac Toe";
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
            lblSubtitle.Text = "Classic three-in-a-row strategy.";
            // 
            // pnlBoard
            // 
            pnlBoard.BackColor = Color.FromArgb(20, 28, 44);
            pnlBoard.Controls.Add(btnCell1);
            pnlBoard.Controls.Add(btnCell2);
            pnlBoard.Controls.Add(btnCell3);
            pnlBoard.Controls.Add(btnCell4);
            pnlBoard.Controls.Add(btnCell5);
            pnlBoard.Controls.Add(btnCell6);
            pnlBoard.Controls.Add(btnCell7);
            pnlBoard.Controls.Add(btnCell8);
            pnlBoard.Controls.Add(btnCell9);
            pnlBoard.Location = new Point(34, 207);
            pnlBoard.Margin = new Padding(3, 4, 3, 4);
            pnlBoard.Name = "pnlBoard";
            pnlBoard.Size = new Size(743, 647);
            pnlBoard.TabIndex = 4;
            // 
            // btnCell1
            // 
            btnCell1.BackColor = Color.FromArgb(15, 23, 40);
            btnCell1.Cursor = Cursors.Hand;
            btnCell1.FlatAppearance.BorderSize = 0;
            btnCell1.FlatStyle = FlatStyle.Flat;
            btnCell1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btnCell1.ForeColor = Color.White;
            btnCell1.Location = new Point(91, 40);
            btnCell1.Margin = new Padding(3, 4, 3, 4);
            btnCell1.Name = "btnCell1";
            btnCell1.Size = new Size(166, 167);
            btnCell1.TabIndex = 0;
            btnCell1.UseVisualStyleBackColor = false;
            // 
            // btnCell2
            // 
            btnCell2.BackColor = Color.FromArgb(15, 23, 40);
            btnCell2.Cursor = Cursors.Hand;
            btnCell2.FlatAppearance.BorderSize = 0;
            btnCell2.FlatStyle = FlatStyle.Flat;
            btnCell2.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btnCell2.ForeColor = Color.White;
            btnCell2.Location = new Point(280, 40);
            btnCell2.Margin = new Padding(3, 4, 3, 4);
            btnCell2.Name = "btnCell2";
            btnCell2.Size = new Size(166, 167);
            btnCell2.TabIndex = 1;
            btnCell2.UseVisualStyleBackColor = false;
            // 
            // btnCell3
            // 
            btnCell3.BackColor = Color.FromArgb(15, 23, 40);
            btnCell3.Cursor = Cursors.Hand;
            btnCell3.FlatAppearance.BorderSize = 0;
            btnCell3.FlatStyle = FlatStyle.Flat;
            btnCell3.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btnCell3.ForeColor = Color.White;
            btnCell3.Location = new Point(469, 40);
            btnCell3.Margin = new Padding(3, 4, 3, 4);
            btnCell3.Name = "btnCell3";
            btnCell3.Size = new Size(166, 167);
            btnCell3.TabIndex = 2;
            btnCell3.UseVisualStyleBackColor = false;
            // 
            // btnCell4
            // 
            btnCell4.BackColor = Color.FromArgb(15, 23, 40);
            btnCell4.Cursor = Cursors.Hand;
            btnCell4.FlatAppearance.BorderSize = 0;
            btnCell4.FlatStyle = FlatStyle.Flat;
            btnCell4.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btnCell4.ForeColor = Color.White;
            btnCell4.Location = new Point(91, 233);
            btnCell4.Margin = new Padding(3, 4, 3, 4);
            btnCell4.Name = "btnCell4";
            btnCell4.Size = new Size(166, 167);
            btnCell4.TabIndex = 3;
            btnCell4.UseVisualStyleBackColor = false;
            // 
            // btnCell5
            // 
            btnCell5.BackColor = Color.FromArgb(15, 23, 40);
            btnCell5.Cursor = Cursors.Hand;
            btnCell5.FlatAppearance.BorderSize = 0;
            btnCell5.FlatStyle = FlatStyle.Flat;
            btnCell5.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btnCell5.ForeColor = Color.White;
            btnCell5.Location = new Point(280, 233);
            btnCell5.Margin = new Padding(3, 4, 3, 4);
            btnCell5.Name = "btnCell5";
            btnCell5.Size = new Size(166, 167);
            btnCell5.TabIndex = 4;
            btnCell5.UseVisualStyleBackColor = false;
            // 
            // btnCell6
            // 
            btnCell6.BackColor = Color.FromArgb(15, 23, 40);
            btnCell6.Cursor = Cursors.Hand;
            btnCell6.FlatAppearance.BorderSize = 0;
            btnCell6.FlatStyle = FlatStyle.Flat;
            btnCell6.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btnCell6.ForeColor = Color.White;
            btnCell6.Location = new Point(469, 233);
            btnCell6.Margin = new Padding(3, 4, 3, 4);
            btnCell6.Name = "btnCell6";
            btnCell6.Size = new Size(166, 167);
            btnCell6.TabIndex = 5;
            btnCell6.UseVisualStyleBackColor = false;
            // 
            // btnCell7
            // 
            btnCell7.BackColor = Color.FromArgb(15, 23, 40);
            btnCell7.Cursor = Cursors.Hand;
            btnCell7.FlatAppearance.BorderSize = 0;
            btnCell7.FlatStyle = FlatStyle.Flat;
            btnCell7.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btnCell7.ForeColor = Color.White;
            btnCell7.Location = new Point(91, 427);
            btnCell7.Margin = new Padding(3, 4, 3, 4);
            btnCell7.Name = "btnCell7";
            btnCell7.Size = new Size(166, 167);
            btnCell7.TabIndex = 6;
            btnCell7.UseVisualStyleBackColor = false;
            // 
            // btnCell8
            // 
            btnCell8.BackColor = Color.FromArgb(15, 23, 40);
            btnCell8.Cursor = Cursors.Hand;
            btnCell8.FlatAppearance.BorderSize = 0;
            btnCell8.FlatStyle = FlatStyle.Flat;
            btnCell8.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btnCell8.ForeColor = Color.White;
            btnCell8.Location = new Point(280, 427);
            btnCell8.Margin = new Padding(3, 4, 3, 4);
            btnCell8.Name = "btnCell8";
            btnCell8.Size = new Size(166, 167);
            btnCell8.TabIndex = 7;
            btnCell8.UseVisualStyleBackColor = false;
            // 
            // btnCell9
            // 
            btnCell9.BackColor = Color.FromArgb(15, 23, 40);
            btnCell9.Cursor = Cursors.Hand;
            btnCell9.FlatAppearance.BorderSize = 0;
            btnCell9.FlatStyle = FlatStyle.Flat;
            btnCell9.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btnCell9.ForeColor = Color.White;
            btnCell9.Location = new Point(469, 427);
            btnCell9.Margin = new Padding(3, 4, 3, 4);
            btnCell9.Name = "btnCell9";
            btnCell9.Size = new Size(166, 167);
            btnCell9.TabIndex = 8;
            btnCell9.UseVisualStyleBackColor = false;
            // 
            // pnlInfo
            // 
            pnlInfo.BackColor = Color.FromArgb(20, 28, 44);
            pnlInfo.Controls.Add(lblTurnCaption);
            pnlInfo.Controls.Add(lblCurrentTurn);
            pnlInfo.Controls.Add(lblStatus);
            pnlInfo.Controls.Add(lblScoreTitle);
            pnlInfo.Controls.Add(lblMatchScore);
            pnlInfo.Controls.Add(btnResetBoard);
            pnlInfo.Location = new Point(806, 207);
            pnlInfo.Margin = new Padding(3, 4, 3, 4);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(371, 647);
            pnlInfo.TabIndex = 5;
            // 
            // lblTurnCaption
            // 
            lblTurnCaption.BackColor = Color.Transparent;
            lblTurnCaption.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTurnCaption.ForeColor = Color.FromArgb(150, 160, 180);
            lblTurnCaption.Location = new Point(29, 47);
            lblTurnCaption.Name = "lblTurnCaption";
            lblTurnCaption.Size = new Size(314, 32);
            lblTurnCaption.TabIndex = 0;
            lblTurnCaption.Text = "CURRENT TURN";
            lblTurnCaption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentTurn
            // 
            lblCurrentTurn.BackColor = Color.Transparent;
            lblCurrentTurn.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCurrentTurn.ForeColor = Color.FromArgb(167, 139, 250);
            lblCurrentTurn.Location = new Point(29, 89);
            lblCurrentTurn.Name = "lblCurrentTurn";
            lblCurrentTurn.Size = new Size(314, 67);
            lblCurrentTurn.TabIndex = 1;
            lblCurrentTurn.Text = "Player X";
            lblCurrentTurn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI", 11F);
            lblStatus.ForeColor = Color.FromArgb(150, 160, 180);
            lblStatus.Location = new Point(29, 200);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(314, 93);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Place three matching symbols in a row to win.";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScoreTitle
            // 
            lblScoreTitle.BackColor = Color.Transparent;
            lblScoreTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblScoreTitle.ForeColor = Color.White;
            lblScoreTitle.Location = new Point(29, 340);
            lblScoreTitle.Name = "lblScoreTitle";
            lblScoreTitle.Size = new Size(314, 33);
            lblScoreTitle.TabIndex = 3;
            lblScoreTitle.Text = "MATCH SCORE";
            lblScoreTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMatchScore
            // 
            lblMatchScore.BackColor = Color.Transparent;
            lblMatchScore.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblMatchScore.ForeColor = Color.White;
            lblMatchScore.Location = new Point(29, 387);
            lblMatchScore.Name = "lblMatchScore";
            lblMatchScore.Size = new Size(314, 60);
            lblMatchScore.TabIndex = 4;
            lblMatchScore.Text = "X  0     •     0  O";
            lblMatchScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnResetBoard
            // 
            btnResetBoard.BackColor = Color.FromArgb(92, 63, 235);
            btnResetBoard.Cursor = Cursors.Hand;
            btnResetBoard.FlatAppearance.BorderSize = 0;
            btnResetBoard.FlatStyle = FlatStyle.Flat;
            btnResetBoard.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnResetBoard.ForeColor = Color.White;
            btnResetBoard.Location = new Point(29, 520);
            btnResetBoard.Margin = new Padding(3, 4, 3, 4);
            btnResetBoard.Name = "btnResetBoard";
            btnResetBoard.Size = new Size(314, 60);
            btnResetBoard.TabIndex = 5;
            btnResetBoard.Text = "RESET BOARD";
            btnResetBoard.UseVisualStyleBackColor = false;
            // 
            // frmTicTacToe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 13, 24);
            ClientSize = new Size(1211, 933);
            Controls.Add(lblBack);
            Controls.Add(lblIcon);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(pnlBoard);
            Controls.Add(pnlInfo);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimumSize = new Size(1227, 970);
            Name = "frmTicTacToe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameHub — Tic Tac Toe";
            pnlBoard.ResumeLayout(false);
            pnlInfo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Button btnCell1;
        private System.Windows.Forms.Button btnCell2;
        private System.Windows.Forms.Button btnCell3;
        private System.Windows.Forms.Button btnCell4;
        private System.Windows.Forms.Button btnCell5;
        private System.Windows.Forms.Button btnCell6;
        private System.Windows.Forms.Button btnCell7;
        private System.Windows.Forms.Button btnCell8;
        private System.Windows.Forms.Button btnCell9;

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblTurnCaption;
        private System.Windows.Forms.Label lblCurrentTurn;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblScoreTitle;
        private System.Windows.Forms.Label lblMatchScore;
        private System.Windows.Forms.Button btnResetBoard;
    }
}
