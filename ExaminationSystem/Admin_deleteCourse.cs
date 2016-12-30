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
    public partial class Admin_deleteCourse : Form
    {
        CourseCollection courses;
        CourseCollection clChecked;
        public Admin_deleteCourse()
        {
            InitializeComponent();
            courses = new CourseCollection();
            courses = CourseDAL.SelectAll();
            for (int i = 0; i < courses.Count; i++)
            {
                ComboboxItem b = new ComboboxItem();
                b.Text = courses[i].Name;
                b.Value = courses[i].Id;
                checkedListBox1.Items.Add(b.Text);
            }

        }

        private void reFillCheckList()
        {
            courses = CourseDAL.SelectAll();
            for (int i = 0; i < courses.Count; i++)
            {
                ComboboxItem b = new ComboboxItem();
                b.Text = courses[i].Name;
                b.Value = courses[i].Id;
                checkedListBox1.Items.Add(b.Text);
            }
        }

        private void Admin_deleteCourse_Load(object sender, EventArgs e)
        {


        }

        private void Delete_Click(object sender, EventArgs e)
        {
            clChecked = new CourseCollection();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    clChecked.Add(courses[i]);
                    checkedListBox1.Items.RemoveAt(i);
                }

            }
            CourseDAL.DeleteSomeids(clChecked);
            UpdateCombobx();


        }
        private void UpdateCombobx()
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    clChecked.Add(courses[i]);
                    checkedListBox1.Items.RemoveAt(i);

                }
                checkedListBox1 = new CheckedListBox();
                reFillCheckList();

            }
        }


    }
}
