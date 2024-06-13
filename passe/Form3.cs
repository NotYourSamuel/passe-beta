using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passe
{
    public partial class deletionConfirmation : Form
    {
        public deletionConfirmation()
        {
            InitializeComponent();
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            if (deleteTextBox.Text == "DELETE")
            {
                if (MessageBox.Show("Are you sure you want to delete all passwords? All Passwords will be permanently gone and you cannot restore it! Are you sure you want to do this?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
            }
            else
            {
                crashHandler.EmplementCrash("ERR_DELETION_ABORT", "0x0f");
            }
        }

        private async void deletionConfirmation_Load(object sender, EventArgs e)
        {
            while (true)
            {
                if (deleteTextBox.Text != "DELETE")
                {
                    deleteButton.Enabled = false;
                }
                else if (deleteTextBox.Text == "DELETE")
                {
                    deleteButton.Enabled = true;
                }
                await Task.Delay(1);
            }
        }
    }
}
