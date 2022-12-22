using Serilog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WordHelper
{
    //Contains code for the database tab
    public partial class frmMain : Form
    {
        SqlConnection _cn = new SqlConnection(_cnString);

        const string _cnString = "Data Source=CS-GP-S;Initial Catalog=OurDictionary;"
        + "Integrated Security=False;User Id=wordee;Password=Let me in, please.;"
        + "MultipleActiveResultSets=True";
        private void initDatabaseConnection()
        {
            _cn.Open();
            RefreshWords();
        }
        private void RefreshWords()
        {
            try
            {
                //refresh list of good words
                lstbxGoodWords.Items.Clear();
                string sql = "SELECT word FROM dbo.cmcgath_GoodWords";
                SqlCommand cmd = new SqlCommand(sql, _cn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lstbxGoodWords.Items.Add(reader["word"].ToString());
                }
                reader.Close();

                //refresh list of deleted words
                lstbxDeletedWords.Items.Clear();
                string sql2 = "SELECT word FROM dbo.cmcgath_DeletedWords";
                SqlCommand cmd2 = new SqlCommand(sql2, _cn);
                cmd2.CommandType = CommandType.Text;
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    lstbxDeletedWords.Items.Add(reader2["word"].ToString());
                }
                reader2.Close();

            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error in Refresh Words.");
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void btnAddWord_Click(object sender, EventArgs e)
        {
            if (txtbxAddWord.Text == String.Empty) { return; }

            try
            {
                string sql = "INSERT INTO dbo.cmcgath_GoodWords(Word) VALUES('" + txtbxAddWord.Text.ToUpper() + "')";
                SqlCommand cmd = new SqlCommand(sql, _cn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                RefreshWords();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error in the Add Word.");
                MessageBox.Show(ex.Message);
                return;
            }

        }
        private void btnDeleteWord_Click(object sender, EventArgs e)
        {
            if (lstbxDeletedWords.SelectedIndex < 0) { return; }
            try
            {
                string word = lstbxDeletedWords.SelectedItem.ToString();
                string sql = "DELETE dbo.cmcgath_DeletedWords WHERE word = '" + word + "'";
                SqlCommand cmd = new SqlCommand(sql, _cn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                RefreshWords();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error in the Add Word.");
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void btnToGood_Click(object sender, EventArgs e)
        {
            //delete from main list, add to deleted list
            if (lstbxDeletedWords.SelectedItems.Count == 0) { return; }

            string selected = lstbxDeletedWords.Text;

            lstbxGoodWords.Items.Add(selected);
            lstbxDeletedWords.Items.Remove(selected);
            //update database
            string sql = "dbo.cmcgath_RestoreWord";
            SqlCommand cmd = new SqlCommand(sql, _cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("word", selected);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Log.Information(ex.Message);
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void btnToDeleted_Click(object sender, EventArgs e)
        {
            //delete from main list, add to deleted list
            if (lstbxGoodWords.SelectedItems.Count == 0) { return; }

            string selected = lstbxGoodWords.Text;

            lstbxDeletedWords.Items.Add(selected);
            lstbxGoodWords.Items.Remove(selected);
            //update database
            string sql = "dbo.cmcgath_DeleteWord";
            SqlCommand cmd = new SqlCommand(sql, _cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("word", selected);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Log.Information(ex.Message);
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void closeDatabaseConnection()
        {
            _cn.Close();
        }
    }
}
