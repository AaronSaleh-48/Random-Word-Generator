namespace RandomWordGenerator
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtxWord = new System.Windows.Forms.RichTextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtWordLength = new System.Windows.Forms.TextBox();
            this.txtFirstLetter = new System.Windows.Forms.TextBox();
            this.lblWordLength = new System.Windows.Forms.Label();
            this.lblFirstLetter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxWord
            // 
            this.rtxWord.Location = new System.Drawing.Point(158, 12);
            this.rtxWord.Name = "rtxWord";
            this.rtxWord.Size = new System.Drawing.Size(117, 159);
            this.rtxWord.TabIndex = 0;
            this.rtxWord.Text = "";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 136);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(140, 35);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtWordLength
            // 
            this.txtWordLength.Location = new System.Drawing.Point(12, 29);
            this.txtWordLength.Name = "txtWordLength";
            this.txtWordLength.Size = new System.Drawing.Size(100, 22);
            this.txtWordLength.TabIndex = 2;
            // 
            // txtFirstLetter
            // 
            this.txtFirstLetter.Location = new System.Drawing.Point(12, 95);
            this.txtFirstLetter.Name = "txtFirstLetter";
            this.txtFirstLetter.Size = new System.Drawing.Size(100, 22);
            this.txtFirstLetter.TabIndex = 3;
            // 
            // lblWordLength
            // 
            this.lblWordLength.AutoSize = true;
            this.lblWordLength.Location = new System.Drawing.Point(12, 9);
            this.lblWordLength.Name = "lblWordLength";
            this.lblWordLength.Size = new System.Drawing.Size(120, 17);
            this.lblWordLength.TabIndex = 4;
            this.lblWordLength.Text = "Amount of Letters";
            // 
            // lblFirstLetter
            // 
            this.lblFirstLetter.AutoSize = true;
            this.lblFirstLetter.Location = new System.Drawing.Point(12, 75);
            this.lblFirstLetter.Name = "lblFirstLetter";
            this.lblFirstLetter.Size = new System.Drawing.Size(140, 17);
            this.lblFirstLetter.TabIndex = 5;
            this.lblFirstLetter.Text = "First Letter (optional)";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 182);
            this.Controls.Add(this.lblFirstLetter);
            this.Controls.Add(this.lblWordLength);
            this.Controls.Add(this.txtFirstLetter);
            this.Controls.Add(this.txtWordLength);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.rtxWord);
            this.Name = "frmMain";
            this.Text = "Word Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxWord;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtWordLength;
        private System.Windows.Forms.TextBox txtFirstLetter;
        private System.Windows.Forms.Label lblWordLength;
        private System.Windows.Forms.Label lblFirstLetter;
    }
}

