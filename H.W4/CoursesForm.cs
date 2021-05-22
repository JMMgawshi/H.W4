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
    public partial class CoursesForm : Form
    {
        public CoursesForm()
        {
            InitializeComponent();
        }

        private void coursesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coursesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hW4DataSet);

        }

        private void CoursesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hW4DataSet.courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.hW4DataSet.courses);

        }
    }
}
