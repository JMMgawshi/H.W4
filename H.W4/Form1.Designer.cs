namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label room_idLabel;
            System.Windows.Forms.Label teacher_idLabel;
            System.Windows.Forms.Label course_idLabel;
            System.Windows.Forms.Label attendance_dateLabel;
            System.Windows.Forms.Label satrt_timeLabel;
            System.Windows.Forms.Label leaving_timeLabel;
            System.Windows.Forms.Label commentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hW4DataSet = new WindowsFormsApplication1.HW4DataSet();
            this.attendancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendancesTableAdapter = new WindowsFormsApplication1.HW4DataSetTableAdapters.attendancesTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.HW4DataSetTableAdapters.TableAdapterManager();
            this.attendancesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.attendancesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.attendancesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.attendance_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.satrt_timeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.leaving_timeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new WindowsFormsApplication1.HW4DataSetTableAdapters.roomsTableAdapter();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new WindowsFormsApplication1.HW4DataSetTableAdapters.teachersTableAdapter();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new WindowsFormsApplication1.HW4DataSetTableAdapters.coursesTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            room_idLabel = new System.Windows.Forms.Label();
            teacher_idLabel = new System.Windows.Forms.Label();
            course_idLabel = new System.Windows.Forms.Label();
            attendance_dateLabel = new System.Windows.Forms.Label();
            satrt_timeLabel = new System.Windows.Forms.Label();
            leaving_timeLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hW4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendancesBindingNavigator)).BeginInit();
            this.attendancesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendancesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(32, 65);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 37;
            idLabel.Text = "id:";
            // 
            // room_idLabel
            // 
            room_idLabel.AutoSize = true;
            room_idLabel.Location = new System.Drawing.Point(32, 91);
            room_idLabel.Name = "room_idLabel";
            room_idLabel.Size = new System.Drawing.Size(46, 13);
            room_idLabel.TabIndex = 39;
            room_idLabel.Text = "room id:";
            // 
            // teacher_idLabel
            // 
            teacher_idLabel.AutoSize = true;
            teacher_idLabel.Location = new System.Drawing.Point(32, 117);
            teacher_idLabel.Name = "teacher_idLabel";
            teacher_idLabel.Size = new System.Drawing.Size(59, 13);
            teacher_idLabel.TabIndex = 41;
            teacher_idLabel.Text = "teacher id:";
            // 
            // course_idLabel
            // 
            course_idLabel.AutoSize = true;
            course_idLabel.Location = new System.Drawing.Point(32, 143);
            course_idLabel.Name = "course_idLabel";
            course_idLabel.Size = new System.Drawing.Size(54, 13);
            course_idLabel.TabIndex = 43;
            course_idLabel.Text = "course id:";
            // 
            // attendance_dateLabel
            // 
            attendance_dateLabel.AutoSize = true;
            attendance_dateLabel.Location = new System.Drawing.Point(541, 62);
            attendance_dateLabel.Name = "attendance_dateLabel";
            attendance_dateLabel.Size = new System.Drawing.Size(91, 13);
            attendance_dateLabel.TabIndex = 45;
            attendance_dateLabel.Text = "attendance date:";
            attendance_dateLabel.Click += new System.EventHandler(this.attendance_dateLabel_Click);
            // 
            // satrt_timeLabel
            // 
            satrt_timeLabel.AutoSize = true;
            satrt_timeLabel.Location = new System.Drawing.Point(541, 88);
            satrt_timeLabel.Name = "satrt_timeLabel";
            satrt_timeLabel.Size = new System.Drawing.Size(57, 13);
            satrt_timeLabel.TabIndex = 47;
            satrt_timeLabel.Text = "satrt time:";
            satrt_timeLabel.Click += new System.EventHandler(this.satrt_timeLabel_Click);
            // 
            // leaving_timeLabel
            // 
            leaving_timeLabel.AutoSize = true;
            leaving_timeLabel.Location = new System.Drawing.Point(541, 114);
            leaving_timeLabel.Name = "leaving_timeLabel";
            leaving_timeLabel.Size = new System.Drawing.Size(68, 13);
            leaving_timeLabel.TabIndex = 49;
            leaving_timeLabel.Text = "leaving time:";
            leaving_timeLabel.Click += new System.EventHandler(this.leaving_timeLabel_Click);
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(541, 145);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(54, 13);
            commentLabel.TabIndex = 51;
            commentLabel.Text = "comment:";
            commentLabel.Click += new System.EventHandler(this.commentLabel_Click);
            // 
            // hW4DataSet
            // 
            this.hW4DataSet.DataSetName = "HW4DataSet";
            this.hW4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendancesBindingSource
            // 
            this.attendancesBindingSource.DataMember = "attendances";
            this.attendancesBindingSource.DataSource = this.hW4DataSet;
            // 
            // attendancesTableAdapter
            // 
            this.attendancesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.attendancesTableAdapter = this.attendancesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.coursesTableAdapter = null;
            this.tableAdapterManager.roomsTableAdapter = null;
            this.tableAdapterManager.teachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.HW4DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // attendancesBindingNavigator
            // 
            this.attendancesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.attendancesBindingNavigator.BindingSource = this.attendancesBindingSource;
            this.attendancesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.attendancesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.attendancesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.attendancesBindingNavigatorSaveItem});
            this.attendancesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.attendancesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.attendancesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.attendancesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.attendancesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.attendancesBindingNavigator.Name = "attendancesBindingNavigator";
            this.attendancesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.attendancesBindingNavigator.Size = new System.Drawing.Size(856, 25);
            this.attendancesBindingNavigator.TabIndex = 37;
            this.attendancesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // attendancesBindingNavigatorSaveItem
            // 
            this.attendancesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.attendancesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("attendancesBindingNavigatorSaveItem.Image")));
            this.attendancesBindingNavigatorSaveItem.Name = "attendancesBindingNavigatorSaveItem";
            this.attendancesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.attendancesBindingNavigatorSaveItem.Text = "Save Data";
            this.attendancesBindingNavigatorSaveItem.Click += new System.EventHandler(this.attendancesBindingNavigatorSaveItem_Click);
            // 
            // attendancesDataGridView
            // 
            this.attendancesDataGridView.AutoGenerateColumns = false;
            this.attendancesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendancesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.attendancesDataGridView.DataSource = this.attendancesBindingSource;
            this.attendancesDataGridView.Location = new System.Drawing.Point(25, 198);
            this.attendancesDataGridView.Name = "attendancesDataGridView";
            this.attendancesDataGridView.Size = new System.Drawing.Size(813, 308);
            this.attendancesDataGridView.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "room_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "room_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "teacher_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "teacher_id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "course_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "course_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "attendance_date";
            this.dataGridViewTextBoxColumn5.HeaderText = "attendance_date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "satrt_time";
            this.dataGridViewTextBoxColumn6.HeaderText = "satrt_time";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "leaving_time";
            this.dataGridViewTextBoxColumn7.HeaderText = "leaving_time";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "comment";
            this.dataGridViewTextBoxColumn8.HeaderText = "comment";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attendancesBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(129, 62);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 38;
            // 
            // attendance_dateDateTimePicker
            // 
            this.attendance_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.attendancesBindingSource, "attendance_date", true));
            this.attendance_dateDateTimePicker.Location = new System.Drawing.Point(638, 58);
            this.attendance_dateDateTimePicker.Name = "attendance_dateDateTimePicker";
            this.attendance_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.attendance_dateDateTimePicker.TabIndex = 46;
            this.attendance_dateDateTimePicker.ValueChanged += new System.EventHandler(this.attendance_dateDateTimePicker_ValueChanged);
            // 
            // satrt_timeDateTimePicker
            // 
            this.satrt_timeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.attendancesBindingSource, "satrt_time", true));
            this.satrt_timeDateTimePicker.Location = new System.Drawing.Point(638, 32);
            this.satrt_timeDateTimePicker.Name = "satrt_timeDateTimePicker";
            this.satrt_timeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.satrt_timeDateTimePicker.TabIndex = 48;
            this.satrt_timeDateTimePicker.ValueChanged += new System.EventHandler(this.satrt_timeDateTimePicker_ValueChanged);
            // 
            // leaving_timeDateTimePicker
            // 
            this.leaving_timeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.attendancesBindingSource, "leaving_time", true));
            this.leaving_timeDateTimePicker.Location = new System.Drawing.Point(638, 110);
            this.leaving_timeDateTimePicker.Name = "leaving_timeDateTimePicker";
            this.leaving_timeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.leaving_timeDateTimePicker.TabIndex = 50;
            this.leaving_timeDateTimePicker.ValueChanged += new System.EventHandler(this.leaving_timeDateTimePicker_ValueChanged);
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attendancesBindingSource, "comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(638, 142);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(200, 20);
            this.commentTextBox.TabIndex = 52;
            this.commentTextBox.TextChanged += new System.EventHandler(this.commentTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 53;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 23);
            this.button2.TabIndex = 54;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(315, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 23);
            this.button3.TabIndex = 55;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.attendancesBindingSource, "room_id", true));
            this.comboBox1.DataSource = this.roomsBindingSource;
            this.comboBox1.DisplayMember = "room_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(165, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 56;
            this.comboBox1.ValueMember = "room_id";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.attendancesBindingSource, "teacher_id", true));
            this.comboBox2.DataSource = this.teachersBindingSource;
            this.comboBox2.DisplayMember = "teacher_name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(165, 117);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 57;
            this.comboBox2.ValueMember = "teacher_id";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.attendancesBindingSource, "course_id", true));
            this.comboBox3.DataSource = this.coursesBindingSource;
            this.comboBox3.DisplayMember = "course_name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(165, 145);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 58;
            this.comboBox3.ValueMember = "course_id";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "rooms";
            this.roomsBindingSource.DataSource = this.hW4DataSet;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "teachers";
            this.teachersBindingSource.DataSource = this.hW4DataSet;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "courses";
            this.coursesBindingSource.DataSource = this.hW4DataSet;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 511);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(room_idLabel);
            this.Controls.Add(teacher_idLabel);
            this.Controls.Add(course_idLabel);
            this.Controls.Add(attendance_dateLabel);
            this.Controls.Add(this.attendance_dateDateTimePicker);
            this.Controls.Add(satrt_timeLabel);
            this.Controls.Add(this.satrt_timeDateTimePicker);
            this.Controls.Add(leaving_timeLabel);
            this.Controls.Add(this.leaving_timeDateTimePicker);
            this.Controls.Add(commentLabel);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.attendancesDataGridView);
            this.Controls.Add(this.attendancesBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hW4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendancesBindingNavigator)).EndInit();
            this.attendancesBindingNavigator.ResumeLayout(false);
            this.attendancesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendancesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HW4DataSet hW4DataSet;
        private HW4DataSetTableAdapters.attendancesTableAdapter attendancesTableAdapter;
        private HW4DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator attendancesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton attendancesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView attendancesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker attendance_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker satrt_timeDateTimePicker;
        private System.Windows.Forms.DateTimePicker leaving_timeDateTimePicker;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.BindingSource attendancesBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private HW4DataSetTableAdapters.roomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private HW4DataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private HW4DataSetTableAdapters.coursesTableAdapter coursesTableAdapter;
    }
}

