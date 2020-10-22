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
            System.Windows.Forms.Label caje_caja_asigLabel;
            System.Windows.Forms.Label caje_fingLabel;
            System.Windows.Forms.Label caje_idLabel;
            System.Windows.Forms.Label emp_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cajeros));
            this.listaCajerosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaCajerosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.caje_caja_asigTextBox = new System.Windows.Forms.TextBox();
            this.caje_fingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.caje_idTextBox = new System.Windows.Forms.TextBox();
            this.listaEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            caje_caja_asigLabel = new System.Windows.Forms.Label();
            caje_fingLabel = new System.Windows.Forms.Label();
            caje_idLabel = new System.Windows.Forms.Label();
            emp_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaCajerosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCajerosBindingNavigator)).BeginInit();
            this.listaCajerosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // caje_caja_asigLabel
            // 
            caje_caja_asigLabel.AutoSize = true;
            caje_caja_asigLabel.Location = new System.Drawing.Point(145, 97);
            caje_caja_asigLabel.Name = "caje_caja_asigLabel";
            caje_caja_asigLabel.Size = new System.Drawing.Size(98, 17);
            caje_caja_asigLabel.TabIndex = 1;
            caje_caja_asigLabel.Text = "caje caja asig:";
            // 
            // caje_fingLabel
            // 
            caje_fingLabel.AutoSize = true;
            caje_fingLabel.Location = new System.Drawing.Point(145, 126);
            caje_fingLabel.Name = "caje_fingLabel";
            caje_fingLabel.Size = new System.Drawing.Size(65, 17);
            caje_fingLabel.TabIndex = 3;
            caje_fingLabel.Text = "caje fing:";
            // 
            // caje_idLabel
            // 
            caje_idLabel.AutoSize = true;
            caje_idLabel.Location = new System.Drawing.Point(145, 153);
            caje_idLabel.Name = "caje_idLabel";
            caje_idLabel.Size = new System.Drawing.Size(53, 17);
            caje_idLabel.TabIndex = 5;
            caje_idLabel.Text = "caje id:";
            // 
            // emp_idLabel
            // 
            emp_idLabel.AutoSize = true;
            emp_idLabel.Location = new System.Drawing.Point(145, 181);
            emp_idLabel.Name = "emp_idLabel";
            emp_idLabel.Size = new System.Drawing.Size(54, 17);
            emp_idLabel.TabIndex = 7;
            emp_idLabel.Text = "emp id:";
            // 
            // listaCajerosBindingSource
            // 
            this.listaCajerosBindingSource.DataSource = typeof(Distribuidora.BL.Entidades.cajero);
            // 
            // listaCajerosBindingNavigator
            // 
            this.listaCajerosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaCajerosBindingNavigator.BindingSource = this.listaCajerosBindingSource;
            this.listaCajerosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaCajerosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listaCajerosBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.listaCajerosBindingNavigator.Location = new System.Drawing.Point(0, 436);
            this.listaCajerosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaCajerosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaCajerosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaCajerosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaCajerosBindingNavigator.Name = "listaCajerosBindingNavigator";
            this.listaCajerosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaCajerosBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.listaCajerosBindingNavigator.TabIndex = 0;
            this.listaCajerosBindingNavigator.Text = "bindingNavigator1";
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
            // caje_caja_asigTextBox
            // 
            this.caje_caja_asigTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCajerosBindingSource, "caje_caja_asig", true));
            this.caje_caja_asigTextBox.Location = new System.Drawing.Point(249, 94);
            this.caje_caja_asigTextBox.Name = "caje_caja_asigTextBox";
            this.caje_caja_asigTextBox.Size = new System.Drawing.Size(200, 22);
            this.caje_caja_asigTextBox.TabIndex = 2;
            // 
            // caje_fingDateTimePicker
            // 
            this.caje_fingDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaCajerosBindingSource, "caje_fing", true));
            this.caje_fingDateTimePicker.Location = new System.Drawing.Point(249, 122);
            this.caje_fingDateTimePicker.Name = "caje_fingDateTimePicker";
            this.caje_fingDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.caje_fingDateTimePicker.TabIndex = 4;
            // 
            // caje_idTextBox
            // 
            this.caje_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCajerosBindingSource, "caje_id", true));
            this.caje_idTextBox.Location = new System.Drawing.Point(249, 150);
            this.caje_idTextBox.Name = "caje_idTextBox";
            this.caje_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.caje_idTextBox.TabIndex = 6;
            // 
            // listaEmpleadosBindingSource
            // 
            this.listaEmpleadosBindingSource.DataSource = typeof(Distribuidora.BL.Entidades.empleado);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.listaCajerosBindingSource;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 47);
            this.bindingNavigator1.TabIndex = 31;
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
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaCajerosBindingSource, "emp_id", true));
            this.comboBox1.DataSource = this.listaEmpleadosBindingSource;
            this.comboBox1.DisplayMember = "emp_pnom";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(249, 178);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.ValueMember = "emp_id";
            // 
            // frm_cajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(caje_caja_asigLabel);
            this.Controls.Add(this.caje_caja_asigTextBox);
            this.Controls.Add(caje_fingLabel);
            this.Controls.Add(this.caje_fingDateTimePicker);
            this.Controls.Add(caje_idLabel);
            this.Controls.Add(this.caje_idTextBox);
            this.Controls.Add(emp_idLabel);
            this.Controls.Add(this.listaCajerosBindingNavigator);
            this.Name = "frm_cajeros";
            this.Text = "frm_cajeros";
            ((System.ComponentModel.ISupportInitialize)(this.listaCajerosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCajerosBindingNavigator)).EndInit();
            this.listaCajerosBindingNavigator.ResumeLayout(false);
            this.listaCajerosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaCajerosBindingSource;
        private System.Windows.Forms.BindingNavigator listaCajerosBindingNavigator;
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
        private System.Windows.Forms.TextBox caje_caja_asigTextBox;
        private System.Windows.Forms.DateTimePicker caje_fingDateTimePicker;
        private System.Windows.Forms.TextBox caje_idTextBox;
        private System.Windows.Forms.BindingSource listaEmpleadosBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}