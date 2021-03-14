
namespace FileExtractor
{
    partial class Form1
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
            this.ExtensionTextBox = new System.Windows.Forms.TextBox();
            this.ExtensionLabel = new System.Windows.Forms.Label();
            this.HintLabel = new System.Windows.Forms.Label();
            this.FolderPathLabel = new System.Windows.Forms.Label();
            this.FolderPathTextBox = new System.Windows.Forms.TextBox();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.ExtractButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExtensionTextBox
            // 
            this.ExtensionTextBox.Location = new System.Drawing.Point(155, 76);
            this.ExtensionTextBox.Name = "ExtensionTextBox";
            this.ExtensionTextBox.Size = new System.Drawing.Size(538, 22);
            this.ExtensionTextBox.TabIndex = 0;
            this.ExtensionTextBox.TextChanged += new System.EventHandler(this.ExtensionTextBox_TextChanged);
            // 
            // ExtensionLabel
            // 
            this.ExtensionLabel.AutoSize = true;
            this.ExtensionLabel.Location = new System.Drawing.Point(26, 76);
            this.ExtensionLabel.Name = "ExtensionLabel";
            this.ExtensionLabel.Size = new System.Drawing.Size(94, 17);
            this.ExtensionLabel.TabIndex = 1;
            this.ExtensionLabel.Text = "Extension(s) :";
            this.ExtensionLabel.Click += new System.EventHandler(this.ExtensionLabel_Click);
            // 
            // HintLabel
            // 
            this.HintLabel.AutoSize = true;
            this.HintLabel.Location = new System.Drawing.Point(152, 118);
            this.HintLabel.Name = "HintLabel";
            this.HintLabel.Size = new System.Drawing.Size(277, 17);
            this.HintLabel.TabIndex = 2;
            this.HintLabel.Text = "Hint : Type like this, \".exe, .gif, .cs, .cshtml\"";
            // 
            // FolderPathLabel
            // 
            this.FolderPathLabel.AutoSize = true;
            this.FolderPathLabel.Location = new System.Drawing.Point(27, 179);
            this.FolderPathLabel.Name = "FolderPathLabel";
            this.FolderPathLabel.Size = new System.Drawing.Size(93, 17);
            this.FolderPathLabel.TabIndex = 3;
            this.FolderPathLabel.Text = "Folder Path : ";
            this.FolderPathLabel.Click += new System.EventHandler(this.FolderPathLabel_Click);
            // 
            // FolderPathTextBox
            // 
            this.FolderPathTextBox.Location = new System.Drawing.Point(155, 176);
            this.FolderPathTextBox.Name = "FolderPathTextBox";
            this.FolderPathTextBox.Size = new System.Drawing.Size(538, 22);
            this.FolderPathTextBox.TabIndex = 4;
            this.FolderPathTextBox.TextChanged += new System.EventHandler(this.FolderPathTextBox_TextChanged);
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Location = new System.Drawing.Point(27, 239);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(87, 17);
            this.DestinationLabel.TabIndex = 5;
            this.DestinationLabel.Text = "Destination :";
            this.DestinationLabel.Click += new System.EventHandler(this.DestinationLabel_Click);
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.Location = new System.Drawing.Point(155, 239);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(538, 22);
            this.DestinationTextBox.TabIndex = 6;
            this.DestinationTextBox.TextChanged += new System.EventHandler(this.DestinationTextBox_TextChanged);
            // 
            // ExtractButton
            // 
            this.ExtractButton.BackColor = System.Drawing.Color.Chocolate;
            this.ExtractButton.Location = new System.Drawing.Point(338, 333);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(127, 44);
            this.ExtractButton.TabIndex = 7;
            this.ExtractButton.Text = "Extract Files";
            this.ExtractButton.UseVisualStyleBackColor = false;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TitleLabel.Location = new System.Drawing.Point(196, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(441, 20);
            this.TitleLabel.TabIndex = 8;
            this.TitleLabel.Text = "Extract Files of specific Extension(s) from a Folder";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ExtractButton);
            this.Controls.Add(this.DestinationTextBox);
            this.Controls.Add(this.DestinationLabel);
            this.Controls.Add(this.FolderPathTextBox);
            this.Controls.Add(this.FolderPathLabel);
            this.Controls.Add(this.HintLabel);
            this.Controls.Add(this.ExtensionLabel);
            this.Controls.Add(this.ExtensionTextBox);
            this.Name = "Form1";
            this.Text = "File Extractor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ExtensionTextBox;
        private System.Windows.Forms.Label ExtensionLabel;
        private System.Windows.Forms.Label HintLabel;
        private System.Windows.Forms.Label FolderPathLabel;
        private System.Windows.Forms.TextBox FolderPathTextBox;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.Button ExtractButton;
        private System.Windows.Forms.Label TitleLabel;
    }
}

