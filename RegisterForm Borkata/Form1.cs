using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace RegisterForm
{
    public partial class Form1 : Form
    {
        public const string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\b0bs1\Desktop\RegisterForm\Vetov.mdb";
        public Form1()
        {
            
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_showpass.Checked)
            {
                txtBox_pass.PasswordChar = '\0';
                txtBox_confpass.PasswordChar = '\0';
            }
            else
            {
                txtBox_pass.PasswordChar = '*';
                txtBox_confpass.PasswordChar = '*';
            }
        }
        private bool CheckPasswords()
        {
            return txtBox_confpass.Text == txtBox_pass.Text;
        }
        private void btn_reg_Click(object sender, EventArgs e)
        {
            string myquery = "INSERT INTO Account VALUES ('" + txt_id.Text + "', '" + txtBox_user.Text + "','" + txtBox_pass.Text + "')";
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            OleDbCommand command = new OleDbCommand(myquery, connection);
            

            if (txtBox_pass.Text.Length == 0 || txtBox_confpass.Text.Length == 0 || txtBox_user.Text.Length == 0)
            {
                MessageBox.Show("Ne si pisal gluposti v neshata", "Ne uspq da vlezesh", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                if (CheckPasswords())
                {
                    MessageBox.Show("Aide vlezna uspeshno", "Evala", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Mn tupo lud", "Ne uspq da vlezesh", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
           
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Uspeshno zapazi neshata v database-a.");
            }
            catch (Exception ex)
            {
                lbl_test.Text = "Exeption in DBHandler" + ex;
            }
            finally { connection.Close(); }

        }
    }
}