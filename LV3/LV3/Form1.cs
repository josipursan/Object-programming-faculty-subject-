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

namespace LV3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            string openFile = null;
            string fileExtenstion;
            var currentDirectory = Directory.GetCurrentDirectory();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = currentDirectory;
            openFileDialog.Title = "Open file";

            openFileDialog.DefaultExt = "txt";
            openFileDialog.Filter = "all files|*.*|txt files|*.txt|RTF files|*.rtf";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                openFile = File.ReadAllText(openFileDialog.FileName);
            }

            fileExtenstion = Path.GetExtension(openFileDialog.FileName);
            if(fileExtenstion == ".rtf")
            {
                richTxtBx_FileInput.Rtf = openFile;
            }
            else
            {
                richTxtBx_FileInput.Text = openFile;
            }


        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            var currentDirectory = Directory.GetCurrentDirectory();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = currentDirectory;
            saveFileDialog.Title = "Save text file";
            saveFileDialog.DefaultExt = "rtf";
            saveFileDialog.Filter = "rtf files|*.rtf";
            saveFileDialog.RestoreDirectory = true;


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName != "")
                {
                    richTxtBx_FileInput.SaveFile(saveFileDialog.FileName);
                }
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fontChoice = new FontDialog();

            if(fontChoice.ShowDialog() == DialogResult.OK)
            {
                richTxtBx_FileInput.SelectionFont = fontChoice.Font;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorChoice = new ColorDialog();

            if(colorChoice.ShowDialog() == DialogResult.OK)
            {
                richTxtBx_FileInput.SelectionColor = colorChoice.Color;
            }
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorChoice = new ColorDialog();

            if(colorChoice.ShowDialog() == DialogResult.OK)
            {
                richTxtBx_FileInput.SelectionBackColor = colorChoice.Color;
            }
        }
    }
}
