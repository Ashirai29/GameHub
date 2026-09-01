using System.Drawing;
using System.Windows.Forms;

namespace GameHub
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        // =========================================================
        // MAIN LAYOUT
        // =========================================================

        private Panel pnlSidebar;
        private Panel pnlMain;
        private Panel pnlGamesArea;

        // =========================================================
        // SIDEBAR
        // =========================================================

        private Label lblLogoIcon;
        private Label lblLogo;
        private Label lblTagline;

        private Button btnHome;
        private Button btnAllGames;
        private Button btnFavorites;
        private Button btnHighScores;
        private Button btnAchievements;
        private Button btnSettings;
        private Button btnAbout;
        private Button btnExit;

        private Panel pnlProfile;
        private Label lblAvatar;
        private Label lblPlayerName;
        private Label lblPlayerLevel;

        // =========================================================
        // HEADER
        // =========================================================

        private Label lblWelcome;
        private Label lblWelcomeSubtitle;

        private Panel pnlSearch;
        private TextBox txtSearch;
        private Label lblSearchIcon;

        private Label lblGamesLibrary;
        private Label lblGamesCount;

        // =========================================================
        // GAME 1 - GUESS THE NUMBER
        // =========================================================

        private Panel pnlGuessNumber;
        private Panel pnlGuessAccent;
        private Label lblGuessIcon;
        private Label lblGuessTitle;
        private Label lblGuessDescription;
        private Label lblGuessDifficulty;
        private Button btnPlayGuessNumber;

        // =========================================================
        // GAME 2 - MEMORY TILES
        // =========================================================

        private Panel pnlMemoryTiles;
        private Panel pnlMemoryAccent;
        private Label lblMemoryIcon;
        private Label lblMemoryTitle;
        private Label lblMemoryDescription;
        private Label lblMemoryDifficulty;
        private Button btnPlayMemoryTiles;

        // =========================================================
        // GAME 3 - MATH CHALLENGE
        // =========================================================

        private Panel pnlMathChallenge;
        private Panel pnlMathAccent;
        private Label lblMathIcon;
        private Label lblMathTitle;
        private Label lblMathDescription;
        private Label lblMathDifficulty;
        private Button btnPlayMathChallenge;

        // =========================================================
        // GAME 4 - TIC TAC TOE
        // =========================================================

        private Panel pnlTicTacToe;
        private Panel pnlTicAccent;
        private Label lblTicIcon;
        private Label lblTicTitle;
        private Label lblTicDescription;
        private Label lblTicDifficulty;
        private Button btnPlayTicTacToe;

        // =========================================================
        // GAME 5 - WORD SCRAMBLE
        // =========================================================

        private Panel pnlWordScramble;
        private Panel pnlWordAccent;
        private Label lblWordIcon;
        private Label lblWordTitle;
        private Label lblWordDescription;
        private Label lblWordDifficulty;
        private Button btnPlayWordScramble;

        // =========================================================
        // GAME 6 - BUBBLE POPPER
        // =========================================================

        private Panel pnlBubblePopper;
        private Panel pnlBubbleAccent;
        private Label lblBubbleIcon;
        private Label lblBubbleTitle;
        private Label lblBubbleDescription;
        private Label lblBubbleDifficulty;
        private Button btnPlayBubblePopper;

        // =========================================================
        // GAME 7 - SNAKE
        // =========================================================

        private Panel pnlSnake;
        private Panel pnlSnakeAccent;
        private Label lblSnakeIcon;
        private Label lblSnakeTitle;
        private Label lblSnakeDescription;
        private Label lblSnakeDifficulty;
        private Button btnPlaySnake;

        // =========================================================
        // GAME 8 - HANGMAN
        // =========================================================

        private Panel pnlHangman;
        private Panel pnlHangmanAccent;
        private Label lblHangmanIcon;
        private Label lblHangmanTitle;
        private Label lblHangmanDescription;
        private Label lblHangmanDifficulty;
        private Button btnPlayHangman;

        // =========================================================
        // GAME 9 - SIMON SAYS
        // =========================================================

        private Panel pnlSimonSays;
        private Panel pnlSimonAccent;
        private Label lblSimonIcon;
        private Label lblSimonTitle;
        private Label lblSimonDescription;
        private Label lblSimonDifficulty;
        private Button btnPlaySimonSays;

        // =========================================================
        // GAME 10 - REACTION TIME
        // =========================================================

        private Panel pnlReactionTime;
        private Panel pnlReactionAccent;
        private Label lblReactionIcon;
        private Label lblReactionTitle;
        private Label lblReactionDescription;
        private Label lblReactionDifficulty;
        private Button btnPlayReactionTime;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            lblLogoIcon = new Label();
            lblLogo = new Label();
            lblTagline = new Label();
            btnHome = new Button();
            btnAllGames = new Button();
            btnFavorites = new Button();
            btnHighScores = new Button();
            btnAchievements = new Button();
            btnSettings = new Button();
            btnAbout = new Button();
            btnExit = new Button();
            pnlProfile = new Panel();
            lblAvatar = new Label();
            lblPlayerName = new Label();
            lblPlayerLevel = new Label();
            pnlMain = new Panel();
            lblWelcome = new Label();
            lblWelcomeSubtitle = new Label();
            pnlSearch = new Panel();
            txtSearch = new TextBox();
            lblSearchIcon = new Label();
            lblGamesLibrary = new Label();
            lblGamesCount = new Label();
            pnlGamesArea = new Panel();
            pnlGuessNumber = new Panel();
            pnlGuessAccent = new Panel();
            lblGuessIcon = new Label();
            lblGuessTitle = new Label();
            lblGuessDescription = new Label();
            lblGuessDifficulty = new Label();
            btnPlayGuessNumber = new Button();
            pnlMemoryTiles = new Panel();
            pnlMemoryAccent = new Panel();
            lblMemoryIcon = new Label();
            lblMemoryTitle = new Label();
            lblMemoryDescription = new Label();
            lblMemoryDifficulty = new Label();
            btnPlayMemoryTiles = new Button();
            pnlMathChallenge = new Panel();
            pnlMathAccent = new Panel();
            lblMathIcon = new Label();
            lblMathTitle = new Label();
            lblMathDescription = new Label();
            lblMathDifficulty = new Label();
            btnPlayMathChallenge = new Button();
            pnlTicTacToe = new Panel();
            pnlTicAccent = new Panel();
            lblTicIcon = new Label();
            lblTicTitle = new Label();
            lblTicDescription = new Label();
            lblTicDifficulty = new Label();
            btnPlayTicTacToe = new Button();
            pnlWordScramble = new Panel();
            pnlWordAccent = new Panel();
            lblWordIcon = new Label();
            lblWordTitle = new Label();
            lblWordDescription = new Label();
            lblWordDifficulty = new Label();
            btnPlayWordScramble = new Button();
            pnlBubblePopper = new Panel();
            pnlBubbleAccent = new Panel();
            lblBubbleIcon = new Label();
            lblBubbleTitle = new Label();
            lblBubbleDescription = new Label();
            lblBubbleDifficulty = new Label();
            btnPlayBubblePopper = new Button();
            pnlSnake = new Panel();
            pnlSnakeAccent = new Panel();
            lblSnakeIcon = new Label();
            lblSnakeTitle = new Label();
            lblSnakeDescription = new Label();
            lblSnakeDifficulty = new Label();
            btnPlaySnake = new Button();
            pnlHangman = new Panel();
            pnlHangmanAccent = new Panel();
            lblHangmanIcon = new Label();
            lblHangmanTitle = new Label();
            lblHangmanDescription = new Label();
            lblHangmanDifficulty = new Label();
            btnPlayHangman = new Button();
            pnlSimonSays = new Panel();
            pnlSimonAccent = new Panel();
            lblSimonIcon = new Label();
            lblSimonTitle = new Label();
            lblSimonDescription = new Label();
            lblSimonDifficulty = new Label();
            btnPlaySimonSays = new Button();
            pnlReactionTime = new Panel();
            pnlReactionAccent = new Panel();
            lblReactionIcon = new Label();
            lblReactionTitle = new Label();
            lblReactionDescription = new Label();
            lblReactionDifficulty = new Label();
            btnPlayReactionTime = new Button();
            pnlSidebar.SuspendLayout();
            pnlProfile.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlSearch.SuspendLayout();
            pnlGamesArea.SuspendLayout();
            pnlGuessNumber.SuspendLayout();
            pnlMemoryTiles.SuspendLayout();
            pnlMathChallenge.SuspendLayout();
            pnlTicTacToe.SuspendLayout();
            pnlWordScramble.SuspendLayout();
            pnlBubblePopper.SuspendLayout();
            pnlSnake.SuspendLayout();
            pnlHangman.SuspendLayout();
            pnlSimonSays.SuspendLayout();
            pnlReactionTime.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlSidebar.BackColor = Color.FromArgb(10, 17, 30);
            pnlSidebar.Controls.Add(lblLogoIcon);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Controls.Add(lblTagline);
            pnlSidebar.Controls.Add(btnHome);
            pnlSidebar.Controls.Add(btnAllGames);
            pnlSidebar.Controls.Add(btnFavorites);
            pnlSidebar.Controls.Add(btnHighScores);
            pnlSidebar.Controls.Add(btnAchievements);
            pnlSidebar.Controls.Add(btnSettings);
            pnlSidebar.Controls.Add(btnAbout);
            pnlSidebar.Controls.Add(btnExit);
            pnlSidebar.Controls.Add(pnlProfile);
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(3, 4, 3, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(263, 1133);
            pnlSidebar.TabIndex = 0;
            // 
            // lblLogoIcon
            // 
            lblLogoIcon.Font = new Font("Segoe UI Emoji", 32F);
            lblLogoIcon.ForeColor = Color.FromArgb(109, 83, 255);
            lblLogoIcon.Location = new Point(17, 27);
            lblLogoIcon.Name = "lblLogoIcon";
            lblLogoIcon.Size = new Size(229, 73);
            lblLogoIcon.TabIndex = 0;
            lblLogoIcon.Text = "🎮";
            lblLogoIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLogo
            // 
            lblLogo.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(17, 96);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(229, 53);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "GameHub";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTagline
            // 
            lblTagline.Font = new Font("Segoe UI", 9F);
            lblTagline.ForeColor = Color.FromArgb(145, 155, 175);
            lblTagline.Location = new Point(17, 149);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(229, 32);
            lblTagline.TabIndex = 2;
            lblTagline.Text = "Play. Challenge. Enjoy.";
            lblTagline.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(92, 63, 235);
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10F);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(19, 220);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(17, 0, 0, 0);
            btnHome.Size = new Size(223, 56);
            btnHome.TabIndex = 3;
            btnHome.Text = "⌂     Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnAllGames
            // 
            btnAllGames.BackColor = Color.FromArgb(10, 17, 30);
            btnAllGames.Cursor = Cursors.Hand;
            btnAllGames.FlatAppearance.BorderSize = 0;
            btnAllGames.FlatStyle = FlatStyle.Flat;
            btnAllGames.Font = new Font("Segoe UI", 10F);
            btnAllGames.ForeColor = Color.White;
            btnAllGames.Location = new Point(19, 284);
            btnAllGames.Margin = new Padding(3, 4, 3, 4);
            btnAllGames.Name = "btnAllGames";
            btnAllGames.Padding = new Padding(17, 0, 0, 0);
            btnAllGames.Size = new Size(223, 56);
            btnAllGames.TabIndex = 4;
            btnAllGames.Text = "▦     All Games";
            btnAllGames.TextAlign = ContentAlignment.MiddleLeft;
            btnAllGames.UseVisualStyleBackColor = false;
            // 
            // btnFavorites
            // 
            btnFavorites.BackColor = Color.FromArgb(10, 17, 30);
            btnFavorites.Cursor = Cursors.Hand;
            btnFavorites.FlatAppearance.BorderSize = 0;
            btnFavorites.FlatStyle = FlatStyle.Flat;
            btnFavorites.Font = new Font("Segoe UI", 10F);
            btnFavorites.ForeColor = Color.White;
            btnFavorites.Location = new Point(19, 348);
            btnFavorites.Margin = new Padding(3, 4, 3, 4);
            btnFavorites.Name = "btnFavorites";
            btnFavorites.Padding = new Padding(17, 0, 0, 0);
            btnFavorites.Size = new Size(223, 56);
            btnFavorites.TabIndex = 5;
            btnFavorites.Text = "♡     Favorites";
            btnFavorites.TextAlign = ContentAlignment.MiddleLeft;
            btnFavorites.UseVisualStyleBackColor = false;
            // 
            // btnHighScores
            // 
            btnHighScores.BackColor = Color.FromArgb(10, 17, 30);
            btnHighScores.Cursor = Cursors.Hand;
            btnHighScores.FlatAppearance.BorderSize = 0;
            btnHighScores.FlatStyle = FlatStyle.Flat;
            btnHighScores.Font = new Font("Segoe UI", 10F);
            btnHighScores.ForeColor = Color.White;
            btnHighScores.Location = new Point(19, 412);
            btnHighScores.Margin = new Padding(3, 4, 3, 4);
            btnHighScores.Name = "btnHighScores";
            btnHighScores.Padding = new Padding(17, 0, 0, 0);
            btnHighScores.Size = new Size(223, 56);
            btnHighScores.TabIndex = 6;
            btnHighScores.Text = "🏆    High Scores";
            btnHighScores.TextAlign = ContentAlignment.MiddleLeft;
            btnHighScores.UseVisualStyleBackColor = false;
            // 
            // btnAchievements
            // 
            btnAchievements.BackColor = Color.FromArgb(10, 17, 30);
            btnAchievements.Cursor = Cursors.Hand;
            btnAchievements.FlatAppearance.BorderSize = 0;
            btnAchievements.FlatStyle = FlatStyle.Flat;
            btnAchievements.Font = new Font("Segoe UI", 10F);
            btnAchievements.ForeColor = Color.White;
            btnAchievements.Location = new Point(19, 476);
            btnAchievements.Margin = new Padding(3, 4, 3, 4);
            btnAchievements.Name = "btnAchievements";
            btnAchievements.Padding = new Padding(17, 0, 0, 0);
            btnAchievements.Size = new Size(223, 56);
            btnAchievements.TabIndex = 7;
            btnAchievements.Text = "★     Achievements";
            btnAchievements.TextAlign = ContentAlignment.MiddleLeft;
            btnAchievements.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(10, 17, 30);
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 10F);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(19, 553);
            btnSettings.Margin = new Padding(3, 4, 3, 4);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(17, 0, 0, 0);
            btnSettings.Size = new Size(223, 56);
            btnSettings.TabIndex = 8;
            btnSettings.Text = "⚙     Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.FromArgb(10, 17, 30);
            btnAbout.Cursor = Cursors.Hand;
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Segoe UI", 10F);
            btnAbout.ForeColor = Color.White;
            btnAbout.Location = new Point(19, 617);
            btnAbout.Margin = new Padding(3, 4, 3, 4);
            btnAbout.Name = "btnAbout";
            btnAbout.Padding = new Padding(17, 0, 0, 0);
            btnAbout.Size = new Size(223, 56);
            btnAbout.TabIndex = 9;
            btnAbout.Text = "ⓘ     About";
            btnAbout.TextAlign = ContentAlignment.MiddleLeft;
            btnAbout.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(10, 17, 30);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10F);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(19, 681);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(17, 0, 0, 0);
            btnExit.Size = new Size(223, 56);
            btnExit.TabIndex = 10;
            btnExit.Text = "\u23fb     Exit";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.UseVisualStyleBackColor = false;
            // 
            // pnlProfile
            // 
            pnlProfile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlProfile.BackColor = Color.FromArgb(20, 28, 44);
            pnlProfile.Controls.Add(lblAvatar);
            pnlProfile.Controls.Add(lblPlayerName);
            pnlProfile.Controls.Add(lblPlayerLevel);
            pnlProfile.Location = new Point(19, 987);
            pnlProfile.Margin = new Padding(3, 4, 3, 4);
            pnlProfile.Name = "pnlProfile";
            pnlProfile.Size = new Size(223, 107);
            pnlProfile.TabIndex = 11;
            // 
            // lblAvatar
            // 
            lblAvatar.Font = new Font("Segoe UI Emoji", 24F);
            lblAvatar.Location = new Point(10, 19);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(57, 67);
            lblAvatar.TabIndex = 0;
            lblAvatar.Text = "👤";
            lblAvatar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPlayerName.ForeColor = Color.White;
            lblPlayerName.Location = new Point(74, 24);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(91, 23);
            lblPlayerName.TabIndex = 1;
            lblPlayerName.Text = "PlayerOne";
            // 
            // lblPlayerLevel
            // 
            lblPlayerLevel.AutoSize = true;
            lblPlayerLevel.Font = new Font("Segoe UI", 8F);
            lblPlayerLevel.ForeColor = Color.FromArgb(145, 155, 175);
            lblPlayerLevel.Location = new Point(74, 57);
            lblPlayerLevel.Name = "lblPlayerLevel";
            lblPlayerLevel.Size = new Size(126, 19);
            lblPlayerLevel.TabIndex = 2;
            lblPlayerLevel.Text = "Level 5  •  1250 XP";
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.BackColor = Color.FromArgb(8, 13, 24);
            pnlMain.Controls.Add(lblWelcome);
            pnlMain.Controls.Add(lblWelcomeSubtitle);
            pnlMain.Controls.Add(pnlSearch);
            pnlMain.Controls.Add(lblGamesLibrary);
            pnlMain.Controls.Add(lblGamesCount);
            pnlMain.Controls.Add(pnlGamesArea);
            pnlMain.Location = new Point(263, 0);
            pnlMain.Margin = new Padding(3, 4, 3, 4);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1394, 1133);
            pnlMain.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(40, 36);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(550, 50);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome back, PlayerOne! 👋";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // lblWelcomeSubtitle
            // 
            lblWelcomeSubtitle.AutoSize = true;
            lblWelcomeSubtitle.Font = new Font("Segoe UI", 10F);
            lblWelcomeSubtitle.ForeColor = Color.FromArgb(145, 155, 175);
            lblWelcomeSubtitle.Location = new Point(43, 96);
            lblWelcomeSubtitle.Name = "lblWelcomeSubtitle";
            lblWelcomeSubtitle.Size = new Size(266, 23);
            lblWelcomeSubtitle.TabIndex = 1;
            lblWelcomeSubtitle.Text = "Choose a game and start playing.";
            // 
            // pnlSearch
            // 
            pnlSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlSearch.BackColor = Color.FromArgb(15, 23, 40);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(lblSearchIcon);
            pnlSearch.Location = new Point(1034, 45);
            pnlSearch.Margin = new Padding(3, 4, 3, 4);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(320, 56);
            pnlSearch.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(15, 23, 40);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.ForeColor = Color.FromArgb(150, 160, 180);
            txtSearch.Location = new Point(17, 15);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(251, 23);
            txtSearch.TabIndex = 0;
            txtSearch.Text = "Search games...";
            // 
            // lblSearchIcon
            // 
            lblSearchIcon.Font = new Font("Segoe UI", 16F);
            lblSearchIcon.ForeColor = Color.White;
            lblSearchIcon.Location = new Point(272, 3);
            lblSearchIcon.Name = "lblSearchIcon";
            lblSearchIcon.Size = new Size(43, 51);
            lblSearchIcon.TabIndex = 1;
            lblSearchIcon.Text = "⌕";
            lblSearchIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGamesLibrary
            // 
            lblGamesLibrary.AutoSize = true;
            lblGamesLibrary.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblGamesLibrary.ForeColor = Color.White;
            lblGamesLibrary.Location = new Point(40, 153);
            lblGamesLibrary.Name = "lblGamesLibrary";
            lblGamesLibrary.Size = new Size(202, 37);
            lblGamesLibrary.TabIndex = 3;
            lblGamesLibrary.Text = "Games Library";
            // 
            // lblGamesCount
            // 
            lblGamesCount.AutoSize = true;
            lblGamesCount.Font = new Font("Segoe UI", 9F);
            lblGamesCount.ForeColor = Color.FromArgb(145, 155, 175);
            lblGamesCount.Location = new Point(43, 199);
            lblGamesCount.Name = "lblGamesCount";
            lblGamesCount.Size = new Size(137, 20);
            lblGamesCount.TabIndex = 4;
            lblGamesCount.Text = "10 games available";
            // 
            // pnlGamesArea
            // 
            pnlGamesArea.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlGamesArea.AutoScroll = true;
            pnlGamesArea.BackColor = Color.FromArgb(8, 13, 24);
            pnlGamesArea.Controls.Add(pnlGuessNumber);
            pnlGamesArea.Controls.Add(pnlMemoryTiles);
            pnlGamesArea.Controls.Add(pnlMathChallenge);
            pnlGamesArea.Controls.Add(pnlTicTacToe);
            pnlGamesArea.Controls.Add(pnlWordScramble);
            pnlGamesArea.Controls.Add(pnlBubblePopper);
            pnlGamesArea.Controls.Add(pnlSnake);
            pnlGamesArea.Controls.Add(pnlHangman);
            pnlGamesArea.Controls.Add(pnlSimonSays);
            pnlGamesArea.Controls.Add(pnlReactionTime);
            pnlGamesArea.Location = new Point(40, 240);
            pnlGamesArea.Margin = new Padding(3, 4, 3, 4);
            pnlGamesArea.Name = "pnlGamesArea";
            pnlGamesArea.Size = new Size(1314, 847);
            pnlGamesArea.TabIndex = 5;
            // 
            // pnlGuessNumber
            // 
            pnlGuessNumber.BackColor = Color.FromArgb(20, 28, 44);
            pnlGuessNumber.Controls.Add(pnlGuessAccent);
            pnlGuessNumber.Controls.Add(lblGuessIcon);
            pnlGuessNumber.Controls.Add(lblGuessTitle);
            pnlGuessNumber.Controls.Add(lblGuessDescription);
            pnlGuessNumber.Controls.Add(lblGuessDifficulty);
            pnlGuessNumber.Controls.Add(btnPlayGuessNumber);
            pnlGuessNumber.Location = new Point(17, 20);
            pnlGuessNumber.Margin = new Padding(3, 4, 3, 4);
            pnlGuessNumber.Name = "pnlGuessNumber";
            pnlGuessNumber.Size = new Size(240, 347);
            pnlGuessNumber.TabIndex = 0;
            // 
            // pnlGuessAccent
            // 
            pnlGuessAccent.BackColor = Color.FromArgb(139, 92, 246);
            pnlGuessAccent.Dock = DockStyle.Top;
            pnlGuessAccent.Location = new Point(0, 0);
            pnlGuessAccent.Margin = new Padding(3, 4, 3, 4);
            pnlGuessAccent.Name = "pnlGuessAccent";
            pnlGuessAccent.Size = new Size(240, 5);
            pnlGuessAccent.TabIndex = 0;
            // 
            // lblGuessIcon
            // 
            lblGuessIcon.Font = new Font("Segoe UI Emoji", 35F);
            lblGuessIcon.Location = new Point(23, 20);
            lblGuessIcon.Name = "lblGuessIcon";
            lblGuessIcon.Size = new Size(194, 80);
            lblGuessIcon.TabIndex = 1;
            lblGuessIcon.Text = "❓";
            lblGuessIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGuessTitle
            // 
            lblGuessTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblGuessTitle.ForeColor = Color.White;
            lblGuessTitle.Location = new Point(17, 109);
            lblGuessTitle.Name = "lblGuessTitle";
            lblGuessTitle.Size = new Size(206, 37);
            lblGuessTitle.TabIndex = 2;
            lblGuessTitle.Text = "Guess the Number";
            // 
            // lblGuessDescription
            // 
            lblGuessDescription.Font = new Font("Segoe UI", 8.5F);
            lblGuessDescription.ForeColor = Color.FromArgb(150, 160, 180);
            lblGuessDescription.Location = new Point(17, 153);
            lblGuessDescription.Name = "lblGuessDescription";
            lblGuessDescription.Size = new Size(206, 67);
            lblGuessDescription.TabIndex = 3;
            lblGuessDescription.Text = "Guess the secret number using higher and lower hints.";
            // 
            // lblGuessDifficulty
            // 
            lblGuessDifficulty.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblGuessDifficulty.ForeColor = Color.FromArgb(150, 125, 255);
            lblGuessDifficulty.Location = new Point(17, 233);
            lblGuessDifficulty.Name = "lblGuessDifficulty";
            lblGuessDifficulty.Size = new Size(206, 27);
            lblGuessDifficulty.TabIndex = 4;
            lblGuessDifficulty.Text = "Easy  •  Logic";
            // 
            // btnPlayGuessNumber
            // 
            btnPlayGuessNumber.BackColor = Color.FromArgb(92, 63, 235);
            btnPlayGuessNumber.Cursor = Cursors.Hand;
            btnPlayGuessNumber.FlatAppearance.BorderSize = 0;
            btnPlayGuessNumber.FlatStyle = FlatStyle.Flat;
            btnPlayGuessNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPlayGuessNumber.ForeColor = Color.White;
            btnPlayGuessNumber.Location = new Point(17, 280);
            btnPlayGuessNumber.Margin = new Padding(3, 4, 3, 4);
            btnPlayGuessNumber.Name = "btnPlayGuessNumber";
            btnPlayGuessNumber.Size = new Size(206, 51);
            btnPlayGuessNumber.TabIndex = 5;
            btnPlayGuessNumber.Text = "PLAY";
            btnPlayGuessNumber.UseVisualStyleBackColor = false;
            // 
            // pnlMemoryTiles
            // 
            pnlMemoryTiles.BackColor = Color.FromArgb(20, 28, 44);
            pnlMemoryTiles.Controls.Add(pnlMemoryAccent);
            pnlMemoryTiles.Controls.Add(lblMemoryIcon);
            pnlMemoryTiles.Controls.Add(lblMemoryTitle);
            pnlMemoryTiles.Controls.Add(lblMemoryDescription);
            pnlMemoryTiles.Controls.Add(lblMemoryDifficulty);
            pnlMemoryTiles.Controls.Add(btnPlayMemoryTiles);
            pnlMemoryTiles.Location = new Point(278, 20);
            pnlMemoryTiles.Margin = new Padding(3, 4, 3, 4);
            pnlMemoryTiles.Name = "pnlMemoryTiles";
            pnlMemoryTiles.Size = new Size(240, 347);
            pnlMemoryTiles.TabIndex = 1;
            // 
            // pnlMemoryAccent
            // 
            pnlMemoryAccent.BackColor = Color.FromArgb(14, 165, 233);
            pnlMemoryAccent.Dock = DockStyle.Top;
            pnlMemoryAccent.Location = new Point(0, 0);
            pnlMemoryAccent.Margin = new Padding(3, 4, 3, 4);
            pnlMemoryAccent.Name = "pnlMemoryAccent";
            pnlMemoryAccent.Size = new Size(240, 5);
            pnlMemoryAccent.TabIndex = 0;
            // 
            // lblMemoryIcon
            // 
            lblMemoryIcon.Font = new Font("Segoe UI Emoji", 35F);
            lblMemoryIcon.Location = new Point(23, 20);
            lblMemoryIcon.Name = "lblMemoryIcon";
            lblMemoryIcon.Size = new Size(194, 80);
            lblMemoryIcon.TabIndex = 1;
            lblMemoryIcon.Text = "\U0001f9e0";
            lblMemoryIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMemoryTitle
            // 
            lblMemoryTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMemoryTitle.ForeColor = Color.White;
            lblMemoryTitle.Location = new Point(17, 109);
            lblMemoryTitle.Name = "lblMemoryTitle";
            lblMemoryTitle.Size = new Size(206, 37);
            lblMemoryTitle.TabIndex = 2;
            lblMemoryTitle.Text = "Memory Tiles";
            // 
            // lblMemoryDescription
            // 
            lblMemoryDescription.Font = new Font("Segoe UI", 8.5F);
            lblMemoryDescription.ForeColor = Color.FromArgb(150, 160, 180);
            lblMemoryDescription.Location = new Point(17, 153);
            lblMemoryDescription.Name = "lblMemoryDescription";
            lblMemoryDescription.Size = new Size(206, 67);
            lblMemoryDescription.TabIndex = 3;
            lblMemoryDescription.Text = "Flip the tiles and find all matching pairs.";
            // 
            // lblMemoryDifficulty
            // 
            lblMemoryDifficulty.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblMemoryDifficulty.ForeColor = Color.FromArgb(64, 190, 255);
            lblMemoryDifficulty.Location = new Point(17, 233);
            lblMemoryDifficulty.Name = "lblMemoryDifficulty";
            lblMemoryDifficulty.Size = new Size(206, 27);
            lblMemoryDifficulty.TabIndex = 4;
            lblMemoryDifficulty.Text = "Medium  •  Memory";
            // 
            // btnPlayMemoryTiles
            // 
            btnPlayMemoryTiles.BackColor = Color.FromArgb(92, 63, 235);
            btnPlayMemoryTiles.Cursor = Cursors.Hand;
            btnPlayMemoryTiles.FlatAppearance.BorderSize = 0;
            btnPlayMemoryTiles.FlatStyle = FlatStyle.Flat;
            btnPlayMemoryTiles.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPlayMemoryTiles.ForeColor = Color.White;
            btnPlayMemoryTiles.Location = new Point(17, 280);
            btnPlayMemoryTiles.Margin = new Padding(3, 4, 3, 4);
            btnPlayMemoryTiles.Name = "btnPlayMemoryTiles";
            btnPlayMemoryTiles.Size = new Size(206, 51);
            btnPlayMemoryTiles.TabIndex = 5;
            btnPlayMemoryTiles.Text = "PLAY";
            btnPlayMemoryTiles.UseVisualStyleBackColor = false;
            // 
            // pnlMathChallenge
            // 
            pnlMathChallenge.BackColor = Color.FromArgb(20, 28, 44);
            pnlMathChallenge.Controls.Add(pnlMathAccent);
            pnlMathChallenge.Controls.Add(lblMathIcon);
            pnlMathChallenge.Controls.Add(lblMathTitle);
            pnlMathChallenge.Controls.Add(lblMathDescription);
            pnlMathChallenge.Controls.Add(lblMathDifficulty);
            pnlMathChallenge.Controls.Add(btnPlayMathChallenge);
            pnlMathChallenge.Location = new Point(538, 20);
            pnlMathChallenge.Margin = new Padding(3, 4, 3, 4);
            pnlMathChallenge.Name = "pnlMathChallenge";
            pnlMathChallenge.Size = new Size(240, 347);
            pnlMathChallenge.TabIndex = 2;
            // 
            // pnlMathAccent
            // 
            pnlMathAccent.BackColor = Color.FromArgb(34, 197, 94);
            pnlMathAccent.Dock = DockStyle.Top;
            pnlMathAccent.Location = new Point(0, 0);
            pnlMathAccent.Margin = new Padding(3, 4, 3, 4);
            pnlMathAccent.Name = "pnlMathAccent";
            pnlMathAccent.Size = new Size(240, 5);
            pnlMathAccent.TabIndex = 0;
            // 
            // lblMathIcon
            // 
            lblMathIcon.Font = new Font("Segoe UI Emoji", 35F);
            lblMathIcon.Location = new Point(23, 20);
            lblMathIcon.Name = "lblMathIcon";
            lblMathIcon.Size = new Size(194, 80);
            lblMathIcon.TabIndex = 1;
            lblMathIcon.Text = "➕";
            lblMathIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMathTitle
            // 
            lblMathTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMathTitle.ForeColor = Color.White;
            lblMathTitle.Location = new Point(17, 109);
            lblMathTitle.Name = "lblMathTitle";
            lblMathTitle.Size = new Size(206, 37);
            lblMathTitle.TabIndex = 2;
            lblMathTitle.Text = "Math Challenge";
            // 
            // lblMathDescription
            // 
            lblMathDescription.Font = new Font("Segoe UI", 8.5F);
            lblMathDescription.ForeColor = Color.FromArgb(150, 160, 180);
            lblMathDescription.Location = new Point(17, 153);
            lblMathDescription.Name = "lblMathDescription";
            lblMathDescription.Size = new Size(206, 67);
            lblMathDescription.TabIndex = 3;
            lblMathDescription.Text = "Solve maths problems before the timer runs out.";
            // 
            // lblMathDifficulty
            // 
            lblMathDifficulty.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblMathDifficulty.ForeColor = Color.FromArgb(34, 197, 94);
            lblMathDifficulty.Location = new Point(17, 233);
            lblMathDifficulty.Name = "lblMathDifficulty";
            lblMathDifficulty.Size = new Size(206, 27);
            lblMathDifficulty.TabIndex = 4;
            lblMathDifficulty.Text = "Medium  •  Maths";
            // 
            // btnPlayMathChallenge
            // 
            btnPlayMathChallenge.BackColor = Color.FromArgb(92, 63, 235);
            btnPlayMathChallenge.Cursor = Cursors.Hand;
            btnPlayMathChallenge.FlatAppearance.BorderSize = 0;
            btnPlayMathChallenge.FlatStyle = FlatStyle.Flat;
            btnPlayMathChallenge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPlayMathChallenge.ForeColor = Color.White;
            btnPlayMathChallenge.Location = new Point(17, 280);
            btnPlayMathChallenge.Margin = new Padding(3, 4, 3, 4);
            btnPlayMathChallenge.Name = "btnPlayMathChallenge";
            btnPlayMathChallenge.Size = new Size(206, 51);
            btnPlayMathChallenge.TabIndex = 5;
            btnPlayMathChallenge.Text = "PLAY";
            btnPlayMathChallenge.UseVisualStyleBackColor = false;
            // 
            // pnlTicTacToe
            // 
            pnlTicTacToe.BackColor = Color.FromArgb(20, 28, 44);
            pnlTicTacToe.Controls.Add(pnlTicAccent);
            pnlTicTacToe.Controls.Add(lblTicIcon);
            pnlTicTacToe.Controls.Add(lblTicTitle);
            pnlTicTacToe.Controls.Add(lblTicDescription);
            pnlTicTacToe.Controls.Add(lblTicDifficulty);
            pnlTicTacToe.Controls.Add(btnPlayTicTacToe);
            pnlTicTacToe.Location = new Point(799, 20);
            pnlTicTacToe.Margin = new Padding(3, 4, 3, 4);
            pnlTicTacToe.Name = "pnlTicTacToe";
            pnlTicTacToe.Size = new Size(240, 347);
            pnlTicTacToe.TabIndex = 3;
            // 
            // pnlTicAccent
            // 
            pnlTicAccent.BackColor = Color.FromArgb(59, 130, 246);
            pnlTicAccent.Dock = DockStyle.Top;
            pnlTicAccent.Location = new Point(0, 0);
            pnlTicAccent.Margin = new Padding(3, 4, 3, 4);
            pnlTicAccent.Name = "pnlTicAccent";
            pnlTicAccent.Size = new Size(240, 5);
            pnlTicAccent.TabIndex = 0;
            // 
            // lblTicIcon
            // 
            lblTicIcon.Font = new Font("Segoe UI Emoji", 35F);
            lblTicIcon.Location = new Point(23, 20);
            lblTicIcon.Name = "lblTicIcon";
            lblTicIcon.Size = new Size(194, 80);
            lblTicIcon.TabIndex = 1;
            lblTicIcon.Text = "⭕";
            lblTicIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTicTitle
            // 
            lblTicTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTicTitle.ForeColor = Color.White;
            lblTicTitle.Location = new Point(17, 109);
            lblTicTitle.Name = "lblTicTitle";
            lblTicTitle.Size = new Size(206, 37);
            lblTicTitle.TabIndex = 2;
            lblTicTitle.Text = "Tic Tac Toe";
            // 
            // lblTicDescription
            // 
            lblTicDescription.Font = new Font("Segoe UI", 8.5F);
            lblTicDescription.ForeColor = Color.FromArgb(150, 160, 180);
            lblTicDescription.Location = new Point(17, 153);
            lblTicDescription.Name = "lblTicDescription";
            lblTicDescription.Size = new Size(206, 67);
            lblTicDescription.TabIndex = 3;
            lblTicDescription.Text = "Classic three-in-a-row strategy game.";
            // 
            // lblTicDifficulty
            // 
            lblTicDifficulty.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTicDifficulty.ForeColor = Color.FromArgb(96, 165, 250);
            lblTicDifficulty.Location = new Point(17, 233);
            lblTicDifficulty.Name = "lblTicDifficulty";
            lblTicDifficulty.Size = new Size(206, 27);
            lblTicDifficulty.TabIndex = 4;
            lblTicDifficulty.Text = "Easy  •  Strategy";
            // 
            // btnPlayTicTacToe
            // 
            btnPlayTicTacToe.BackColor = Color.FromArgb(92, 63, 235);
            btnPlayTicTacToe.Cursor = Cursors.Hand;
            btnPlayTicTacToe.FlatAppearance.BorderSize = 0;
            btnPlayTicTacToe.FlatStyle = FlatStyle.Flat;
            btnPlayTicTacToe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPlayTicTacToe.ForeColor = Color.White;
            btnPlayTicTacToe.Location = new Point(17, 280);
            btnPlayTicTacToe.Margin = new Padding(3, 4, 3, 4);
            btnPlayTicTacToe.Name = "btnPlayTicTacToe";
            btnPlayTicTacToe.Size = new Size(206, 51);
            btnPlayTicTacToe.TabIndex = 5;
            btnPlayTicTacToe.Text = "PLAY";
            btnPlayTicTacToe.UseVisualStyleBackColor = false;
            // 
            // pnlWordScramble
            // 
            pnlWordScramble.BackColor = Color.FromArgb(20, 28, 44);
            pnlWordScramble.Controls.Add(pnlWordAccent);
            pnlWordScramble.Controls.Add(lblWordIcon);
            pnlWordScramble.Controls.Add(lblWordTitle);
            pnlWordScramble.Controls.Add(lblWordDescription);
            pnlWordScramble.Controls.Add(lblWordDifficulty);
            pnlWordScramble.Controls.Add(btnPlayWordScramble);
            pnlWordScramble.Location = new Point(1059, 20);
            pnlWordScramble.Margin = new Padding(3, 4, 3, 4);
            pnlWordScramble.Name = "pnlWordScramble";
            pnlWordScramble.Size = new Size(240, 347);
            pnlWordScramble.TabIndex = 4;
            // 
            // pnlWordAccent
            // 
            pnlWordAccent.BackColor = Color.FromArgb(168, 85, 247);
            pnlWordAccent.Dock = DockStyle.Top;
            pnlWordAccent.Location = new Point(0, 0);
            pnlWordAccent.Margin = new Padding(3, 4, 3, 4);
            pnlWordAccent.Name = "pnlWordAccent";
            pnlWordAccent.Size = new Size(240, 5);
            pnlWordAccent.TabIndex = 0;
            // 
            // lblWordIcon
            // 
            lblWordIcon.Font = new Font("Segoe UI Emoji", 35F);
            lblWordIcon.Location = new Point(23, 20);
            lblWordIcon.Name = "lblWordIcon";
            lblWordIcon.Size = new Size(194, 80);
            lblWordIcon.TabIndex = 1;
            lblWordIcon.Text = "🔤";
            lblWordIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWordTitle
            // 
            lblWordTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblWordTitle.ForeColor = Color.White;
            lblWordTitle.Location = new Point(17, 109);
            lblWordTitle.Name = "lblWordTitle";
            lblWordTitle.Size = new Size(206, 37);
            lblWordTitle.TabIndex = 2;
            lblWordTitle.Text = "Word Scramble";
            // 
            // lblWordDescription
            // 
            lblWordDescription.Font = new Font("Segoe UI", 8.5F);
            lblWordDescription.ForeColor = Color.FromArgb(150, 160, 180);
            lblWordDescription.Location = new Point(17, 153);
            lblWordDescription.Name = "lblWordDescription";
            lblWordDescription.Size = new Size(206, 67);
            lblWordDescription.TabIndex = 3;
            lblWordDescription.Text = "Unscramble letters and discover the hidden word.";
            // 
            // lblWordDifficulty
            // 
            lblWordDifficulty.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblWordDifficulty.ForeColor = Color.FromArgb(192, 132, 252);
            lblWordDifficulty.Location = new Point(17, 233);
            lblWordDifficulty.Name = "lblWordDifficulty";
            lblWordDifficulty.Size = new Size(206, 27);
            lblWordDifficulty.TabIndex = 4;
            lblWordDifficulty.Text = "Medium  •  Words";
            // 
            // btnPlayWordScramble
            // 
            btnPlayWordScramble.BackColor = Color.FromArgb(92, 63, 235);
            btnPlayWordScramble.Cursor = Cursors.Hand;
            btnPlayWordScramble.FlatAppearance.BorderSize = 0;
            btnPlayWordScramble.FlatStyle = FlatStyle.Flat;
            btnPlayWordScramble.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPlayWordScramble.ForeColor = Color.White;
            btnPlayWordScramble.Location = new Point(17, 280);
            btnPlayWordScramble.Margin = new Padding(3, 4, 3, 4);
            btnPlayWordScramble.Name = "btnPlayWordScramble";
            btnPlayWordScramble.Size = new Size(206, 51);
            btnPlayWordScramble.TabIndex = 5;
            btnPlayWordScramble.Text = "PLAY";
            btnPlayWordScramble.UseVisualStyleBackColor = false;
            // 
            // pnlBubblePopper
            // 
            pnlBubblePopper.BackColor = Color.FromArgb(20, 28, 44);
            pnlBubblePopper.Controls.Add(pnlBubbleAccent);
            pnlBubblePopper.Controls.Add(lblBubbleIcon);
            pnlBubblePopper.Controls.Add(lblBubbleTitle);
            pnlBubblePopper.Controls.Add(lblBubbleDescription);
            pnlBubblePopper.Controls.Add(lblBubbleDifficulty);
            pnlBubblePopper.Controls.Add(btnPlayBubblePopper);
            pnlBubblePopper.Location = new Point(17, 393);
            pnlBubblePopper.Margin = new Padding(3, 4, 3, 4);
            pnlBubblePopper.Name = "pnlBubblePopper";
            pnlBubblePopper.Size = new Size(240, 347);
            pnlBubblePopper.TabIndex = 5;
            // 
            // pnlBubbleAccent
            // 
            pnlBubbleAccent.BackColor = Color.FromArgb(239, 68, 68);
            pnlBubbleAccent.Dock = DockStyle.Top;
            pnlBubbleAccent.Location = new Point(0, 0);
            pnlBubbleAccent.Margin = new Padding(3, 4, 3, 4);
            pnlBubbleAccent.Name = "pnlBubbleAccent";
            pnlBubbleAccent.Size = new Size(240, 5);
            pnlBubbleAccent.TabIndex = 0;
            // 
            // lblBubbleIcon
            // 
            lblBubbleIcon.Font = new Font("Segoe UI Emoji", 35F);
            lblBubbleIcon.Location = new Point(23, 20);
            lblBubbleIcon.Name = "lblBubbleIcon";
            lblBubbleIcon.Size = new Size(194, 80);
            lblBubbleIcon.TabIndex = 1;
            lblBubbleIcon.Text = "🔵";
            lblBubbleIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBubbleTitle
            // 
            lblBubbleTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblBubbleTitle.ForeColor = Color.White;
            lblBubbleTitle.Location = new Point(17, 109);
            lblBubbleTitle.Name = "lblBubbleTitle";
            lblBubbleTitle.Size = new Size(206, 37);
            lblBubbleTitle.TabIndex = 2;
            lblBubbleTitle.Text = "Bubble Popper";
            // 
            // lblBubbleDescription
            // 
            lblBubbleDescription.Font = new Font("Segoe UI", 8.5F);
            lblBubbleDescription.ForeColor = Color.FromArgb(150, 160, 180);
            lblBubbleDescription.Location = new Point(17, 153);
            lblBubbleDescription.Name = "lblBubbleDescription";
            lblBubbleDescription.Size = new Size(206, 67);
            lblBubbleDescription.TabIndex = 3;
            lblBubbleDescription.Text = "Pop as many bubbles as possible before time ends.";
            // 
            // lblBubbleDifficulty
            // 
            lblBubbleDifficulty.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblBubbleDifficulty.ForeColor = Color.FromArgb(248, 113, 113);
            lblBubbleDifficulty.Location = new Point(17, 233);
            lblBubbleDifficulty.Name = "lblBubbleDifficulty";
            lblBubbleDifficulty.Size = new Size(206, 27);
            lblBubbleDifficulty.TabIndex = 4;
            lblBubbleDifficulty.Text = "Easy  •  Speed";
            // 
            // btnPlayBubblePopper
            // 
            btnPlayBubblePopper.BackColor = Color.FromArgb(92, 63, 235);
            btnPlayBubblePopper.Cursor = Cursors.Hand;
            btnPlayBubblePopper.FlatAppearance.BorderSize = 0;
            btnPlayBubblePopper.FlatStyle = FlatStyle.Flat;
            btnPlayBubblePopper.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPlayBubblePopper.ForeColor = Color.White;
            btnPlayBubblePopper.Location = new Point(17, 280);
            btnPlayBubblePopper.Margin = new Padding(3, 4, 3, 4);
            btnPlayBubblePopper.Name = "btnPlayBubblePopper";
            btnPlayBubblePopper.Size = new Size(206, 51);
            btnPlayBubblePopper.TabIndex = 5;
            btnPlayBubblePopper.Text = "PLAY";
            btnPlayBubblePopper.UseVisualStyleBackColor = false;
            // 
            // pnlSnake
            // 
            pnlSnake.BackColor = Color.FromArgb(20, 28, 44);
            pnlSnake.Controls.Add(pnlSnakeAccent);
            pnlSnake.Controls.Add(lblSnakeIcon);
            pnlSnake.Controls.Add(lblSnakeTitle);
            pnlSnake.Controls.Add(lblSnakeDescription);
            pnlSnake.Controls.Add(lblSnakeDifficulty);
            pnlSnake.Controls.Add(btnPlaySnake);
            pnlSnake.Location = new Point(278, 393);
            pnlSnake.Margin = new Padding(3, 4, 3, 4);
            pnlSnake.Name = "pnlSnake";
            pnlSnake.Size = new Size(240, 347);
            pnlSnake.TabIndex = 6;
            // 
            // pnlSnakeAccent
            // 
            pnlSnakeAccent.BackColor = Color.FromArgb(34, 197, 94);
            pnlSnakeAccent.Dock = DockStyle.Top;
            pnlSnakeAccent.Location = new Point(0, 0);
            pnlSnakeAccent.Margin = new Padding(3, 4, 3, 4);
            pnlSnakeAccent.Name = "pnlSnakeAccent";
            pnlSnakeAccent.Size = new Size(240, 5);
            pnlSnakeAccent.TabIndex = 0;
            // 
            // lblSnakeIcon
            // 
            lblSnakeIcon.Font = new Font("Segoe UI Emoji", 35F);
            lblSnakeIcon.Location = new Point(23, 20);
            lblSnakeIcon.Name = "lblSnakeIcon";
            lblSnakeIcon.Size = new Size(194, 80);
            lblSnakeIcon.TabIndex = 1;
            lblSnakeIcon.Text = "🐍";
            lblSnakeIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSnakeTitle
            // 
            lblSnakeTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSnakeTitle.ForeColor = Color.White;
            lblSnakeTitle.Location = new Point(17, 109);
            lblSnakeTitle.Name = "lblSnakeTitle";
            lblSnakeTitle.Size = new Size(206, 37);
            lblSnakeTitle.TabIndex = 2;
            lblSnakeTitle.Text = "Snake";
            // 
            // lblSnakeDescription
            // 
            lblSnakeDescription.Font = new Font("Segoe UI", 8.5F);
            lblSnakeDescription.ForeColor = Color.FromArgb(150, 160, 180);
            lblSnakeDescription.Location = new Point(17, 153);
            lblSnakeDescription.Name = "lblSnakeDescription";
            lblSnakeDescription.Size = new Size(206, 67);
            lblSnakeDescription.TabIndex = 3;
            lblSnakeDescription.Text = "Eat food, grow longer and avoid crashing.";
            // 
            // lblSnakeDifficulty
            // 
            lblSnakeDifficulty.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblSnakeDifficulty.ForeColor = Color.FromArgb(74, 222, 128);
            lblSnakeDifficulty.Location = new Point(17, 233);
            lblSnakeDifficulty.Name = "lblSnakeDifficulty";
            lblSnakeDifficulty.Size = new Size(206, 27);
            lblSnakeDifficulty.TabIndex = 4;
            lblSnakeDifficulty.Text = "Hard  •  Arcade";
            // 
            // btnPlaySnake
            // 
            btnPlaySnake.BackColor = Color.FromArgb(92, 63, 235);
            btnPlaySnake.Cursor = Cursors.Hand;
            btnPlaySnake.FlatAppearance.BorderSize = 0;
            btnPlaySnake.FlatStyle = FlatStyle.Flat;
            btnPlaySnake.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPlaySnake.ForeColor = Color.White;
            btnPlaySnake.Location = new Point(17, 280);
            btnPlaySnake.Margin = new Padding(3, 4, 3, 4);
            btnPlaySnake.Name = "btnPlaySnake";
            btnPlaySnake.Size = new Size(206, 51);
            btnPlaySnake.TabIndex = 5;
            btnPlaySnake.Text = "PLAY";
            btnPlaySnake.UseVisualStyleBackColor = false;
            // 
            // pnlHangman
            // 
            pnlHangman.BackColor = Color.FromArgb(20, 28, 44);
            pnlHangman.Controls.Add(pnlHangmanAccent);
            pnlHangman.Controls.Add(lblHangmanIcon);
            pnlHangman.Controls.Add(lblHangmanTitle);
            pnlHangman.Controls.Add(lblHangmanDescription);
            pnlHangman.Controls.Add(lblHangmanDifficulty);
            pnlHangman.Controls.Add(btnPlayHangman);
            pnlHangman.Location = new Point(538, 393);
            pnlHangman.Margin = new Padding(3, 4, 3, 4);
            pnlHangman.Name = "pnlHangman";
            pnlHangman.Size = new Size(240, 347);
            pnlHangman.TabIndex = 7;
            // 
            // pnlHangmanAccent
            // 
            pnlHangmanAccent.BackColor = Color.FromArgb(245, 158, 11);
            pnlHangmanAccent.Dock = DockStyle.Top;
            pnlHangmanAccent.Location = new Point(0, 0);
            pnlHangmanAccent.Margin = new Padding(3, 4, 3, 4);
            pnlHangmanAccent.Name = "pnlHangmanAccent";
            pnlHangmanAccent.Size = new Size(240, 5);
            pnlHangmanAccent.TabIndex = 0;
            // 
            // lblHangmanIcon
            // 
            lblHangmanIcon.Font = new Font("Segoe UI Emoji", 35F);
            lblHangmanIcon.Location = new Point(23, 20);
            lblHangmanIcon.Name = "lblHangmanIcon";
            lblHangmanIcon.Size = new Size(194, 80);
            lblHangmanIcon.TabIndex = 1;
            lblHangmanIcon.Text = "💡";
            lblHangmanIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHangmanTitle
            // 
            lblHangmanTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblHangmanTitle.ForeColor = Color.White;
            lblHangmanTitle.Location = new Point(17, 109);
            lblHangmanTitle.Name = "lblHangmanTitle";
            lblHangmanTitle.Size = new Size(206, 37);
            lblHangmanTitle.TabIndex = 2;
            lblHangmanTitle.Text = "Hangman";
            // 
            // lblHangmanDescription
            // 
            lblHangmanDescription.Font = new Font("Segoe UI", 8.5F);
            lblHangmanDescription.ForeColor = Color.FromArgb(150, 160, 180);
            lblHangmanDescription.Location = new Point(17, 153);
            lblHangmanDescription.Name = "lblHangmanDescription";
            lblHangmanDescription.Size = new Size(206, 67);
            lblHangmanDescription.TabIndex = 3;
            lblHangmanDescription.Text = "Guess the word before your attempts run out.";
            // 
            // lblHangmanDifficulty
            // 
            lblHangmanDifficulty.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblHangmanDifficulty.ForeColor = Color.FromArgb(251, 191, 36);
            lblHangmanDifficulty.Location = new Point(17, 233);
            lblHangmanDifficulty.Name = "lblHangmanDifficulty";
            lblHangmanDifficulty.Size = new Size(206, 27);
            lblHangmanDifficulty.TabIndex = 4;
            lblHangmanDifficulty.Text = "Medium  •  Words";
            // 
            // btnPlayHangman
            // 
            btnPlayHangman.BackColor = Color.FromArgb(92, 63, 235);
            btnPlayHangman.Cursor = Cursors.Hand;
            btnPlayHangman.FlatAppearance.BorderSize = 0;
            btnPlayHangman.FlatStyle = FlatStyle.Flat;
            btnPlayHangman.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPlayHangman.ForeColor = Color.White;
            btnPlayHangman.Location = new Point(17, 280);
            btnPlayHangman.Margin = new Padding(3, 4, 3, 4);
            btnPlayHangman.Name = "btnPlayHangman";
            btnPlayHangman.Size = new Size(206, 51);
            btnPlayHangman.TabIndex = 5;
            btnPlayHangman.Text = "PLAY";
            btnPlayHangman.UseVisualStyleBackColor = false;
            // 
            // pnlSimonSays
            // 
            pnlSimonSays.BackColor = Color.FromArgb(20, 28, 44);
            pnlSimonSays.Controls.Add(pnlSimonAccent);
            pnlSimonSays.Controls.Add(lblSimonIcon);
            pnlSimonSays.Controls.Add(lblSimonTitle);
            pnlSimonSays.Controls.Add(lblSimonDescription);
            pnlSimonSays.Controls.Add(lblSimonDifficulty);
            pnlSimonSays.Controls.Add(btnPlaySimonSays);
            pnlSimonSays.Location = new Point(799, 393);
            pnlSimonSays.Margin = new Padding(3, 4, 3, 4);
            pnlSimonSays.Name = "pnlSimonSays";
            pnlSimonSays.Size = new Size(240, 347);
            pnlSimonSays.TabIndex = 8;
            // 
            // pnlSimonAccent
            // 
            pnlSimonAccent.BackColor = Color.FromArgb(6, 182, 212);
            pnlSimonAccent.Dock = DockStyle.Top;
            pnlSimonAccent.Location = new Point(0, 0);
            pnlSimonAccent.Margin = new Padding(3, 4, 3, 4);
            pnlSimonAccent.Name = "pnlSimonAccent";
            pnlSimonAccent.Size = new Size(240, 5);
            pnlSimonAccent.TabIndex = 0;
            // 
            // lblSimonIcon
            // 
            lblSimonIcon.Font = new Font("Segoe UI Emoji", 35F);
            lblSimonIcon.Location = new Point(23, 20);
            lblSimonIcon.Name = "lblSimonIcon";
            lblSimonIcon.Size = new Size(194, 80);
            lblSimonIcon.TabIndex = 1;
            lblSimonIcon.Text = "🎨";
            lblSimonIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSimonTitle
            // 
            lblSimonTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSimonTitle.ForeColor = Color.White;
            lblSimonTitle.Location = new Point(17, 109);
            lblSimonTitle.Name = "lblSimonTitle";
            lblSimonTitle.Size = new Size(206, 37);
            lblSimonTitle.TabIndex = 2;
            lblSimonTitle.Text = "Simon Says";
            // 
            // lblSimonDescription
            // 
            lblSimonDescription.Font = new Font("Segoe UI", 8.5F);
            lblSimonDescription.ForeColor = Color.FromArgb(150, 160, 180);
            lblSimonDescription.Location = new Point(17, 153);
            lblSimonDescription.Name = "lblSimonDescription";
            lblSimonDescription.Size = new Size(206, 67);
            lblSimonDescription.TabIndex = 3;
            lblSimonDescription.Text = "Remember and repeat the increasingly long pattern.";
            // 
            // lblSimonDifficulty
            // 
            lblSimonDifficulty.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblSimonDifficulty.ForeColor = Color.FromArgb(34, 211, 238);
            lblSimonDifficulty.Location = new Point(17, 233);
            lblSimonDifficulty.Name = "lblSimonDifficulty";
            lblSimonDifficulty.Size = new Size(206, 27);
            lblSimonDifficulty.TabIndex = 4;
            lblSimonDifficulty.Text = "Hard  •  Memory";
            // 
            // btnPlaySimonSays
            // 
            btnPlaySimonSays.BackColor = Color.FromArgb(92, 63, 235);
            btnPlaySimonSays.Cursor = Cursors.Hand;
            btnPlaySimonSays.FlatAppearance.BorderSize = 0;
            btnPlaySimonSays.FlatStyle = FlatStyle.Flat;
            btnPlaySimonSays.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPlaySimonSays.ForeColor = Color.White;
            btnPlaySimonSays.Location = new Point(17, 280);
            btnPlaySimonSays.Margin = new Padding(3, 4, 3, 4);
            btnPlaySimonSays.Name = "btnPlaySimonSays";
            btnPlaySimonSays.Size = new Size(206, 51);
            btnPlaySimonSays.TabIndex = 5;
            btnPlaySimonSays.Text = "PLAY";
            btnPlaySimonSays.UseVisualStyleBackColor = false;
            // 
            // pnlReactionTime
            // 
            pnlReactionTime.BackColor = Color.FromArgb(20, 28, 44);
            pnlReactionTime.Controls.Add(pnlReactionAccent);
            pnlReactionTime.Controls.Add(lblReactionIcon);
            pnlReactionTime.Controls.Add(lblReactionTitle);
            pnlReactionTime.Controls.Add(lblReactionDescription);
            pnlReactionTime.Controls.Add(lblReactionDifficulty);
            pnlReactionTime.Controls.Add(btnPlayReactionTime);
            pnlReactionTime.Location = new Point(1059, 393);
            pnlReactionTime.Margin = new Padding(3, 4, 3, 4);
            pnlReactionTime.Name = "pnlReactionTime";
            pnlReactionTime.Size = new Size(240, 347);
            pnlReactionTime.TabIndex = 9;
            // 
            // pnlReactionAccent
            // 
            pnlReactionAccent.BackColor = Color.FromArgb(139, 92, 246);
            pnlReactionAccent.Dock = DockStyle.Top;
            pnlReactionAccent.Location = new Point(0, 0);
            pnlReactionAccent.Margin = new Padding(3, 4, 3, 4);
            pnlReactionAccent.Name = "pnlReactionAccent";
            pnlReactionAccent.Size = new Size(240, 5);
            pnlReactionAccent.TabIndex = 0;
            // 
            // lblReactionIcon
            // 
            lblReactionIcon.Font = new Font("Segoe UI Emoji", 35F);
            lblReactionIcon.Location = new Point(23, 20);
            lblReactionIcon.Name = "lblReactionIcon";
            lblReactionIcon.Size = new Size(194, 80);
            lblReactionIcon.TabIndex = 1;
            lblReactionIcon.Text = "⚡";
            lblReactionIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblReactionTitle
            // 
            lblReactionTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblReactionTitle.ForeColor = Color.White;
            lblReactionTitle.Location = new Point(17, 109);
            lblReactionTitle.Name = "lblReactionTitle";
            lblReactionTitle.Size = new Size(206, 37);
            lblReactionTitle.TabIndex = 2;
            lblReactionTitle.Text = "Reaction Time";
            // 
            // lblReactionDescription
            // 
            lblReactionDescription.Font = new Font("Segoe UI", 8.5F);
            lblReactionDescription.ForeColor = Color.FromArgb(150, 160, 180);
            lblReactionDescription.Location = new Point(17, 153);
            lblReactionDescription.Name = "lblReactionDescription";
            lblReactionDescription.Size = new Size(206, 67);
            lblReactionDescription.TabIndex = 3;
            lblReactionDescription.Text = "Test how quickly you react when the signal appears.";
            // 
            // lblReactionDifficulty
            // 
            lblReactionDifficulty.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblReactionDifficulty.ForeColor = Color.FromArgb(167, 139, 250);
            lblReactionDifficulty.Location = new Point(17, 233);
            lblReactionDifficulty.Name = "lblReactionDifficulty";
            lblReactionDifficulty.Size = new Size(206, 27);
            lblReactionDifficulty.TabIndex = 4;
            lblReactionDifficulty.Text = "Easy  •  Reflex";
            // 
            // btnPlayReactionTime
            // 
            btnPlayReactionTime.BackColor = Color.FromArgb(92, 63, 235);
            btnPlayReactionTime.Cursor = Cursors.Hand;
            btnPlayReactionTime.FlatAppearance.BorderSize = 0;
            btnPlayReactionTime.FlatStyle = FlatStyle.Flat;
            btnPlayReactionTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPlayReactionTime.ForeColor = Color.White;
            btnPlayReactionTime.Location = new Point(17, 280);
            btnPlayReactionTime.Margin = new Padding(3, 4, 3, 4);
            btnPlayReactionTime.Name = "btnPlayReactionTime";
            btnPlayReactionTime.Size = new Size(206, 51);
            btnPlayReactionTime.TabIndex = 5;
            btnPlayReactionTime.Text = "PLAY";
            btnPlayReactionTime.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 13, 24);
            ClientSize = new Size(1657, 1055);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1369, 944);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameHub";
            pnlSidebar.ResumeLayout(false);
            pnlProfile.ResumeLayout(false);
            pnlProfile.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            pnlGamesArea.ResumeLayout(false);
            pnlGuessNumber.ResumeLayout(false);
            pnlMemoryTiles.ResumeLayout(false);
            pnlMathChallenge.ResumeLayout(false);
            pnlTicTacToe.ResumeLayout(false);
            pnlWordScramble.ResumeLayout(false);
            pnlBubblePopper.ResumeLayout(false);
            pnlSnake.ResumeLayout(false);
            pnlHangman.ResumeLayout(false);
            pnlSimonSays.ResumeLayout(false);
            pnlReactionTime.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}