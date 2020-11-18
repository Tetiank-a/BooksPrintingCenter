namespace PRINTER_CENTER.Forms_Form
{
    partial class ProcessLOOK
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
            this.dataGridViewProcess = new System.Windows.Forms.DataGridView();
            this.processBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printingDataSet = new PRINTER_CENTER.PrintingDataSet();
            this.processTableAdapter = new PRINTER_CENTER.PrintingDataSetTableAdapters.ProcessTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeNeededDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProcess
            // 
            this.dataGridViewProcess.AutoGenerateColumns = false;
            this.dataGridViewProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProcess.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.processIdDataGridViewTextBoxColumn,
            this.printerIdDataGridViewTextBoxColumn,
            this.bookIdDataGridViewTextBoxColumn,
            this.timeNeededDataGridViewTextBoxColumn});
            this.dataGridViewProcess.DataSource = this.processBindingSource;
            this.dataGridViewProcess.Location = new System.Drawing.Point(70, 66);
            this.dataGridViewProcess.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewProcess.MultiSelect = false;
            this.dataGridViewProcess.Name = "dataGridViewProcess";
            this.dataGridViewProcess.ReadOnly = true;
            this.dataGridViewProcess.RowHeadersWidth = 51;
            this.dataGridViewProcess.RowTemplate.Height = 24;
            this.dataGridViewProcess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProcess.Size = new System.Drawing.Size(877, 380);
            this.dataGridViewProcess.TabIndex = 0;
            // 
            // processBindingSource
            // 
            this.processBindingSource.DataMember = "Process";
            this.processBindingSource.DataSource = this.printingDataSet;
            // 
            // printingDataSet
            // 
            this.printingDataSet.DataSetName = "PrintingDataSet";
            this.printingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // processTableAdapter
            // 
            this.processTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dELETEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.dELETEToolStripMenuItem_Click);
            // 
            // processIdDataGridViewTextBoxColumn
            // 
            this.processIdDataGridViewTextBoxColumn.DataPropertyName = "ProcessId";
            this.processIdDataGridViewTextBoxColumn.HeaderText = "ProcessId";
            this.processIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.processIdDataGridViewTextBoxColumn.Name = "processIdDataGridViewTextBoxColumn";
            this.processIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // printerIdDataGridViewTextBoxColumn
            // 
            this.printerIdDataGridViewTextBoxColumn.DataPropertyName = "PrinterId";
            this.printerIdDataGridViewTextBoxColumn.HeaderText = "PrinterId";
            this.printerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.printerIdDataGridViewTextBoxColumn.Name = "printerIdDataGridViewTextBoxColumn";
            this.printerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId";
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "BookId";
            this.bookIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            this.bookIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeNeededDataGridViewTextBoxColumn
            // 
            this.timeNeededDataGridViewTextBoxColumn.DataPropertyName = "TimeNeeded";
            this.timeNeededDataGridViewTextBoxColumn.HeaderText = "TimeNeeded";
            this.timeNeededDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeNeededDataGridViewTextBoxColumn.Name = "timeNeededDataGridViewTextBoxColumn";
            this.timeNeededDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProcessLOOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1012, 486);
            this.Controls.Add(this.dataGridViewProcess);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProcessLOOK";
            this.Text = "ProcessLOOK";
            this.Load += new System.EventHandler(this.ProcessLOOK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProcess;
        private PrintingDataSet printingDataSet;
        private System.Windows.Forms.BindingSource processBindingSource;
        private PrintingDataSetTableAdapters.ProcessTableAdapter processTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn processIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn printerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeNeededDataGridViewTextBoxColumn;
    }
}