using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HostalMngm_System
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            comboBoxPost.SelectedIndex = 0;
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Connection conobj = new Connection();
                SqlConnection obj = conobj.GetDBCon();

                if (textBoxUserID.Text != null && textBoxFname.Text != null && textBoxLname.Text != null && textBoxEmail.Text != null && textBoxRoomNo.Text != null && textBoxAddress.Text != null && textBoxContact.Text != null && (radioButton_male.Checked || radioButton_female.Checked) && comboBoxPost.SelectedItem != null)
                {
                    string gender;

                    if (radioButton_male.Checked)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }
                    string sql = "Insert into  Users(UserID,FName,LName,User_Address,Gender,User_Email,Room_No)" +
                    "values('" + textBoxUserID.Text + "','" + textBoxFname.Text + "','" + textBoxLname.Text + "','" + textBoxAddress.Text + "','" + gender + "','" + textBoxEmail.Text + "','" + textBoxRoomNo.Text + "')";

                    string sql1 = "Insert into User_contact(UserID,User_Contact)" +
                    "values('" + textBoxUserID.Text + "','" + textBoxContact.Text + "')";

                    string sql2 = "Insert into Employee(UserID,Post)" +
                    "values('" + textBoxUserID.Text + "','" + comboBoxPost.SelectedItem + "')";


                    SqlCommand connobj = new SqlCommand(sql, obj);
                    connobj.ExecuteNonQuery();

                    SqlCommand connobj1 = new SqlCommand(sql1, obj);
                    connobj1.ExecuteNonQuery();

                    SqlCommand connobj2 = new SqlCommand(sql2, obj);
                    connobj2.ExecuteNonQuery();

                    MessageBox.Show("Record Saved Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection is failed" + ex.Message);

            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Connection conobj = new Connection();
                SqlConnection obj = conobj.GetDBCon();

                if (textBoxUserID.Text != null && textBoxFname.Text != null && textBoxLname.Text != null && textBoxEmail.Text != null && textBoxRoomNo.Text != null && textBoxAddress.Text != null && textBoxContact.Text != null && (radioButton_male.Checked || radioButton_female.Checked) && comboBoxPost.SelectedItem != null)
                {
                    string gender;

                    if (radioButton_male.Checked)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }
                    string sql = "Update Users Set FName='" + textBoxFname.Text + "',LName='" + textBoxLname.Text + "',User_Address='" + textBoxAddress.Text + "',Gender='" + gender + "',User_Email='" + textBoxEmail.Text + "',Room_No='" + textBoxRoomNo.Text + "'" +
                    "where UserID='" + textBoxUserID.Text + "'";

                    string sql1 = "Update User_contact Set User_Contact='" + textBoxContact.Text + "'" +
                    "where UserID='" + textBoxUserID.Text + "'";

                    string sql2 = "Update Employee Set Post='" + comboBoxPost.SelectedItem + "'" +
                    "where UserID='" + textBoxUserID.Text + "'";

                    SqlCommand connobj = new SqlCommand(sql, obj);
                    connobj.ExecuteNonQuery();

                    SqlCommand connobj1 = new SqlCommand(sql1, obj);
                    connobj1.ExecuteNonQuery();

                    SqlCommand connobj2 = new SqlCommand(sql2, obj);
                    connobj2.ExecuteNonQuery();

                    MessageBox.Show("Record Updated Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection is failed" + ex.Message);
            }
        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            try
            {
                Connection obj = new Connection();

                string sql = "Select * from Users";
                SqlCommand conobj = new SqlCommand(sql, obj.GetDBCon());
                SqlDataAdapter adapter = new SqlDataAdapter(conobj);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                //Display data in data grid view
                dataGridViewUserEmployee.DataSource = datatable;


                string sql1 = "Select * from User_contact";
                SqlCommand conobj1 = new SqlCommand(sql1, obj.GetDBCon());
                SqlDataAdapter adapter1 = new SqlDataAdapter(conobj1);
                DataTable datatable1 = new DataTable();
                adapter1.Fill(datatable1);
                //Display data in data grid view
                dataGridViewContact.DataSource = datatable1;


                string sql2 = "Select * from Employee";
                SqlCommand conobj2 = new SqlCommand(sql2, obj.GetDBCon());
                SqlDataAdapter adapter2 = new SqlDataAdapter(conobj2);
                DataTable datatable2 = new DataTable();
                adapter2.Fill(datatable2);
                //Display data in data grid view
                dataGridViewPost.DataSource = datatable2;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUserID.Text = null;
            textBoxFname.Text = null;
            textBoxLname.Text = null;
            textBoxAddress.Text = null;
            textBoxEmail.Text = null;
            textBoxRoomNo.Text = null;
            textBoxContact.Text = null;
            comboBoxPost.SelectedItem = null;
            radioButton_male.Checked = false;
            radioButton_female.Checked = false;
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

        private void textBoxContact_TextChanged(object sender, EventArgs e)
        {
            if (textBoxContact.Text != string.Empty)
            {
                labelMsgContact.Visible = false;
            }
            else
            {
                labelMsgContact.Visible = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Connection conobj = new Connection();
                SqlConnection obj = conobj.GetDBCon();

                string sql = "Delete from User_contact where UserID='" + textBoxUserID.Text + "'";

                string sql1 = "Delete from Employee where UserID='" + textBoxUserID.Text + "'";

                string sql2 = "Delete from Users where UserID='" + textBoxUserID.Text + "'";

                SqlCommand connobj = new SqlCommand(sql, obj);
                connobj.ExecuteNonQuery();

                SqlCommand connobj1 = new SqlCommand(sql1, obj);
                connobj1.ExecuteNonQuery();

                SqlCommand connobj2 = new SqlCommand(sql2, obj);
                connobj2.ExecuteNonQuery();

                MessageBox.Show("Record deleted successfully");

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
