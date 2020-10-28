namespace Distribuidora.Win
{
    partial class frm_facturas
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
            System.Windows.Forms.Label fact_idLabel;
            System.Windows.Forms.Label fact_isvLabel;
            System.Windows.Forms.Label fact_subtLabel;
            System.Windows.Forms.Label fact_totalLabel;
            System.Windows.Forms.Label fact_fechaLabel;
            System.Windows.Forms.Label clien_idLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_facturas));
            this.listaFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaFacturasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fact_idTextBox = new System.Windows.Forms.TextBox();
            this.fact_isvTextBox = new System.Windows.Forms.TextBox();
            this.fact_subtTextBox = new System.Windows.Forms.TextBox();
            this.fact_totalTextBox = new System.Windows.Forms.TextBox();
            this.factura_detalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factura_detalleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.listaProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorTop = new System.Windows.Forms.BindingNavigator(this.components);
            this.listaFacturasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCancelItem = new System.Windows.Forms.ToolStripButton();
            this.listaNombreCajerosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fact_fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ListaFacturaDetalleDelete = new System.Windows.Forms.Button();
            this.ListaFacturaDetalleAdd = new System.Windows.Forms.Button();
            fact_idLabel = new System.Windows.Forms.Label();
            fact_isvLabel = new System.Windows.Forms.Label();
            fact_subtLabel = new System.Windows.Forms.Label();
            fact_totalLabel = new System.Windows.Forms.Label();
            fact_fechaLabel = new System.Windows.Forms.Label();
            clien_idLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFacturasBindingNavigator)).BeginInit();
            this.listaFacturasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.factura_detalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura_detalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorTop)).BeginInit();
            this.bindingNavigatorTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaNombreCajerosBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // fact_idLabel
            // 
            fact_idLabel.AutoSize = true;
            fact_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fact_idLabel.Location = new System.Drawing.Point(12, 15);
            fact_idLabel.Name = "fact_idLabel";
            fact_idLabel.Size = new System.Drawing.Size(271, 36);
            fact_idLabel.TabIndex = 7;
            fact_idLabel.Text = "N° DE FACTURA:";
            // 
            // fact_isvLabel
            // 
            fact_isvLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            fact_isvLabel.AutoSize = true;
            fact_isvLabel.Location = new System.Drawing.Point(962, 265);
            fact_isvLabel.Name = "fact_isvLabel";
            fact_isvLabel.Size = new System.Drawing.Size(40, 20);
            fact_isvLabel.TabIndex = 9;
            fact_isvLabel.Text = "ISV:";
            // 
            // fact_subtLabel
            // 
            fact_subtLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            fact_subtLabel.AutoSize = true;
            fact_subtLabel.Location = new System.Drawing.Point(962, 194);
            fact_subtLabel.Name = "fact_subtLabel";
            fact_subtLabel.Size = new System.Drawing.Size(103, 20);
            fact_subtLabel.TabIndex = 11;
            fact_subtLabel.Text = "SUBTOTAL:";
            // 
            // fact_totalLabel
            // 
            fact_totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            fact_totalLabel.AutoSize = true;
            fact_totalLabel.Location = new System.Drawing.Point(962, 334);
            fact_totalLabel.Name = "fact_totalLabel";
            fact_totalLabel.Size = new System.Drawing.Size(68, 20);
            fact_totalLabel.TabIndex = 13;
            fact_totalLabel.Text = "TOTAL:";
            // 
            // fact_fechaLabel
            // 
            fact_fechaLabel.AutoSize = true;
            fact_fechaLabel.Location = new System.Drawing.Point(21, 86);
            fact_fechaLabel.Name = "fact_fechaLabel";
            fact_fechaLabel.Size = new System.Drawing.Size(60, 20);
            fact_fechaLabel.TabIndex = 22;
            fact_fechaLabel.Text = "Fecha:";
            // 
            // clien_idLabel
            // 
            clien_idLabel.AutoSize = true;
            clien_idLabel.Location = new System.Drawing.Point(21, 21);
            clien_idLabel.Name = "clien_idLabel";
            clien_idLabel.Size = new System.Drawing.Size(66, 20);
            clien_idLabel.TabIndex = 21;
            clien_idLabel.Text = "Cliente:";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(773, 86);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(131, 20);
            label1.TabIndex = 26;
            label1.Text = "Cajero antiende:";
            // 
            // listaFacturasBindingSource
            // 
            this.listaFacturasBindingSource.DataSource = typeof(Distribuidora.BL.Entidades.factura);
            // 
            // listaFacturasBindingNavigator
            // 
            this.listaFacturasBindingNavigator.AddNewItem = null;
            this.listaFacturasBindingNavigator.BindingSource = this.listaFacturasBindingSource;
            this.listaFacturasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaFacturasBindingNavigator.DeleteItem = null;
            this.listaFacturasBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listaFacturasBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listaFacturasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.listaFacturasBindingNavigator.Location = new System.Drawing.Point(0, 738);
            this.listaFacturasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaFacturasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaFacturasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaFacturasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaFacturasBindingNavigator.Name = "listaFacturasBindingNavigator";
            this.listaFacturasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaFacturasBindingNavigator.Size = new System.Drawing.Size(1278, 27);
            this.listaFacturasBindingNavigator.TabIndex = 0;
            this.listaFacturasBindingNavigator.Text = "bindingNavigator1";
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
            // fact_idTextBox
            // 
            this.fact_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFacturasBindingSource, "fact_id", true));
            this.fact_idTextBox.Enabled = false;
            this.fact_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fact_idTextBox.Location = new System.Drawing.Point(312, 12);
            this.fact_idTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fact_idTextBox.Name = "fact_idTextBox";
            this.fact_idTextBox.Size = new System.Drawing.Size(386, 41);
            this.fact_idTextBox.TabIndex = 8;
            // 
            // fact_isvTextBox
            // 
            this.fact_isvTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fact_isvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFacturasBindingSource, "fact_isv", true));
            this.fact_isvTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fact_isvTextBox.Location = new System.Drawing.Point(966, 287);
            this.fact_isvTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fact_isvTextBox.Name = "fact_isvTextBox";
            this.fact_isvTextBox.Size = new System.Drawing.Size(240, 34);
            this.fact_isvTextBox.TabIndex = 10;
            // 
            // fact_subtTextBox
            // 
            this.fact_subtTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fact_subtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFacturasBindingSource, "fact_subt", true));
            this.fact_subtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fact_subtTextBox.Location = new System.Drawing.Point(966, 216);
            this.fact_subtTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fact_subtTextBox.Name = "fact_subtTextBox";
            this.fact_subtTextBox.Size = new System.Drawing.Size(240, 34);
            this.fact_subtTextBox.TabIndex = 12;
            // 
            // fact_totalTextBox
            // 
            this.fact_totalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fact_totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFacturasBindingSource, "fact_total", true));
            this.fact_totalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fact_totalTextBox.Location = new System.Drawing.Point(966, 356);
            this.fact_totalTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fact_totalTextBox.Name = "fact_totalTextBox";
            this.fact_totalTextBox.Size = new System.Drawing.Size(240, 34);
            this.fact_totalTextBox.TabIndex = 14;
            // 
            // factura_detalleBindingSource
            // 
            this.factura_detalleBindingSource.AllowNew = false;
            this.factura_detalleBindingSource.DataMember = "factura_detalle";
            this.factura_detalleBindingSource.DataSource = this.listaFacturasBindingSource;
            // 
            // factura_detalleDataGridView
            // 
            this.factura_detalleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.factura_detalleDataGridView.AutoGenerateColumns = false;
            this.factura_detalleDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.factura_detalleDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.factura_detalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.factura_detalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.factura_detalleDataGridView.DataSource = this.factura_detalleBindingSource;
            this.factura_detalleDataGridView.Location = new System.Drawing.Point(3, 2);
            this.factura_detalleDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.factura_detalleDataGridView.Name = "factura_detalleDataGridView";
            this.factura_detalleDataGridView.RowHeadersWidth = 51;
            this.factura_detalleDataGridView.RowTemplate.Height = 24;
            this.factura_detalleDataGridView.Size = new System.Drawing.Size(888, 411);
            this.factura_detalleDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "produ_id";
            this.dataGridViewTextBoxColumn4.DataSource = this.listaProductosBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "produ_nom";
            this.dataGridViewTextBoxColumn4.HeaderText = "Productos";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "produ_id";
            // 
            // listaProductosBindingSource
            // 
            this.listaProductosBindingSource.DataSource = typeof(Distribuidora.BL.Entidades.producto);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fact_det_cant";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fact_det_prec";
            this.dataGridViewTextBoxColumn7.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "fact_det_total";
            this.dataGridViewTextBoxColumn8.HeaderText = "Total";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // listaClientesBindingSource
            // 
            this.listaClientesBindingSource.DataSource = typeof(Distribuidora.BL.Entidades.cliente);
            // 
            // bindingNavigatorTop
            // 
            this.bindingNavigatorTop.AddNewItem = null;
            this.bindingNavigatorTop.BindingSource = this.listaFacturasBindingSource;
            this.bindingNavigatorTop.CountItem = null;
            this.bindingNavigatorTop.DeleteItem = null;
            this.bindingNavigatorTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaFacturasBindingNavigatorSaveItem,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorEditItem,
            this.bindingNavigatorCancelItem});
            this.bindingNavigatorTop.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorTop.MoveFirstItem = null;
            this.bindingNavigatorTop.MoveLastItem = null;
            this.bindingNavigatorTop.MoveNextItem = null;
            this.bindingNavigatorTop.MovePreviousItem = null;
            this.bindingNavigatorTop.Name = "bindingNavigatorTop";
            this.bindingNavigatorTop.PositionItem = null;
            this.bindingNavigatorTop.Size = new System.Drawing.Size(1278, 47);
            this.bindingNavigatorTop.TabIndex = 18;
            this.bindingNavigatorTop.Text = "bindingNavigator1";
            // 
            // listaFacturasBindingNavigatorSaveItem
            // 
            this.listaFacturasBindingNavigatorSaveItem.Enabled = false;
            this.listaFacturasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaFacturasBindingNavigatorSaveItem.Image")));
            this.listaFacturasBindingNavigatorSaveItem.Name = "listaFacturasBindingNavigatorSaveItem";
            this.listaFacturasBindingNavigatorSaveItem.Size = new System.Drawing.Size(107, 44);
            this.listaFacturasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaFacturasBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.listaFacturasBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaFacturasBindingNavigatorSaveItem_Click);
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
            // listaNombreCajerosBindingSource
            // 
            this.listaNombreCajerosBindingSource.DataSource = typeof(Distribuidora.BL.BL.cajerosBL.cajeroNombre);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.fact_idTextBox);
            this.panel1.Controls.Add(fact_idLabel);
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 67);
            this.panel1.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaFacturasBindingSource, "clien_id", true));
            this.comboBox1.DataSource = this.listaClientesBindingSource;
            this.comboBox1.DisplayMember = "clien_nom";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 43);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(357, 28);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.ValueMember = "clien_id";
            // 
            // fact_fechaDateTimePicker
            // 
            this.fact_fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaFacturasBindingSource, "fact_fecha", true));
            this.fact_fechaDateTimePicker.Location = new System.Drawing.Point(20, 108);
            this.fact_fechaDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fact_fechaDateTimePicker.Name = "fact_fechaDateTimePicker";
            this.fact_fechaDateTimePicker.Size = new System.Drawing.Size(357, 27);
            this.fact_fechaDateTimePicker.TabIndex = 23;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaFacturasBindingSource, "caje_id", true));
            this.comboBox2.DataSource = this.listaNombreCajerosBindingSource;
            this.comboBox2.DisplayMember = "empleadoNombre";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(777, 108);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(424, 28);
            this.comboBox2.TabIndex = 25;
            this.comboBox2.ValueMember = "caje_id";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(label1);
            this.panel2.Controls.Add(clien_idLabel);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(fact_fechaLabel);
            this.panel2.Controls.Add(this.fact_fechaDateTimePicker);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(28, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1220, 157);
            this.panel2.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.ListaFacturaDetalleDelete);
            this.panel3.Controls.Add(this.factura_detalleDataGridView);
            this.panel3.Controls.Add(this.fact_subtTextBox);
            this.panel3.Controls.Add(fact_subtLabel);
            this.panel3.Controls.Add(this.ListaFacturaDetalleAdd);
            this.panel3.Controls.Add(this.fact_isvTextBox);
            this.panel3.Controls.Add(fact_isvLabel);
            this.panel3.Controls.Add(this.fact_totalTextBox);
            this.panel3.Controls.Add(fact_totalLabel);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(28, 306);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1220, 419);
            this.panel3.TabIndex = 39;
            // 
            // ListaFacturaDetalleDelete
            // 
            this.ListaFacturaDetalleDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ListaFacturaDetalleDelete.Location = new System.Drawing.Point(892, 360);
            this.ListaFacturaDetalleDelete.Name = "ListaFacturaDetalleDelete";
            this.ListaFacturaDetalleDelete.Size = new System.Drawing.Size(47, 36);
            this.ListaFacturaDetalleDelete.TabIndex = 17;
            this.ListaFacturaDetalleDelete.Text = "-";
            this.ListaFacturaDetalleDelete.UseVisualStyleBackColor = true;
            this.ListaFacturaDetalleDelete.Click += new System.EventHandler(this.ListaFacturaDetalleDelete_Click);
            // 
            // ListaFacturaDetalleAdd
            // 
            this.ListaFacturaDetalleAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ListaFacturaDetalleAdd.Location = new System.Drawing.Point(892, 322);
            this.ListaFacturaDetalleAdd.Name = "ListaFacturaDetalleAdd";
            this.ListaFacturaDetalleAdd.Size = new System.Drawing.Size(47, 36);
            this.ListaFacturaDetalleAdd.TabIndex = 16;
            this.ListaFacturaDetalleAdd.Text = "+";
            this.ListaFacturaDetalleAdd.UseVisualStyleBackColor = true;
            this.ListaFacturaDetalleAdd.Click += new System.EventHandler(this.ListaFacturaDetalleAdd_Click);
            // 
            // frm_facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1278, 765);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bindingNavigatorTop);
            this.Controls.Add(this.listaFacturasBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_facturas";
            this.Text = "frm_facturas";
            ((System.ComponentModel.ISupportInitialize)(this.listaFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFacturasBindingNavigator)).EndInit();
            this.listaFacturasBindingNavigator.ResumeLayout(false);
            this.listaFacturasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.factura_detalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura_detalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorTop)).EndInit();
            this.bindingNavigatorTop.ResumeLayout(false);
            this.bindingNavigatorTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaNombreCajerosBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaFacturasBindingSource;
        private System.Windows.Forms.BindingNavigator listaFacturasBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox fact_idTextBox;
        private System.Windows.Forms.TextBox fact_isvTextBox;
        private System.Windows.Forms.TextBox fact_subtTextBox;
        private System.Windows.Forms.TextBox fact_totalTextBox;
        private System.Windows.Forms.BindingSource factura_detalleBindingSource;
        private System.Windows.Forms.DataGridView factura_detalleDataGridView;
        private System.Windows.Forms.BindingSource listaClientesBindingSource;
        private System.Windows.Forms.BindingSource listaProductosBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigatorTop;
        private System.Windows.Forms.ToolStripButton listaFacturasBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancelItem;
        private System.Windows.Forms.BindingSource listaNombreCajerosBindingSource;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEditItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker fact_fechaDateTimePicker;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ListaFacturaDetalleDelete;
        private System.Windows.Forms.Button ListaFacturaDetalleAdd;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}