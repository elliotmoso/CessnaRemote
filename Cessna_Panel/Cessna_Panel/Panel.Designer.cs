namespace Cessna_Panel
{
    partial class Cessna_Control
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFailureListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfFailuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.restartServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripip2 = new System.Windows.Forms.ToolStripTextBox();
            this.SaveTxt = new System.Windows.Forms.SaveFileDialog();
            this.OpenTxt = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.control = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.enginebox = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.setcom_checkbox = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.setcom_box = new System.Windows.Forms.TextBox();
            this.flaps_bar = new System.Windows.Forms.TrackBar();
            this.leftleak_box = new System.Windows.Forms.CheckBox();
            this.leftleak_bar = new System.Windows.Forms.TrackBar();
            this.rightleak_bar = new System.Windows.Forms.TrackBar();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.oiltempincrease_box = new System.Windows.Forms.CheckBox();
            this.oiltempincrease_bar = new System.Windows.Forms.TrackBar();
            this.events = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fail_grid = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ranking_grid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.vert_speed = new System.Windows.Forms.Label();
            this.pilot_name = new System.Windows.Forms.TextBox();
            this.freq_timer = new System.Windows.Forms.Timer(this.components);
            this.flaps_timer = new System.Windows.Forms.Timer(this.components);
            this.leftleak_timer = new System.Windows.Forms.Timer(this.components);
            this.rightleak_timer = new System.Windows.Forms.Timer(this.components);
            this.vert_speed_timer = new System.Windows.Forms.Timer(this.components);
            this.vert_speed_aircheck = new System.Windows.Forms.Timer(this.components);
            this.BDUpdate = new System.Windows.Forms.Timer(this.components);
            this.RestartServer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.control.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flaps_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftleak_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightleak_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oiltempincrease_bar)).BeginInit();
            this.events.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fail_grid)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ranking_grid)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripip2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFailureListToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(45, 23);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // loadFailureListToolStripMenuItem
            // 
            this.loadFailureListToolStripMenuItem.Name = "loadFailureListToolStripMenuItem";
            this.loadFailureListToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.loadFailureListToolStripMenuItem.Text = "Load Failure List";
            this.loadFailureListToolStripMenuItem.Click += new System.EventHandler(this.loadFailureListToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfFailuresToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 23);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // listOfFailuresToolStripMenuItem
            // 
            this.listOfFailuresToolStripMenuItem.Name = "listOfFailuresToolStripMenuItem";
            this.listOfFailuresToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.listOfFailuresToolStripMenuItem.Text = "List of events";
            this.listOfFailuresToolStripMenuItem.Click += new System.EventHandler(this.listOfFailuresToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.restartServerToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Runway";
            // 
            // restartServerToolStripMenuItem
            // 
            this.restartServerToolStripMenuItem.Name = "restartServerToolStripMenuItem";
            this.restartServerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.restartServerToolStripMenuItem.Text = "Restart Server";
            this.restartServerToolStripMenuItem.Click += new System.EventHandler(this.RestartServer_Tick);
            // 
            // toolStripip2
            // 
            this.toolStripip2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripip2.Name = "toolStripip2";
            this.toolStripip2.Size = new System.Drawing.Size(100, 23);
            this.toolStripip2.Text = "192.168.0.2";
            this.toolStripip2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripip2.Enter += new System.EventHandler(this.toolStripip2_Leave);
            this.toolStripip2.Leave += new System.EventHandler(this.toolStripip2_Leave);
            // 
            // SaveTxt
            // 
            this.SaveTxt.Filter = "Text | *.txt";
            // 
            // OpenTxt
            // 
            this.OpenTxt.FileName = "openFileDialog1";
            this.OpenTxt.Filter = "Text |*.txt";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.control);
            this.tabControl1.Controls.Add(this.events);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 448);
            this.tabControl1.TabIndex = 2;
            // 
            // control
            // 
            this.control.BackColor = System.Drawing.SystemColors.Control;
            this.control.Controls.Add(this.tableLayoutPanel1);
            this.control.Location = new System.Drawing.Point(4, 22);
            this.control.Name = "control";
            this.control.Padding = new System.Windows.Forms.Padding(3);
            this.control.Size = new System.Drawing.Size(749, 422);
            this.control.TabIndex = 0;
            this.control.Text = "Cessna Control";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(743, 416);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 410);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Failures";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.checkBox10, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.checkBox3, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.checkBox17, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.checkBox14, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.checkBox11, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.checkBox5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.enginebox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBox6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.checkBox4, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(359, 391);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // checkBox10
            // 
            this.checkBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(3, 228);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(100, 19);
            this.checkBox10.TabIndex = 30;
            this.checkBox10.Tag = "0B71";
            this.checkBox10.Text = "Pitot Inoperable";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.failure_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(3, 203);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(174, 19);
            this.checkBox3.TabIndex = 28;
            this.checkBox3.Tag = "0B6F";
            this.checkBox3.Text = "Transponder Gauge Inoperable\r\n";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.failure_CheckedChanged);
            // 
            // checkBox17
            // 
            this.checkBox17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(3, 178);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(131, 19);
            this.checkBox17.TabIndex = 27;
            this.checkBox17.Tag = "0B6E";
            this.checkBox17.Text = "VSI Gauge Inoperable";
            this.checkBox17.UseVisualStyleBackColor = true;
            this.checkBox17.CheckedChanged += new System.EventHandler(this.failure_CheckedChanged);
            // 
            // checkBox14
            // 
            this.checkBox14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(3, 153);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(200, 19);
            this.checkBox14.TabIndex = 24;
            this.checkBox14.Tag = "0B6D";
            this.checkBox14.Text = "Direction Indicator Gauge Inoperable";
            this.checkBox14.UseVisualStyleBackColor = true;
            this.checkBox14.CheckedChanged += new System.EventHandler(this.failure_CheckedChanged);
            // 
            // checkBox11
            // 
            this.checkBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(3, 128);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(112, 19);
            this.checkBox11.TabIndex = 21;
            this.checkBox11.Tag = "0B6B";
            this.checkBox11.Text = "Engine Inoperable";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.failure_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(3, 103);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(159, 19);
            this.checkBox5.TabIndex = 12;
            this.checkBox5.Tag = "0B67";
            this.checkBox5.Text = "Attitude Indicator Inoperable";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.failure_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 19);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Tag = "0B63";
            this.checkBox1.Text = "Total Brakes Failure";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.failure_CheckedChanged);
            // 
            // enginebox
            // 
            this.enginebox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.enginebox.AutoSize = true;
            this.enginebox.Location = new System.Drawing.Point(3, 3);
            this.enginebox.Name = "enginebox";
            this.enginebox.Size = new System.Drawing.Size(109, 19);
            this.enginebox.TabIndex = 0;
            this.enginebox.Tag = "0B62";
            this.enginebox.Text = "Hydraulics Failure";
            this.enginebox.UseVisualStyleBackColor = true;
            this.enginebox.CheckedChanged += new System.EventHandler(this.failure_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(3, 53);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(131, 19);
            this.checkBox6.TabIndex = 14;
            this.checkBox6.Tag = "0B65";
            this.checkBox6.Text = "ASI Gauge Inoperable";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.failure_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(3, 78);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(154, 19);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.Tag = "0B66";
            this.checkBox4.Text = "Altimeter Gauge Inoperable";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.failure_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(374, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 410);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aircraft State";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.11111F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.88889F));
            this.tableLayoutPanel3.Controls.Add(this.checkBox7, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.setcom_checkbox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.checkBox2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.setcom_box, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.flaps_bar, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.leftleak_box, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.leftleak_bar, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.rightleak_bar, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.checkBox8, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.oiltempincrease_box, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.oiltempincrease_bar, 1, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(360, 391);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // checkBox7
            // 
            this.checkBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(3, 53);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(73, 19);
            this.checkBox7.TabIndex = 35;
            this.checkBox7.Tag = "";
            this.checkBox7.Text = "Set Flaps:";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // setcom_checkbox
            // 
            this.setcom_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.setcom_checkbox.AutoSize = true;
            this.setcom_checkbox.Location = new System.Drawing.Point(3, 28);
            this.setcom_checkbox.Name = "setcom_checkbox";
            this.setcom_checkbox.Size = new System.Drawing.Size(102, 19);
            this.setcom_checkbox.TabIndex = 33;
            this.setcom_checkbox.Tag = "";
            this.setcom_checkbox.Text = "Set COM1 Freq:";
            this.setcom_checkbox.UseVisualStyleBackColor = true;
            this.setcom_checkbox.CheckedChanged += new System.EventHandler(this.setcom_checkbox_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(3, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(83, 19);
            this.checkBox2.TabIndex = 32;
            this.checkBox2.Tag = "3103";
            this.checkBox2.Text = "Avionics On";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.failure_CheckedChanged);
            // 
            // setcom_box
            // 
            this.setcom_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setcom_box.Location = new System.Drawing.Point(186, 28);
            this.setcom_box.Name = "setcom_box";
            this.setcom_box.Size = new System.Drawing.Size(171, 20);
            this.setcom_box.TabIndex = 34;
            this.setcom_box.Text = "123.45";
            // 
            // flaps_bar
            // 
            this.flaps_bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flaps_bar.Location = new System.Drawing.Point(186, 53);
            this.flaps_bar.Maximum = 16383;
            this.flaps_bar.Name = "flaps_bar";
            this.flaps_bar.Size = new System.Drawing.Size(171, 19);
            this.flaps_bar.SmallChange = 5461;
            this.flaps_bar.TabIndex = 36;
            this.flaps_bar.TickFrequency = 5461;
            // 
            // leftleak_box
            // 
            this.leftleak_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftleak_box.AutoSize = true;
            this.leftleak_box.Location = new System.Drawing.Point(3, 78);
            this.leftleak_box.Name = "leftleak_box";
            this.leftleak_box.Size = new System.Drawing.Size(166, 19);
            this.leftleak_box.TabIndex = 37;
            this.leftleak_box.Tag = "";
            this.leftleak_box.Text = "Fuel Leak (Left, % per minute)";
            this.leftleak_box.UseVisualStyleBackColor = true;
            this.leftleak_box.CheckedChanged += new System.EventHandler(this.leftleak_box_CheckedChanged);
            // 
            // leftleak_bar
            // 
            this.leftleak_bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftleak_bar.Location = new System.Drawing.Point(186, 78);
            this.leftleak_bar.Maximum = 8388608;
            this.leftleak_bar.Name = "leftleak_bar";
            this.leftleak_bar.Size = new System.Drawing.Size(171, 19);
            this.leftleak_bar.SmallChange = 1000000;
            this.leftleak_bar.TabIndex = 39;
            this.leftleak_bar.TickFrequency = 1000000;
            // 
            // rightleak_bar
            // 
            this.rightleak_bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightleak_bar.Location = new System.Drawing.Point(186, 103);
            this.rightleak_bar.Maximum = 8388608;
            this.rightleak_bar.Name = "rightleak_bar";
            this.rightleak_bar.Size = new System.Drawing.Size(171, 19);
            this.rightleak_bar.SmallChange = 1000000;
            this.rightleak_bar.TabIndex = 40;
            this.rightleak_bar.TickFrequency = 1000000;
            // 
            // checkBox8
            // 
            this.checkBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(3, 103);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(173, 19);
            this.checkBox8.TabIndex = 41;
            this.checkBox8.Tag = "";
            this.checkBox8.Text = "Fuel Leak (Right, % per minute)";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.rightleak_box_CheckedChanged);
            // 
            // oiltempincrease_box
            // 
            this.oiltempincrease_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.oiltempincrease_box.AutoSize = true;
            this.oiltempincrease_box.Location = new System.Drawing.Point(3, 128);
            this.oiltempincrease_box.Name = "oiltempincrease_box";
            this.oiltempincrease_box.Size = new System.Drawing.Size(168, 19);
            this.oiltempincrease_box.TabIndex = 38;
            this.oiltempincrease_box.Tag = "";
            this.oiltempincrease_box.Text = "Oil Temp Increase (ºC/minute)";
            this.oiltempincrease_box.UseVisualStyleBackColor = true;
            this.oiltempincrease_box.CheckedChanged += new System.EventHandler(this.rightleak_box_CheckedChanged);
            // 
            // oiltempincrease_bar
            // 
            this.oiltempincrease_bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oiltempincrease_bar.Location = new System.Drawing.Point(186, 128);
            this.oiltempincrease_bar.Maximum = 11702;
            this.oiltempincrease_bar.Name = "oiltempincrease_bar";
            this.oiltempincrease_bar.Size = new System.Drawing.Size(171, 19);
            this.oiltempincrease_bar.SmallChange = 500;
            this.oiltempincrease_bar.TabIndex = 42;
            this.oiltempincrease_bar.TickFrequency = 500;
            // 
            // events
            // 
            this.events.Controls.Add(this.groupBox1);
            this.events.Location = new System.Drawing.Point(4, 22);
            this.events.Name = "events";
            this.events.Padding = new System.Windows.Forms.Padding(3);
            this.events.Size = new System.Drawing.Size(749, 422);
            this.events.TabIndex = 1;
            this.events.Text = "Events";
            this.events.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fail_grid);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 419);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Events";
            // 
            // fail_grid
            // 
            this.fail_grid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.fail_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fail_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Name,
            this.Value});
            this.fail_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fail_grid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.fail_grid.Location = new System.Drawing.Point(3, 16);
            this.fail_grid.Name = "fail_grid";
            this.fail_grid.Size = new System.Drawing.Size(737, 400);
            this.fail_grid.TabIndex = 0;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(749, 422);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "AirSimMeeting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.ranking_grid, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(749, 422);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // ranking_grid
            // 
            this.ranking_grid.AllowUserToAddRows = false;
            this.ranking_grid.AllowUserToDeleteRows = false;
            this.ranking_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ranking_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ranking_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ranking_grid.Location = new System.Drawing.Point(377, 3);
            this.ranking_grid.MultiSelect = false;
            this.ranking_grid.Name = "ranking_grid";
            this.ranking_grid.ReadOnly = true;
            this.ranking_grid.RowHeadersVisible = false;
            this.ranking_grid.Size = new System.Drawing.Size(369, 416);
            this.ranking_grid.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.vert_speed, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.pilot_name, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.78281F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.21718F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(368, 416);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // vert_speed
            // 
            this.vert_speed.AutoSize = true;
            this.vert_speed.BackColor = System.Drawing.Color.White;
            this.vert_speed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vert_speed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vert_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 110.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vert_speed.Location = new System.Drawing.Point(25, 25);
            this.vert_speed.Margin = new System.Windows.Forms.Padding(25);
            this.vert_speed.Name = "vert_speed";
            this.vert_speed.Size = new System.Drawing.Size(318, 319);
            this.vert_speed.TabIndex = 2;
            this.vert_speed.Text = "0";
            this.vert_speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pilot_name
            // 
            this.pilot_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pilot_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pilot_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilot_name.Location = new System.Drawing.Point(3, 372);
            this.pilot_name.Name = "pilot_name";
            this.pilot_name.Size = new System.Drawing.Size(362, 40);
            this.pilot_name.TabIndex = 3;
            this.pilot_name.Text = "Pilot in Command";
            this.pilot_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // freq_timer
            // 
            this.freq_timer.Interval = 500;
            this.freq_timer.Tick += new System.EventHandler(this.freqtimer_Tick);
            // 
            // flaps_timer
            // 
            this.flaps_timer.Interval = 500;
            this.flaps_timer.Tick += new System.EventHandler(this.flaps_timer_Tick);
            // 
            // leftleak_timer
            // 
            this.leftleak_timer.Interval = 500;
            this.leftleak_timer.Tick += new System.EventHandler(this.leftleak_timer_Tick);
            // 
            // rightleak_timer
            // 
            this.rightleak_timer.Interval = 500;
            this.rightleak_timer.Tick += new System.EventHandler(this.rightleak_timer_Tick);
            // 
            // vert_speed_timer
            // 
            this.vert_speed_timer.Enabled = true;
            this.vert_speed_timer.Interval = 500;
            this.vert_speed_timer.Tick += new System.EventHandler(this.vert_speed_timer_Tick);
            // 
            // vert_speed_aircheck
            // 
            this.vert_speed_aircheck.Interval = 500;
            this.vert_speed_aircheck.Tick += new System.EventHandler(this.vert_speed_aircheck_Tick);
            // 
            // BDUpdate
            // 
            this.BDUpdate.Enabled = true;
            this.BDUpdate.Interval = 1000;
            this.BDUpdate.Tick += new System.EventHandler(this.BDUpdate_Tick);
            // 
            // RestartServer
            // 
            this.RestartServer.Interval = 60000;
            this.RestartServer.Tick += new System.EventHandler(this.RestartServer_Tick);
            // 
            // Cessna_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 475);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.control.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flaps_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftleak_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightleak_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oiltempincrease_bar)).EndInit();
            this.events.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fail_grid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ranking_grid)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfFailuresToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveTxt;
        private System.Windows.Forms.ToolStripMenuItem loadFailureListToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenTxt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage control;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.TabPage events;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView fail_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox enginebox;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox setcom_checkbox;
        private System.Windows.Forms.TextBox setcom_box;
        private System.Windows.Forms.Timer freq_timer;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.TrackBar flaps_bar;
        private System.Windows.Forms.Timer flaps_timer;
        private System.Windows.Forms.CheckBox leftleak_box;
        private System.Windows.Forms.CheckBox oiltempincrease_box;
        private System.Windows.Forms.TrackBar leftleak_bar;
        private System.Windows.Forms.TrackBar rightleak_bar;
        private System.Windows.Forms.Timer leftleak_timer;
        private System.Windows.Forms.Timer rightleak_timer;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.TrackBar oiltempincrease_bar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView ranking_grid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label vert_speed;
        private System.Windows.Forms.TextBox pilot_name;
        private System.Windows.Forms.Timer vert_speed_timer;
        private System.Windows.Forms.Timer vert_speed_aircheck;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Timer BDUpdate;
        private System.Windows.Forms.Timer RestartServer;
        private System.Windows.Forms.ToolStripMenuItem restartServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripip2;
    }
}

