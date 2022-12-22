using Serilog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordHelper
{
    //partial class contains the code for the wordle game tab
    public partial class frmMain : Form
    {
        static int wordleGuessCount = 0;
        bool isWordleClear = true;
        private void initWordleInterface()
        {
            Log.Information("Initializing Wordle interface...");
            dgvWordle.ColumnCount = 5;
            for (int i = 0; i < 5; i++)
            {
                dgvWordle.Columns[i].Width = 50;
            }
            dgvWordle.RowCount = 2;
            dgvWordle.ColumnHeadersVisible = false;
            dgvWordle.RowHeadersVisible = false;
            // set a cell to a button
            for (int i = 0; i < dgvWordle.Columns.Count; i++)
            {
                DataGridViewButtonCell bc = new DataGridViewButtonCell();
                dgvWordle.Rows[1].Cells[i] = bc;
                bc.Value = "Color";
                DataGridViewTextBoxCell tc = new DataGridViewTextBoxCell();
                tc.MaxInputLength = 1;
                dgvWordle.Rows[0].Cells[i] = tc;
            }
            //CellClick handler to handle clicks in the button column
            dgvWordle.CellClick +=
                new DataGridViewCellEventHandler(dgvWordle_CellClick);
        }
        //determines which color to switch to and cycle
        private void dgvWordle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != dgvWordle.Rows.Count - 1)
            {
                return;
            }
            else
            {
                DataGridViewCellStyle oldStyle = dgvWordle.Rows[e.RowIndex - 1].Cells[e.ColumnIndex].Style;
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                if ((oldStyle.BackColor != Color.Green && oldStyle.BackColor != Color.Yellow)
                    || oldStyle.BackColor == Color.White)  //not assigned
                {
                    style.BackColor = Color.Green;
                }
                else if (oldStyle.BackColor == Color.Green)
                {
                    style.BackColor = Color.Yellow;
                }
                else if (oldStyle.BackColor == Color.Yellow)
                {
                    style.BackColor = Color.White;
                }

                dgvWordle.Rows[e.RowIndex - 1].Cells[e.ColumnIndex].Style = style;
            }
        }
        private void resetWordle()
        {
            //Clear all lists and initialize interface
            Log.Information("Clearing wordle.");
            wordleGuessCount = 0;
            biggestList.Clear();
            toDelete.Clear();
            preDict.Clear();
            postDict.Clear();
            lstbxWords.Items.Clear();
            initWordleInterface();
            isWordleClear = true;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            resetWordle();
        }
        private void calculateWordle()
        {
            Log.Information("Calculating wordle...");
            isWordleClear = false;
            wordleGuessCount++;
            //set the next calculations previous solutions to last calculations results
            preDict = postDict;
            try
            {
                if (wordleGuessCount == 1)
                {
                    biggestList = File.ReadAllLines("valid-wordle-words.txt").ToList();
                    foreach (string word in lstbxGoodWords.Items)
                    {
                        if (word.Length == 5)
                        {
                            biggestList.Add(word.ToLower());
                        }
                    }
                }
                foreach (DataGridViewTextBoxCell cell in dgvWordle.Rows[wordleGuessCount - 1].Cells)
                {
                    //if cell is white, remove all words containing that letter
                    if (cell.Style.BackColor != Color.Yellow
                        && cell.Style.BackColor != Color.Green)
                    {
                        foreach (string word in biggestList)
                        {
                            if (word.Contains(cell.Value.ToString().ToLower()))
                            {
                                toDelete.Add(word);
                            }
                        }
                        biggestList = biggestList.Except(toDelete).ToList();
                        toDelete.Clear();
                    }
                    //if cell is yellow, remove all words not containing that word
                    //possibly add check to make sure also not in same position?
                    else if (cell.Style.BackColor == Color.Yellow)
                    {
                        foreach (string word in biggestList)
                        {
                            if (!word.Contains(cell.Value.ToString().ToLower())
                                || word[cell.ColumnIndex].ToString() == cell.Value.ToString().ToLower())
                            {
                                toDelete.Add(word);
                            }
                        }
                        biggestList = biggestList.Except(toDelete).ToList();
                        toDelete.Clear();
                    }
                    //cell is green, get rid of words with letters that don't match at the position of the cell
                    else if (cell.Style.BackColor == Color.Green)
                    {
                        int position = cell.ColumnIndex;
                        foreach (string word in biggestList)
                        {
                            if (word[position].ToString() != cell.Value.ToString().ToLower())
                            {
                                toDelete.Add(word);
                            }
                        }
                        biggestList = biggestList.Except(toDelete).ToList();
                        toDelete.Clear();
                    }
                }
                //remove words in the deleted personal database
                foreach (string word in lstbxDeletedWords.Items)
                {
                    if (biggestList.Contains(word.ToLower()) && word.Length == 5)
                    {
                        biggestList.Remove(word.ToLower());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Occurred while calculating wordle");
                Log.Information(ex.Message, "Occurred while calculating wordle");
                wordleGuessCount--;
                return;
            }

            postDict = biggestList;
            postDict.Sort();

            //insert new row for the next guess
            dgvWordle.Rows.InsertCopy(0, wordleGuessCount);
            for (int i = 0; i < dgvWordle.Rows[wordleGuessCount].Cells.Count; i++)
            {
                DataGridViewTextBoxCell tc = new DataGridViewTextBoxCell();
                tc.MaxInputLength = 1;
                dgvWordle.Rows[wordleGuessCount].Cells[i] = tc;
            }
            lstbxWords.Items.Clear();
            Log.Information("Wordle valid words:");
            foreach (string word in postDict)
            {
                Log.Information(word);
                lstbxWords.Items.Add(word);
            }
            lstbxWords.Sorted = true;
            statusStripSelected.Text = "Done Calculating";
            Refresh();
        }
    }
}
