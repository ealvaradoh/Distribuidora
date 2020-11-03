namespace Distribuidora.Win
{
    partial class frm_cajeros
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
            System.Windows.Forms.Label caje_fingLabel;
            System.Windows.Forms.Label clien_idLabel;
            System.Windows.Forms.Label caje_caja_asigLabel;
            System.Windows.Forms.Label nombreEmpleadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cajeros));
            this.listaCajerosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.listaCajerosBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.caje_fingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCancelItem = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.caje_idTextBox = new System.Windows.Forms.TextBox();
            this.caje_caja_asigTextBox1 = new System.Windows.Forms.TextBox();
            this.listaNombreEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreEmpleadoComboBox = new System.Windows.Forms.ComboBox();
            this.panelDatos = new System.Windows.Forms.Panel();
            caje_fingLabel = new System.Windows.Forms.Label();
            clien_idLabel = new System.Windows.Forms.Label();
            caje_caja_asigLabel = new System.Windows.Forms.Label();
            nombreEmpleadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaCajerosBindingNavigator)).BeginInit();
            this.listaCajerosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCajerosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaNombreEmpleadosBindingSource)).BeginInit();
            this.panelDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // caje_fingLabel
            // 
            caje_fingLabel.AutoSize = true;
            caje_fingLabel.BackColor = System.Drawing.Color.Transparent;
            caje_fingLabel.Location = new System.Drawing.Point(24, 35);
            caje_fingLabel.Name = "caje_fingLabel";
            caje_fingLabel.Size = new System.Drawing.Size(143, 20);
            caje_fingLabel.TabIndex = 3;
            caje_fingLabel.Text = "Fecha de ingreso:";
            // 
            // clien_idLabel
            // 
            clien_idLabel.AutoSize = true;
            clien_idLabel.BackColor = System.Drawing.Color.Transparent;
            clien_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            clien_idLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            clien_idLabel.Location = new System.Drawing.Point(4, 12);
            clien_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            clien_idLabel.Name = "clien_idLabel";
            clien_idLabel.Size = new System.Drawing.Size(257, 36);
            clien_idLabel.TabIndex = 16;
            clien_idLabel.Text = "N° DE CAJERO: ";
            // 
            // caje_caja_asigLabel
            // 
            caje_caja_asigLabel.AutoSize = true;
            caje_caja_asigLabel.BackColor = System.Drawing.Color.Transparent;
            caje_caja_asigLabel.Location = new System.Drawing.Point(49, 153);
            caje_caja_asigLabel.Name = "caje_caja_asigLabel";
            caje_caja_asigLabel.Size = new System.Drawing.Size(120, 20);
            caje_caja_asigLabel.TabIndex = 33;
            caje_caja_asigLabel.Text = "Caja asignada:";
            // 
            // nombreEmpleadoLabel
            // 
            nombreEmpleadoLabel.AutoSize = true;
            nombreEmpleadoLabel.BackColor = System.Drawing.Color.Transparent;
            nombreEmpleadoLabel.Location = new System.Drawing.Point(82, 94);
            nombreEmpleadoLabel.Name = "nombreEmpleadoLabel";
            nombreEmpleadoLabel.Size = new System.Drawing.Size(93, 20);
            nombreEmpleadoLabel.TabIndex = 34;
            nombreEmpleadoLabel.Text = "Empleado: ";
            // 
            // listaCajerosBindingNavigator
            // 
            this.listaCajerosBindingNavigator.AddNewItem = null;
            this.listaCajerosBindingNavigator.BindingSource = this.listaCajerosBindingSource;
            this.listaCajerosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaCajerosBindingNavigator.DeleteItem = null;
            this.listaCajerosBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listaCajerosBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaCajerosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listaCajerosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaCajerosBindingNavigator.Location = new System.Drawing.Point(0, 442);
            this.listaCajerosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaCajerosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaCajerosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaCajerosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaCajerosBindingNavigator.Name = "listaCajerosBindingNavigator";
            this.listaCajerosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaCajerosBindingNavigator.Size = new System.Drawing.Size(746, 27);
            this.listaCajerosBindingNavigator.TabIndex = 0;
            this.listaCajerosBindingNavigator.Text = "bindingNavigator1";
            // 
            // listaCajerosBindingSource
            // 
            this.listaCajerosBindingSource.DataSource = typeof(Distribuidora.BL.Entidades.cajero);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(87, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // caje_fingDateTimePicker
            // 
            this.caje_fingDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaCajerosBindingSource, "caje_fing", true));
            this.caje_fingDateTimePicker.Location = new System.Drawing.Point(197, 35);
            this.caje_fingDateTimePicker.Name = "caje_fingDateTimePicker";
            this.caje_fingDateTimePicker.Size = new System.Drawing.Size(452, 27);
            this.caje_fingDateTimePicker.TabIndex = 4;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.BackColor = System.Drawing.SystemColors.Control;
            this.bindingNavigator.BindingSource = this.listaCajerosBindingSource;
            this.bindingNavigator.CountItem = null;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BindingNavigatorSaveItem,
            this.bindingNavigatorEditItem,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorCancelItem});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator.MoveFirstItem = null;
            this.bindingNavigator.MoveLastItem = null;
            this.bindingNavigator.MoveNextItem = null;
            this.bindingNavigator.MovePreviousItem = null;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = null;
            this.bindingNavigator.Size = new System.Drawing.Size(746, 47);
            this.bindingNavigator.TabIndex = 31;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // BindingNavigatorSaveItem
            // 
            this.BindingNavigatorSaveItem.Enabled = false;
            this.BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorSaveItem.Image")));
            this.BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem";
            this.BindingNavigatorSaveItem.Size = new System.Drawing.Size(107, 44);
            this.BindingNavigatorSaveItem.Text = "Guardar datos";
            this.BindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BindingNavigatorSaveItem.Click += new System.EventHandler(this.listaCajerosBindingNavigatorSaveItem_Click);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.caje_idTextBox);
            this.panel1.Controls.Add(clien_idLabel);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 67);
            this.panel1.TabIndex = 33;
            // 
            // caje_idTextBox
            // 
            this.caje_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCajerosBindingSource, "caje_id", true));
            this.caje_idTextBox.Location = new System.Drawing.Point(279, 9);
            this.caje_idTextBox.Name = "caje_idTextBox";
            this.caje_idTextBox.ReadOnly = true;
            this.caje_idTextBox.Size = new System.Drawing.Size(316, 41);
            this.caje_idTextBox.TabIndex = 36;
            this.caje_idTextBox.Text = "0";
            // 
            // caje_caja_asigTextBox1
            // 
            this.caje_caja_asigTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCajerosBindingSource, "caje_caja_asig", true));
            this.caje_caja_asigTextBox1.Location = new System.Drawing.Point(197, 154);
            this.caje_caja_asigTextBox1.Name = "caje_caja_asigTextBox1";
            this.caje_caja_asigTextBox1.Size = new System.Drawing.Size(74, 27);
            this.caje_caja_asigTextBox1.TabIndex = 34;
            // 
            // listaNombreEmpleadosBindingSource
            // 
            this.listaNombreEmpleadosBindingSource.DataSource = typeof(Distribuidora.BL.BL.empleadosBL.empleadoNombre);
            // 
            // nombreEmpleadoComboBox
            // 
            this.nombreEmpleadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaCajerosBindingSource, "emp_id", true));
            this.nombreEmpleadoComboBox.DataSource = this.listaNombreEmpleadosBindingSource;
            this.nombreEmpleadoComboBox.DisplayMember = "nombreEmpleado";
            this.nombreEmpleadoComboBox.FormattingEnabled = true;
            this.nombreEmpleadoComboBox.Location = new System.Drawing.Point(197, 93);
            this.nombreEmpleadoComboBox.Name = "nombreEmpleadoComboBox";
            this.nombreEmpleadoComboBox.Size = new System.Drawing.Size(452, 28);
            this.nombreEmpleadoComboBox.TabIndex = 35;
            this.nombreEmpleadoComboBox.ValueMember = "emp_id";
            // 
            // panelDatos
            // 
            this.panelDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDatos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDatos.Controls.Add(this.caje_fingDateTimePicker);
            this.panelDatos.Controls.Add(caje_caja_asigLabel);
            this.panelDatos.Controls.Add(this.nombreEmpleadoComboBox);
            this.panelDatos.Controls.Add(caje_fingLabel);
            this.panelDatos.Controls.Add(nombreEmpleadoLabel);
            this.panelDatos.Controls.Add(this.caje_caja_asigTextBox1);
            this.panelDatos.Enabled = false;
            this.panelDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDatos.Location = new System.Drawing.Point(27, 151);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(688, 223);
            this.panelDatos.TabIndex = 36;
            // 
            // frm_cajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(746, 469);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bindingNavigator);
            this.Controls.Add(this.listaCajerosBindingNavigator);
            this.Name = "frm_cajeros";
            this.Text = "Cajeros";
            ((System.ComponentModel.ISupportInitialize)(this.listaCajerosBindingNavigator)).EndInit();
            this.listaCajerosBindingNavigator.ResumeLayout(false);
            this.listaCajerosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCajerosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaNombreEmpleadosBindingSource)).EndInit();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaCajerosBindingSource;
        private System.Windows.Forms.BindingNavigator listaCajerosBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DateTimePicker caje_fingDateTimePicker;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripButton BindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEditItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancelItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox caje_caja_asigTextBox1;
        private System.Windows.Forms.BindingSource listaNombreEmpleadosBindingSource;
        private System.Windows.Forms.ComboBox nombreEmpleadoComboBox;
        private System.Windows.Forms.TextBox caje_idTextBox;
        private System.Windows.Forms.Panel panelDatos;
    }
}