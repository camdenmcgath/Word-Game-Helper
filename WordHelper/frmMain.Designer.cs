namespace WordHelper
{
    partial class frmMain
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
            this.lstbxWords = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.chbxAllCombinations = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStripSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabDatabase = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteWord = new System.Windows.Forms.Button();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.txtbxAddWord = new System.Windows.Forms.TextBox();
            this.btnToGood = new System.Windows.Forms.Button();
            this.btnToDeleted = new System.Windows.Forms.Button();
            this.lstbxDeletedWords = new System.Windows.Forms.ListBox();
            this.lstbxGoodWords = new System.Windows.Forms.ListBox();
            this.tabWordle = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvWordle = new System.Windows.Forms.DataGridView();
            this.tabBasic = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLetter3 = new System.Windows.Forms.Label();
            this.lblLetter2 = new System.Windows.Forms.Label();
            this.lblLetter = new System.Windows.Forms.Label();
            this.lblCharacters = new System.Windows.Forms.Label();
            this.txtbxLetter3 = new System.Windows.Forms.TextBox();
            this.txtbxLetter2 = new System.Windows.Forms.TextBox();
            this.txtbxLetter1 = new System.Windows.Forms.TextBox();
            this.txtbxCharacters = new System.Windows.Forms.TextBox();
            this.nudWordLength = new System.Windows.Forms.NumericUpDown();
            this.nudAtPosition1 = new System.Windows.Forms.NumericUpDown();
            this.nudAtPosition2 = new System.Windows.Forms.NumericUpDown();
            this.nudAtPosition3 = new System.Windows.Forms.NumericUpDown();
            this.lblAtPosition3 = new System.Windows.Forms.Label();
            this.lblWordLength = new System.Windows.Forms.Label();
            this.lblAtPosition2 = new System.Windows.Forms.Label();
            this.lblAtPosition1 = new System.Windows.Forms.Label();
            this.tabctrlGames = new System.Windows.Forms.TabControl();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabDatabase.SuspendLayout();
            this.tabWordle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWordle)).BeginInit();
            this.tabBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWordLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAtPosition1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAtPosition2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAtPosition3)).BeginInit();
            this.tabctrlGames.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbxWords
            // 
            this.lstbxWords.FormattingEnabled = true;
            this.lstbxWords.Location = new System.Drawing.Point(546, 64);
            this.lstbxWords.Name = "lstbxWords";
            this.lstbxWords.Size = new System.Drawing.Size(157, 394);
            this.lstbxWords.TabIndex = 20;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(226, 464);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 32;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // chbxAllCombinations
            // 
            this.chbxAllCombinations.AutoSize = true;
            this.chbxAllCombinations.Location = new System.Drawing.Point(226, 493);
            this.chbxAllCombinations.Name = "chbxAllCombinations";
            this.chbxAllCombinations.Size = new System.Drawing.Size(80, 17);
            this.chbxAllCombinations.TabIndex = 31;
            this.chbxAllCombinations.Text = "Show More";
            this.chbxAllCombinations.UseVisualStyleBackColor = true;
            this.chbxAllCombinations.CheckedChanged += new System.EventHandler(this.chbxShowMore_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripSelected});
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(713, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStripSelected
            // 
            this.statusStripSelected.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusStripSelected.Name = "statusStripSelected";
            this.statusStripSelected.Size = new System.Drawing.Size(104, 17);
            this.statusStripSelected.Text = "Play a word game!";
            // 
            // tabDatabase
            // 
            this.tabDatabase.Controls.Add(this.label4);
            this.tabDatabase.Controls.Add(this.label2);
            this.tabDatabase.Controls.Add(this.label1);
            this.tabDatabase.Controls.Add(this.btnDeleteWord);
            this.tabDatabase.Controls.Add(this.btnAddWord);
            this.tabDatabase.Controls.Add(this.txtbxAddWord);
            this.tabDatabase.Controls.Add(this.btnToGood);
            this.tabDatabase.Controls.Add(this.btnToDeleted);
            this.tabDatabase.Controls.Add(this.lstbxDeletedWords);
            this.tabDatabase.Controls.Add(this.lstbxGoodWords);
            this.tabDatabase.Location = new System.Drawing.Point(4, 22);
            this.tabDatabase.Name = "tabDatabase";
            this.tabDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatabase.Size = new System.Drawing.Size(520, 388);
            this.tabDatabase.TabIndex = 2;
            this.tabDatabase.Text = "Personal Dictionary";
            this.tabDatabase.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Add or remove words from the dictionaries!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Deleted Words";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Added Words";
            // 
            // btnDeleteWord
            // 
            this.btnDeleteWord.Location = new System.Drawing.Point(311, 336);
            this.btnDeleteWord.Name = "btnDeleteWord";
            this.btnDeleteWord.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteWord.TabIndex = 6;
            this.btnDeleteWord.Text = "Delete Word";
            this.btnDeleteWord.UseVisualStyleBackColor = true;
            this.btnDeleteWord.Click += new System.EventHandler(this.btnDeleteWord_Click);
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(132, 336);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(75, 23);
            this.btnAddWord.TabIndex = 5;
            this.btnAddWord.Text = "Add Word";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // txtbxAddWord
            // 
            this.txtbxAddWord.Location = new System.Drawing.Point(210, 290);
            this.txtbxAddWord.Name = "txtbxAddWord";
            this.txtbxAddWord.Size = new System.Drawing.Size(100, 20);
            this.txtbxAddWord.TabIndex = 4;
            // 
            // btnToGood
            // 
            this.btnToGood.Location = new System.Drawing.Point(220, 209);
            this.btnToGood.Name = "btnToGood";
            this.btnToGood.Size = new System.Drawing.Size(75, 23);
            this.btnToGood.TabIndex = 3;
            this.btnToGood.Text = "To Good";
            this.btnToGood.UseVisualStyleBackColor = true;
            this.btnToGood.Click += new System.EventHandler(this.btnToGood_Click);
            // 
            // btnToDeleted
            // 
            this.btnToDeleted.Location = new System.Drawing.Point(220, 95);
            this.btnToDeleted.Name = "btnToDeleted";
            this.btnToDeleted.Size = new System.Drawing.Size(75, 23);
            this.btnToDeleted.TabIndex = 2;
            this.btnToDeleted.Text = "To Deleted";
            this.btnToDeleted.UseVisualStyleBackColor = true;
            this.btnToDeleted.Click += new System.EventHandler(this.btnToDeleted_Click);
            // 
            // lstbxDeletedWords
            // 
            this.lstbxDeletedWords.FormattingEnabled = true;
            this.lstbxDeletedWords.Location = new System.Drawing.Point(340, 65);
            this.lstbxDeletedWords.Name = "lstbxDeletedWords";
            this.lstbxDeletedWords.Size = new System.Drawing.Size(120, 225);
            this.lstbxDeletedWords.TabIndex = 1;
            // 
            // lstbxGoodWords
            // 
            this.lstbxGoodWords.FormattingEnabled = true;
            this.lstbxGoodWords.Location = new System.Drawing.Point(51, 65);
            this.lstbxGoodWords.Name = "lstbxGoodWords";
            this.lstbxGoodWords.Size = new System.Drawing.Size(120, 225);
            this.lstbxGoodWords.TabIndex = 0;
            // 
            // tabWordle
            // 
            this.tabWordle.Controls.Add(this.label5);
            this.tabWordle.Controls.Add(this.btnReset);
            this.tabWordle.Controls.Add(this.dgvWordle);
            this.tabWordle.Location = new System.Drawing.Point(4, 22);
            this.tabWordle.Name = "tabWordle";
            this.tabWordle.Padding = new System.Windows.Forms.Padding(3);
            this.tabWordle.Size = new System.Drawing.Size(520, 388);
            this.tabWordle.TabIndex = 1;
            this.tabWordle.Text = "Wordle";
            this.tabWordle.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Record wordle guesses below!";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(210, 359);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvWordle
            // 
            this.dgvWordle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWordle.Location = new System.Drawing.Point(126, 46);
            this.dgvWordle.Name = "dgvWordle";
            this.dgvWordle.Size = new System.Drawing.Size(254, 310);
            this.dgvWordle.TabIndex = 0;
            // 
            // tabBasic
            // 
            this.tabBasic.Controls.Add(this.label6);
            this.tabBasic.Controls.Add(this.lblLetter3);
            this.tabBasic.Controls.Add(this.lblLetter2);
            this.tabBasic.Controls.Add(this.lblLetter);
            this.tabBasic.Controls.Add(this.lblCharacters);
            this.tabBasic.Controls.Add(this.txtbxLetter3);
            this.tabBasic.Controls.Add(this.txtbxLetter2);
            this.tabBasic.Controls.Add(this.txtbxLetter1);
            this.tabBasic.Controls.Add(this.txtbxCharacters);
            this.tabBasic.Controls.Add(this.nudWordLength);
            this.tabBasic.Controls.Add(this.nudAtPosition1);
            this.tabBasic.Controls.Add(this.nudAtPosition2);
            this.tabBasic.Controls.Add(this.nudAtPosition3);
            this.tabBasic.Controls.Add(this.lblAtPosition3);
            this.tabBasic.Controls.Add(this.lblWordLength);
            this.tabBasic.Controls.Add(this.lblAtPosition2);
            this.tabBasic.Controls.Add(this.lblAtPosition1);
            this.tabBasic.Location = new System.Drawing.Point(4, 22);
            this.tabBasic.Name = "tabBasic";
            this.tabBasic.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasic.Size = new System.Drawing.Size(520, 388);
            this.tabBasic.TabIndex = 0;
            this.tabBasic.Text = "Basic";
            this.tabBasic.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Basic Word Game";
            // 
            // lblLetter3
            // 
            this.lblLetter3.AutoSize = true;
            this.lblLetter3.Location = new System.Drawing.Point(106, 249);
            this.lblLetter3.Name = "lblLetter3";
            this.lblLetter3.Size = new System.Drawing.Size(50, 13);
            this.lblLetter3.TabIndex = 28;
            this.lblLetter3.Text = "Letter #3";
            // 
            // lblLetter2
            // 
            this.lblLetter2.AutoSize = true;
            this.lblLetter2.Location = new System.Drawing.Point(106, 183);
            this.lblLetter2.Name = "lblLetter2";
            this.lblLetter2.Size = new System.Drawing.Size(50, 13);
            this.lblLetter2.TabIndex = 27;
            this.lblLetter2.Text = "Letter #2";
            // 
            // lblLetter
            // 
            this.lblLetter.AutoSize = true;
            this.lblLetter.Location = new System.Drawing.Point(106, 124);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(34, 13);
            this.lblLetter.TabIndex = 26;
            this.lblLetter.Text = "Letter";
            // 
            // lblCharacters
            // 
            this.lblCharacters.AutoSize = true;
            this.lblCharacters.Location = new System.Drawing.Point(106, 67);
            this.lblCharacters.Name = "lblCharacters";
            this.lblCharacters.Size = new System.Drawing.Size(58, 13);
            this.lblCharacters.TabIndex = 25;
            this.lblCharacters.Text = "Characters";
            // 
            // txtbxLetter3
            // 
            this.txtbxLetter3.Location = new System.Drawing.Point(109, 265);
            this.txtbxLetter3.Name = "txtbxLetter3";
            this.txtbxLetter3.Size = new System.Drawing.Size(100, 20);
            this.txtbxLetter3.TabIndex = 24;
            // 
            // txtbxLetter2
            // 
            this.txtbxLetter2.Location = new System.Drawing.Point(109, 200);
            this.txtbxLetter2.Name = "txtbxLetter2";
            this.txtbxLetter2.Size = new System.Drawing.Size(100, 20);
            this.txtbxLetter2.TabIndex = 23;
            // 
            // txtbxLetter1
            // 
            this.txtbxLetter1.Location = new System.Drawing.Point(109, 140);
            this.txtbxLetter1.Name = "txtbxLetter1";
            this.txtbxLetter1.Size = new System.Drawing.Size(100, 20);
            this.txtbxLetter1.TabIndex = 22;
            // 
            // txtbxCharacters
            // 
            this.txtbxCharacters.Location = new System.Drawing.Point(109, 83);
            this.txtbxCharacters.Name = "txtbxCharacters";
            this.txtbxCharacters.Size = new System.Drawing.Size(100, 20);
            this.txtbxCharacters.TabIndex = 21;
            // 
            // nudWordLength
            // 
            this.nudWordLength.Location = new System.Drawing.Point(268, 83);
            this.nudWordLength.Name = "nudWordLength";
            this.nudWordLength.Size = new System.Drawing.Size(120, 20);
            this.nudWordLength.TabIndex = 8;
            // 
            // nudAtPosition1
            // 
            this.nudAtPosition1.Location = new System.Drawing.Point(268, 140);
            this.nudAtPosition1.Name = "nudAtPosition1";
            this.nudAtPosition1.Size = new System.Drawing.Size(120, 20);
            this.nudAtPosition1.TabIndex = 9;
            // 
            // nudAtPosition2
            // 
            this.nudAtPosition2.Location = new System.Drawing.Point(268, 200);
            this.nudAtPosition2.Name = "nudAtPosition2";
            this.nudAtPosition2.Size = new System.Drawing.Size(120, 20);
            this.nudAtPosition2.TabIndex = 10;
            // 
            // nudAtPosition3
            // 
            this.nudAtPosition3.Location = new System.Drawing.Point(268, 265);
            this.nudAtPosition3.Name = "nudAtPosition3";
            this.nudAtPosition3.Size = new System.Drawing.Size(120, 20);
            this.nudAtPosition3.TabIndex = 11;
            // 
            // lblAtPosition3
            // 
            this.lblAtPosition3.AutoSize = true;
            this.lblAtPosition3.Location = new System.Drawing.Point(265, 249);
            this.lblAtPosition3.Name = "lblAtPosition3";
            this.lblAtPosition3.Size = new System.Drawing.Size(57, 13);
            this.lblAtPosition3.TabIndex = 15;
            this.lblAtPosition3.Text = "At Position";
            // 
            // lblWordLength
            // 
            this.lblWordLength.AutoSize = true;
            this.lblWordLength.Location = new System.Drawing.Point(265, 67);
            this.lblWordLength.Name = "lblWordLength";
            this.lblWordLength.Size = new System.Drawing.Size(69, 13);
            this.lblWordLength.TabIndex = 12;
            this.lblWordLength.Text = "Word Length";
            // 
            // lblAtPosition2
            // 
            this.lblAtPosition2.AutoSize = true;
            this.lblAtPosition2.Location = new System.Drawing.Point(265, 183);
            this.lblAtPosition2.Name = "lblAtPosition2";
            this.lblAtPosition2.Size = new System.Drawing.Size(57, 13);
            this.lblAtPosition2.TabIndex = 14;
            this.lblAtPosition2.Text = "At Position";
            // 
            // lblAtPosition1
            // 
            this.lblAtPosition1.AutoSize = true;
            this.lblAtPosition1.Location = new System.Drawing.Point(265, 124);
            this.lblAtPosition1.Name = "lblAtPosition1";
            this.lblAtPosition1.Size = new System.Drawing.Size(57, 13);
            this.lblAtPosition1.TabIndex = 13;
            this.lblAtPosition1.Text = "At Position";
            // 
            // tabctrlGames
            // 
            this.tabctrlGames.Controls.Add(this.tabBasic);
            this.tabctrlGames.Controls.Add(this.tabWordle);
            this.tabctrlGames.Controls.Add(this.tabDatabase);
            this.tabctrlGames.Location = new System.Drawing.Point(12, 44);
            this.tabctrlGames.Name = "tabctrlGames";
            this.tabctrlGames.SelectedIndex = 0;
            this.tabctrlGames.Size = new System.Drawing.Size(528, 414);
            this.tabctrlGames.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Possible Words";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(713, 551);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chbxAllCombinations);
            this.Controls.Add(this.tabctrlGames);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lstbxWords);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Word Helper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabDatabase.ResumeLayout(false);
            this.tabDatabase.PerformLayout();
            this.tabWordle.ResumeLayout(false);
            this.tabWordle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWordle)).EndInit();
            this.tabBasic.ResumeLayout(false);
            this.tabBasic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWordLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAtPosition1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAtPosition2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAtPosition3)).EndInit();
            this.tabctrlGames.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstbxWords;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.CheckBox chbxAllCombinations;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripSelected;
        private System.Windows.Forms.TabPage tabDatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteWord;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.TextBox txtbxAddWord;
        private System.Windows.Forms.Button btnToGood;
        private System.Windows.Forms.Button btnToDeleted;
        private System.Windows.Forms.ListBox lstbxDeletedWords;
        private System.Windows.Forms.ListBox lstbxGoodWords;
        private System.Windows.Forms.TabPage tabWordle;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvWordle;
        private System.Windows.Forms.TabPage tabBasic;
        private System.Windows.Forms.Label lblLetter3;
        private System.Windows.Forms.Label lblLetter2;
        private System.Windows.Forms.Label lblLetter;
        private System.Windows.Forms.Label lblCharacters;
        private System.Windows.Forms.TextBox txtbxLetter3;
        private System.Windows.Forms.TextBox txtbxLetter2;
        private System.Windows.Forms.TextBox txtbxLetter1;
        private System.Windows.Forms.TextBox txtbxCharacters;
        private System.Windows.Forms.NumericUpDown nudWordLength;
        private System.Windows.Forms.NumericUpDown nudAtPosition1;
        private System.Windows.Forms.NumericUpDown nudAtPosition2;
        private System.Windows.Forms.NumericUpDown nudAtPosition3;
        private System.Windows.Forms.Label lblAtPosition3;
        private System.Windows.Forms.Label lblWordLength;
        private System.Windows.Forms.Label lblAtPosition2;
        private System.Windows.Forms.Label lblAtPosition1;
        private System.Windows.Forms.TabControl tabctrlGames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

