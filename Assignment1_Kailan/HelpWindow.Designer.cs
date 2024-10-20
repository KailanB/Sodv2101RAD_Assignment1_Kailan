namespace Assignment1_Kailan
{
    partial class HelpWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpWindow));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.MaximumSize = new Size(350, 80);
            label1.MinimumSize = new Size(350, 80);
            label1.Name = "label1";
            label1.Size = new Size(350, 80);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 108);
            label2.Name = "label2";
            label2.Size = new Size(172, 15);
            label2.TabIndex = 1;
            label2.Text = "Start by clicking Start Sequence";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 135);
            label3.Name = "label3";
            label3.Size = new Size(214, 15);
            label3.TabIndex = 2;
            label3.Text = "Reset - immediately ends current game";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 162);
            label4.Name = "label4";
            label4.Size = new Size(319, 15);
            label4.TabIndex = 3;
            label4.Text = "Once the game is over, hit Reset then Start Sequence again!";
            // 
            // HelpWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 234);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HelpWindow";
            Text = "Help";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}