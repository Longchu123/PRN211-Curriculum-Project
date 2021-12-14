using Curriculum_Project.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Curriculum_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String sql = @"select distinct SubjectCode, SubjectName, Termno from SUBJECTS order by Termno ";
            dataGridView1.DataSource = DAO.GetDataBySQL(sql, new System.Data.SqlClient.SqlParameter[] { });
            String sql2 = @"select S2.SubjectCode, S1.SubjectCode from SUBJECTS S1 join SUBJECTS S2 on S1.SubjectId = S2.Subjec_prequisite";
            dataGridView2.DataSource = DAO.GetDataBySQL(sql2, new System.Data.SqlClient.SqlParameter[] { });
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
