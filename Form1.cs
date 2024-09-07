using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set filter options 
            openFileDialog.Filter = "|*.txt"; //only txt file allowed

            // Show the open file dialog and get the user input
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileDialog.FileName;

                // Read the contents of the file into a string
                string fileContent = System.IO.File.ReadAllText(filePath);

                // Display the file content in the richtextbox1
                richTextBox1.Text = fileContent; 
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Set filter options 
            saveFileDialog.Filter = "|*.txt";

            // Show the save as dialog and get the user input
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path of the selected file
                string filePath = saveFileDialog.FileName;

                // Write the contents of the richtextbox1
                System.IO.File.WriteAllText(filePath, richTextBox1.Text); 
            }
        }
    }
}
