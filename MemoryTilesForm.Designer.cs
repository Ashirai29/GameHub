using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GameHub
{
    partial class frmMemoryTiles
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
            pnlBoard = new Panel();
            btnTile1 = new Button();
            btnTile2 = new Button();
            btnTile3 = new Button();
            btnTile4 = new Button();
            btnTile5 = new Button();
            btnTile6 = new Button();
            btnTile7 = new Button();
            btnTile8 = new Button();
            btnTile9 = new Button();
            btnTile10 = new Button();
            btnTile11 = new Button();
            btnTile12 = new Button();
            btnTile13 = new Button();
            btnTile14 = new Button();
            btnTile15 = new Button();
            btnTile16 = new Button();
            pnlInfo = new Panel();
            lblMovesCaption = new Label();
            lblMoves = new Label();
            lblPairsCaption = new Label();
            lblPairs = new Label();
            lblMemoryStatus = new Label();
            btnRestart = new Button();
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
            lblIcon.Text = "\U0001f9e0";
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
            lblTitle.Text = "Memory Tiles";
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
            lblSubtitle.Text = "Flip the cards and match all eight pairs.";
            // 
            // pnlBoard
            // 
            pnlBoard.BackColor = Color.FromArgb(20, 28, 44);
            pnlBoard.Controls.Add(btnTile1);
            pnlBoard.Controls.Add(btnTile2);
            pnlBoard.Controls.Add(btnTile3);
            pnlBoard.Controls.Add(btnTile4);
            pnlBoard.Controls.Add(btnTile5);
            pnlBoard.Controls.Add(btnTile6);
            pnlBoard.Controls.Add(btnTile7);
            pnlBoard.Controls.Add(btnTile8);
            pnlBoard.Controls.Add(btnTile9);
            pnlBoard.Controls.Add(btnTile10);
            pnlBoard.Controls.Add(btnTile11);
            pnlBoard.Controls.Add(btnTile12);
            pnlBoard.Controls.Add(btnTile13);
            pnlBoard.Controls.Add(btnTile14);
            pnlBoard.Controls.Add(btnTile15);
            pnlBoard.Controls.Add(btnTile16);
            pnlBoard.Location = new Point(34, 207);
            pnlBoard.Margin = new Padding(3, 4, 3, 4);
            pnlBoard.Name = "pnlBoard";
            pnlBoard.Size = new Size(743, 647);
            pnlBoard.TabIndex = 4;
            // 
            // btnTile1
            // 
            btnTile1.BackColor = Color.FromArgb(15, 23, 40);
            btnTile1.Cursor = Cursors.Hand;
            btnTile1.FlatAppearance.BorderSize = 0;
            btnTile1.FlatStyle = FlatStyle.Flat;
            btnTile1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnTile1.ForeColor = Color.White;
            btnTile1.Location = new Point(40, 40);
            btnTile1.Margin = new Padding(3, 4, 3, 4);
            btnTile1.Name = "btnTile1";
            btnTile1.Size = new Size(143, 113);
            btnTile1.TabIndex = 0;
            btnTile1.Text = "?";
            btnTile1.UseVisualStyleBackColor = false;
            // 
            // btnTile2
            // 
            btnTile2.BackColor = Color.FromArgb(15, 23, 40);
            btnTile2.Cursor = Cursors.Hand;
            btnTile2.FlatAppearance.BorderSize = 0;
            btnTile2.FlatStyle = FlatStyle.Flat;
            btnTile2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnTile2.ForeColor = Color.White;
            btnTile2.Location = new Point(206, 40);
            btnTile2.Margin = new Padding(3, 4, 3, 4);
            btnTile2.Name = "btnTile2";
            btnTile2.Size = new Size(143, 113);
            btnTile2.TabIndex = 1;
            btnTile2.Text = "?";
            btnTile2.UseVisualStyleBackColor = false;
            // 
            // btnTile3
            // 
            btnTile3.BackColor = Color.FromArgb(15, 23, 40);
            btnTile3.Cursor = Cursors.Hand;
            btnTile3.FlatAppearance.BorderSize = 0;
            btnTile3.FlatStyle = FlatStyle.Flat;
            btnTile3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnTile3.ForeColor = Color.White;
            btnTile3.Location = new Point(371, 40);
            btnTile3.Margin = new Padding(3, 4, 3, 4);
            btnTile3.Name = "btnTile3";
            btnTile3.Size = new Size(143, 113);
            btnTile3.TabIndex = 2;
            btnTile3.Text = "?";
            btnTile3.UseVisualStyleBackColor = false;
            // 
            // btnTile4
            // 
            btnTile4.BackColor = Color.FromArgb(15, 23, 40);
            btnTile4.Cursor = Cursors.Hand;
            btnTile4.FlatAppearance.BorderSize = 0;
            btnTile4.FlatStyle = FlatStyle.Flat;
            btnTile4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnTile4.ForeColor = Color.White;
            btnTile4.Location = new Point(537, 40);
            btnTile4.Margin = new Padding(3, 4, 3, 4);
            btnTile4.Name = "btnTile4";
            btnTile4.Size = new Size(143, 113);
            btnTile4.TabIndex = 3;
            btnTile4.Text = "?";
            btnTile4.UseVisualStyleBackColor = false;
            // 
            // btnTile5
            // 
            btnTile5.BackColor = Color.FromArgb(15, 23, 40);
            btnTile5.Cursor = Cursors.Hand;
            btnTile5.FlatAppearance.BorderSize = 0;
            btnTile5.FlatStyle = FlatStyle.Flat;
            btnTile5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnTile5.ForeColor = Color.White;
            btnTile5.Location = new Point(40, 180);
            btnTile5.Margin = new Padding(3, 4, 3, 4);
            btnTile5.Name = "btnTile5";
            btnTile5.Size = new Size(143, 113);
            btnTile5.TabIndex = 4;
            btnTile5.Text = "?";
            btnTile5.UseVisualStyleBackColor = false;
            // 
            // btnTile6
            // 
            btnTile6.BackColor = Color.FromArgb(15, 23, 40);
            btnTile6.Cursor = Cursors.Hand;
            btnTile6.FlatAppearance.BorderSize = 0;
            btnTile6.FlatStyle = FlatStyle.Flat;
            btnTile6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnTile6.ForeColor = Color.White;
            btnTile6.Location = new Point(206, 180);
            btnTile6.Margin = new Padding(3, 4, 3, 4);
            btnTile6.Name = "btnTile6";
            btnTile6.Size = new Size(143, 113);
            btnTile6.TabIndex = 5;
            btnTile6.Text = "?";
            btnTile6.UseVisualStyleBackColor = false;
            // 
            // btnTile7
            // 
            btnTile7.BackColor = Color.FromArgb(15, 23, 40);
            btnTile7.Cursor = Cursors.Hand;
            btnTile7.FlatAppearance.BorderSize = 0;
            btnTile7.FlatStyle = FlatStyle.Flat;
            btnTile7.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnTile7.ForeColor = Color.White;
            btnTile7.Location = new Point(371, 180);
            btnTile7.Margin = new Padding(3, 4, 3, 4);
            btnTile7.Name = "btnTile7";
            btnTile7.Size = new Size(143, 113);
            btnTile7.TabIndex = 6;
            btnTile7.Text = "?";
            btnTile7.UseVisualStyleBackColor = false;
            // 
            // btnTile8
            // 
            btnTile8.BackColor = Color.FromArgb(15, 23, 40);
            btnTile8.Cursor = Cursors.Hand;
            btnTile8.FlatAppearance.BorderSize = 0;
            btnTile8.FlatStyle = FlatStyle.Flat;
            btnTile8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnTile8.ForeColor = Color.White;
            btnTile8.Location = new Point(537, 180);
            btnTile8.Margin = new Padding(3, 4, 3, 4);
            btnTile8.Name = "btnTile8";
            btnTile8.Size = new Size(143, 113);
            btnTile8.TabIndex = 7;
            btnTile8.Text = "?";
            btnTile8.UseVisualStyleBackColor = false;
            // 
            // btnTile9
            // 
            btnTile9.BackColor = Color.FromArgb(15, 23, 40);
            btnTile9.Cursor = Cursors.Hand;
            btnTile9.FlatAppearance.BorderSize = 0;
            btnTile9.FlatStyle = FlatStyle.Flat;
            btnTile9.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnTile9.ForeColor = Color.White;
            btnTile9.Location = new Point(40, 320);
            btnTile9.Margin = new Padding(3, 4, 3, 4);
            btnTile9.Name = "btnTile9";
            btnTile9.Size = new Size(143, 113);
            btnTile9.TabIndex = 8;
            btnTile9.Text = "?";
            btnTile9.UseVisualStyleBackColor = false;
            // 
            // btnTile10
            // 
            btnTile10.BackColor = Color.FromArgb(15, 23, 40);
            btnTile10.Cursor = Cursors.Hand;
            btnTile10.FlatAppearance.BorderSize = 0;
            btnTile10.FlatStyle = FlatStyle.Flat;
            btnTile10.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnTile10.ForeColor = Color.White;
            btnTile10.Location = new Point(206, 320);
            btnTile10.Margin = new Padding(3, 4, 3, 4);
            btnTile10.Name = "btnTile10";
            btnTile10.Size = new Size(143, 113);
            btnTile10.TabIndex = 9;
            btnTile10.Text = "?";
            btnTile10.UseVisualStyleBackColor = false;
            // 
            // btnTile11
            // 
            btnTile11.BackColor = Color.FromArgb(15, 23, 40);
            btnTile11.Cursor = Cursors.Hand;
            btnTile11.FlatAppearance.BorderSize = 0;
            btnTile11.FlatStyle = FlatStyle.Flat;
            btnTile11.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnTile11.ForeColor = Color.White;
            btnTile11.Location = new Point(371, 320);
            btnTile11.Margin = new Padding(3, 4, 3, 4);
            btnTile11.Name = "btnTile11";
            btnTile11.Size = new Size(143, 113);
            btnTile11.TabIndex = 10;
            btnTile11.Text = "?";
            btnTile11.UseVisualStyleBackColor = false;
            // 
            // btnTile12
            // 
            btnTile12.BackColor = Color.FromArgb(15, 23, 40);
            btnTile12.Cursor = Cursors.Hand;
            btnTile12.FlatAppearance.BorderSize = 0;
            btnTile12.FlatStyle = FlatStyle.Flat;
            btnTile12.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnTile12.ForeColor = Color.White;
            btnTile12.Location = new Point(537, 320);
            btnTile12.Margin = new Padding(3, 4, 3, 4);
            btnTile12.Name = "btnTile12";
            btnTile12.Size = new Size(143, 113);
            btnTile12.TabIndex = 11;
            btnTile12.Text = "?";
            btnTile12.UseVisualStyleBackColor = false;
            // 
            // btnTile13
            // 
            btnTile13.BackColor = Color.FromArgb(15, 23, 40);
            btnTile13.Cursor = Cursors.Hand;
            btnTile13.FlatAppearance.BorderSize = 0;
            btnTile13.FlatStyle = FlatStyle.Flat;
            btnTile13.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnTile13.ForeColor = Color.White;
            btnTile13.Location = new Point(40, 460);
            btnTile13.Margin = new Padding(3, 4, 3, 4);
            btnTile13.Name = "btnTile13";
            btnTile13.Size = new Size(143, 113);
            btnTile13.TabIndex = 12;
            btnTile13.Text = "?";
            btnTile13.UseVisualStyleBackColor = false;
            // 
            // btnTile14
            // 
            btnTile14.BackColor = Color.FromArgb(15, 23, 40);
            btnTile14.Cursor = Cursors.Hand;
            btnTile14.FlatAppearance.BorderSize = 0;
            btnTile14.FlatStyle = FlatStyle.Flat;
            btnTile14.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnTile14.ForeColor = Color.White;
            btnTile14.Location = new Point(206, 460);
            btnTile14.Margin = new Padding(3, 4, 3, 4);
            btnTile14.Name = "btnTile14";
            btnTile14.Size = new Size(143, 113);
            btnTile14.TabIndex = 13;
            btnTile14.Text = "?";
            btnTile14.UseVisualStyleBackColor = false;
            // 
            // btnTile15
            // 
            btnTile15.BackColor = Color.FromArgb(15, 23, 40);
            btnTile15.Cursor = Cursors.Hand;
            btnTile15.FlatAppearance.BorderSize = 0;
            btnTile15.FlatStyle = FlatStyle.Flat;
            btnTile15.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnTile15.ForeColor = Color.White;
            btnTile15.Location = new Point(371, 460);
            btnTile15.Margin = new Padding(3, 4, 3, 4);
            btnTile15.Name = "btnTile15";
            btnTile15.Size = new Size(143, 113);
            btnTile15.TabIndex = 14;
            btnTile15.Text = "?";
            btnTile15.UseVisualStyleBackColor = false;
            // 
            // btnTile16
            // 
            btnTile16.BackColor = Color.FromArgb(15, 23, 40);
            btnTile16.Cursor = Cursors.Hand;
            btnTile16.FlatAppearance.BorderSize = 0;
            btnTile16.FlatStyle = FlatStyle.Flat;
            btnTile16.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnTile16.ForeColor = Color.White;
            btnTile16.Location = new Point(537, 460);
            btnTile16.Margin = new Padding(3, 4, 3, 4);
            btnTile16.Name = "btnTile16";
            btnTile16.Size = new Size(143, 113);
            btnTile16.TabIndex = 15;
            btnTile16.Text = "?";
            btnTile16.UseVisualStyleBackColor = false;
            // 
            // pnlInfo
            // 
            pnlInfo.BackColor = Color.FromArgb(20, 28, 44);
            pnlInfo.Controls.Add(lblMovesCaption);
            pnlInfo.Controls.Add(lblMoves);
            pnlInfo.Controls.Add(lblPairsCaption);
            pnlInfo.Controls.Add(lblPairs);
            pnlInfo.Controls.Add(lblMemoryStatus);
            pnlInfo.Controls.Add(btnRestart);
            pnlInfo.Location = new Point(806, 207);
            pnlInfo.Margin = new Padding(3, 4, 3, 4);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(371, 647);
            pnlInfo.TabIndex = 5;
            // 
            // lblMovesCaption
            // 
            lblMovesCaption.BackColor = Color.Transparent;
            lblMovesCaption.Font = new Font("Segoe UI", 10F);
            lblMovesCaption.ForeColor = Color.FromArgb(150, 160, 180);
            lblMovesCaption.Location = new Point(29, 47);
            lblMovesCaption.Name = "lblMovesCaption";
            lblMovesCaption.Size = new Size(309, 33);
            lblMovesCaption.TabIndex = 0;
            lblMovesCaption.Text = "Moves";
            // 
            // lblMoves
            // 
            lblMoves.BackColor = Color.Transparent;
            lblMoves.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblMoves.ForeColor = Color.White;
            lblMoves.Location = new Point(29, 84);
            lblMoves.Name = "lblMoves";
            lblMoves.Size = new Size(309, 56);
            lblMoves.TabIndex = 1;
            lblMoves.Text = "0";
            // 
            // lblPairsCaption
            // 
            lblPairsCaption.BackColor = Color.Transparent;
            lblPairsCaption.Font = new Font("Segoe UI", 10F);
            lblPairsCaption.ForeColor = Color.FromArgb(150, 160, 180);
            lblPairsCaption.Location = new Point(29, 173);
            lblPairsCaption.Name = "lblPairsCaption";
            lblPairsCaption.Size = new Size(309, 33);
            lblPairsCaption.TabIndex = 2;
            lblPairsCaption.Text = "Pairs found";
            // 
            // lblPairs
            // 
            lblPairs.BackColor = Color.Transparent;
            lblPairs.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblPairs.ForeColor = Color.White;
            lblPairs.Location = new Point(29, 211);
            lblPairs.Name = "lblPairs";
            lblPairs.Size = new Size(309, 56);
            lblPairs.TabIndex = 3;
            lblPairs.Text = "0 / 8";
            // 
            // lblMemoryStatus
            // 
            lblMemoryStatus.BackColor = Color.Transparent;
            lblMemoryStatus.Font = new Font("Segoe UI", 11F);
            lblMemoryStatus.ForeColor = Color.FromArgb(150, 160, 180);
            lblMemoryStatus.Location = new Point(29, 300);
            lblMemoryStatus.Name = "lblMemoryStatus";
            lblMemoryStatus.Size = new Size(309, 93);
            lblMemoryStatus.TabIndex = 4;
            lblMemoryStatus.Text = "Select two tiles to find a matching pair.";
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.FromArgb(92, 63, 235);
            btnRestart.Cursor = Cursors.Hand;
            btnRestart.FlatAppearance.BorderSize = 0;
            btnRestart.FlatStyle = FlatStyle.Flat;
            btnRestart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRestart.ForeColor = Color.White;
            btnRestart.Location = new Point(29, 520);
            btnRestart.Margin = new Padding(3, 4, 3, 4);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(314, 60);
            btnRestart.TabIndex = 5;
            btnRestart.Text = "RESTART BOARD";
            btnRestart.UseVisualStyleBackColor = false;
            // 
            // frmMemoryTiles
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
            Name = "frmMemoryTiles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameHub — Memory Tiles";
            pnlBoard.ResumeLayout(false);
            pnlInfo.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Label lblBack;
        private Label lblIcon;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlBoard;
        private Panel pnlInfo;
        private Button btnTile1;
        private Button btnTile2;
        private Button btnTile3;
        private Button btnTile4;
        private Button btnTile5;
        private Button btnTile6;
        private Button btnTile7;
        private Button btnTile8;
        private Button btnTile9;
        private Button btnTile10;
        private Button btnTile11;
        private Button btnTile12;
        private Button btnTile13;
        private Button btnTile14;
        private Button btnTile15;
        private Button btnTile16;
        private Label lblMovesCaption;
        private Label lblMoves;
        private Label lblPairsCaption;
        private Label lblPairs;
        private Label lblMemoryStatus;
        private Button btnRestart;
    }
}
