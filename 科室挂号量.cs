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
    public partial class 科室挂号量 : Form
    {
        dbOPT dataOpt = new dbOPT();
        public 科室挂号量()
        {
            InitializeComponent();
        }

        private void 科室挂号量_Load(object sender, EventArgs e)
        {
            DataSet ds1;
            string strSql = "SELECT 挂号科室 as 科室名称, count(病人编号) as 人数统计, sum(挂号费用) as 金额统计 FROM [EMR].[dbo].[门诊挂号] WHERE 时间 BETWEEN '1900-01-01' AND '9999-01-01' GROUP BY 挂号科室";
            ds1 = dataOpt.GetTable(strSql);
            this.dataGridView1.DataSource = ds1.Tables[0];
        }

        private void select_Click(object sender, EventArgs e)
        {
            /*
            SELECT
              挂号科室 as 科室名称,
              count(病人编号) as 人数统计,
              sum(挂号费用) as 金额统计
            FROM
              [EMR].[dbo].[门诊挂号]
            WHERE
              时间 BETWEEN '1999-01-01' AND '9999-01-01'
            GROUP BY
              挂号科室
            */
            DataSet ds1;
            string strSql = "SELECT 挂号科室 as 科室名称, count(病人编号) as 人数统计, sum(挂号费用) as 金额统计 FROM [EMR].[dbo].[门诊挂号] WHERE 时间 BETWEEN '{0}' AND '{1}' GROUP BY 挂号科室";
            strSql = string.Format(strSql, dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            ds1 = dataOpt.GetTable(strSql);
            this.dataGridView1.DataSource = ds1.Tables[0];
        }
    }
}
