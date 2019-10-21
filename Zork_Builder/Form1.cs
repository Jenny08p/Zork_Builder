using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Zork_Builder
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();

        }

        private void OpenWorldCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Document (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Title = "Open";

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.RestoreDirectory = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                //string text = File.ReadAllText(file);
               // textBox1.Text = text;
            }

        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FileMenu_Click(object sender, EventArgs e)
        {

        }
        string OurFilename;

        private void SaveCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String file = saveFileDialog.FileName;
                richTextBox1.SaveFile(file);
            }
        }


        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String file = saveFileDialog.FileName;
                richTextBox1.SaveFile(file);
            }
         }
    }
    }

