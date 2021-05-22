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
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }

        private void roomsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hW4DataSet);

        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hW4DataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.hW4DataSet.rooms);

        }
    }
}
