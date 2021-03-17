using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExtractor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DestinationTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ExtensionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExtensionLabel_Click(object sender, EventArgs e)
        {

        }

        private void FolderPathLabel_Click(object sender, EventArgs e)
        {

        }

        private void FolderPathTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DestinationLabel_Click(object sender, EventArgs e)
        {

        }

        private void DestinationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExtractButton_Click(object sender, EventArgs e)
        {
           if(CheckExtension())
           {
                OutputLabel.Text = "True";
           }
           else 
           {
                OutputLabel.Text = "Something Wrong in Extension(s) Field. Check Again!!!";
           }
        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }

        private bool CheckExtension()
        {
            string[] extensions = ExtensionTextBox.Text.Split(' ');
            bool check = false;
            foreach (var item in extensions)
            {
                if (item.Substring(0, 1) == "." && item.Substring(1, item.Length - 1).All(c => char.IsLetterOrDigit(c)))
                {
                    check = true;
                }
                else
                {
                    check = false;
                    break;
                }
            }
            return check;
        }

        private void BrowseFolderPathButton_Click(object sender, EventArgs e)
        {
            FolderPathDialog.ShowNewFolderButton = true;
            DialogResult result = FolderPathDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                FolderPathTextBox.Text = FolderPathDialog.SelectedPath;
            }
        }

        private void BrowseDestinationButton_Click(object sender, EventArgs e)
        {
            DestinationDialog.ShowNewFolderButton = true;
            DialogResult result = DestinationDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                DestinationTextBox.Text = DestinationDialog.SelectedPath;
            }
        }
    }
}
