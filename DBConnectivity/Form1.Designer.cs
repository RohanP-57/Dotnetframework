namespace DBConnectivity
{
    partial class Form1
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
            this.sTUDENTSDataSet = new DBConnectivity.STUDENTSDataSet();
            this.sTUDENTSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new DBConnectivity.STUDENTSDataSetTableAdapters.studentTableAdapter();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sTUDENTSDataSet1 = new DBConnectivity.STUDENTSDataSet1();
            this.empBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empTableAdapter = new DBConnectivity.STUDENTSDataSet1TableAdapters.empTableAdapter();
            this.eidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sTUDENTSDataSet
            // 
            this.sTUDENTSDataSet.DataSetName = "STUDENTSDataSet";
            this.sTUDENTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTUDENTSDataSetBindingSource
            // 
            this.sTUDENTSDataSetBindingSource.DataSource = this.sTUDENTSDataSet;
            this.sTUDENTSDataSetBindingSource.Position = 0;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.sTUDENTSDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "student";
            this.studentBindingSource1.DataSource = this.sTUDENTSDataSetBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.empBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(132, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // sTUDENTSDataSet1
            // 
            this.sTUDENTSDataSet1.DataSetName = "STUDENTSDataSet1";
            this.sTUDENTSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empBindingSource
            // 
            this.empBindingSource.DataMember = "emp";
            this.empBindingSource.DataSource = this.sTUDENTSDataSet1;
            // 
            // empTableAdapter
            // 
            this.empTableAdapter.ClearBeforeFill = true;
            // 
            // eidDataGridViewTextBoxColumn
            // 
            this.eidDataGridViewTextBoxColumn.DataPropertyName = "eid";
            this.eidDataGridViewTextBoxColumn.HeaderText = "eid";
            this.eidDataGridViewTextBoxColumn.Name = "eidDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource sTUDENTSDataSetBindingSource;
        private STUDENTSDataSet sTUDENTSDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private STUDENTSDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private STUDENTSDataSet1 sTUDENTSDataSet1;
        private System.Windows.Forms.BindingSource empBindingSource;
        private STUDENTSDataSet1TableAdapters.empTableAdapter empTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}

