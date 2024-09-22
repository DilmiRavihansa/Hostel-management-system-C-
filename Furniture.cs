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
    public partial class Furniture : Form
    {
        public Furniture()
        {
            InitializeComponent();
            comboBoxFurniture_Type.SelectedItem = 0;
        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            try
            {
                Connection obj = new Connection();

                string sql = "Select * from Furniture";
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
            textBoxFurnitureID.Clear();
            comboBoxFurniture_Type.SelectedItem=null;
            textBoxQuantity.Clear();
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

                if(textBoxFurnitureID.Text!=null && comboBoxFurniture_Type.SelectedItem!=null && textBoxQuantity.Text!=null)
                {
                    string sql="Insert into Furniture(Furniture_ID,Furniture_type,Quantity)"+
                    "Values('"+textBoxFurnitureID.Text+"','"+comboBoxFurniture_Type.SelectedItem+"','"+textBoxQuantity.Text+"')";

                    SqlCommand connobj = new SqlCommand(sql, obj);
                    connobj.ExecuteNonQuery();
                    MessageBox.Show("Record inserted successfully");
                }
            }
            catch(Exception ex)
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

                if (textBoxFurnitureID.Text != null && comboBoxFurniture_Type.SelectedItem != null && textBoxQuantity.Text != null)
                {
                    string sql = "Update Furniture Set Furniture_type='" + comboBoxFurniture_Type.SelectedItem + "',Quantity='" + textBoxQuantity.Text + "'"+
                    "Where Furniture_ID='" + textBoxFurnitureID.Text + "'";

                    SqlCommand connobj = new SqlCommand(sql, obj);
                    connobj.ExecuteNonQuery();
                    MessageBox.Show("Record updated successfully");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed" + ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Connection conobj = new Connection();
                SqlConnection obj = conobj.GetDBCon();
                
                string sql = "Delete from Furniture Where Furniture_ID='" + textBoxFurnitureID.Text + "'";

                SqlCommand connobj = new SqlCommand(sql, obj);
                connobj.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed" + ex.Message);
            }
        }

       
    }
}
