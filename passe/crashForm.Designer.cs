namespace passe
{
    partial class crashForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.Label();
            this.footer1 = new System.Windows.Forms.Label();
            this.footer2 = new System.Windows.Forms.Label();
            this.listObject3 = new System.Windows.Forms.Label();
            this.listObject1 = new System.Windows.Forms.Label();
            this.listObject2 = new System.Windows.Forms.Label();
            this.crashInfoLabel = new System.Windows.Forms.Label();
            this.errorReasonLabel = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(459, 219);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(106, 32);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(12, 9);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(100, 39);
            this.titleText.TabIndex = 1;
            this.titleText.Text = "Oops";
            // 
            // footer1
            // 
            this.footer1.AutoSize = true;
            this.footer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footer1.Location = new System.Drawing.Point(15, 48);
            this.footer1.Name = "footer1";
            this.footer1.Size = new System.Drawing.Size(431, 20);
            this.footer1.TabIndex = 2;
            this.footer1.Text = "The application received an error and crashed unexpectedly.";
            // 
            // footer2
            // 
            this.footer2.AutoSize = true;
            this.footer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footer2.Location = new System.Drawing.Point(16, 111);
            this.footer2.Name = "footer2";
            this.footer2.Size = new System.Drawing.Size(334, 18);
            this.footer2.TabIndex = 3;
            this.footer2.Text = "Here are some things that might resolve the error:";
            // 
            // listObject3
            // 
            this.listObject3.AutoSize = true;
            this.listObject3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listObject3.Location = new System.Drawing.Point(32, 190);
            this.listObject3.Name = "listObject3";
            this.listObject3.Size = new System.Drawing.Size(185, 18);
            this.listObject3.TabIndex = 4;
            this.listObject3.Text = "• Redownload the program";
            // 
            // listObject1
            // 
            this.listObject1.AutoSize = true;
            this.listObject1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listObject1.Location = new System.Drawing.Point(32, 136);
            this.listObject1.Name = "listObject1";
            this.listObject1.Size = new System.Drawing.Size(141, 18);
            this.listObject1.TabIndex = 5;
            this.listObject1.Text = "• Reset the program";
            // 
            // listObject2
            // 
            this.listObject2.AutoSize = true;
            this.listObject2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listObject2.Location = new System.Drawing.Point(32, 163);
            this.listObject2.Name = "listObject2";
            this.listObject2.Size = new System.Drawing.Size(166, 18);
            this.listObject2.TabIndex = 6;
            this.listObject2.Text = "• Restart your computer";
            // 
            // crashInfoLabel
            // 
            this.crashInfoLabel.AutoSize = true;
            this.crashInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crashInfoLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.crashInfoLabel.Location = new System.Drawing.Point(12, 238);
            this.crashInfoLabel.Name = "crashInfoLabel";
            this.crashInfoLabel.Size = new System.Drawing.Size(49, 16);
            this.crashInfoLabel.TabIndex = 7;
            this.crashInfoLabel.Text = "000000";
            // 
            // errorReasonLabel
            // 
            this.errorReasonLabel.AutoSize = true;
            this.errorReasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorReasonLabel.Location = new System.Drawing.Point(16, 68);
            this.errorReasonLabel.Name = "errorReasonLabel";
            this.errorReasonLabel.Size = new System.Drawing.Size(241, 18);
            this.errorReasonLabel.TabIndex = 8;
            this.errorReasonLabel.Text = "Error Code Received:  ERR_HERE";
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.Location = new System.Drawing.Point(347, 219);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(106, 32);
            this.restartButton.TabIndex = 9;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // crashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 263);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.errorReasonLabel);
            this.Controls.Add(this.crashInfoLabel);
            this.Controls.Add(this.listObject2);
            this.Controls.Add(this.listObject1);
            this.Controls.Add(this.listObject3);
            this.Controls.Add(this.footer2);
            this.Controls.Add(this.footer1);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.okButton);
            this.Name = "crashForm";
            this.ShowIcon = false;
            this.Text = "Error";
            this.Load += new System.EventHandler(this.crashForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label footer2;
        private System.Windows.Forms.Label listObject3;
        private System.Windows.Forms.Label listObject1;
        private System.Windows.Forms.Label listObject2;
        public System.Windows.Forms.Label footer1;
        public System.Windows.Forms.Label crashInfoLabel;
        public System.Windows.Forms.Label errorReasonLabel;
        private System.Windows.Forms.Button restartButton;
    }
}