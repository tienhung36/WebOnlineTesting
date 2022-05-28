using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoCF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            QLSV db = new QLSV();
            dataGridView1.DataSource=db.SVs.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                QLSV qLSV = new QLSV();
                foreach ( DataGridViewRow i in dataGridView1.SelectedRows )
                {
                    string MSSV = i.Cells["MSSV"].Value.ToString();
                    var s = qLSV.SVs.Find(MSSV);
                    qLSV.SVs.Remove(s);
                    qLSV.SaveChanges();
                }
                dataGridView1.DataSource= qLSV.SVs.ToList();
            }
        }
    }
}
