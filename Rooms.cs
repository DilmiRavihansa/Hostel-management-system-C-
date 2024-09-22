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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
            comboBoxRoomType.SelectedIndex = 0;
        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            try
            {
                Connection obj = new Connection();

                string sql = "Select * from Room";
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxRoomNo.Text= string.Empty;
            comboBoxRoomType.Items.Clear();
            textBoxRoomDescription.Text= string.Empty;
            textBoxHostal_Id.Text= string.Empty;
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
            try
            {
                Connection conobj = new Connection();
                SqlConnection obj = conobj.GetDBCon();

                if(textBoxRoomNo.Text!=null && comboBoxRoomType.SelectedItem!=null && textBoxRoomDescription.Text!=null && textBoxHostal_Id.Text!=null)
                {
                    string sql = "Insert into Room(Room_No,Room_Type,Room_Description,Hostel_ID)" +
                    "Values('" + textBoxRoomNo.Text + "','" + comboBoxRoomType.SelectedItem + "','" + textBoxRoomDescription.Text + "','" + textBoxHostal_Id.Text + "')";

                    SqlCommand connobj = new SqlCommand(sql, obj);
                    connobj.ExecuteNonQuery();
                    MessageBox.Show("Record inserted successfully");
                
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Connection failed"+ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Connection conobj = new Connection();
                SqlConnection obj = conobj.GetDBCon();

                if (textBoxRoomNo.Text != null && comboBoxRoomType.SelectedItem != null && textBoxRoomDescription.Text != null && textBoxHostal_Id.Text != null)
                {
                    string sql = "Update Room Set Room_Type='" + comboBoxRoomType.SelectedItem + "',Room_Description='" + textBoxRoomDescription.Text + "',Hostel_ID='" + textBoxHostal_Id.Text + "'" +
                    "Where Room_No='" + textBoxRoomNo.Text + "'";

                    SqlCommand connobj = new SqlCommand(sql, obj);
                    connobj.ExecuteNonQuery();
                    MessageBox.Show("Record updated successfully");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection failed"+ex.Message );
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Connection conobj = new Connection();
                SqlConnection obj = conobj.GetDBCon();

                string sql = "Delete from Room Where Room_No='" + textBoxRoomNo.Text + "'";

                SqlCommand connobj = new SqlCommand(sql, obj);
                connobj.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully");
            }
            catch( Exception ex )
            {
                MessageBox.Show("Connection failed" + ex.Message);
            }
        }
    }
}
