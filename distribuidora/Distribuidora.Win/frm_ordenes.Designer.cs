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
            this.bindingNavigatorDelete = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.listaOrdenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.listaOrdenesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ord_cant_produTextBox = new System.Windows.Forms.TextBox();
            this.ord_fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ord_idTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.prov_nomComboBox = new System.Windows.Forms.ComboBox();
            this.listaProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.ListaProductosDetalleDelete = new System.Windows.Forms.Button();
            this.ListaProductosDetalleAdd = new System.Windows.Forms.Button();
            this.orden_detalleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.listaProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orden_detalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            ord_cant_produLabel = new System.Windows.Forms.Label();
            ord_fechaLabel = new System.Windows.Forms.Label();
            prov_idLabel = new System.Windows.Forms.Label();
            fact_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDelete)).BeginInit();
            this.bindingNavigatorDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaOrdenesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProveedoresBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orden_detalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_detalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // ord_cant_produLabel
            // 
            ord_cant_produLabel.AutoSize = true;
            ord_cant_produLabel.Location = new System.Drawing.Point(19, 364);
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
            // bindingNavigatorDelete
            // 
            this.bindingNavigatorDelete.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorDelete.BindingSource = this.listaOrdenesBindingSource;
            this.bindingNavigatorDelete.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorDelete.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorDelete.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaOrdenesBindingNavigatorSaveItem});
            this.bindingNavigatorDelete.Location = new System.Drawing.Point(0, 642);
            this.bindingNavigatorDelete.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorDelete.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorDelete.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorDelete.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorDelete.Name = "bindingNavigatorDelete";
            this.bindingNavigatorDelete.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorDelete.Size = new System.Drawing.Size(1156, 27);
            this.bindingNavigatorDelete.TabIndex = 0;
            this.bindingNavigatorDelete.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
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
            // listaOrdenesBindingNavigatorSaveItem
            // 
            this.listaOrdenesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaOrdenesBindingNavigatorSaveItem.Image")));
            this.listaOrdenesBindingNavigatorSaveItem.Name = "listaOrdenesBindingNavigatorSaveItem";
            this.listaOrdenesBindingNavigatorSaveItem.Size = new System.Drawing.Size(76, 24);
            this.listaOrdenesBindingNavigatorSaveItem.Text = "Anular";
            // 
            // ord_cant_produTextBox
            // 
            this.ord_cant_produTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaOrdenesBindingSource, "ord_cant_produ", true));
            this.ord_cant_produTextBox.Location = new System.Drawing.Point(23, 387);
            this.ord_cant_produTextBox.Name = "ord_cant_produTextBox";
            this.ord_cant_produTextBox.Size = new System.Drawing.Size(276, 27);
            this.ord_cant_produTextBox.TabIndex = 2;
            // 
            // ord_fechaDateTimePicker
            // 
            this.ord_fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaOrdenesBindingSource, "ord_fecha", true));
            this.ord_fechaDateTimePicker.Location = new System.Drawing.Point(23, 131);
            this.ord_fechaDateTimePicker.Name = "ord_fechaDateTimePicker";
            this.ord_fechaDateTimePicker.Size = new System.Drawing.Size(400, 27);
            this.ord_fechaDateTimePicker.TabIndex = 4;
            // 
            // ord_idTextBox
            // 
            this.ord_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaOrdenesBindingSource, "ord_id", true));
            this.ord_idTextBox.Enabled = false;
            this.ord_idTextBox.Location = new System.Drawing.Point(273, 12);
            this.ord_idTextBox.Name = "ord_idTextBox";
            this.ord_idTextBox.Size = new System.Drawing.Size(409, 41);
            this.ord_idTextBox.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(fact_idLabel);
            this.panel1.Controls.Add(this.ord_idTextBox);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 67);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.prov_nomComboBox);
            this.panel2.Controls.Add(prov_idLabel);
            this.panel2.Controls.Add(this.ord_fechaDateTimePicker);
            this.panel2.Controls.Add(ord_cant_produLabel);
            this.panel2.Controls.Add(ord_fechaLabel);
            this.panel2.Controls.Add(this.ord_cant_produTextBox);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(20, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 436);
            this.panel2.TabIndex = 39;
            // 
            // prov_nomComboBox
            // 
            this.prov_nomComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaOrdenesBindingSource, "prov_id", true));
            this.prov_nomComboBox.DataSource = this.listaProveedoresBindingSource;
            this.prov_nomComboBox.DisplayMember = "prov_nom";
            this.prov_nomComboBox.FormattingEnabled = true;
            this.prov_nomComboBox.Location = new System.Drawing.Point(23, 45);
            this.prov_nomComboBox.Name = "prov_nomComboBox";
            this.prov_nomComboBox.Size = new System.Drawing.Size(400, 28);
            this.prov_nomComboBox.TabIndex = 8;
            this.prov_nomComboBox.ValueMember = "prov_id";
            // 
            // listaProveedoresBindingSource
            // 
            this.listaProveedoresBindingSource.DataSource = typeof(Distribuidora.BL.Entidades.proveedor);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.ListaProductosDetalleDelete);
            this.panel3.Controls.Add(this.ListaProductosDetalleAdd);
            this.panel3.Controls.Add(this.orden_detalleDataGridView);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(479, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(651, 436);
            this.panel3.TabIndex = 40;
            // 
            // ListaProductosDetalleDelete
            // 
            this.ListaProductosDetalleDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ListaProductosDetalleDelete.Location = new System.Drawing.Point(586, 338);
            this.ListaProductosDetalleDelete.Name = "ListaProductosDetalleDelete";
            this.ListaProductosDetalleDelete.Size = new System.Drawing.Size(47, 36);
            this.ListaProductosDetalleDelete.TabIndex = 19;
            this.ListaProductosDetalleDelete.Text = "-";
            this.ListaProductosDetalleDelete.UseVisualStyleBackColor = true;
            // 
            // ListaProductosDetalleAdd
            // 
            this.ListaProductosDetalleAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ListaProductosDetalleAdd.Location = new System.Drawing.Point(533, 338);
            this.ListaProductosDetalleAdd.Name = "ListaProductosDetalleAdd";
            this.ListaProductosDetalleAdd.Size = new System.Drawing.Size(47, 36);
            this.ListaProductosDetalleAdd.TabIndex = 18;
            this.ListaProductosDetalleAdd.Text = "+";
            this.ListaProductosDetalleAdd.UseVisualStyleBackColor = true;
            // 
            // orden_detalleDataGridView
            // 
            this.orden_detalleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orden_detalleDataGridView.AutoGenerateColumns = false;
            this.orden_detalleDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.orden_detalleDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orden_detalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orden_detalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.orden_detalleDataGridView.DataSource = this.orden_detalleBindingSource;
            this.orden_detalleDataGridView.Location = new System.Drawing.Point(3, 3);
            this.orden_detalleDataGridView.Name = "orden_detalleDataGridView";
            this.orden_detalleDataGridView.RowHeadersWidth = 51;
            this.orden_detalleDataGridView.RowTemplate.Height = 24;
            this.orden_detalleDataGridView.Size = new System.Drawing.Size(641, 329);
            this.orden_detalleDataGridView.TabIndex = 0;
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
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.BindingSource = this.listaOrdenesBindingSource;
            this.bindingNavigator.CountItem = null;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripButton2,
            this.toolStripButton7});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator.MoveFirstItem = null;
            this.bindingNavigator.MoveLastItem = null;
            this.bindingNavigator.MoveNextItem = null;
            this.bindingNavigator.MovePreviousItem = null;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = null;
            this.bindingNavigator.Size = new System.Drawing.Size(1156, 47);
            this.bindingNavigator.TabIndex = 41;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(107, 44);
            this.toolStripButton1.Text = "Guardar datos";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(52, 44);
            this.toolStripButton3.Text = "Editar";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(57, 44);
            this.toolStripButton2.Text = "Añadir";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Enabled = false;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(70, 44);
            this.toolStripButton7.Text = "Cancelar";
            this.toolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // frm_ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 669);
            this.Controls.Add(this.bindingNavigator);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bindingNavigatorDelete);
            this.Name = "frm_ordenes";
            this.Text = "frm_ordenes";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDelete)).EndInit();
            this.bindingNavigatorDelete.ResumeLayout(false);
            this.bindingNavigatorDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaOrdenesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProveedoresBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orden_detalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orden_detalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaOrdenesBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigatorDelete;
        private System.Windows.Forms.ToolStripButton listaOrdenesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox ord_cant_produTextBox;
        private System.Windows.Forms.DateTimePicker ord_fechaDateTimePicker;
        private System.Windows.Forms.TextBox ord_idTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView orden_detalleDataGridView;
        private System.Windows.Forms.BindingSource orden_detalleBindingSource;
        private System.Windows.Forms.BindingSource listaProductosBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox prov_nomComboBox;
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
        private System.Windows.Forms.Button ListaProductosDetalleDelete;
        private System.Windows.Forms.Button ListaProductosDetalleAdd;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.BindingSource listaProveedoresBindingSource;
    }
}