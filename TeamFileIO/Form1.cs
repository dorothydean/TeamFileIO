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
using System.Security.AccessControl;


namespace TeamFileIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //choose file
            ImportFile();

        }

        private void ImportFile()
        {
            var importFile = new OpenFileDialog();
            importFile.ShowDialog();

            //show file name in text box
            txtImport.Text = importFile.FileName;

            if (cboxDecrypt.Checked)
            {
                File.Decrypt(importFile.FileName);
            }

            //display file
            //MessageBox.Show($"{file}");


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.ShowDialog();
            if (cboxEncrypt.Checked)
            {
                File.Encrypt(saveFile.FileName);
            }
            txtSave.Text = saveFile.FileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<String> file = new List<string>();
            file.Add("string Hey there joe!");
            string path = @"C:test";
            File.AppendAllLines(path, file);
            
        }


    }
}
