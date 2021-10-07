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
using System.IO;

namespace FileExtractor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DestinationTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            FolderPathTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            FolderPathTextBox.ReadOnly = true;
            DestinationTextBox.ReadOnly = true;
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
            if (CheckExtension())
            {
                OutputLabel.Text = "True";
                FolderPath();
            }
            else
            {
                OutputLabel.Text = "Something Wrong in Extension(s) Field. Check Again!!!";
            }
        }

        private void FolderPath()
        {
            string[] extensions = GetExtensions();
            DirectoryInfo folderPathDirectory = new DirectoryInfo(FolderPathTextBox.Text);
            FileInfo[] files = folderPathDirectory.GetFiles();
            DirectoryInfo destinationDirectory = new DirectoryInfo(DestinationTextBox.Text);
            FileInfo[] destinationFiles = destinationDirectory.GetFiles();
            List<FileInfo> filesOfExtensions = new List<FileInfo>();
            List<FileInfo> destinationFilesList = new List<FileInfo>();
            bool checkRepeat = false;

            foreach (var item in files)
            {
                for (int i = 0; i < extensions.Length; i++)
                {
                    if (item.Extension == extensions[i])
                    {
                        filesOfExtensions.Add(item);
                    }
                }
            }
            foreach (var item in destinationFiles)
            {
                destinationFilesList.Add(item);
            }
            for (int i = 0; i < filesOfExtensions.Count; i++)
            {
                for (int j = 0; j < destinationFilesList.Count; j++)
                {
                    if (filesOfExtensions[i].Name.Equals(destinationFilesList[j].Name))
                    {
                        checkRepeat = true;
                        OutputLabel.Text = "Same file name in folder path and destination. Error.";
                        break;
                    }
                }
            }
            if (checkRepeat == false)
            {
                for (int i = 0; i < filesOfExtensions.Count; i++)
                {
                    filesOfExtensions[i].CopyTo(DestinationTextBox.Text + "\\" + filesOfExtensions[i].Name);
                }
            }

            //DirectoryInfo[] folderPathDirectories = folderPathDirectory.GetDirectories();
            //foreach (var item in folderPathDirectories)
            //{
            //    FileInfo[] files = item.GetFiles();
            //}

        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }

        private string[] GetExtensions()
        {
            string[] extensions = ExtensionTextBox.Text.Trim().Split(' ');
            return extensions;
        }

        private bool CheckExtension()
        {
            string[] extensions = GetExtensions();
            bool check = false;
            foreach (var item in extensions)
            {
                try
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
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
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
            if (result == DialogResult.OK)
            {
                FolderPathTextBox.Text = FolderPathDialog.SelectedPath;
            }
        }

        private void BrowseDestinationButton_Click(object sender, EventArgs e)
        {
            DestinationDialog.ShowNewFolderButton = true;
            DialogResult result = DestinationDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                DestinationTextBox.Text = DestinationDialog.SelectedPath;
            }
        }
    }
}
