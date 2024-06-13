using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms.VisualStyles;
using System.Security.Principal;
using static System.Windows.Forms.LinkLabel;
using System.Threading;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace passe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string EncryptionKey = "FuSyXxsIncJutVBv";
        public static void EncryptFile(string filePath, string plainText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(EncryptionKey);
                aesAlg.IV = new byte[16];

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (FileStream fs = File.Create(filePath))
                using (CryptoStream cs = new CryptoStream(fs, encryptor, CryptoStreamMode.Write))
                using (StreamWriter sw = new StreamWriter(cs))
                {
                    sw.Write(plainText);
                }
            }
        }
        public static string DecryptFile(string filePath)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(EncryptionKey);
                aesAlg.IV = new byte[16]; // Same IV used during encryption.

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (FileStream fs = File.OpenRead(filePath))
                using (CryptoStream cs = new CryptoStream(fs, decryptor, CryptoStreamMode.Read))
                using (StreamReader sr = new StreamReader(cs))
                {
                    return sr.ReadToEnd();
                }
            }
        }
    public string AddPasswordToDataGrid(string website, string account, string password, string type)
        {
            string executablePath = AppDomain.CurrentDomain.BaseDirectory;
            string folderName = Path.Combine(executablePath, "passwords");
            string folderPath = Path.Combine(executablePath, folderName);
            string fileName = website + "_" + account + type;
            string encryptedFilePath = Path.Combine(folderPath, fileName);

            EncryptFile(encryptedFilePath, password);

            dataGridBindingSource.Add(new dataGrid() { Website = website, Account = account, Password = password });
            return website + "_" + account;
        }
        public void refreshData()
        {
            try
            {
                passwordDataGrid.Rows.Clear();
            }
            catch { }
            string executablePath = AppDomain.CurrentDomain.BaseDirectory;
            string folderName = "passwords";
            string folderPath = Path.Combine(executablePath, folderName);

            string[] encryptedFiles = Directory.GetFiles(folderPath, "*encpas");

            foreach (string filePath in encryptedFiles)
            {
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                string[] parts = fileName.Split('_');

                if (parts.Length == 2)
                {
                    string websiteName = parts[0];
                    string accountName = parts[1];

                    // Decrypt password
                    string encryptedPassword = File.ReadAllText(filePath);
                    string decryptedPassword = DecryptFile(filePath);

                    dataGridBindingSource.Add(new dataGrid() { Website = websiteName, Account = accountName, Password = decryptedPassword });
                    AddPasswordToDataGrid(websiteName, accountName, decryptedPassword, fileTypeComboBox.SelectedItem.ToString());
                } else { MessageBox.Show("h", "h");  }
            }
            passwordDataGrid.Refresh();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            performanceTimer.Start();
            fileStatus.Text = string.Empty;
            string executablePath = AppDomain.CurrentDomain.BaseDirectory;
            string folderName = "passwords";
            string folderPath = Path.Combine(executablePath, folderName);
            string folderPath2 = Path.Combine(executablePath, "resources");

            if (!Directory.Exists(folderPath2))
            {
                fileTypeComboBox.SelectedItem = ".encpas";
                try
                {
                    Directory.CreateDirectory(folderPath2);
                    string[] fileContent =
                    {
                        "DO NOT CHANGE ANYTHING IN THIS FILE",
                        "DOING SO WILL MESS IT UP",
                        "",
                        "encpas"
                    };

                    try
                    {
                        using (FileStream fs = File.Create(Path.Combine(folderPath2, "extype.txt")))
                        {
                            using (StreamWriter writer = new StreamWriter(fs))
                            {
                                foreach (string line in fileContent)
                                {
                                    writer.WriteLine(line);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error writing 'extype' line: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating resources folder: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string txtpath = Path.Combine(folderPath2, "extype.txt");
                string[] lines = File.ReadAllLines(txtpath);
                fileTypeComboBox.SelectedItem = "." + lines[3];
            }

            if (!Directory.Exists(folderPath))
            {
                try
                {
                    Directory.CreateDirectory(folderPath);

                    string[] foundFiles = Directory.GetFiles(folderPath);
                    if (foundFiles.Length > 0)
                    {
                        string fileExtensionWithDot = Path.GetExtension(foundFiles[0]);
                        fileTypeComboBox.Text = fileExtensionWithDot;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating password folder: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // folder found; put list logic here
                string[] encryptedFiles = Directory.GetFiles(folderPath, "*encpas");

                foreach (string filePath in encryptedFiles)
                {
                    string fileName = Path.GetFileNameWithoutExtension(filePath);
                    string[] parts = fileName.Split('_');

                    if (parts.Length == 2)
                    {
                        string websiteName = parts[0];
                        string accountName = parts[1];

                        // Decrypt password
                        string encryptedPassword = File.ReadAllText(filePath);
                        string decryptedPassword = DecryptFile(filePath);

                        dataGridBindingSource.Add(new dataGrid() { Website = websiteName, Account = accountName, Password = decryptedPassword });
                    }
                }
            }


            string[] previousFiles = Directory.GetFiles(folderPath);
            /*while (true)
            {
                string[] currentFiles = Directory.GetFiles(folderPath);
                var addedFiles = currentFiles.Except(previousFiles).ToList();
                var deletedFiles = previousFiles.Except(currentFiles).ToList();

                if (addedFiles.Count > 0)
                {
                    foreach (string addedFile in addedFiles)
                    {
                        refreshData();
                    }
                }

                if (deletedFiles.Count > 0)
                {
                    foreach (string deletedFile in deletedFiles)
                    {
                        refreshData();
                    }
                }

                previousFiles = currentFiles;
                System.Threading.Thread.Sleep(100);
            }*/
        }

        private async void newButton_Click(object sender, EventArgs e)
        {
            string executablePath = AppDomain.CurrentDomain.BaseDirectory;
            string folderName = "passwords";
            string folderPath = Path.Combine(executablePath, folderName);
            string folderPath2 = Path.Combine(executablePath, "resources");


            if (File.Exists(Path.Combine(folderPath2, "extype.txt")))
            {
                try
                {
                    string txtpath = Path.Combine(folderPath2, "extype.txt");
                    string[] lines = File.ReadAllLines(txtpath);
                    string formattedString = "." + lines[3];

                    addPasswordForm popupForm = new addPasswordForm();
                    DialogResult result = popupForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        AddPasswordToDataGrid(popupForm.WebsiteText, popupForm.AccountText, popupForm.PasswordText, formattedString);
                        fileStatus.Text = "File Saved: (" + popupForm.fileName + ")";
                        await Task.Delay(5000);
                        fileStatus.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("no", "no");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string executablePath = AppDomain.CurrentDomain.BaseDirectory;
            string folderName = "passwords";
            string folderPath = Path.Combine(executablePath, folderName);
            string folderPath2 = Path.Combine(executablePath, "resources");


            if (File.Exists(Path.Combine(folderPath2, "extype.txt")))
            {
                string txtpath = Path.Combine(folderPath2, "extype.txt");
                string[] lines = File.ReadAllLines(txtpath);
                string lineContent = lines[4 - 1];
                string formattedString = "." + lineContent;

                
                string[] encryptedFiles = Directory.GetFiles(folderPath, "*" + formattedString.TrimStart('.'));
                if (passwordDataGrid.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow selectedRow in passwordDataGrid.SelectedRows)
                    {
                        foreach (string filePath in encryptedFiles)
                        {
                            string fileName = Path.GetFileNameWithoutExtension(filePath);
                            string[] parts = fileName.Split('_');
                            if (parts.Length == 2)
                            {
                                if (selectedRow.Cells[1].Value != null && selectedRow.Cells[2].Value != null)
                                {
                                    string websiteName = selectedRow.Cells[1].Value.ToString();
                                    string accountName = selectedRow.Cells[2].Value.ToString();
                                    string combinded = websiteName + "_" + accountName;
                                    string[] matchingFiles = Directory.GetFiles(folderPath, combinded, SearchOption.AllDirectories);
                                    File.Delete(filePath);

                                    if (matchingFiles.Length > 0)
                                    {
                                        File.Delete(filePath);
                                    }
                                    passwordDataGrid.Rows.Remove(selectedRow);
                                }
                            }
                        }
                    }
                }
            }
            
        }

        private void fileTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string executablePath = AppDomain.CurrentDomain.BaseDirectory;
            string folderName = "passwords";
            string folderPath = Path.Combine(executablePath, folderName);
            string folderPath2 = Path.Combine(executablePath, "resources");


            if (File.Exists(Path.Combine(folderPath2, "extype.txt")))
            {
                string txtpath = Path.Combine(folderPath2, "extype.txt");
                string[] lines = File.ReadAllLines(txtpath);
                string lineContent = lines[4 - 1];
                string formattedString = "." + lineContent;

                try
                {
                    string[] files = Directory.GetFiles(folderPath);

                    foreach (string filePath in files)
                    {
                        
                        string fileDirectory = Path.GetDirectoryName(filePath);
                        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);

                        string newFilePath = Path.Combine(fileDirectory, fileNameWithoutExtension + "." + fileTypeComboBox.SelectedItem.ToString().TrimStart('.'));
                        File.Move(filePath, newFilePath);
                    }
                    // rewrite extype
                    try
                    {
                        string[] newContent =
                        {
                            "DO NOT CHANGE ANYTHING IN THIS FILE",
                            "DOING SO WILL MESS IT UP",
                            "",
                            fileTypeComboBox.SelectedItem.ToString().TrimStart('.')
                        };

                        File.WriteAllLines(txtpath, newContent);
                    }
                    catch ( Exception ex )
                    {
                        MessageBox.Show("Error rewriting 'extype' value: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        log("Error rewriting 'extype' value.");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error changing filetypes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log("Error changing filetypes.");

                }
            }
            else
            {
                MessageBox.Show("Cannot change filetype as the values do not exist. Try deleting your password folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log("Cannot change filetype as the values do not exist. Try deleting your password folder.");

            }
        }

        static bool IsRunningAsAdmin()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        private void deleteAllButton_Click(object sender, EventArgs e)
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "passwords");
            deletionConfirmation form = new deletionConfirmation();
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.Yes)
            {
                string[] files = Directory.GetFiles(folderPath);
                foreach (string file in files)
                {
                    File.Delete(Path.Combine(file));
                }
            }
            log("Deleted all.");

        }

        public async void setStatus(string status, int waitTime)
        {
            fileStatus.Text = status;
            await Task.Delay(waitTime * 1000);
            fileStatus.Text = string.Empty;
        }
        private async void liveValuesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            while (liveValuesCheckBox.Checked)
            {
                refreshData();
                await Task.Delay(10);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setStatus("Saved Data", 5);
            log("Saved data.");

        }

        private void passwordsFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "passwords");
            Process.Start(folderPath);
            log("Opened password folder.");

        }

        private void resourcesFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "resources");
            Process.Start(folderPath);
            log("Opened resource folder.");

        }

        private void mainFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderPath = AppDomain.CurrentDomain.BaseDirectory;
            Process.Start(folderPath);
            log("Opened main folder.");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "passwords");
            deletionConfirmation form = new deletionConfirmation();
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.Yes)
            {
                string[] files = Directory.GetFiles(folderPath);
                foreach (string file in files)
                {
                    File.Delete(Path.Combine(file));
                }
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string messageString = "Passe is a versatile and secure password management program developed in C#, designed to empower users to efficiently and safely manage their passwords. With an intuitive user interface and robust security features, Passe offers a seamless and convenient solution for organizing and safeguarding your sensitive login credentials.";
            MessageBox.Show(messageString, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void EcopyResultButton_Click(object sender, EventArgs e)
        {
            EencryptedResult.SelectAll();
            Clipboard.SetText(EencryptedResult.Text);
            log("Copied password result.");

        }

        private void EecryptButton_Click(object sender, EventArgs e)
        {
            string hash = EhashTextBox.Text;

            if (EpasswordTextbox.Text != "" || EpasswordTextbox.Text != string.Empty)
            {
                byte[] data = UTF32Encoding.UTF8.GetBytes(EpasswordTextbox.Text);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripDes.CreateEncryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        EencryptedResult.Text = Convert.ToBase64String(results, 0, results.Length);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            log("Successfully encrypted password.");
        }

        private void EdecryptButton_Click(object sender, EventArgs e)
        {
            string hash = EhashTextBox.Text;

            byte[] data = Convert.FromBase64String(EencryptedResult.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    EencryptedResult.Text = UTF8Encoding.UTF8.GetString(results);
                }
            }

            log("Successfully decrypted password.");
        }
        public enum PassowrdStregnthScores
        {
            Empty = 0,
            VeryWeak = 1,
            Weak = 2,
            Bad = 3,
            Okay = 4,
            Good = 5,
            VeryGood = 6,
            Great = 7,
            Strong = 8,
            VeryStrong = 9,
            Uncrackable = 10 // figure of speech
        }

        private void SMpasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            int score = 0;
            int minLength = 5;
            int maxLength = 50;
            int minLowercase = 3;
            int minUppercase = 3;
            int minDigits = 2;
            int minSpecial = 1;

            // Length Check
            if (SMpasswordTextBox.Text != "")
            {
                score++;
            }
            if (SMpasswordTextBox.Text.Length < minLength)
            {
                SMminLengthLabel.Text = "Your Password must be at least " + minLength + " characters.";
            } else SMminLengthLabel.Text = "";
            if (SMpasswordTextBox.Text.Length > maxLength)
            {
                SMmaxLengthLabel.Text = "Your Password cannot be more than " + maxLength + " characters.";
            } else SMmaxLengthLabel.Text = "";

            // Lowercase, and Uppercase
            int uppercaseAmount = 0;
            int lowercaseAmount = 0;
            int digitAmount = 0;
            int specialAmount = 0;


            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "resources");

            foreach (char c in SMpasswordTextBox.Text)
            {
                if (char.IsLower(c))
                {
                    lowercaseAmount++;
                }
                if (char.IsUpper(c))
                {
                    uppercaseAmount++;
                }
                if (char.IsDigit(c))
                {
                    digitAmount++;
                }
                if ("!@#$%^&*()><,.+=".Contains(c))
                {
                    specialAmount++;
                }
            }
            if (lowercaseAmount < minLowercase)
            {
                SMlowercaseLettersLabel.Text = "Your Password must contain more than " + minLowercase + " lowercase letters.";
            } else SMlowercaseLettersLabel.Text = ""; score++;
            if (uppercaseAmount < minUppercase)
            {
                SMuppercaseLabel.Text = "Your Password must contain at least " + minUppercase + " uppercase letters.";
            } else SMuppercaseLabel.Text = ""; score++;
            if (digitAmount < minDigits)
            {
                SMdigitCountLabel.Text = "Your Password must contain at least " + minDigits + " digits.";
            } else SMdigitCountLabel.Text = ""; score++;
            if (specialAmount < minSpecial)
            {
                SMspecialAmountLabel.Text = "Your Password must contain at least " + minSpecial + " special characters.";
            } else SMspecialAmountLabel.Text = ""; score++;

            if (SMpasswordTextBox.Text.Length >= 15)
            {
                score++;
            }
            if (SMpasswordTextBox.Text.Length >= 30)
            {
                score++;
            }
            

            if (score == 1)
            {
                SMbadPanel.BackColor = Color.Red;
                SMokayPanel.BackColor = Color.Transparent;
                SMdecentPanel.BackColor = Color.Transparent;
                SMbetterPanel.BackColor = Color.Transparent;
                SMgoodPanel.BackColor = Color.Transparent;
                SMgreatPanel.BackColor = Color.Transparent;
                SMexcellentPanel.BackColor = Color.Transparent;
            }
            else if (score == 2)
            {
                SMbadPanel.BackColor = Color.Red;
                SMokayPanel.BackColor = Color.OrangeRed;
                SMdecentPanel.BackColor = Color.Transparent;
                SMbetterPanel.BackColor = Color.Transparent;
                SMgoodPanel.BackColor = Color.Transparent;
                SMgreatPanel.BackColor = Color.Transparent;
                SMexcellentPanel.BackColor = Color.Transparent;
            }
            else if (score == 3)
            {
                SMbadPanel.BackColor = Color.Red;
                SMokayPanel.BackColor = Color.OrangeRed;
                SMdecentPanel.BackColor = Color.Orange;
                SMbetterPanel.BackColor = Color.Transparent;
                SMgoodPanel.BackColor = Color.Transparent;
                SMgreatPanel.BackColor = Color.Transparent;
                SMexcellentPanel.BackColor = Color.Transparent;
            }
            else if (score == 4)
            {
                SMbadPanel.BackColor = Color.Red;
                SMokayPanel.BackColor = Color.OrangeRed;
                SMdecentPanel.BackColor = Color.Orange;
                SMbetterPanel.BackColor = Color.Yellow;
                SMgoodPanel.BackColor = Color.Transparent;
                SMgreatPanel.BackColor = Color.Transparent;
                SMexcellentPanel.BackColor = Color.Transparent;
            }
            else if (score == 5)
            {
                SMbadPanel.BackColor = Color.Red;
                SMokayPanel.BackColor = Color.OrangeRed;
                SMdecentPanel.BackColor = Color.Orange;
                SMbetterPanel.BackColor = Color.Yellow;
                SMgoodPanel.BackColor = Color.YellowGreen;
                SMgreatPanel.BackColor = Color.Transparent;
                SMexcellentPanel.BackColor = Color.Transparent;
            }
            else if (score == 6)
            {
                SMbadPanel.BackColor = Color.Red;
                SMokayPanel.BackColor = Color.OrangeRed;
                SMdecentPanel.BackColor = Color.Orange;
                SMbetterPanel.BackColor = Color.Yellow;
                SMgoodPanel.BackColor = Color.YellowGreen;
                SMgreatPanel.BackColor = Color.Chartreuse;
                SMexcellentPanel.BackColor = Color.Transparent;
            }
            else if (score == 7)
            {
                SMbadPanel.BackColor = Color.Red;
                SMokayPanel.BackColor = Color.OrangeRed;
                SMdecentPanel.BackColor = Color.Orange;
                SMbetterPanel.BackColor = Color.Yellow;
                SMgoodPanel.BackColor = Color.YellowGreen;
                SMgreatPanel.BackColor = Color.Chartreuse;
                SMexcellentPanel.BackColor = Color.ForestGreen;
            }
            SMscoreLabel.Text = "Score: " + score;
        }
        private void tabControl_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SPGgenerateButton_Click(object sender, EventArgs e)
        {
            SPGpasswordTextBox.Text = "";
            int length = (int)SPGlength.Value;
            bool includeNumbers = SPGincludeNumbersCheckBox.Checked;
            bool includeLowercase = SPGincludeLowercaseCheckBox.Checked;
            bool includeUppercase = SPGincludeUppercaseCheckBox.Checked;
            bool includeSymbols = SPGincludeSymbolsCheckBox.Checked;
            bool beginWithLetter = SPGbeginWithLetterCheckBox.Checked;
            bool noSimilarChars = SPGnoSimilarCharactersCheckBox.Checked;
            bool noDupeChars = SPGnoDupeCharactersCheckBox.Checked;
            bool noSequentialChars = SPGnoSequentialCharsCheckBox.Checked;

            for (int i = 0; i < (int)SPGquanity.Value; i++)
            {
                string password = PasswordGenerator.GeneratePassword(length, includeNumbers, includeLowercase, includeUppercase, includeSymbols,
            beginWithLetter, noSimilarChars, noDupeChars, noSequentialChars);
                SPGpasswordTextBox.Text += Environment.NewLine + password;
            }
            log("Successfully generated password.");
        }

        private void SPGexportButton_Click(object sender, EventArgs e)
        {
            if (SPGpasswordTextBox.Text.Length != 0)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text Files (*.txt) | *.txt | All Files (*.*) | *.*";
                    saveFileDialog.Title = "Save Password(s)";
                    saveFileDialog.FileName = "exportedPassword.txt";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        try
                        {
                            File.WriteAllText(filePath, SPGpasswordTextBox.Text);
                            log("Successfully exported password list.");
                        }
                        catch { }
                    }
                }
            }
        }

        private void addFirewallRuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string command = $"netsh advfirewall firewall add rule name=\"passe_firewall_rule\" dir=in action=allow program=\"{Application.ExecutablePath}\" enable=yes";

            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            Process process = new Process();
            process.StartInfo = processInfo;
            process.Start();

            process.WaitForExit();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            if (string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Firewall rule added successfully.", "Success");
                log("Firewall rule added successfully.");
            }
            else
            {
                MessageBox.Show($"An error occurred: {error}", "Error");
                log("An error occured adding an application firewall rule.");
            }
        }

        private void log(string text)
        {
            logTextBox.AppendText(text + "\n");
        }

        private void performanceTimer_Tick(object sender, EventArgs e)
        {
            float cpuUsage = CPUperformance.NextValue();
            float availableMemory = RAMperformance.NextValue() / 1024;

            float roundedCPUUsage = (float)Math.Round(cpuUsage, 2);
            float roundedMemory = (float)Math.Round(availableMemory, 2);

            performanceLabel.Text = "CPU: " + roundedCPUUsage + "% | RAM: " + roundedMemory + "GB";
        }
    }
}
