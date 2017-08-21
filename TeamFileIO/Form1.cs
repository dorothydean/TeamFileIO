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

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //choose file
            ImportFile();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.ShowDialog();

            string fileName = saveFile.FileName;
            string textToAdd = txtReadFile.Text;
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileName, FileMode.Create);
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write(textToAdd);
                }
            }
            finally
            {
                if (fs != null)
                    fs.Dispose();
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            DecryptFile();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            EncryptFile();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //helper methods
        private void ImportFile()
        {
            var importFile = new OpenFileDialog();
            importFile.ShowDialog();

            //show file name in text box
            txtImport.Text = importFile.FileName;

            ReadFile();

        }

        private void ReadFile()
        {
            //display file into text box
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(txtImport.Text))
                {
                    String line = sr.ReadToEnd();
                    txtReadFile.Text = line;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("The file could not be read:");
            }
        }

        private void EncryptFile()
        {
            string text = txtReadFile.Text;
            byte[] mybyte = System.Text.Encoding.UTF8.GetBytes(text);
            string returntext = System.Convert.ToBase64String(mybyte);
            txtReadFile.Text = returntext;
        }

        private void DecryptFile()
        {
            string text = txtReadFile.Text;
            byte[] mybyte = System.Convert.FromBase64String(text);
            string returntext = System.Text.Encoding.UTF8.GetString(mybyte);
            txtReadFile.Text = returntext;
        }
    }
}
