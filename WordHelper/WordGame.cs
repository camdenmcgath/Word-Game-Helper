using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordHelper
{
    //contains the code for the Basic Word Game
    public partial class frmMain : Form
    {
        static List<string> biggestList = new List<string>();
        static List<string> toDelete = new List<string>();
        static List<string> preDict = new List<string>();
        static List<string> postDict = new List<string>();
        
        private void initWordGameInterface()
        {
            //set max length for inputs
            txtbxCharacters.MaxLength = 7;
            txtbxLetter1.MaxLength = 1;
            txtbxLetter2.MaxLength = 1;
            txtbxLetter3.MaxLength = 1;
            //set textbox's to uppercase
            txtbxCharacters.CharacterCasing = CharacterCasing.Upper;
            txtbxLetter1.CharacterCasing = CharacterCasing.Upper;
            txtbxLetter2.CharacterCasing = CharacterCasing.Upper;
            txtbxLetter3.CharacterCasing = CharacterCasing.Upper;
        }
        private void calculateWordGame()
        {
            Log.Information("Calculating word game...");
            Log.Information("Clearing lists before calculations...");
            //reset all lists
            biggestList.Clear();
            toDelete.Clear();
            preDict.Clear();
            postDict.Clear();
            lstbxWords.Items.Clear();

            char[] inWord = txtbxCharacters.Text.ToUpper().ToCharArray();

            //use with dictionary to get all possible words
            biggestList = GetArrayPermutations(inWord); 

            Log.Information("Filtering based on user specs...");

            if (nudWordLength.Value > 0)
            {
                // remove all list items whose length is not equal to specified
                for (int i = biggestList.Count - 1; i >= 0; i--)
                {
                    if (biggestList[i].Length != nudWordLength.Value)
                    {
                        toDelete.Add(biggestList[i]);
                    }
                }
            }
            statusStripSelected.Text = "Removing specified combinations";
            biggestList = biggestList.Except(toDelete).ToList();
            toDelete.Clear();
            Refresh();

            //lambda for filtering words based on user letter and position specs
            Action<TextBox, NumericUpDown> filter = (txtbx, nud) =>
            {
                if (txtbx.Text != string.Empty && nud.Value > 0)
                {
                    int pos = Convert.ToInt32(Math.Round(nudAtPosition1.Value, 0)) - 1;
                    for (int i = biggestList.Count - 1; i >= 0; i--)
                    {
                        if (biggestList[i].Length <= pos
                        || biggestList[i][pos] != txtbxLetter1.Text[0])
                        {
                            toDelete.Add(biggestList[i]);
                        }
                    }
                }
            };

            filter(txtbxLetter1, nudAtPosition1);
            filter(txtbxLetter2, nudAtPosition2);
            filter(txtbxLetter3, nudAtPosition3);
            biggestList = biggestList.Except(toDelete).ToList();
            toDelete.Clear();
            preDict = biggestList;
            preDict.Sort();

            statusStripSelected.Text = "Spell checking...";
            Refresh();

            //initialize dictionary 
            NetSpell.SpellChecker.Dictionary.WordDictionary oDict = new NetSpell.SpellChecker.Dictionary.WordDictionary();
            oDict.DictionaryFile = Directory.GetCurrentDirectory() + @"\..\..\..\packages\NetSpell.2.1.7\dic\en-US.dic";
            oDict.Initialize();

            NetSpell.SpellChecker.Spelling oSpell = new NetSpell.SpellChecker.Spelling();

            string wordToCheck;
            oSpell.Dictionary = oDict;
            for (int i = biggestList.Count - 1; i >= 0; i--)
            {
                // get a word
                wordToCheck = biggestList[i];

                //dictionary doesn't contain word
                if (!oSpell.TestWord(wordToCheck))
                {
                    //good words table doesn't contain 
                    if (lstbxGoodWords.FindStringExact(wordToCheck) == ListBox.NoMatches)
                    {
                        toDelete.Add(wordToCheck);
                    }
                }
                if (lstbxDeletedWords.FindStringExact(wordToCheck) != ListBox.NoMatches)
                {
                    toDelete.Add(wordToCheck);
                }
            }
            postDict = biggestList.Except(toDelete).ToList();
            postDict.Sort();

            Log.Information("Word Game results:");
            foreach (string word in postDict)
            {
                lstbxWords.Items.Add(word);
                Log.Information(word);
            }
            lstbxWords.Sorted = true;
            statusStripSelected.Text = "Done Calculating";
            Refresh();
        }
    }
}
