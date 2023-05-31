namespace library
{
    partial class excel
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
            this.aktar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.libraryDataSet = new library.libraryDataSet();
            this.kitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitaplarTableAdapter = new library.libraryDataSetTableAdapters.kitaplarTableAdapter();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazaradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayıneviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitaptürDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aktar
            // 
            this.aktar.Location = new System.Drawing.Point(401, 12);
            this.aktar.Name = "aktar";
            this.aktar.Size = new System.Drawing.Size(75, 23);
            this.aktar.TabIndex = 0;
            this.aktar.Text = "Excel Aktar";
            this.aktar.UseVisualStyleBackColor = true;
            this.aktar.Click += new System.EventHandler(this.aktar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.kitapadDataGridViewTextBoxColumn,
            this.yazaradDataGridViewTextBoxColumn,
            this.yayıneviDataGridViewTextBoxColumn,
            this.kitapkodDataGridViewTextBoxColumn,
            this.kitaptürDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kitaplarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 304);
            this.dataGridView1.TabIndex = 15;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "libraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitaplarBindingSource
            // 
            this.kitaplarBindingSource.DataMember = "kitaplar";
            this.kitaplarBindingSource.DataSource = this.libraryDataSet;
            // 
            // kitaplarTableAdapter
            // 
            this.kitaplarTableAdapter.ClearBeforeFill = true;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            // 
            // kitapadDataGridViewTextBoxColumn
            // 
            this.kitapadDataGridViewTextBoxColumn.DataPropertyName = "kitap_ad";
            this.kitapadDataGridViewTextBoxColumn.HeaderText = "kitap_ad";
            this.kitapadDataGridViewTextBoxColumn.Name = "kitapadDataGridViewTextBoxColumn";
            // 
            // yazaradDataGridViewTextBoxColumn
            // 
            this.yazaradDataGridViewTextBoxColumn.DataPropertyName = "yazar_ad";
            this.yazaradDataGridViewTextBoxColumn.HeaderText = "yazar_ad";
            this.yazaradDataGridViewTextBoxColumn.Name = "yazaradDataGridViewTextBoxColumn";
            // 
            // yayıneviDataGridViewTextBoxColumn
            // 
            this.yayıneviDataGridViewTextBoxColumn.DataPropertyName = "Yayınevi";
            this.yayıneviDataGridViewTextBoxColumn.HeaderText = "Yayınevi";
            this.yayıneviDataGridViewTextBoxColumn.Name = "yayıneviDataGridViewTextBoxColumn";
            // 
            // kitapkodDataGridViewTextBoxColumn
            // 
            this.kitapkodDataGridViewTextBoxColumn.DataPropertyName = "kitap_kod";
            this.kitapkodDataGridViewTextBoxColumn.HeaderText = "kitap_kod";
            this.kitapkodDataGridViewTextBoxColumn.Name = "kitapkodDataGridViewTextBoxColumn";
            // 
            // kitaptürDataGridViewTextBoxColumn
            // 
            this.kitaptürDataGridViewTextBoxColumn.DataPropertyName = "kitap_tür";
            this.kitaptürDataGridViewTextBoxColumn.HeaderText = "kitap_tür";
            this.kitaptürDataGridViewTextBoxColumn.Name = "kitaptürDataGridViewTextBoxColumn";
            // 
            // excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 349);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.aktar);
            this.Name = "excel";
            this.Text = "excel";
            this.Load += new System.EventHandler(this.excel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button aktar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private libraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource kitaplarBindingSource;
        private libraryDataSetTableAdapters.kitaplarTableAdapter kitaplarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazaradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayıneviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapkodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitaptürDataGridViewTextBoxColumn;
    }
}