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
            txtYourSequence = new TextBox();
            lblColourSequence = new Label();
            btnClearYourSequence = new Button();
            btnCheckSequence = new Button();
            txtOutputHelper = new TextBox();
            label1 = new Label();
            lblResult = new Label();
            lblYourScore = new Label();
            label2 = new Label();
            lblHighScore = new Label();
            SuspendLayout();
            // 
            // btnGreen
            // 
            btnGreen.BackColor = Color.ForestGreen;
            btnGreen.Location = new Point(130, 110);
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
            btnOrange.Location = new Point(209, 110);
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
            btnPurple.Location = new Point(288, 110);
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
            btnBlue.Location = new Point(51, 110);
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
            btnStart.Location = new Point(51, 69);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(139, 23);
            btnStart.TabIndex = 5;
            btnStart.Text = "Show Next Sequence";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnShowNextSequence_Click;
            // 
            // btnResetGame
            // 
            btnResetGame.Location = new Point(272, 69);
            btnResetGame.Name = "btnResetGame";
            btnResetGame.Size = new Size(89, 23);
            btnResetGame.TabIndex = 6;
            btnResetGame.Text = "Reset Game";
            btnResetGame.UseVisualStyleBackColor = true;
            btnResetGame.Click += btnResetGame_Click;
            // 
            // txtYourSequence
            // 
            txtYourSequence.Location = new Point(51, 238);
            txtYourSequence.Multiline = true;
            txtYourSequence.Name = "txtYourSequence";
            txtYourSequence.ScrollBars = ScrollBars.Vertical;
            txtYourSequence.Size = new Size(152, 99);
            txtYourSequence.TabIndex = 7;
            // 
            // lblColourSequence
            // 
            lblColourSequence.AutoSize = true;
            lblColourSequence.Location = new Point(51, 207);
            lblColourSequence.Name = "lblColourSequence";
            lblColourSequence.Size = new Size(121, 15);
            lblColourSequence.TabIndex = 8;
            lblColourSequence.Text = "Your colour sequence";
            // 
            // btnClearYourSequence
            // 
            btnClearYourSequence.Location = new Point(219, 238);
            btnClearYourSequence.Name = "btnClearYourSequence";
            btnClearYourSequence.Size = new Size(106, 23);
            btnClearYourSequence.TabIndex = 9;
            btnClearYourSequence.Text = "Clear Sequence";
            btnClearYourSequence.UseVisualStyleBackColor = true;
            btnClearYourSequence.Click += btnClearYourSequence_Click;
            // 
            // btnCheckSequence
            // 
            btnCheckSequence.Location = new Point(504, 12);
            btnCheckSequence.Name = "btnCheckSequence";
            btnCheckSequence.Size = new Size(106, 23);
            btnCheckSequence.TabIndex = 10;
            btnCheckSequence.Text = "Check Sequence";
            btnCheckSequence.UseVisualStyleBackColor = true;
            // 
            // txtOutputHelper
            // 
            txtOutputHelper.Location = new Point(446, 98);
            txtOutputHelper.Multiline = true;
            txtOutputHelper.Name = "txtOutputHelper";
            txtOutputHelper.ScrollBars = ScrollBars.Vertical;
            txtOutputHelper.Size = new Size(183, 262);
            txtOutputHelper.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(446, 80);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 12;
            label1.Text = "Output Helper";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(221, 326);
            lblResult.MaximumSize = new Size(200, 60);
            lblResult.MinimumSize = new Size(200, 60);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(200, 60);
            lblResult.TabIndex = 13;
            lblResult.Text = "Result: ";
            // 
            // lblYourScore
            // 
            lblYourScore.AutoSize = true;
            lblYourScore.Location = new Point(221, 371);
            lblYourScore.Name = "lblYourScore";
            lblYourScore.Size = new Size(66, 15);
            lblYourScore.TabIndex = 14;
            lblYourScore.Text = "Your Score:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 20);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 15;
            label2.Text = "High Score: ";
            // 
            // lblHighScore
            // 
            lblHighScore.AutoSize = true;
            lblHighScore.Location = new Point(119, 20);
            lblHighScore.Name = "lblHighScore";
            lblHighScore.Size = new Size(34, 15);
            lblHighScore.TabIndex = 16;
            lblHighScore.Text = "none";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 481);
            Controls.Add(lblHighScore);
            Controls.Add(label2);
            Controls.Add(lblYourScore);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Controls.Add(txtOutputHelper);
            Controls.Add(btnCheckSequence);
            Controls.Add(btnClearYourSequence);
            Controls.Add(lblColourSequence);
            Controls.Add(txtYourSequence);
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
        private TextBox txtYourSequence;
        private Label lblColourSequence;
        private Button btnClearYourSequence;
        private Button btnCheckSequence;
        private TextBox txtOutputHelper;
        private Label label1;
        private Label lblResult;
        private Label lblYourScore;
        private Label label2;
        private Label lblHighScore;
    }
}
