using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GameHub
{
    partial class frmMathChallenge
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
            pnlQuestion = new Panel();
            lblQuestionNumber = new Label();
            lblEquation = new Label();
            txtAnswer = new TextBox();
            btnSubmitAnswer = new Button();
            lblFeedback = new Label();
            btnStartMath = new Button();
            pnlStats = new Panel();
            lblScoreCaption = new Label();
            lblScore = new Label();
            lblTimeCaption = new Label();
            lblTime = new Label();
            prgTime = new ProgressBar();
            lblCorrectCaption = new Label();
            lblCorrect = new Label();
            pnlQuestion.SuspendLayout();
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
            lblIcon.Text = "➕";
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
            lblTitle.Text = "Math Challenge";
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
            lblSubtitle.Text = "Solve the questions before the clock runs out.";
            // 
            // pnlQuestion
            // 
            pnlQuestion.BackColor = Color.FromArgb(20, 28, 44);
            pnlQuestion.Controls.Add(lblQuestionNumber);
            pnlQuestion.Controls.Add(lblEquation);
            pnlQuestion.Controls.Add(txtAnswer);
            pnlQuestion.Controls.Add(btnSubmitAnswer);
            pnlQuestion.Controls.Add(lblFeedback);
            pnlQuestion.Controls.Add(btnStartMath);
            pnlQuestion.Location = new Point(34, 207);
            pnlQuestion.Margin = new Padding(3, 4, 3, 4);
            pnlQuestion.Name = "pnlQuestion";
            pnlQuestion.Size = new Size(743, 647);
            pnlQuestion.TabIndex = 4;
            // 
            // lblQuestionNumber
            // 
            lblQuestionNumber.BackColor = Color.Transparent;
            lblQuestionNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblQuestionNumber.ForeColor = Color.FromArgb(167, 139, 250);
            lblQuestionNumber.Location = new Point(46, 47);
            lblQuestionNumber.Name = "lblQuestionNumber";
            lblQuestionNumber.Size = new Size(651, 35);
            lblQuestionNumber.TabIndex = 0;
            lblQuestionNumber.Text = "QUESTION 1 OF 10";
            lblQuestionNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEquation
            // 
            lblEquation.BackColor = Color.Transparent;
            lblEquation.Font = new Font("Segoe UI", 34F, FontStyle.Bold);
            lblEquation.ForeColor = Color.White;
            lblEquation.Location = new Point(46, 127);
            lblEquation.Name = "lblEquation";
            lblEquation.Size = new Size(651, 107);
            lblEquation.TabIndex = 1;
            lblEquation.Text = "12  +  8  =  ?";
            lblEquation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAnswer
            // 
            txtAnswer.BackColor = Color.FromArgb(15, 23, 40);
            txtAnswer.BorderStyle = BorderStyle.FixedSingle;
            txtAnswer.Font = new Font("Segoe UI", 11F);
            txtAnswer.ForeColor = Color.FromArgb(150, 160, 180);
            txtAnswer.Location = new Point(177, 273);
            txtAnswer.Margin = new Padding(3, 4, 3, 4);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(388, 32);
            txtAnswer.TabIndex = 2;
            txtAnswer.Text = "Type your answer";
            // 
            // btnSubmitAnswer
            // 
            btnSubmitAnswer.BackColor = Color.FromArgb(92, 63, 235);
            btnSubmitAnswer.Cursor = Cursors.Hand;
            btnSubmitAnswer.FlatAppearance.BorderSize = 0;
            btnSubmitAnswer.FlatStyle = FlatStyle.Flat;
            btnSubmitAnswer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSubmitAnswer.ForeColor = Color.White;
            btnSubmitAnswer.Location = new Point(177, 347);
            btnSubmitAnswer.Margin = new Padding(3, 4, 3, 4);
            btnSubmitAnswer.Name = "btnSubmitAnswer";
            btnSubmitAnswer.Size = new Size(389, 60);
            btnSubmitAnswer.TabIndex = 3;
            btnSubmitAnswer.Text = "SUBMIT ANSWER";
            btnSubmitAnswer.UseVisualStyleBackColor = false;
            // 
            // lblFeedback
            // 
            lblFeedback.BackColor = Color.Transparent;
            lblFeedback.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFeedback.ForeColor = Color.FromArgb(150, 160, 180);
            lblFeedback.Location = new Point(46, 440);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(651, 60);
            lblFeedback.TabIndex = 4;
            lblFeedback.Text = "Your feedback will appear here.";
            lblFeedback.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStartMath
            // 
            btnStartMath.BackColor = Color.FromArgb(15, 23, 40);
            btnStartMath.Cursor = Cursors.Hand;
            btnStartMath.FlatAppearance.BorderSize = 0;
            btnStartMath.FlatStyle = FlatStyle.Flat;
            btnStartMath.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnStartMath.ForeColor = Color.White;
            btnStartMath.Location = new Point(240, 533);
            btnStartMath.Margin = new Padding(3, 4, 3, 4);
            btnStartMath.Name = "btnStartMath";
            btnStartMath.Size = new Size(263, 56);
            btnStartMath.TabIndex = 5;
            btnStartMath.Text = "START NEW ROUND";
            btnStartMath.UseVisualStyleBackColor = false;
            // 
            // pnlStats
            // 
            pnlStats.BackColor = Color.FromArgb(20, 28, 44);
            pnlStats.Controls.Add(lblScoreCaption);
            pnlStats.Controls.Add(lblScore);
            pnlStats.Controls.Add(lblTimeCaption);
            pnlStats.Controls.Add(lblTime);
            pnlStats.Controls.Add(prgTime);
            pnlStats.Controls.Add(lblCorrectCaption);
            pnlStats.Controls.Add(lblCorrect);
            pnlStats.Location = new Point(806, 207);
            pnlStats.Margin = new Padding(3, 4, 3, 4);
            pnlStats.Name = "pnlStats";
            pnlStats.Size = new Size(371, 647);
            pnlStats.TabIndex = 5;
            // 
            // lblScoreCaption
            // 
            lblScoreCaption.BackColor = Color.Transparent;
            lblScoreCaption.Font = new Font("Segoe UI", 10F);
            lblScoreCaption.ForeColor = Color.FromArgb(150, 160, 180);
            lblScoreCaption.Location = new Point(29, 47);
            lblScoreCaption.Name = "lblScoreCaption";
            lblScoreCaption.Size = new Size(309, 33);
            lblScoreCaption.TabIndex = 0;
            lblScoreCaption.Text = "Score";
            // 
            // lblScore
            // 
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblScore.ForeColor = Color.White;
            lblScore.Location = new Point(29, 84);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(309, 56);
            lblScore.TabIndex = 1;
            lblScore.Text = "0";
            // 
            // lblTimeCaption
            // 
            lblTimeCaption.BackColor = Color.Transparent;
            lblTimeCaption.Font = new Font("Segoe UI", 10F);
            lblTimeCaption.ForeColor = Color.FromArgb(150, 160, 180);
            lblTimeCaption.Location = new Point(29, 180);
            lblTimeCaption.Name = "lblTimeCaption";
            lblTimeCaption.Size = new Size(309, 33);
            lblTimeCaption.TabIndex = 2;
            lblTimeCaption.Text = "Time remaining";
            // 
            // lblTime
            // 
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(29, 217);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(309, 56);
            lblTime.TabIndex = 3;
            lblTime.Text = "60 seconds";
            // 
            // prgTime
            // 
            prgTime.Location = new Point(29, 287);
            prgTime.Margin = new Padding(3, 4, 3, 4);
            prgTime.Name = "prgTime";
            prgTime.Size = new Size(314, 21);
            prgTime.Style = ProgressBarStyle.Continuous;
            prgTime.TabIndex = 4;
            prgTime.Value = 100;
            // 
            // lblCorrectCaption
            // 
            lblCorrectCaption.BackColor = Color.Transparent;
            lblCorrectCaption.Font = new Font("Segoe UI", 10F);
            lblCorrectCaption.ForeColor = Color.FromArgb(150, 160, 180);
            lblCorrectCaption.Location = new Point(29, 380);
            lblCorrectCaption.Name = "lblCorrectCaption";
            lblCorrectCaption.Size = new Size(309, 33);
            lblCorrectCaption.TabIndex = 5;
            lblCorrectCaption.Text = "Correct answers";
            // 
            // lblCorrect
            // 
            lblCorrect.BackColor = Color.Transparent;
            lblCorrect.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblCorrect.ForeColor = Color.White;
            lblCorrect.Location = new Point(29, 417);
            lblCorrect.Name = "lblCorrect";
            lblCorrect.Size = new Size(309, 56);
            lblCorrect.TabIndex = 6;
            lblCorrect.Text = "0 / 10";
            // 
            // frmMathChallenge
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 13, 24);
            ClientSize = new Size(1211, 933);
            Controls.Add(lblBack);
            Controls.Add(lblIcon);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(pnlQuestion);
            Controls.Add(pnlStats);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimumSize = new Size(1227, 970);
            Name = "frmMathChallenge";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameHub — Math Challenge";
            pnlQuestion.ResumeLayout(false);
            pnlQuestion.PerformLayout();
            pnlStats.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Label lblBack;
        private Label lblIcon;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlQuestion;
        private Panel pnlStats;
        private Label lblQuestionNumber;
        private Label lblEquation;
        private TextBox txtAnswer;
        private Button btnSubmitAnswer;
        private Label lblFeedback;
        private Button btnStartMath;
        private Label lblScoreCaption;
        private Label lblScore;
        private Label lblTimeCaption;
        private Label lblTime;
        private ProgressBar prgTime;
        private Label lblCorrectCaption;
        private Label lblCorrect;
    }
}
