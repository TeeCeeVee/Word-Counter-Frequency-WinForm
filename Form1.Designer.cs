namespace WordCounterApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnChooseFile = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.TextChooseFile = new System.Windows.Forms.TextBox();
            this.LstWords = new System.Windows.Forms.ListBox();
            this.BtnCreateWordList = new System.Windows.Forms.Button();
            this.BtnSort = new System.Windows.Forms.Button();
            this.BtnCount = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(140, 27);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(103, 16);
            this.Lbl1.TabIndex = 0;
            this.Lbl1.Text = "Load a Text File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "2. Split the File into Words";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(805, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "3. Count the Frequency of Each Word";
            // 
            // BtnChooseFile
            // 
            this.BtnChooseFile.Location = new System.Drawing.Point(118, 59);
            this.BtnChooseFile.Name = "BtnChooseFile";
            this.BtnChooseFile.Size = new System.Drawing.Size(76, 50);
            this.BtnChooseFile.TabIndex = 1;
            this.BtnChooseFile.Text = "Choose a File";
            this.BtnChooseFile.UseVisualStyleBackColor = true;
            this.BtnChooseFile.Click += new System.EventHandler(this.BtnChooseFile_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(210, 73);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // TextChooseFile
            // 
            this.TextChooseFile.Location = new System.Drawing.Point(51, 131);
            this.TextChooseFile.Multiline = true;
            this.TextChooseFile.Name = "TextChooseFile";
            this.TextChooseFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextChooseFile.Size = new System.Drawing.Size(330, 400);
            this.TextChooseFile.TabIndex = 3;
            // 
            // LstWords
            // 
            this.LstWords.FormattingEnabled = true;
            this.LstWords.ItemHeight = 16;
            this.LstWords.Location = new System.Drawing.Point(439, 131);
            this.LstWords.Name = "LstWords";
            this.LstWords.Size = new System.Drawing.Size(305, 404);
            this.LstWords.TabIndex = 4;
            // 
            // BtnCreateWordList
            // 
            this.BtnCreateWordList.Location = new System.Drawing.Point(465, 59);
            this.BtnCreateWordList.Name = "BtnCreateWordList";
            this.BtnCreateWordList.Size = new System.Drawing.Size(67, 50);
            this.BtnCreateWordList.TabIndex = 5;
            this.BtnCreateWordList.Text = "Create Word List";
            this.BtnCreateWordList.UseVisualStyleBackColor = true;
            this.BtnCreateWordList.Click += new System.EventHandler(this.BtnCreateWordList_Click);
            // 
            // BtnSort
            // 
            this.BtnSort.Location = new System.Drawing.Point(594, 59);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(75, 23);
            this.BtnSort.TabIndex = 6;
            this.BtnSort.Text = "Sort Words";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // BtnCount
            // 
            this.BtnCount.Location = new System.Drawing.Point(873, 59);
            this.BtnCount.Name = "BtnCount";
            this.BtnCount.Size = new System.Drawing.Size(75, 23);
            this.BtnCount.TabIndex = 7;
            this.BtnCount.Text = "Count";
            this.BtnCount.UseVisualStyleBackColor = true;
            this.BtnCount.Click += new System.EventHandler(this.BtnCount_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(955, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(826, 131);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(248, 404);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 608);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnCount);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.BtnCreateWordList);
            this.Controls.Add(this.LstWords);
            this.Controls.Add(this.TextChooseFile);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnChooseFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnChooseFile;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.TextBox TextChooseFile;
        private System.Windows.Forms.ListBox LstWords;
        private System.Windows.Forms.Button BtnCreateWordList;
        private System.Windows.Forms.Button BtnSort;
        private System.Windows.Forms.Button BtnCount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
    }
}

