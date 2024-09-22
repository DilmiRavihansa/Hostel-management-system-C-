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

namespace HostalMngm_System
{
    public partial class Student_Details : Form
    {
        public Student_Details()
        {
            InitializeComponent();
            comboBoxStudent_Type.SelectedIndex = 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Connection conobj = new Connection();
                SqlConnection obj = conobj.GetDBCon();

                if (textBoxID.Text != null && textBoxFname.Text != null && textBoxLname.Text != null && textBoxEmail.Text != null && textBoxRoomNo.Text != null && textBoxAddress.Text != null && textBoxContact.Text != null && (radioButtonMale.Checked || radioButtonFemale.Checked) && comboBoxStudent_Type.SelectedItem != null)
                {
                    string gender;
                    if (radioButtonMale.Checked)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }

                    string sql = "Insert into  Users(UserID,FName,LName,User_Address,Gender,User_Email,Room_No)" +
                    "values('" + textBoxID.Text + "','" + textBoxFname.Text + "','" + textBoxLname.Text + "','" + textBoxAddress.Text + "','" + gender + "','" + textBoxEmail.Text + "','" + textBoxRoomNo.Text + "')";

                    string sql1 = "Insert into User_contact(UserID,User_Contact)" +
                    "values('" + textBoxID.Text + "','" + textBoxContact.Text + "')";

                    string sql2 = "Insert into Student(UserID,Student_type)" +
                    "values('" + textBoxID.Text + "','" + comboBoxStudent_Type.SelectedItem + "')";

                     SqlCommand connobj = new SqlCommand(sql, obj);
                     connobj.ExecuteNonQuery();

                     SqlCommand connobj1 = new SqlCommand(sql1, obj);
                     connobj1.ExecuteNonQuery();

                     SqlCommand connobj2 = new SqlCommand(sql2,obj);
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

                if(textBoxID.Text != null && textBoxFname.Text != null && textBoxLname.Text != null && textBoxEmail.Text != null && textBoxRoomNo.Text != null && textBoxAddress.Text != null && textBoxContact.Text != null && (radioButtonMale.Checked || radioButtonFemale.Checked) && comboBoxStudent_Type.SelectedItem != null)
                {
                    string gender;
                    if (radioButtonMale.Checked)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }

                    string sql2 = "Update Users Set FName='" + textBoxFname.Text + "',LName='" + textBoxLname.Text + "',User_Address='" + textBoxAddress.Text + "',Gender='" +gender+ "',User_Email='" + textBoxEmail.Text + "', Room_No='" + textBoxRoomNo.Text + "'" +
                    "where UserID='" + textBoxID.Text + "'";

                    string sql = "Update User_contact Set User_Contact='" + textBoxContact.Text + "'" +
                    "where UserID='" + textBoxID.Text + "'";

                    string sql1 = "Update Student Set Student_type='" + comboBoxStudent_Type.SelectedItem + "'" +
                    "where UserID='" + textBoxID.Text + "'";

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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Connection conobj = new Connection();
                SqlConnection obj = conobj.GetDBCon();

                string sql = "Delete from User_contact where UserID='" + textBoxID.Text + "'";

                string sql1 = "Delete from Student where UserID='" + textBoxID.Text + "'";

                string sql2 = "Delete from Users where UserID='" + textBoxID.Text + "'";

                SqlCommand connobj = new SqlCommand(sql, obj);
                connobj.ExecuteNonQuery();

                SqlCommand connobj1 = new SqlCommand(sql1, obj);
                connobj1.ExecuteNonQuery();

                SqlCommand connobj2 = new SqlCommand(sql2,obj);
                connobj2.ExecuteNonQuery();

                MessageBox.Show("Record Deleted Successfully");

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
                dataGridViewUserStudent.DataSource = datatable;


                string sql1 = "Select * from User_contact";
                SqlCommand conobj1 = new SqlCommand(sql1, obj.GetDBCon());
                SqlDataAdapter adapter1 = new SqlDataAdapter(conobj1);
                DataTable datatable1 = new DataTable();
                adapter1.Fill(datatable1);
                //Display data in data grid view
                dataGridViewContact.DataSource = datatable1;


                string sql2 = "Select * from Student";
                SqlCommand conobj2 = new SqlCommand(sql2, obj.GetDBCon());
                SqlDataAdapter adapter2 = new SqlDataAdapter(conobj2);
                DataTable datatable2 = new DataTable();
                adapter2.Fill(datatable2);
                //Display data in data grid view
                dataGridViewType.DataSource = datatable2;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxID.Text = null;
            textBoxFname.Text = null;
            textBoxLname.Text = null;
            textBoxAddress.Text = null;
            textBoxEmail.Text = null;
            textBoxRoomNo.Text = null;
            comboBoxStudent_Type.SelectedItem = null;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            textBoxContact.Text = null;
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
    }
}
