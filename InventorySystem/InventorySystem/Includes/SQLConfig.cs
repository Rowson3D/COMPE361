using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SQLite.Generic;
using System.Data;

namespace InventorySystem
{
    class SQLConfig
    {
        private SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;");
        private SQLiteCommand sqlite_cmd;
        private SQLiteDataAdapter sqlite_datadapter;
        public SQLiteDataReader sqlite_datareader;

        public DataTable dt;
       
        int result;

        usableFunction funct = new usableFunction();


        // Create a method that is called OpenConnection()
        public void OpenConnection()
        {
            // Open the connection
            sqlite_conn.Open();
        }

        // Create a method called sqlQuery(sql)
        public void sqlQuery(string sql)
        {
            sqlite_conn.Open();
            // Create a new SQLiteCommand object called sqlite_cmd
            sqlite_cmd = sqlite_conn.CreateCommand();

            // Set the CommandText property of sqlite_cmd to our sql query
            sqlite_cmd.CommandText = sql;

            // Call ExecuteReader() on the sqlite_cmd object
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            // Create a new datatable object
            dt = new DataTable();

            // Use the Load method of our datatable object to load the sqlite_datareader data
            dt.Load(sqlite_datareader);

            sqlite_conn.Close();
        }

        public void Execute_CUD(string sql, string msg_false, string msg_true)
        {
            try
            {
                sqlite_conn.Open();
                sqlite_cmd = new SQLiteCommand();
                sqlite_cmd.Connection = sqlite_conn;
                sqlite_cmd.CommandText = sql;
                result = sqlite_cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(msg_true);
                }
                else
                {
                    MessageBox.Show(msg_false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlite_conn.Close();
            }
        }

        



        // Create a checkExists method to check if the data already exists in the database
        public bool checkExists(string sql)
        {
            try
            {
                sqlite_conn.Open();
                sqlite_cmd = new SQLiteCommand();
                sqlite_cmd.Connection = sqlite_conn;
                sqlite_cmd.CommandText = sql;
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                if (sqlite_datareader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                sqlite_conn.Close();
            }
        }

    


        public void Execute_Query(string sql)
        {
            try
            {
                sqlite_conn.Open();
                sqlite_cmd = new SQLiteCommand();
                sqlite_cmd.Connection = sqlite_conn;
                sqlite_cmd.CommandText = sql;
                result = sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlite_conn.Close();
            }
        }

        public void Load_DTG(string sql, DataGridView dtg)
        {
            try
            {
                sqlite_conn.Open();
                sqlite_cmd = new SQLiteCommand();
                sqlite_datadapter = new SQLiteDataAdapter();
                dt = new DataTable();

                sqlite_cmd.Connection = sqlite_conn;
                sqlite_cmd.CommandText = sql;
                sqlite_datadapter.SelectCommand = sqlite_cmd;
                sqlite_datadapter.Fill(dt);
                dtg.DataSource = dt;

                funct.ResponsiveDtg(dtg);
                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlite_conn.Close();
            }
        }

        public void fill_CBO(string sql, ComboBox cbo)
        {
            try
            {
                sqlite_conn.Open();
                sqlite_cmd = new SQLiteCommand();
                sqlite_datadapter = new SQLiteDataAdapter();
                dt = new DataTable();

                sqlite_cmd.Connection = sqlite_conn;
                sqlite_cmd.CommandText = sql;
                sqlite_datadapter.SelectCommand = sqlite_cmd;
                sqlite_datadapter.Fill(dt);
                cbo.DataSource = dt;
                cbo.ValueMember = dt.Columns[0].ColumnName;
                cbo.DisplayMember = dt.Columns[0].ColumnName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlite_conn.Close();
            }
        }

        public void singleResult(string sql)
        {
            try
            {
                sqlite_conn.Open();
                sqlite_cmd = new SQLiteCommand();
                sqlite_datadapter = new SQLiteDataAdapter();
                dt = new DataTable();

                sqlite_cmd.Connection = sqlite_conn;
                sqlite_cmd.CommandText = sql;
                sqlite_datadapter.SelectCommand = sqlite_cmd;
                sqlite_datadapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlite_conn.Close();
            }
        }

        public void autocomplete(string sql, TextBox txt)
        {
            try
            {
                sqlite_conn.Open();
                sqlite_cmd = new SQLiteCommand();
                sqlite_datadapter = new SQLiteDataAdapter();
                dt = new DataTable();

                sqlite_cmd.Connection = sqlite_conn;
                sqlite_cmd.CommandText = sql;
                sqlite_datadapter.SelectCommand = sqlite_cmd;
                sqlite_datadapter.Fill(dt);
                txt.AutoCompleteCustomSource.Clear();
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                foreach (DataRow dr in dt.Rows)
                {
                    txt.AutoCompleteCustomSource.Add(dr[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlite_conn.Close();
            }
        }

        public void autonumber(string sql, TextBox txt)
        {
            try
            {
                sqlite_conn.Open();
                sqlite_cmd = new SQLiteCommand();
                sqlite_datadapter = new SQLiteDataAdapter();
                dt = new DataTable();

                sqlite_cmd.Connection = sqlite_conn;
                sqlite_cmd.CommandText = sql;
                sqlite_datadapter.SelectCommand = sqlite_cmd;
                sqlite_datadapter.Fill(dt);

                txt.Text = dt.Rows[0].Field<string>(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlite_conn.Close();
            }
        }

        public void update_Autonumber(string id)
        {
            Execute_Query("UPDATE autonumber SET id = '" + id + "' WHERE id = '" + id + "'");
        }     
    }
}