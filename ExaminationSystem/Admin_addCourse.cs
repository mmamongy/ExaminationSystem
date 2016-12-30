using ExaminationSystem.Collection;
using ExaminationSystem.DAL;
using ExaminationSystem.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class Admin_addCourse : Form
    {
        DepartmentCollection depts;
        public Admin_addCourse()
        {
            InitializeComponent();
            depts = DepartmentDAL.GetAll();
            for (int i = 0; i < depts.Count; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = depts[i].Name;
                item.Value = depts[i].Id;
                comboBox1.Items.Add(item);
                comboBox1.SelectedIndex = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Department x = new Department(depts[comboBox1.SelectedIndex].Id, depts[comboBox1.SelectedIndex].Name);
            DAL.CourseDAL.Add(textBox1.Text, x);
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
