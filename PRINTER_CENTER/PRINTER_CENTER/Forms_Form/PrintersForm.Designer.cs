namespace PRINTER_CENTER.Forms_Form
{
    partial class PrintersForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewPrinters = new System.Windows.Forms.DataGridView();
            this.printerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paperSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.printingMachinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printingDataSet = new PRINTER_CENTER.PrintingDataSet();
            this.printingMachinesTableAdapter = new PRINTER_CENTER.PrintingDataSetTableAdapters.PrintingMachinesTableAdapter();
            this.getProcessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrinters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingMachinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.getProcessesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(846, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // dataGridViewPrinters
            // 
            this.dataGridViewPrinters.AutoGenerateColumns = false;
            this.dataGridViewPrinters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPrinters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrinters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.printerIdDataGridViewTextBoxColumn,
            this.paperSizeDataGridViewTextBoxColumn,
            this.speedDataGridViewTextBoxColumn,
            this.conditionDataGridViewCheckBoxColumn});
            this.dataGridViewPrinters.DataSource = this.printingMachinesBindingSource;
            this.dataGridViewPrinters.Location = new System.Drawing.Point(35, 60);
            this.dataGridViewPrinters.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPrinters.MultiSelect = false;
            this.dataGridViewPrinters.Name = "dataGridViewPrinters";
            this.dataGridViewPrinters.ReadOnly = true;
            this.dataGridViewPrinters.RowHeadersWidth = 51;
            this.dataGridViewPrinters.RowTemplate.Height = 24;
            this.dataGridViewPrinters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPrinters.Size = new System.Drawing.Size(772, 340);
            this.dataGridViewPrinters.TabIndex = 4;
            // 
            // printerIdDataGridViewTextBoxColumn
            // 
            this.printerIdDataGridViewTextBoxColumn.DataPropertyName = "PrinterId";
            this.printerIdDataGridViewTextBoxColumn.HeaderText = "PrinterId";
            this.printerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.printerIdDataGridViewTextBoxColumn.Name = "printerIdDataGridViewTextBoxColumn";
            this.printerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paperSizeDataGridViewTextBoxColumn
            // 
            this.paperSizeDataGridViewTextBoxColumn.DataPropertyName = "PaperSize";
            this.paperSizeDataGridViewTextBoxColumn.HeaderText = "PaperSize";
            this.paperSizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paperSizeDataGridViewTextBoxColumn.Name = "paperSizeDataGridViewTextBoxColumn";
            this.paperSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // speedDataGridViewTextBoxColumn
            // 
            this.speedDataGridViewTextBoxColumn.DataPropertyName = "Speed";
            this.speedDataGridViewTextBoxColumn.HeaderText = "Speed";
            this.speedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.speedDataGridViewTextBoxColumn.Name = "speedDataGridViewTextBoxColumn";
            this.speedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conditionDataGridViewCheckBoxColumn
            // 
            this.conditionDataGridViewCheckBoxColumn.DataPropertyName = "Condition";
            this.conditionDataGridViewCheckBoxColumn.HeaderText = "Condition";
            this.conditionDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.conditionDataGridViewCheckBoxColumn.Name = "conditionDataGridViewCheckBoxColumn";
            this.conditionDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // printingMachinesBindingSource
            // 
            this.printingMachinesBindingSource.DataMember = "PrintingMachines";
            this.printingMachinesBindingSource.DataSource = this.printingDataSet;
            // 
            // printingDataSet
            // 
            this.printingDataSet.DataSetName = "PrintingDataSet";
            this.printingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printingMachinesTableAdapter
            // 
            this.printingMachinesTableAdapter.ClearBeforeFill = true;
            // 
            // getProcessesToolStripMenuItem
            // 
            this.getProcessesToolStripMenuItem.Name = "getProcessesToolStripMenuItem";
            this.getProcessesToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.getProcessesToolStripMenuItem.Text = "Get processes";
            this.getProcessesToolStripMenuItem.Click += new System.EventHandler(this.getProcessesToolStripMenuItem_Click);
            // 
            // PrintersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(846, 460);
            this.Controls.Add(this.dataGridViewPrinters);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrintersForm";
            this.Text = "PrintersForm";
            this.Load += new System.EventHandler(this.PrintersForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrinters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingMachinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewPrinters;
        private PrintingDataSet printingDataSet;
        private System.Windows.Forms.BindingSource printingMachinesBindingSource;
        private PrintingDataSetTableAdapters.PrintingMachinesTableAdapter printingMachinesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn printerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paperSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn conditionDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem getProcessesToolStripMenuItem;
    }
}