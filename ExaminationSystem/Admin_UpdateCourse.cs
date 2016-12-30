using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExaminationSystem.entities;
using ExaminationSystem.instatnce;
using ExaminationSystem.Collection;
using ExaminationSystem.DAL;
using ExaminationSystem.database;

namespace ExaminationSystem
{
    public partial class  Admin_UpdateCourse : Form 
    {
        DepartmentCollection depts;
        public Admin_UpdateCourse()
        {
            InitializeComponent();
            
        }

        private void Admin_UpdateCourse_Load(object sender, EventArgs e)
        {

            textBox1.Text = MyCourse.C.Name;
            depts = DepartmentDAL.GetAll();
            
           for (int i = 0; i < depts.Count; i++)
            {

                ComboboxItem item = new ComboboxItem();
                item.Text = depts[i].Name;
                item.Value = depts[i].Id;
                comboBox1.Items.Add(item);
                
            }

            String text;
            int id;
            int super = 0;
            for (int i=0; i<depts.Count; i++)
            {
                if (depts[i].Id == MyCourse.C.Deparment.Id)
                {
                    super = i;
                    break;
                }
            }
           
            comboBox1.SelectedText = MyCourse.C.Deparment.Name;
            comboBox1.SelectedValue = MyCourse.C.Deparment.Id;
            comboBox1.SelectedIndex = super;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Course cc = new Course();
            cc.Id = MyCourse.C.Id;
            cc.Name = textBox1.Text;

            Department d  = new Department(depts[comboBox1.SelectedIndex].Id, depts[comboBox1.SelectedIndex].Name);
            cc.Deparment = d;
            bool b = CourseDAL.Update(cc);
            if (b)
            {
                MessageBox.Show("The calculations are complete", "My Application",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }
    }
}
