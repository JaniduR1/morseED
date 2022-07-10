
namespace MorseRSAAlgorithms
{
    partial class MainForm
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.dropDownRsaOrMorse = new System.Windows.Forms.ComboBox();
            this.labelRsaOrMorse = new System.Windows.Forms.Label();
            this.labelEncryptOrDecrypt = new System.Windows.Forms.Label();
            this.dropDownEncryptorDecrypt = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.saveAsBtn = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(12, 317);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(396, 287);
            this.inputBox.TabIndex = 0;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.Location = new System.Drawing.Point(12, 289);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(55, 25);
            this.inputLabel.TabIndex = 4;
            this.inputLabel.Text = "Input";
            this.inputLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(671, 289);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(71, 25);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.Text = "Output";
            this.outputLabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // outputBox
            // 
            this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.Location = new System.Drawing.Point(637, 317);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(396, 287);
            this.outputBox.TabIndex = 5;
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(440, 386);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(168, 54);
            this.convertButton.TabIndex = 7;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // dropDownRsaOrMorse
            // 
            this.dropDownRsaOrMorse.FormattingEnabled = true;
            this.dropDownRsaOrMorse.Items.AddRange(new object[] {
            "RSA",
            "Morse"});
            this.dropDownRsaOrMorse.Location = new System.Drawing.Point(428, 153);
            this.dropDownRsaOrMorse.Name = "dropDownRsaOrMorse";
            this.dropDownRsaOrMorse.Size = new System.Drawing.Size(191, 24);
            this.dropDownRsaOrMorse.TabIndex = 8;
            this.dropDownRsaOrMorse.SelectedIndexChanged += new System.EventHandler(this.dropDownRsaOrMorse_SelectedIndexChanged);
            // 
            // labelRsaOrMorse
            // 
            this.labelRsaOrMorse.AutoSize = true;
            this.labelRsaOrMorse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRsaOrMorse.Location = new System.Drawing.Point(468, 130);
            this.labelRsaOrMorse.Name = "labelRsaOrMorse";
            this.labelRsaOrMorse.Size = new System.Drawing.Size(115, 20);
            this.labelRsaOrMorse.TabIndex = 9;
            this.labelRsaOrMorse.Text = "RSA or Morse";
            this.labelRsaOrMorse.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // labelEncryptOrDecrypt
            // 
            this.labelEncryptOrDecrypt.AutoSize = true;
            this.labelEncryptOrDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEncryptOrDecrypt.Location = new System.Drawing.Point(449, 189);
            this.labelEncryptOrDecrypt.Name = "labelEncryptOrDecrypt";
            this.labelEncryptOrDecrypt.Size = new System.Drawing.Size(150, 20);
            this.labelEncryptOrDecrypt.TabIndex = 11;
            this.labelEncryptOrDecrypt.Text = "Encrypt or Decrypt";
            // 
            // dropDownEncryptorDecrypt
            // 
            this.dropDownEncryptorDecrypt.FormattingEnabled = true;
            this.dropDownEncryptorDecrypt.Items.AddRange(new object[] {
            "Encrypt",
            "Decrypt"});
            this.dropDownEncryptorDecrypt.Location = new System.Drawing.Point(428, 212);
            this.dropDownEncryptorDecrypt.Name = "dropDownEncryptorDecrypt";
            this.dropDownEncryptorDecrypt.Size = new System.Drawing.Size(191, 24);
            this.dropDownEncryptorDecrypt.TabIndex = 10;
            this.dropDownEncryptorDecrypt.SelectedIndexChanged += new System.EventHandler(this.dropDownEncryptorDecrypt_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenu.Text = "File";
            this.toolStripMenu.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1045, 28);
            this.menuStrip.TabIndex = 14;
            this.menuStrip.Text = "menuStrip2";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileBtn
            // 
            this.openFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileBtn.Location = new System.Drawing.Point(127, 610);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(126, 45);
            this.openFileBtn.TabIndex = 15;
            this.openFileBtn.Text = "Open File";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // saveAsBtn
            // 
            this.saveAsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAsBtn.Location = new System.Drawing.Point(777, 610);
            this.saveAsBtn.Name = "saveAsBtn";
            this.saveAsBtn.Size = new System.Drawing.Size(126, 45);
            this.saveAsBtn.TabIndex = 17;
            this.saveAsBtn.Text = "Save As";
            this.saveAsBtn.UseVisualStyleBackColor = true;
            this.saveAsBtn.Click += new System.EventHandler(this.saveAsBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.saveAsBtn);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.labelEncryptOrDecrypt);
            this.Controls.Add(this.dropDownEncryptorDecrypt);
            this.Controls.Add(this.labelRsaOrMorse);
            this.Controls.Add(this.dropDownRsaOrMorse);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.menuStrip);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Morse and RSA Algorithm TestBench";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.ComboBox dropDownRsaOrMorse;
        private System.Windows.Forms.Label labelRsaOrMorse;
        private System.Windows.Forms.Label labelEncryptOrDecrypt;
        private System.Windows.Forms.ComboBox dropDownEncryptorDecrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.Button saveAsBtn;
    }
}

