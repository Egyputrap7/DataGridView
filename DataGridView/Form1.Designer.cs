
namespace DataGridView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namamahasiswaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeniskelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgllahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODIDataSet = new DataGridView.PRODIDataSet();
            this.mahasiswaTableAdapter = new DataGridView.PRODIDataSetTableAdapters.mahasiswaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODIDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nimDataGridViewTextBoxColumn,
            this.namamahasiswaDataGridViewTextBoxColumn,
            this.jeniskelDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.tgllahirDataGridViewTextBoxColumn,
            this.idprodiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mahasiswaBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1107, 482);
            this.dataGridView1.TabIndex = 0;
            // 
            // nimDataGridViewTextBoxColumn
            // 
            this.nimDataGridViewTextBoxColumn.DataPropertyName = "nim";
            this.nimDataGridViewTextBoxColumn.HeaderText = "nim";
            this.nimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nimDataGridViewTextBoxColumn.Name = "nimDataGridViewTextBoxColumn";
            this.nimDataGridViewTextBoxColumn.Width = 125;
            // 
            // namamahasiswaDataGridViewTextBoxColumn
            // 
            this.namamahasiswaDataGridViewTextBoxColumn.DataPropertyName = "nama_mahasiswa";
            this.namamahasiswaDataGridViewTextBoxColumn.HeaderText = "nama_mahasiswa";
            this.namamahasiswaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namamahasiswaDataGridViewTextBoxColumn.Name = "namamahasiswaDataGridViewTextBoxColumn";
            this.namamahasiswaDataGridViewTextBoxColumn.Width = 125;
            // 
            // jeniskelDataGridViewTextBoxColumn
            // 
            this.jeniskelDataGridViewTextBoxColumn.DataPropertyName = "jenis_kel";
            this.jeniskelDataGridViewTextBoxColumn.HeaderText = "jenis_kel";
            this.jeniskelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jeniskelDataGridViewTextBoxColumn.Name = "jeniskelDataGridViewTextBoxColumn";
            this.jeniskelDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 125;
            // 
            // tgllahirDataGridViewTextBoxColumn
            // 
            this.tgllahirDataGridViewTextBoxColumn.DataPropertyName = "tgl_lahir";
            this.tgllahirDataGridViewTextBoxColumn.HeaderText = "tgl_lahir";
            this.tgllahirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tgllahirDataGridViewTextBoxColumn.Name = "tgllahirDataGridViewTextBoxColumn";
            this.tgllahirDataGridViewTextBoxColumn.Width = 125;
            // 
            // idprodiDataGridViewTextBoxColumn
            // 
            this.idprodiDataGridViewTextBoxColumn.DataPropertyName = "id_prodi";
            this.idprodiDataGridViewTextBoxColumn.HeaderText = "id_prodi";
            this.idprodiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idprodiDataGridViewTextBoxColumn.Name = "idprodiDataGridViewTextBoxColumn";
            this.idprodiDataGridViewTextBoxColumn.Width = 125;
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.pRODIDataSet;
            // 
            // pRODIDataSet
            // 
            this.pRODIDataSet.DataSetName = "PRODIDataSet";
            this.pRODIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 497);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODIDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PRODIDataSet pRODIDataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private PRODIDataSetTableAdapters.mahasiswaTableAdapter mahasiswaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namamahasiswaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jeniskelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgllahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodiDataGridViewTextBoxColumn;
    }
}

