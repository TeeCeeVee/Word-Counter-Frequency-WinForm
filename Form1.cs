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

        private void BtnCount_Click(object sender, EventArgs e)
        {
            string allWords = TextChooseFile.Text;
            string[] allWordsArray = allWords.Split(' ', '.', ',', '-', '!', ':');

            // convert the array to List to use find command

            // instantiate WordCounter List
            List<WordCounter> wordCounter = new List<WordCounter>();

            // if the word is found in the list, add 1 to the frequency
            // if the word is NOT found, add it to the list and set its frequency to 1

            foreach (string word in allWordsArray)
            {
                //returns true or false // find returns the word
                WordCounter foundWord = wordCounter.Find( x => x.word == word);

                if (foundWord == null)
                {
                    // word is not on the list. Add it
                    wordCounter.Add(new WordCounter(word, 1));

                }
                else
                {
                    // word is found, increment the frequency value
                    foundWord.frequency++;
                }
            }
            //done with the loop. 

            // to display the words and their frequency values
            listView1.Columns.Add("Frequency", 70);
            listView1.Columns.Add("Word", 100);
           
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Sorting = SortOrder.Descending;

            foreach (WordCounter word in wordCounter)
            {
                string[] rowItem = new string[] { word.frequency.ToString("D5"), word.word };
                listView1.Items.Add( new ListViewItem(rowItem));
            }

        }
    }
}
