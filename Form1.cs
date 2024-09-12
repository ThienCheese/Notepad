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

namespace Notepad
{
    public partial class Notepad : Form
    {
        private bool saveSignal;
        private bool updateSignal;
        private string filePath;
        public Notepad()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "|*.txt"; //only txt file allowed
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
            
                string filePath = openFileDialog.FileName;          
                string fileContent = System.IO.File.ReadAllText(filePath);
                // Display the file content in the richtextbox1
                richTextBox1.Text = fileContent; 
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            // set filter options 
            saveFileDialog.Filter = "|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {  
                string filePath = saveFileDialog.FileName;
                // Write the contents of the richtextbox1
                System.IO.File.WriteAllText(filePath, richTextBox1.Text); 
            }
            saveSignal = true;
            updateSignal = false;
            filePath = saveFileDialog.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveSignal)
            {
                if (Path.GetExtension(filePath) == ".txt")
                {
                    richTextBox1.SaveFile(filePath, RichTextBoxStreamType.PlainText);
                }
                if (Path.GetExtension(filePath) == ".rtf")
                {
                    richTextBox1.SaveFile(filePath, RichTextBoxStreamType.RichText);
                }
                updateSignal = false;
            }
            else
            {
                
                    saveAsToolStripMenuItem_Click(sender, e);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
