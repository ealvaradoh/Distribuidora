namespace Distribuidora.Win
{
    partial class frm_ordenes
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
            System.Windows.Forms.Label ord_cant_produLabel;
            System.Windows.Forms.Label ord_fechaLabel;
            System.Windows.Forms.Label prov_idLabel;
            System.Windows.Forms.Label fact_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ordenes));
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.listaOrdenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.ord_cant_produTextBox = new System.Windows.Forms.TextBox();
            this.ord_fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ord_idTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.prov_nomComboBox = new System.Windows.Forms.ComboBox();
            this.listaProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.ListaProductosDetalleDelete = new System.Windows.Forms.Button();
            this.ListaProductosDetalleAdd = new System.Windows.Forms.Button();
            this.orden_detalleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.listaProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orden_detalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCancelItem = new System.Windows.Forms.ToolStripButton();
            ord_cant_produLabel = new System.Windows.Forms.Label();
            ord_fechaLabel = new System.Windows.Forms.Label();
            prov_idLabel = new System.Windows.Forms.Label();
            fact_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaOrdenesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProveedoresBindingSource)).BeginInit();
            this.panelDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orden_detalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_detalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ord_cant_produLabel
            // 
            ord_cant_produLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            ord_cant_produLabel.AutoSize = true;
            ord_cant_produLabel.Location = new System.Drawing.Point(19, 335);
            ord_cant_produLabel.Name = "ord_cant_produLabel";
            ord_cant_produLabel.Size = new System.Drawing.Size(280, 20);
            ord_cant_produLabel.TabIndex = 1;
            ord_cant_produLabel.Text = "Cantidad de producto en esta orden:";
            // 
            // ord_fechaLabel
            // 
            ord_fechaLabel.AutoSize = true;
            ord_fechaLabel.Location = new System.Drawing.Point(19, 108);
            ord_fechaLabel.Name = "ord_fechaLabel";
            ord_fechaLabel.Size = new System.Drawing.Size(60, 20);
            ord_fechaLabel.TabIndex = 3;
            ord_fechaLabel.Text = "Fecha:";
            // 
            // prov_idLabel
            // 
            prov_idLabel.AutoSize = true;
            prov_idLabel.Location = new System.Drawing.Point(19, 22);
            prov_idLabel.Name = "prov_idLabel";
            prov_idLabel.Size = new System.Drawing.Size(90, 20);
            prov_idLabel.TabIndex = 7;
            prov_idLabel.Text = "Proveedor:";
            // 
            // fact_idLabel
            // 
            fact_idLabel.AutoSize = true;
            fact_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fact_idLabel.Location = new System.Drawing.Point(12, 15);
            fact_idLabel.Name = "fact_idLabel";
            fact_idLabel.Size = new System.Drawing.Size(233, 36);
            fact_idLabel.TabIndex = 7;
            fact_idLabel.Text = "N° DE ORDEN:";
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.BindingSource = this.listaOrdenesBindingSource;
            this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 591);
            this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(1156, 27);
            this.bindingNavigator.TabIndex = 0;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // listaOrdenesBindingSource
            // 
            this.listaOrdenesBindingSource.DataSource = typeof(Distribuidora.BL.Entidades.orden_entrega);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(76, 24);
            this.bindingNavigatorDeleteItem.Text = "Anular";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // ord_cant_produTextBox
            // 
            this.ord_cant_produTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ord_cant_produTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaOrdenesBindingSource, "ord_cant_produ", true));
            this.ord_cant_produTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ord_cant_produTextBox.Location = new System.Drawing.Point(23, 357);
            this.ord_cant_produTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ord_cant_produTextBox.Name = "ord_cant_produTextBox";
            this.ord_cant_produTextBox.Size = new System.Drawing.Size(276, 34);
            this.ord_cant_produTextBox.TabIndex = 2;
            // 
            // ord_fechaDateTimePicker
            // 
            this.ord_fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaOrdenesBindingSource, "ord_fecha", true));
            this.ord_fechaDateTimePicker.Location = new System.Drawing.Point(23, 130);
            this.ord_fechaDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ord_fechaDateTimePicker.Name = "ord_fechaDateTimePicker";
            this.ord_fechaDateTimePicker.Size = new System.Drawing.Size(400, 27);
            this.ord_fechaDateTimePicker.TabIndex = 4;
            // 
            // ord_idTextBox
            // 
            this.ord_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaOrdenesBindingSource, "ord_id", true));
            this.ord_idTextBox.Location = new System.Drawing.Point(273, 12);
            this.ord_idTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ord_idTextBox.Name = "ord_idTextBox";
            this.ord_idTextBox.ReadOnly = true;
            this.ord_idTextBox.Size = new System.Drawing.Size(409, 41);
            this.ord_idTextBox.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(fact_idLabel);
            this.panel1.Controls.Add(this.ord_idTextBox);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 67);
            this.panel1.TabIndex = 21;
            // 
            // panelDatos
            // 
            this.panelDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelDatos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDatos.Controls.Add(this.ord_cant_produTextBox);
            this.panelDatos.Controls.Add(this.prov_nomComboBox);
            this.panelDatos.Controls.Add(prov_idLabel);
            this.panelDatos.Controls.Add(this.ord_fechaDateTimePicker);
            this.panelDatos.Controls.Add(ord_cant_produLabel);
            this.panelDatos.Controls.Add(ord_fechaLabel);
            this.panelDatos.Enabled = false;
            this.panelDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDatos.Location = new System.Drawing.Point(20, 162);
            this.panelDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(439, 413);
            this.panelDatos.TabIndex = 39;
            // 
            // prov_nomComboBox
            // 
            this.prov_nomComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaOrdenesBindingSource, "prov_id", true));
            this.prov_nomComboBox.DataSource = this.listaProveedoresBindingSource;
            this.prov_nomComboBox.DisplayMember = "prov_nom";
            this.prov_nomComboBox.FormattingEnabled = true;
            this.prov_nomComboBox.Location = new System.Drawing.Point(23, 46);
            this.prov_nomComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prov_nomComboBox.Name = "prov_nomComboBox";
            this.prov_nomComboBox.Size = new System.Drawing.Size(400, 28);
            this.prov_nomComboBox.TabIndex = 8;
            this.prov_nomComboBox.ValueMember = "prov_id";
            // 
            // listaProveedoresBindingSource
            // 
            this.listaProveedoresBindingSource.DataSource = typeof(Distribuidora.BL.Entidades.proveedor);
            // 
            // panelDetalle
            // 
            this.panelDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetalle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDetalle.Controls.Add(this.ListaProductosDetalleDelete);
            this.panelDetalle.Controls.Add(this.ListaProductosDetalleAdd);
            this.panelDetalle.Controls.Add(this.orden_detalleDataGridView);
            this.panelDetalle.Enabled = false;
            this.panelDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDetalle.Location = new System.Drawing.Point(479, 162);
            this.panelDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(651, 413);
            this.panelDetalle.TabIndex = 40;
            // 
            // ListaProductosDetalleDelete
            // 
            this.ListaProductosDetalleDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ListaProductosDetalleDelete.Location = new System.Drawing.Point(56, 370);
            this.ListaProductosDetalleDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListaProductosDetalleDelete.Name = "ListaProductosDetalleDelete";
            this.ListaProductosDetalleDelete.Size = new System.Drawing.Size(47, 36);
            this.ListaProductosDetalleDelete.TabIndex = 19;
            this.ListaProductosDetalleDelete.Text = "-";
            this.ListaProductosDetalleDelete.UseVisualStyleBackColor = true;
            this.ListaProductosDetalleDelete.Click += new System.EventHandler(this.ListaProductosDetalleDelete_Click);
            // 
            // ListaProductosDetalleAdd
            // 
            this.ListaProductosDetalleAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ListaProductosDetalleAdd.Location = new System.Drawing.Point(3, 370);
            this.ListaProductosDetalleAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListaProductosDetalleAdd.Name = "ListaProductosDetalleAdd";
            this.ListaProductosDetalleAdd.Size = new System.Drawing.Size(47, 36);
            this.ListaProductosDetalleAdd.TabIndex = 18;
            this.ListaProductosDetalleAdd.Text = "+";
            this.ListaProductosDetalleAdd.UseVisualStyleBackColor = true;
            this.ListaProductosDetalleAdd.Click += new System.EventHandler(this.ListaProductosDetalleAdd_Click);
            // 
            // orden_detalleDataGridView
            // 
            this.orden_detalleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orden_detalleDataGridView.AutoGenerateColumns = false;
            this.orden_detalleDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.orden_detalleDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orden_detalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orden_detalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.orden_detalleDataGridView.DataSource = this.orden_detalleBindingSource;
            this.orden_detalleDataGridView.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.orden_detalleDataGridView.Location = new System.Drawing.Point(3, 2);
            this.orden_detalleDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orden_detalleDataGridView.Name = "orden_detalleDataGridView";
            this.orden_detalleDataGridView.RowHeadersWidth = 51;
            this.orden_detalleDataGridView.RowTemplate.Height = 24;
            this.orden_detalleDataGridView.Size = new System.Drawing.Size(641, 361);
            this.orden_detalleDataGridView.TabIndex = 0;
            this.orden_detalleDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orden_detalleDataGridView_CellClick);
            this.orden_detalleDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.orden_detalleDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "produ_id";
            this.dataGridViewTextBoxColumn3.DataSource = this.listaProductosBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "produ_nom";
            this.dataGridViewTextBoxColumn3.FillWeight = 150F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 15;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "produ_id";
            // 
            // listaProductosBindingSource
            // 
            this.listaProductosBindingSource.AllowNew = true;
            this.listaProductosBindingSource.DataSource = typeof(Distribuidora.BL.Entidades.producto);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ord_det_cant";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 289;
            // 
            // orden_detalleBindingSource
            // 
            this.orden_detalleBindingSource.AllowNew = false;
            this.orden_detalleBindingSource.DataMember = "orden_detalle";
            this.orden_detalleBindingSource.DataSource = this.listaOrdenesBindingSource;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.listaOrdenesBindingSource;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSaveItem,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorEditItem,
            this.bindingNavigatorCancelItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1156, 47);
            this.bindingNavigator1.TabIndex = 41;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.Enabled = false;
            this.bindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveItem.Image")));
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(107, 44);
            this.bindingNavigatorSaveItem.Text = "Guardar datos";
            this.bindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(57, 44);
            this.bindingNavigatorAddNewItem.Text = "Añadir";
            this.bindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorEditItem
            // 
            this.bindingNavigatorEditItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorEditItem.Image")));
            this.bindingNavigatorEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorEditItem.Name = "bindingNavigatorEditItem";
            this.bindingNavigatorEditItem.Size = new System.Drawing.Size(52, 44);
            this.bindingNavigatorEditItem.Text = "Editar";
            this.bindingNavigatorEditItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorEditItem.Click += new System.EventHandler(this.bindingNavigatorEditItem_Click);
            // 
            // bindingNavigatorCancelItem
            // 
            this.bindingNavigatorCancelItem.Enabled = false;
            this.bindingNavigatorCancelItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorCancelItem.Image")));
            this.bindingNavigatorCancelItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorCancelItem.Name = "bindingNavigatorCancelItem";
            this.bindingNavigatorCancelItem.Size = new System.Drawing.Size(70, 44);
            this.bindingNavigatorCancelItem.Text = "Cancelar";
            this.bindingNavigatorCancelItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorCancelItem.Click += new System.EventHandler(this.bindingNavigatorCancelItem_Click);
            // 
            // frm_ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 618);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.panelDetalle);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_ordenes";
            this.Text = "Órdenes de Entrega";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaOrdenesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProveedoresBindingSource)).EndInit();
            this.panelDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orden_detalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_detalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaOrdenesBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.TextBox ord_cant_produTextBox;
        private System.Windows.Forms.DateTimePicker ord_fechaDateTimePicker;
        private System.Windows.Forms.TextBox ord_idTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.DataGridView orden_detalleDataGridView;
        private System.Windows.Forms.BindingSource orden_detalleBindingSource;
        private System.Windows.Forms.BindingSource listaProductosBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox prov_nomComboBox;
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
        private System.Windows.Forms.Button ListaProductosDetalleDelete;
        private System.Windows.Forms.Button ListaProductosDetalleAdd;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.BindingSource listaProveedoresBindingSource;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEditItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancelItem;
    }
}