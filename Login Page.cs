using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HostalMngm_System
{
    public partial class LoginPage : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DD80ACK;Initial Catalog=Hostel_Management_System;Integrated Security=True");

        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxAdminId.Text = null;
            textBoxUserName.Text = null;
            textBoxPws.Text = null;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSign_In_Click(object sender, EventArgs e)
        {
            int Admin_ID = Convert.ToInt32(textBoxAdminId.Text);
            string UserName = textBoxUserName.Text;
            string Password = textBoxPws.Text;

            try
            {
                string sql = "SELECT * FROM Log_in WHERE Password='" + Password + "' AND UserName='" + UserName + "' AND Admin_ID='" + Admin_ID + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    Home_Page home = new Home_Page();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void textBoxPws_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPws.Text != String.Empty)
            {
                e.Cancel = false;
                errorProviderPassword.SetError(textBoxPws, "");
            }
            else
            {
                e.Cancel = true;
                errorProviderPassword.SetError(textBoxPws, "Please enter a value");
            }
        }
    }
}
