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

namespace WordCounterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnChooseFile_Click(object sender, EventArgs e)
        {
            // instance openDialog
            OpenFileDialog openDialog = new OpenFileDialog();

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openDialog.FileName;
                TextChooseFile.Text = File.ReadAllText(filePath);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TextChooseFile.Text = "";
        }

        private void BtnCreateWordList_Click(object sender, EventArgs e)
        {

            string allWords = TextChooseFile.Text;
            string[] allWordsArray = allWords.Split(' ', '.',',','-','!',':');

            foreach (string word in allWordsArray)
            {
                if (!LstWords.Items.Contains(word))
                {
                    LstWords.Items.Add(word);
                }
            }
   
   
  
 
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            LstWords.Sorted = true;
        }

    }
}
