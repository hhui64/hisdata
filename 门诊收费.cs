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
    public partial class 门诊收费 : Form
    {
        dbOPT dataOpt = new dbOPT();
        public 门诊收费()
        {
            InitializeComponent();
        }

        public void initAll ()
        {
            dataOpt.BindDataGridView(dSelectHuajiaTable, "SELECT b.姓名, b.性别, a.编号, a.科室, a.挂号编号, a.医生, a.划价时间, a.划价员, a.是否收费, a.收费员, a.收费时间, a.划价金额, a.是否发药, a.发药时间, a.发药员 FROM 门诊划价 a INNER JOIN 门诊挂号 b ON a.挂号编号 = b.编号 WHERE (a.是否收费 = '否');");
            SetPrice.Text = "0";
            GetPrice.Text = "0";
            dDrugListTable.DataSource = null;
            //String HuajiaId = dSelectHuajiaTable.Rows[dSelectHuajiaTable.CurrentRow.Index].Cells[2].Value.ToString();
            //String strSql = "SELECT DISTINCT a.编号, a.药品编号, b.名称, a.单价, a.数量, a.金额, a.划价编号 FROM 门诊划价明细 a INNER JOIN v收费项目及药品 b ON a.药品编号 = b.编号 AND a.划价编号='" + HuajiaId + "';";
            //dataOpt.BindDataGridView(dDrugListTable, strSql);
        }

        private void 门诊收费_Load(object sender, EventArgs e)
        {
            initAll();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            String a = tId.Text != "" ? " AND a.编号 like '%" + tId.Text + "%'" : null;
            String b = tName.Text != "" ? " AND b.姓名 like '%" + tName.Text + "%'" : null;
            String c = dStartTime.Text != "" ? " AND a.划价时间>='" + dStartTime.Text + "'" : null;
            String d = dEndTime.Text != "" ? " AND a.划价时间<='" + dEndTime.Text + "'" : null;
            String strSql = "SELECT b.姓名, b.性别, a.编号, a.科室, a.挂号编号, a.医生, a.划价时间, a.划价员, a.是否收费, a.收费员, a.收费时间, a.划价金额, a.是否发药, a.发药时间, a.发药员 FROM 门诊划价 a INNER JOIN 门诊挂号 b ON a.挂号编号 = b.编号 WHERE (a.是否收费 = '否')" + a + b + c + d + ";";
            dataOpt.BindDataGridView(dSelectHuajiaTable, strSql);
        }

        private void dSelectHuajiaTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            String HuajiaId = dSelectHuajiaTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            String strSql = "SELECT DISTINCT a.编号, a.药品编号, b.名称, a.单价, a.数量, a.金额, a.划价编号 FROM 门诊划价明细 a INNER JOIN v收费项目及药品 b ON a.药品编号 = b.编号 AND a.划价编号='" + HuajiaId + "';";
            dataOpt.BindDataGridView(dDrugListTable, strSql);

            Double ListTotalPrice = 0;

            for (int i = 0; i < dDrugListTable.Rows.Count - 1; i++)
            {
                ListTotalPrice += System.Convert.ToDouble(dDrugListTable.Rows[i].Cells[5].Value.ToString());
            }

            TotalPrice.Text = ListTotalPrice.ToString("f2");
            SetPrice.Text = "0";
            GetPrice.Text = "0";
        }

        private void SetPrice_TextChanged(object sender, EventArgs e)
        {
            if (SetPrice.Text == "") SetPrice.Text = "0";
            Double a0 = System.Convert.ToDouble(TotalPrice.Text);
            Double a1 = System.Convert.ToDouble(SetPrice.Text);
            Double b = a1 - a0;
            GetPrice.Text = b.ToString("f2");
        }

        private void bSetPrice_Click(object sender, EventArgs e)
        {
            Double b = System.Convert.ToDouble(GetPrice.Text);
            if (b < 0)
            {
                MessageBox.Show("大哥钱不够请补上吧!!!");
                return;
            } else {
                if (dSelectHuajiaTable.Rows.Count == 1) return;
                String HuajiaId = dSelectHuajiaTable.Rows[dSelectHuajiaTable.CurrentRow.Index].Cells[2].Value.ToString();
                if (HuajiaId == "") return;
                String strSql = string.Format("UPDATE [dbo].[门诊划价] SET [是否收费] = '是',[收费员] = '{0}',[收费时间] = '{1}' WHERE [编号] = '{2}';", null, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), HuajiaId);
                if (dataOpt.OperateData(strSql) == -1)
                {
                    MessageBox.Show("执行SQL语句出错????Whaaaaaaaaaat???!!!又炸了???");
                } else
                {
                    initAll();
                }
            }
        }
    }
}
