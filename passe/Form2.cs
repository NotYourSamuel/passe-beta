using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passe
{
    public partial class addPasswordForm : Form
    {
        public addPasswordForm()
        {
            InitializeComponent();
        }

        public string WebsiteText
        {
            get { return websiteTextBox.Text; }
        }
        public string AccountText
        {
            get { return accountTextBox.Text; }
        }
        public string PasswordText
        {
            get { return passwordTextBox.Text; }
        }
        string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "passwords");

        public string fileName
        {
            get { return folderPath + "\\" + websiteTextBox.Text + "_" + accountTextBox.Text; }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (retypeTextBox.Text != passwordTextBox.Text)
            {
                MessageBox.Show("Password is not the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void addPasswordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
