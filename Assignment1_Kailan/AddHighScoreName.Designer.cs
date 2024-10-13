namespace Assignment1_Kailan
{
    partial class AddHighScoreName
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
            btnSubmitName = new Button();
            label1 = new Label();
            txtPlayerName = new TextBox();
            btnCancel = new Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // btnSubmitName
            // 
            btnSubmitName.Location = new Point(177, 92);
            btnSubmitName.Name = "btnSubmitName";
            btnSubmitName.Size = new Size(97, 23);
            btnSubmitName.TabIndex = 0;
            btnSubmitName.Text = "Submit Name";
            btnSubmitName.UseVisualStyleBackColor = true;
            btnSubmitName.Click += btnSubmitName_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 46);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "Player Name";
            // 
            // txtPlayerName
            // 
            txtPlayerName.Location = new Point(131, 43);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.Size = new Size(143, 23);
            txtPlayerName.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(51, 92);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(51, 128);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 4;
            // 
            // AddHighScoreName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 166);
            Controls.Add(lblError);
            Controls.Add(btnCancel);
            Controls.Add(txtPlayerName);
            Controls.Add(label1);
            Controls.Add(btnSubmitName);
            Name = "AddHighScoreName";
            Text = "AddHighScoreName";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmitName;
        private Label label1;
        private TextBox txtPlayerName;
        private Button btnCancel;
        private Label lblError;
    }
}