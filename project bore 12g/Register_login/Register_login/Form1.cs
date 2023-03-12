using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register_login
{
    public partial class Register_Login : Form
    {
        public const string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\b0bs1\Desktop\RegisterForm\Vetov.mdb";
        public Register_Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void chbShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowpassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirm.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirm.PasswordChar = '*';
            }
        }

        private bool CheckPasswords()
        {
            return txtConfirm.Text == txtPassword.Text;
        }

        private void btnReg_Click(object sender, EventArgs e)
        {

            string myquery = "INSERT INTO Account VALUES ('" + txt_id.Text + "', '" + txtUsername.Text + "','" + txtPassword.Text + "')";
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            OleDbCommand command = new OleDbCommand(myquery, connection);


            if (txtPassword.Text.Length == 0 || txtConfirm.Text.Length == 0 || txtUsername.Text.Length == 0)
            {
                MessageBox.Show("Pishi grozen", "Nema kak da stanat neshata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                if (CheckPasswords())
                {
                    MessageBox.Show("Aide chichoooo", "Nahlu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Grozna rabota", "Trea poveche leb da qdesh grozen", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

           try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Aideeee neshata v database-a.");
            }
            catch (Exception ex)
            {
               // lbl_test.Text = "Exeption in DBHandler" + ex;
            }
            finally { connection.Close(); } 
        }

    }
}
