using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WordHelper
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load_1(object sender, EventArgs e)
        {
            initLogger();
            initWordGameInterface();
            initWordleInterface();
            initDatabaseConnection();
            statusStripSelected.Text = "Welcome!";
            Log.Information("Program opened!");

        }
        private void initLogger()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File("log-.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            Log.Information("Logger was initialized successfully.");
        }
        private void closeLogger()
        {
            Log.Information("Closing logger.");
            Log.CloseAndFlush();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.Information("Form exited from tool strip menu");
            System.Windows.Forms.Application.Exit();
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeDatabaseConnection();
            closeLogger();
            Log.Information("Cosing form, bye bye.");
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //word game basic is selected
            if (tabctrlGames.SelectedIndex == 0)
            {
                if (!isWordleClear)
                {
                    resetWordle();
                }
                calculateWordGame();
            }
            //wordle tab is selected
            else if (tabctrlGames.SelectedIndex == 1)
            {
                calculateWordle();
            }
        }
        //function to determine which word combos to show given the checkbox and tab page selected
        private void chbxShowMore_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxAllCombinations.Checked)
            {

                if (tabctrlGames.SelectedIndex == 0)
                {
                    statusStripSelected.Text = "Showing permutations before dictionary filter.";
                    Log.Information("Showing Basic Word Game permutations (pre dictionary filter).");
                    lstbxWords.Items.Clear();
                    foreach (string word in preDict)
                    {
                        lstbxWords.Items.Add(word);
                    }
                    lstbxWords.Sorted = true;
                }
                else if (tabctrlGames.SelectedIndex == 1 && preDict.Any())
                {
                    statusStripSelected.Text = "Showing combos including last calculation's results";
                    Log.Information("Show More checkbox clicked in wordle");
                    lstbxWords.Items.Clear();
                    foreach (string word in preDict)
                    {
                        lstbxWords.Items.Add(word);
                    }
                    lstbxWords.Sorted = true;
                }
                else if (tabctrlGames.SelectedIndex == 1 && !preDict.Any())
                {
                    statusStripSelected.Text = "No previous calculations to see.";
                    Log.Information("Show More checkbox clicked in wordle, but there are no previous calculatiosn.");
                }
            }
            else
            {
                lstbxWords.Items.Clear();
                foreach (string word in postDict)
                {
                    lstbxWords.Items.Add(word);
                }
                lstbxWords.Sorted = true;
                statusStripSelected.Text = "Showing calculation results";
                Log.Information("Shwoing calculation results");
            }
        }
    }
}
