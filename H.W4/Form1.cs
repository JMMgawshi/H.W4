using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DTPickerLeaveTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTeacherName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoomForm frm = new RoomForm();

            frm.Show();
        }

       

        private void attendancesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.attendancesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hW4DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hW4DataSet.courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.hW4DataSet.courses);
            // TODO: This line of code loads data into the 'hW4DataSet.teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.hW4DataSet.teachers);
            // TODO: This line of code loads data into the 'hW4DataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.hW4DataSet.rooms);
            // TODO: This line of code loads data into the 'hW4DataSet.attendances' table. You can move, or remove it, as needed.
            this.attendancesTableAdapter.Fill(this.hW4DataSet.attendances);
           
        }

        private void attendance_dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void satrt_timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void leaving_timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void commentLabel_Click(object sender, EventArgs e)
        {

        }

        private void commentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void leaving_timeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void satrt_timeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void attendance_dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new RoomForm().ShowDialog();
            this.roomsTableAdapter.Fill(this.hW4DataSet.rooms);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new TeacherForm().ShowDialog();
            this.teachersTableAdapter.Fill(this.hW4DataSet.teachers);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CoursesForm().ShowDialog();
            this.coursesTableAdapter.Fill(this.hW4DataSet.courses);
        }
    }
}
