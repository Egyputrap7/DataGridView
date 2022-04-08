using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRODIDataSet.mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.pRODIDataSet.mahasiswa);
            this.dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Blue;
            this.dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Red;
            this.dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Green;
            this.dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Brown;
            this.dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.DarkCyan;
            this.dataGridView1.Columns[5].DefaultCellStyle.ForeColor = Color.DarkMagenta;
            this.dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.Navy;
            this.dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            this.dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.Blue;
            this.dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
            this.dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            this.dataGridView1.Columns[5].DefaultCellStyle.SelectionBackColor = Color.SkyBlue;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Italic);
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSeaGreen;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font ("Times New Roman", 10, FontStyle.Bold);

        }
    }
}
