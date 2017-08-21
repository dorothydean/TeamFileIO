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

            ReadFile();
            
        }

        private void ReadFile()
        {
            //display file into text box
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(txtImport.Text))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    txtReadFile.Text = line;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("The file could not be read:");
            }
        }

        private void WriteFile()
        {

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.ShowDialog();

            //pull txtReadFile.text and do something with it
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

            if (cboxEncrypt.Checked)
            {
                EncryptFile();
            }
            
        }

        private void EncryptFile()
        {
            //convert to ASCII equivalent
            string text = txtReadFile.Text;
            byte[] bytes = Encoding.ASCII.GetBytes(text);
            int result = BitConverter.ToInt32(bytes, 0);
            //display encrypted text in text box
        }

        private void DecryptFile()
        {
            //pull encrypted text from text box
            //run ascii conversion
            //display back into text box

            string text = txtReadFile.Text;
            //possible conversion to ints
            //byte[] bytes2 = BitConverter.GetBytes(); //bool
            //string s2 = Encoding.ASCII.GetString(bytes);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<String> file = new List<string>();
            //file.Add("string Hey there joe!");
            //string path = @"C:test";
            //File.AppendAllLines(path, file);
            
        }


    }
}
