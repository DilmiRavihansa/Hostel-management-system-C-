using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostalMngm_System
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }

 

        private void label_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms();
            rooms.Show();
            this.Hide();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Details student = new Student_Details();
            student.Show();
            this.Hide();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            this.Hide();

        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Furniture furniture = new Furniture();
            furniture.Show();
            this.Hide();
        }

        private void furnitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
            this.Hide();
        }
    }
}
