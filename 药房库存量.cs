using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace login
{
    public partial class 药房库存量 : Form
    {
        dbOPT dataOpt = new dbOPT(); // 创建数据库操作对象
        public 药房库存量()
        {
            InitializeComponent();
        }

        private void 药房库存量_Load(object sender, EventArgs e)
        {
            // 载入时显示所有库存表
            DataSet ds1;
            string strSql = "select * from 药品资料 where 1=1 ";
            ds1 = dataOpt.GetTable(strSql);
            this.dataGridView1.DataSource = ds1.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds1;
            string strSql = "select * from 药品资料 where 1=1 ";
            if (this.textBox3.Text.Trim() != "")
            {
                strSql += string.Format(" and 编号 like '%{0}%' or 名称 like '%{0}%' ", textBox3.Text.Trim());
            }
            ds1 = dataOpt.GetTable(strSql);
            this.dataGridView1.DataSource = ds1.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds1;
            string strSql = "select * from 药品库存 where 1=1 ";
            if (this.textBox1.Text.Trim() != "")
            {
                strSql += string.Format(" and 编号 like '%{0}%' or 库房  like '%{0}%' or 药品编号 like '%{0}%' or 药品数量 like '%{0}%' or 备注 like '%{0}%'", textBox1.Text.Trim());


            }

            ds1 = dataOpt.GetTable(strSql);
            this.dataGridView1.DataSource = ds1.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet ds1;
            string strSql = "select * from 药品资料 where 1=1 ";
            if (this.textBox2.Text.Trim() != "")
            {
                strSql += string.Format(" and 编号 like '%{0}%' or 名称 like '%{0}%' ", textBox2.Text.Trim());


            }

            ds1 = dataOpt.GetTable(strSql);
            this.dataGridView1.DataSource = ds1.Tables[0];
        }

       
    }
}
