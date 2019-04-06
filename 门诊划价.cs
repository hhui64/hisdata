using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace login
{
    public partial class 门诊划价 : Form
    {
        dbOPT dataOpt = new dbOPT();

        public void initAll ()
        {
            tGuahaoId.Text = null;
            tName.Text = null;
            tSex.Text = null;
            tGuahaoOffice.Text = null;
            tDoctorName.Text = null;
            lTotal.Text = "0.00";
            dPriceTable.Rows.Clear();
            dSelectGuahaoTable.Visible = false;
            dSelectDrugTable.Visible = false;
        }

        public 门诊划价()
        {
            InitializeComponent();
        }

        private void 门诊划价_Load(object sender, EventArgs e)
        {
            dSelectGuahaoTable.Visible = false;
        }

        private void bSelectGuahaoId_Click(object sender, EventArgs e)
        {
            //dSelectGuahaoTable.Top = 426;
            dSelectGuahaoTable.Visible = true;
            dataOpt.BindDataGridView(dSelectGuahaoTable, "SELECT * FROM [EMR].[dbo].[门诊挂号] WHERE [是否已划价] = '否';");
        }

        private void dSelectGuahaoTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                String guahaoId = dSelectGuahaoTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                tGuahaoId.Text = guahaoId;
                dSelectGuahaoTable.Visible = false;

                String strSql = "SELECT * FROM [门诊挂号] WHERE [编号] = '" + tGuahaoId.Text + "';";

                if (dataOpt.GetTable(strSql).Tables[0].Rows.Count <= 0)
                {
                    MessageBox.Show("查无此人！");
                    return;
                }

                tName.Text = dataOpt.GetTable(strSql).Tables[0].Rows[0].ItemArray[2].ToString();
                tSex.Text = dataOpt.GetTable(strSql).Tables[0].Rows[0].ItemArray[3].ToString();
                tGuahaoOffice.Text = dataOpt.GetTable(strSql).Tables[0].Rows[0].ItemArray[4].ToString();
                tDoctorName.Text = dataOpt.GetTable(strSql).Tables[0].Rows[0].ItemArray[8].ToString();

            }
        }

        private void dPriceTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
            {
                return;
            }
            
            if(e.ColumnIndex == 0)
            {
                String keyText = Interaction.InputBox("请输入药品拼音码", "添加药品", "", -1, -1);
                if (keyText != "")
                {
                    Console.WriteLine(keyText);
                    String strSql = "SELECT 编号 as 药品编号, 名称 as 药品名称, 规格 as 规格, 整量单位 as 单位, 出库单价 as 单价, 拼音码 as 拼音码 FROM [EMR].[dbo].[药品资料] WHERE [拼音码] LIKE '%" + keyText + "%';";
                    if (dataOpt.GetTable(strSql).Tables[0].Rows.Count > 0)
                    {
                        dataOpt.BindDataGridView(dSelectDrugTable, strSql);
                        dSelectDrugTable.Visible = true;
                    } else
                    {
                        MessageBox.Show("没有找到拼音码为'" + keyText + "'相似的药品,请检查！");
                    }

                }
            }

            if (e.ColumnIndex == 5)
            {
                /*
                if (dPriceTable.Rows[e.RowIndex].Cells[5].Value.ToString() == null)
                {
                    //e.cancel = true;
                }
                */
            }

        }

        private void dPriceTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 5)
            {
                if (dPriceTable.Rows[e.RowIndex].Cells[5].Value.ToString() == "") dPriceTable.Rows[e.RowIndex].Cells[5].Value = "0";
                Double Num = System.Convert.ToDouble(dPriceTable.Rows[e.RowIndex].Cells[5].Value.ToString());
                Double Price = System.Convert.ToDouble(dPriceTable.Rows[e.RowIndex].Cells[4].Value.ToString());
                Double TotalPrice = Num * Price;
                dPriceTable.Rows[e.RowIndex].Cells[6].Value = TotalPrice.ToString("f2");

                Double ListTotalPrice = 0;

                for (int i = 0; i < dPriceTable.Rows.Count - 1; i++)
                {
                    ListTotalPrice += System.Convert.ToDouble(dPriceTable.Rows[i].Cells[6].Value.ToString());
                }

                lTotal.Text = ListTotalPrice.ToString("f2");
            }
        }

        private void dSelectDrugTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            dSelectDrugTable.Visible = false;
            int index = dPriceTable.Rows.Add();
            dPriceTable.Rows[index].Cells[0].Value = dSelectDrugTable.Rows[e.RowIndex].Cells[0].Value.ToString(); // 药品编号
            dPriceTable.Rows[index].Cells[1].Value = dSelectDrugTable.Rows[e.RowIndex].Cells[1].Value.ToString(); // 药品名称
            dPriceTable.Rows[index].Cells[2].Value = dSelectDrugTable.Rows[e.RowIndex].Cells[2].Value.ToString(); // 规格
            dPriceTable.Rows[index].Cells[3].Value = dSelectDrugTable.Rows[e.RowIndex].Cells[3].Value.ToString(); // 单位
            dPriceTable.Rows[index].Cells[4].Value = dSelectDrugTable.Rows[e.RowIndex].Cells[4].Value.ToString(); // 单价
            dPriceTable.Rows[index].Cells[5].Value = "1"; // 数量
            dPriceTable.Rows[index].Cells[6].Value = dSelectDrugTable.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void bCleanAll_Click(object sender, EventArgs e)
        {
            initAll();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (tName.Text == "" || tGuahaoId.Text == "")
            {
                MessageBox.Show("请选择一位已挂号的病人!");
                return;
            }

            if (dPriceTable.Rows.Count <= 1) {
                MessageBox.Show("请添加划价药品!");
                return;
            }

            for (int i = 0; i < dPriceTable.Rows.Count - 1; i++)
            {
                if (dPriceTable.Rows[i].Cells[5].Value.ToString() == "" || dPriceTable.Rows[i].Cells[6].Value.ToString() == "")
                {
                    MessageBox.Show("请填写药品数量!!! 位于第" + i + "行");
                    return;
                }
            }

            String lastId = dataOpt.GetTable("SELECT TOP (1) * FROM [EMR].[dbo].[门诊划价明细] ORDER BY [编号] DESC;").Tables[0].Rows[0].ItemArray[0].ToString();
            int latestId = int.Parse(lastId);

            String lastHuajiaId = dataOpt.GetTable("SELECT TOP (1) * FROM [EMR].[dbo].[门诊划价明细] ORDER BY [划价编号] DESC;").Tables[0].Rows[0].ItemArray[1].ToString().Substring(4, 7);
            String latestHuajiaId = Convert.ToString(int.Parse(lastHuajiaId) + 1);
            latestHuajiaId = DateTime.Now.ToString("yyyy") + latestHuajiaId.PadLeft(7, '0');

            String strSql1 = string.Format("INSERT INTO [dbo].[门诊划价] ([编号],[科室],[挂号编号],[医生],[划价时间],[划价员],[是否收费],[收费员],[收费时间],[划价金额],[是否发药],[发药时间],[发药员]) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')", latestHuajiaId, tGuahaoOffice.Text, tGuahaoId.Text, tDoctorName.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), null, "否", null, null, lTotal.Text, "否", null, null);
            String strSql2 = "set IDENTITY_INSERT [dbo].[门诊划价明细] on; INSERT INTO [dbo].[门诊划价明细] ([编号],[划价编号],[药品编号],[单价],[数量],[金额]) VALUES";
            String strSql3 = "UPDATE [dbo].[门诊挂号] SET [是否已划价] = '是' WHERE [编号] = '" + tGuahaoId.Text + "';";

            for (int i = 0; i < dPriceTable.Rows.Count - 1; i++)
            {
                String DrugId = dPriceTable.Rows[i].Cells[0].Value.ToString();
                String Num = dPriceTable.Rows[i].Cells[5].Value.ToString();
                String SinglePrice = dPriceTable.Rows[i].Cells[4].Value.ToString();
                String TotalPrice = dPriceTable.Rows[i].Cells[6].Value.ToString();
                String dh = i == dPriceTable.Rows.Count - 2 ? ";" : ",";
                latestId++;
                strSql2 += string.Format("('{0}','{1}','{2}',{3},{4},{5})" + dh, latestId.ToString(), latestHuajiaId, DrugId, SinglePrice, Num, TotalPrice);
            }

            if (dataOpt.OperateData(strSql1) + dataOpt.OperateData(strSql2) > 0)
            {
                dataOpt.OperateData(strSql3); // 改变划价状态
                initAll();
            } else {
                MessageBox.Show("语句执行失败!!!!!!!!!!!!!!!!炸了");
            }

        }
    }
}
