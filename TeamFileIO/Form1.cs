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
            
            //encrypt
        }

        private void ImportFile()
        {
            var importFile = new OpenFileDialog();
            importFile.ShowDialog();
            MessageBox.Show("File successfully imported!");
            //todo add if else for success or failure of import
        }

        private void EncryptOrDecryptFile()
        {
            if (cboxDecrypt.Checked)
            {
                //decrypt file
            }

            if (cboxEncrypt.Checked)
            {
                //encrypt file
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.ShowDialog();
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
