using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passe
{
    internal class crashHandler
    {
        public static string ExceptionCrash(string message)
        {
            throw new Exception(message);
        }

        public static void EmplementCrash(string error, string errorcode)
        {
            // Hide all forms
            foreach (Form form in Application.OpenForms)
            {
                form.Hide();
            }

            crashForm crashForm = new crashForm();

            crashForm.crashInfoLabel.Text = errorcode;
            crashForm.errorReasonLabel.Text = "Error Code Received: " + error;

            DialogResult result = crashForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
