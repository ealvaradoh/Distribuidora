namespace Distribuidora.Win
{
    partial class frm_usuarios
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
            System.Windows.Forms.Label emp_fingLabel;
            System.Windows.Forms.Label emp_mailLabel;
            System.Windows.Forms.Label emp_mail_ctrLabel;
            System.Windows.Forms.Label emp_papeLabel;
            System.Windows.Forms.Label emp_pnomLabel;
            System.Windows.Forms.Label emp_sapeLabel;
            System.Windows.Forms.Label emp_snomLabel;
            System.Windows.Forms.Label depar_idLabel;
            System.Windows.Forms.Label emp_numidLabel;
            System.Windows.Forms.Label emp_telLabel;
            System.Windows.Forms.Label produ_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_usuarios));
            this.listaEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaEmpleadosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.emp_activoCheckBox = new System.Windows.Forms.CheckBox();
            this.emp_fingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emp_idTextBox = new System.Windows.Forms.TextBox();
            this.emp_mailTextBox = new System.Windows.Forms.TextBox();
            this.emp_mail_ctrTextBox = new System.Windows.Forms.TextBox();
            this.emp_papeTextBox = new System.Windows.Forms.TextBox();
            this.emp_pnomTextBox = new System.Windows.Forms.TextBox();
            this.emp_sapeTextBox = new System.Windows.Forms.TextBox();
            this.emp_snomTextBox = new System.Windows.Forms.TextBox();
            this.listaDepartamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depar_idComboBox = new System.Windows.Forms.ComboBox();
            this.emp_numidTextBox = new System.Windows.Forms.TextBox();
            this.emp_telTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            emp_fingLabel = new System.Windows.Forms.Label();
            emp_mailLabel = new System.Windows.Forms.Label();
            emp_mail_ctrLabel = new System.Windows.Forms.Label();
            emp_papeLabel = new System.Windows.Forms.Label();
            emp_pnomLabel = new System.Windows.Forms.Label();
            emp_sapeLabel = new System.Windows.Forms.Label();
            emp_snomLabel = new System.Windows.Forms.Label();
            depar_idLabel = new System.Windows.Forms.Label();
            emp_numidLabel = new System.Windows.Forms.Label();
            emp_telLabel = new System.Windows.Forms.Label();
            produ_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEmpleadosBindingNavigator)).BeginInit();
            this.listaEmpleadosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDepartamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emp_fingLabel
            // 
            emp_fingLabel.AutoSize = true;
            emp_fingLabel.Location = new System.Drawing.Point(32, 13);
            emp_fingLabel.Name = "emp_fingLabel";
            emp_fingLabel.Size = new System.Drawing.Size(143, 20);
            emp_fingLabel.TabIndex = 5;
            emp_fingLabel.Text = "Fecha de Ingreso:";
            // 
            // emp_mailLabel
            // 
            emp_mailLabel.AutoSize = true;
            emp_mailLabel.Location = new System.Drawing.Point(75, 330);
            emp_mailLabel.Name = "emp_mailLabel";
            emp_mailLabel.Size = new System.Drawing.Size(40, 20);
            emp_mailLabel.TabIndex = 9;
            emp_mailLabel.Text = "Mail";
            // 
            // emp_mail_ctrLabel
            // 
            emp_mail_ctrLabel.AutoSize = true;
            emp_mail_ctrLabel.Location = new System.Drawing.Point(75, 386);
            emp_mail_ctrLabel.Name = "emp_mail_ctrLabel";
            emp_mail_ctrLabel.Size = new System.Drawing.Size(131, 20);
            emp_mail_ctrLabel.TabIndex = 11;
            emp_mail_ctrLabel.Text = "Contraseña Mail";
            // 
            // emp_papeLabel
            // 
            emp_papeLabel.AutoSize = true;
            emp_papeLabel.Location = new System.Drawing.Point(27, 190);
            emp_papeLabel.Name = "emp_papeLabel";
            emp_papeLabel.Size = new System.Drawing.Size(126, 20);
            emp_papeLabel.TabIndex = 13;
            emp_papeLabel.Text = "Primer apellido:";
            // 
            // emp_pnomLabel
            // 
            emp_pnomLabel.AutoSize = true;
            emp_pnomLabel.Location = new System.Drawing.Point(28, 150);
            emp_pnomLabel.Name = "emp_pnomLabel";
            emp_pnomLabel.Size = new System.Drawing.Size(125, 20);
            emp_pnomLabel.TabIndex = 15;
            emp_pnomLabel.Text = "Primer nombre:";
            // 
            // emp_sapeLabel
            // 
            emp_sapeLabel.AutoSize = true;
            emp_sapeLabel.Location = new System.Drawing.Point(452, 190);
            emp_sapeLabel.Name = "emp_sapeLabel";
            emp_sapeLabel.Size = new System.Drawing.Size(141, 20);
            emp_sapeLabel.TabIndex = 17;
            emp_sapeLabel.Text = "Segundo apellido:";
            // 
            // emp_snomLabel
            // 
            emp_snomLabel.AutoSize = true;
            emp_snomLabel.Location = new System.Drawing.Point(452, 150);
            emp_snomLabel.Name = "emp_snomLabel";
            emp_snomLabel.Size = new System.Drawing.Size(140, 20);
            emp_snomLabel.TabIndex = 19;
            emp_snomLabel.Text = "Segundo nombre:";
            // 
            // depar_idLabel
            // 
            depar_idLabel.AutoSize = true;
            depar_idLabel.Location = new System.Drawing.Point(32, 78);
            depar_idLabel.Name = "depar_idLabel";
            depar_idLabel.Size = new System.Drawing.Size(125, 20);
            depar_idLabel.TabIndex = 20;
            depar_idLabel.Text = "Departamento: ";
            // 
            // emp_numidLabel
            // 
            emp_numidLabel.AutoSize = true;
            emp_numidLabel.Location = new System.Drawing.Point(58, 230);
            emp_numidLabel.Name = "emp_numidLabel";
            emp_numidLabel.Size = new System.Drawing.Size(95, 20);
            emp_numidLabel.TabIndex = 21;
            emp_numidLabel.Text = "Número ID:";
            // 
            // emp_telLabel
            // 
            emp_telLabel.AutoSize = true;
            emp_telLabel.Location = new System.Drawing.Point(75, 270);
            emp_telLabel.Name = "emp_telLabel";
            emp_telLabel.Size = new System.Drawing.Size(78, 20);
            emp_telLabel.TabIndex = 22;
            emp_telLabel.Text = "Teléfono:";
            // 
            // produ_idLabel
            // 
            produ_idLabel.AutoSize = true;
            produ_idLabel.Location = new System.Drawing.Point(13, 12);
            produ_idLabel.Name = "produ_idLabel";
            produ_idLabel.Size = new System.Drawing.Size(280, 36);
            produ_idLabel.TabIndex = 1;
            produ_idLabel.Text = "N° DE EMPLEADO:";
            // 
            // listaEmpleadosBindingSource
            // 
            this.listaEmpleadosBindingSource.DataSource = typeof(Distribuidora.BL.Entidades.empleado);
            // 
            // listaEmpleadosBindingNavigator
            // 
            this.listaEmpleadosBindingNavigator.AddNewItem = null;
            this.listaEmpleadosBindingNavigator.BindingSource = this.listaEmpleadosBindingSource;
            this.listaEmpleadosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaEmpleadosBindingNavigator.DeleteItem = null;
            this.listaEmpleadosBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listaEmpleadosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listaEmpleadosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.listaEmpleadosBindingNavigator.Location = new System.Drawing.Point(0, 629);
            this.listaEmpleadosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaEmpleadosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaEmpleadosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaEmpleadosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaEmpleadosBindingNavigator.Name = "listaEmpleadosBindingNavigator";
            this.listaEmpleadosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaEmpleadosBindingNavigator.Size = new System.Drawing.Size(897, 27);
            this.listaEmpleadosBindingNavigator.TabIndex = 0;
            this.listaEmpleadosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(49, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // emp_activoCheckBox
            // 
            this.emp_activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaEmpleadosBindingSource, "emp_activo", true));
            this.emp_activoCheckBox.Enabled = false;
            this.emp_activoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_activoCheckBox.Location = new System.Drawing.Point(655, 12);
            this.emp_activoCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emp_activoCheckBox.Name = "emp_activoCheckBox";
            this.emp_activoCheckBox.Size = new System.Drawing.Size(200, 36);
            this.emp_activoCheckBox.TabIndex = 4;
            this.emp_activoCheckBox.Text = "Activo";
            this.emp_activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // emp_fingDateTimePicker
            // 
            this.emp_fingDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaEmpleadosBindingSource, "emp_fing", true));
            this.emp_fingDateTimePicker.Enabled = false;
            this.emp_fingDateTimePicker.Location = new System.Drawing.Point(36, 35);
            this.emp_fingDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emp_fingDateTimePicker.Name = "emp_fingDateTimePicker";
            this.emp_fingDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.emp_fingDateTimePicker.TabIndex = 6;
            // 
            // emp_idTextBox
            // 
            this.emp_idTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.emp_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "emp_id", true));
            this.emp_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_idTextBox.Location = new System.Drawing.Point(320, 12);
            this.emp_idTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emp_idTextBox.Name = "emp_idTextBox";
            this.emp_idTextBox.ReadOnly = true;
            this.emp_idTextBox.Size = new System.Drawing.Size(312, 38);
            this.emp_idTextBox.TabIndex = 8;
            // 
            // emp_mailTextBox
            // 
            this.emp_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "emp_mail", true));
            this.emp_mailTextBox.Location = new System.Drawing.Point(75, 352);
            this.emp_mailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emp_mailTextBox.Name = "emp_mailTextBox";
            this.emp_mailTextBox.ReadOnly = true;
            this.emp_mailTextBox.Size = new System.Drawing.Size(200, 27);
            this.emp_mailTextBox.TabIndex = 10;
            // 
            // emp_mail_ctrTextBox
            // 
            this.emp_mail_ctrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "emp_mail_ctr", true));
            this.emp_mail_ctrTextBox.Location = new System.Drawing.Point(75, 408);
            this.emp_mail_ctrTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emp_mail_ctrTextBox.Name = "emp_mail_ctrTextBox";
            this.emp_mail_ctrTextBox.ReadOnly = true;
            this.emp_mail_ctrTextBox.Size = new System.Drawing.Size(200, 27);
            this.emp_mail_ctrTextBox.TabIndex = 12;
            // 
            // emp_papeTextBox
            // 
            this.emp_papeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "emp_pape", true));
            this.emp_papeTextBox.Location = new System.Drawing.Point(179, 187);
            this.emp_papeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emp_papeTextBox.Name = "emp_papeTextBox";
            this.emp_papeTextBox.ReadOnly = true;
            this.emp_papeTextBox.Size = new System.Drawing.Size(200, 27);
            this.emp_papeTextBox.TabIndex = 14;
            // 
            // emp_pnomTextBox
            // 
            this.emp_pnomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "emp_pnom", true));
            this.emp_pnomTextBox.Location = new System.Drawing.Point(179, 147);
            this.emp_pnomTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emp_pnomTextBox.Name = "emp_pnomTextBox";
            this.emp_pnomTextBox.ReadOnly = true;
            this.emp_pnomTextBox.Size = new System.Drawing.Size(200, 27);
            this.emp_pnomTextBox.TabIndex = 16;
            // 
            // emp_sapeTextBox
            // 
            this.emp_sapeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "emp_sape", true));
            this.emp_sapeTextBox.Location = new System.Drawing.Point(614, 187);
            this.emp_sapeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emp_sapeTextBox.Name = "emp_sapeTextBox";
            this.emp_sapeTextBox.ReadOnly = true;
            this.emp_sapeTextBox.Size = new System.Drawing.Size(200, 27);
            this.emp_sapeTextBox.TabIndex = 18;
            // 
            // emp_snomTextBox
            // 
            this.emp_snomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "emp_snom", true));
            this.emp_snomTextBox.Location = new System.Drawing.Point(613, 147);
            this.emp_snomTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emp_snomTextBox.Name = "emp_snomTextBox";
            this.emp_snomTextBox.ReadOnly = true;
            this.emp_snomTextBox.Size = new System.Drawing.Size(201, 27);
            this.emp_snomTextBox.TabIndex = 20;
            // 
            // listaDepartamentosBindingSource
            // 
            this.listaDepartamentosBindingSource.DataSource = typeof(Distribuidora.BL.Entidades.departamento);
            // 
            // depar_idComboBox
            // 
            this.depar_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaEmpleadosBindingSource, "depar_id", true));
            this.depar_idComboBox.DataSource = this.listaDepartamentosBindingSource;
            this.depar_idComboBox.DisplayMember = "depar_nom";
            this.depar_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depar_idComboBox.Enabled = false;
            this.depar_idComboBox.FormattingEnabled = true;
            this.depar_idComboBox.Location = new System.Drawing.Point(36, 100);
            this.depar_idComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.depar_idComboBox.Name = "depar_idComboBox";
            this.depar_idComboBox.Size = new System.Drawing.Size(200, 28);
            this.depar_idComboBox.TabIndex = 21;
            this.depar_idComboBox.ValueMember = "depar_id";
            // 
            // emp_numidTextBox
            // 
            this.emp_numidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "emp_numid", true));
            this.emp_numidTextBox.Location = new System.Drawing.Point(179, 227);
            this.emp_numidTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emp_numidTextBox.Name = "emp_numidTextBox";
            this.emp_numidTextBox.ReadOnly = true;
            this.emp_numidTextBox.Size = new System.Drawing.Size(200, 27);
            this.emp_numidTextBox.TabIndex = 22;
            // 
            // emp_telTextBox
            // 
            this.emp_telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "emp_tel", true));
            this.emp_telTextBox.Location = new System.Drawing.Point(179, 267);
            this.emp_telTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emp_telTextBox.Name = "emp_telTextBox";
            this.emp_telTextBox.ReadOnly = true;
            this.emp_telTextBox.Size = new System.Drawing.Size(200, 27);
            this.emp_telTextBox.TabIndex = 23;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.listaEmpleadosBindingSource;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(897, 47);
            this.bindingNavigator1.TabIndex = 24;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Enabled = false;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(107, 44);
            this.toolStripButton7.Text = "Guardar datos";
            this.toolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.emp_mail_ctrTextBox);
            this.panel2.Controls.Add(this.emp_mailTextBox);
            this.panel2.Controls.Add(this.emp_snomTextBox);
            this.panel2.Controls.Add(this.emp_sapeTextBox);
            this.panel2.Controls.Add(this.emp_fingDateTimePicker);
            this.panel2.Controls.Add(this.emp_telTextBox);
            this.panel2.Controls.Add(this.emp_numidTextBox);
            this.panel2.Controls.Add(this.emp_pnomTextBox);
            this.panel2.Controls.Add(this.depar_idComboBox);
            this.panel2.Controls.Add(this.emp_papeTextBox);
            this.panel2.Controls.Add(emp_telLabel);
            this.panel2.Controls.Add(emp_snomLabel);
            this.panel2.Controls.Add(emp_numidLabel);
            this.panel2.Controls.Add(emp_sapeLabel);
            this.panel2.Controls.Add(emp_pnomLabel);
            this.panel2.Controls.Add(depar_idLabel);
            this.panel2.Controls.Add(emp_papeLabel);
            this.panel2.Controls.Add(emp_fingLabel);
            this.panel2.Controls.Add(emp_mail_ctrLabel);
            this.panel2.Controls.Add(emp_mailLabel);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(21, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 481);
            this.panel2.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.emp_activoCheckBox);
            this.panel1.Controls.Add(this.emp_idTextBox);
            this.panel1.Controls.Add(produ_idLabel);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 67);
            this.panel1.TabIndex = 40;
            // 
            // frm_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 656);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.listaEmpleadosBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_usuarios";
            this.Text = "Control de Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.listaEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEmpleadosBindingNavigator)).EndInit();
            this.listaEmpleadosBindingNavigator.ResumeLayout(false);
            this.listaEmpleadosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDepartamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaEmpleadosBindingSource;
        private System.Windows.Forms.BindingNavigator listaEmpleadosBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.CheckBox emp_activoCheckBox;
        private System.Windows.Forms.DateTimePicker emp_fingDateTimePicker;
        private System.Windows.Forms.TextBox emp_idTextBox;
        private System.Windows.Forms.TextBox emp_mailTextBox;
        private System.Windows.Forms.TextBox emp_mail_ctrTextBox;
        private System.Windows.Forms.TextBox emp_papeTextBox;
        private System.Windows.Forms.TextBox emp_pnomTextBox;
        private System.Windows.Forms.TextBox emp_sapeTextBox;
        private System.Windows.Forms.TextBox emp_snomTextBox;
        private System.Windows.Forms.BindingSource listaDepartamentosBindingSource;
        private System.Windows.Forms.ComboBox depar_idComboBox;
        private System.Windows.Forms.TextBox emp_numidTextBox;
        private System.Windows.Forms.TextBox emp_telTextBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}