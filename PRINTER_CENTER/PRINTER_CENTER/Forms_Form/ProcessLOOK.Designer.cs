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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printingDataSet = new PRINTER_CENTER.PrintingDataSet();
            this.processBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processTableAdapter = new PRINTER_CENTER.PrintingDataSetTableAdapters.ProcessTableAdapter();
            this.processIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeNeededDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.processIdDataGridViewTextBoxColumn,
            this.printerIdDataGridViewTextBoxColumn,
            this.bookIdDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.timeNeededDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.processBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 33);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(877, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // printingDataSet
            // 
            this.printingDataSet.DataSetName = "PrintingDataSet";
            this.printingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // processBindingSource
            // 
            this.processBindingSource.DataMember = "Process";
            this.processBindingSource.DataSource = this.printingDataSet;
            // 
            // processTableAdapter
            // 
            this.processTableAdapter.ClearBeforeFill = true;
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
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId";
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "BookId";
            this.bookIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // timeNeededDataGridViewTextBoxColumn
            // 
            this.timeNeededDataGridViewTextBoxColumn.DataPropertyName = "TimeNeeded";
            this.timeNeededDataGridViewTextBoxColumn.HeaderText = "TimeNeeded";
            this.timeNeededDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeNeededDataGridViewTextBoxColumn.Name = "timeNeededDataGridViewTextBoxColumn";
            // 
            // ProcessLOOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1012, 486);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProcessLOOK";
            this.Text = "ProcessLOOK";
            this.Load += new System.EventHandler(this.ProcessLOOK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PrintingDataSet printingDataSet;
        private System.Windows.Forms.BindingSource processBindingSource;
        private PrintingDataSetTableAdapters.ProcessTableAdapter processTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn processIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn printerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeNeededDataGridViewTextBoxColumn;
    }
}