namespace Assignment1_Kailan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGreen = new Button();
            btnOrange = new Button();
            btnPurple = new Button();
            btnBlue = new Button();
            btnStart = new Button();
            btnResetGame = new Button();
            txtHighScoreList = new TextBox();
            label1 = new Label();
            lblResult = new Label();
            lblYourScore = new Label();
            lblCurrentHighScore = new Label();
            lblNewHighScore = new Label();
            SuspendLayout();
            // 
            // btnGreen
            // 
            btnGreen.BackColor = Color.ForestGreen;
            btnGreen.Location = new Point(94, 103);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(73, 66);
            btnGreen.TabIndex = 1;
            btnGreen.UseVisualStyleBackColor = false;
            btnGreen.Click += btnColours_Click;
            btnGreen.MouseDown += btnColours_MouseDown;
            btnGreen.MouseUp += btnColours_MouseUp;
            // 
            // btnOrange
            // 
            btnOrange.BackColor = Color.OrangeRed;
            btnOrange.Location = new Point(173, 103);
            btnOrange.Name = "btnOrange";
            btnOrange.Size = new Size(73, 66);
            btnOrange.TabIndex = 2;
            btnOrange.UseVisualStyleBackColor = false;
            btnOrange.Click += btnColours_Click;
            btnOrange.MouseDown += btnColours_MouseDown;
            btnOrange.MouseUp += btnColours_MouseUp;
            // 
            // btnPurple
            // 
            btnPurple.BackColor = Color.Indigo;
            btnPurple.Location = new Point(252, 103);
            btnPurple.Name = "btnPurple";
            btnPurple.Size = new Size(73, 66);
            btnPurple.TabIndex = 3;
            btnPurple.UseVisualStyleBackColor = false;
            btnPurple.Click += btnColours_Click;
            btnPurple.MouseDown += btnColours_MouseDown;
            btnPurple.MouseUp += btnColours_MouseUp;
            // 
            // btnBlue
            // 
            btnBlue.BackColor = Color.RoyalBlue;
            btnBlue.FlatAppearance.BorderColor = Color.MidnightBlue;
            btnBlue.Location = new Point(15, 103);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(73, 66);
            btnBlue.TabIndex = 4;
            btnBlue.UseVisualStyleBackColor = false;
            btnBlue.Click += btnColours_Click;
            btnBlue.MouseDown += btnColours_MouseDown;
            btnBlue.MouseUp += btnColours_MouseUp;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(15, 62);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(139, 23);
            btnStart.TabIndex = 5;
            btnStart.Text = "Show Next Sequence";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnShowNextSequence_Click;
            // 
            // btnResetGame
            // 
            btnResetGame.Location = new Point(236, 62);
            btnResetGame.Name = "btnResetGame";
            btnResetGame.Size = new Size(89, 23);
            btnResetGame.TabIndex = 6;
            btnResetGame.Text = "Reset Game";
            btnResetGame.UseVisualStyleBackColor = true;
            btnResetGame.Click += btnResetGame_Click;
            // 
            // txtHighScoreList
            // 
            txtHighScoreList.Location = new Point(359, 29);
            txtHighScoreList.Multiline = true;
            txtHighScoreList.Name = "txtHighScoreList";
            txtHighScoreList.ScrollBars = ScrollBars.Horizontal;
            txtHighScoreList.Size = new Size(183, 171);
            txtHighScoreList.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 11);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 12;
            label1.Text = "High Scores";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(15, 188);
            lblResult.MaximumSize = new Size(250, 30);
            lblResult.MinimumSize = new Size(250, 30);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(250, 30);
            lblResult.TabIndex = 13;
            lblResult.Text = "Result: ";
            // 
            // lblYourScore
            // 
            lblYourScore.AutoSize = true;
            lblYourScore.Location = new Point(15, 218);
            lblYourScore.Name = "lblYourScore";
            lblYourScore.Size = new Size(66, 15);
            lblYourScore.TabIndex = 14;
            lblYourScore.Text = "Your Score:";
            // 
            // lblCurrentHighScore
            // 
            lblCurrentHighScore.AutoSize = true;
            lblCurrentHighScore.Location = new Point(15, 13);
            lblCurrentHighScore.Name = "lblCurrentHighScore";
            lblCurrentHighScore.Size = new Size(71, 15);
            lblCurrentHighScore.TabIndex = 15;
            lblCurrentHighScore.Text = "High Score: ";
            // 
            // lblNewHighScore
            // 
            lblNewHighScore.AutoSize = true;
            lblNewHighScore.Location = new Point(15, 247);
            lblNewHighScore.Name = "lblNewHighScore";
            lblNewHighScore.Size = new Size(0, 15);
            lblNewHighScore.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 284);
            Controls.Add(lblNewHighScore);
            Controls.Add(lblCurrentHighScore);
            Controls.Add(lblYourScore);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Controls.Add(txtHighScoreList);
            Controls.Add(btnResetGame);
            Controls.Add(btnStart);
            Controls.Add(btnBlue);
            Controls.Add(btnPurple);
            Controls.Add(btnOrange);
            Controls.Add(btnGreen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGreen;
        private Button btnOrange;
        private Button btnPurple;
        private Button btnBlue;
        private Button btnStart;
        private Button btnResetGame;
        private TextBox txtHighScoreList;
        private Label label1;
        private Label lblResult;
        private Label lblYourScore;
        private Label lblCurrentHighScore;
        private Label lblNewHighScore;
    }
}
