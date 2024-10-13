using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1_Kailan
{
    public partial class AddHighScoreName : Form
    {
        public string InputName = "";
        public AddHighScoreName()
        {
            InitializeComponent();
        }

        private void btnSubmitName_Click(object sender, EventArgs e)
        {
            if (txtPlayerName.Text != "")
            {
                InputName = txtPlayerName.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblError.Text = "Please Enter a name!";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
