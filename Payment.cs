using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostalMngm_System
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxPayID.Clear();
            radioButtonCard.Enabled = false;
            radioButtonCash.Enabled = false;
            textBoxAmount.Clear();
            textBoxPayDesc.Clear();
            textBoxAdmin_ID.Clear();
        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            try
            {
                Connection obj = new Connection();

                string sql = "Select * from Payment";
                SqlCommand conobj = new SqlCommand(sql, obj.GetDBCon());
                SqlDataAdapter adapter = new SqlDataAdapter(conobj);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                //Display data in DataGridView
                dataGridViewAll.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Home_Page home = new Home_Page();
            home.Show();
            this.Hide();
        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string Admin_ID=Convert.ToString(textBoxAdmin_ID.Text);
            try
            {
                Connection conobj = new Connection();
                SqlConnection obj = conobj.GetDBCon();

                if (textBoxPayID.Text != null && (radioButtonCard.Checked || radioButtonCash.Checked) && textBoxAmount.Text != null && textBoxPayDesc.Text != null && textBoxAdmin_ID.Text != null)
                {
                    string type;
                    if(radioButtonCard.Checked)
                    {
                        type = "Card";
                    }
                    else
                    {
                        type = "Cash";
                    }
                    string sql = "Insert into Payment(Payment_ID,Payment_type,Amount,Pay_description,Admin_ID)" +
                    "Values('" + textBoxPayID.Text + "','" + type + "','" + textBoxAmount.Text + "','" + textBoxPayDesc.Text + "','"+Admin_ID+"')";

                    SqlCommand connobj = new SqlCommand(sql, obj);
                    connobj.ExecuteNonQuery();
                    MessageBox.Show("Record inserted successfully");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed" + ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Connection conobj = new Connection();
                SqlConnection obj = conobj.GetDBCon();

                if (textBoxPayID.Text != null && (radioButtonCard.Checked || radioButtonCash.Checked) && textBoxAmount.Text != null && textBoxPayDesc.Text != null && textBoxAdmin_ID.Text != null)
                {
                    string type;

                    if (radioButtonCard.Checked)
                    {
                        type = "Card";
                    }
                    else
                    {
                        type = "Cash";
                    }
                    string sql = "Update Payment Set Payment_type='" +type+ "',Amount='" + textBoxAmount.Text + "',Pay_description='" + textBoxPayDesc.Text + "',Admin_ID='" + textBoxAdmin_ID.Text + "'" +
                        "Where Payment_ID='" + textBoxPayID.Text + "'";

                    SqlCommand connobj = new SqlCommand(sql,obj);
                    connobj.ExecuteNonQuery();
                    MessageBox.Show("Record updated successfully");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connectio failed" + ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Connection conobj = new Connection();
                SqlConnection obj = conobj.GetDBCon();

                string sql = "Delete from Payment Where Payment_ID='" + textBoxPayID.Text + "'";

                SqlCommand connobj = new SqlCommand(sql, obj);
                connobj.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection failed" + ex.Message);
            }
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAmount.Text != string.Empty) 
            {
                labelMsgPayAmount.Visible=false;
            }
            else
            { 
                labelMsgPayAmount.Visible=true;
            }
        }   
    }
}

