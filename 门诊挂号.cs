using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NPinyin;

namespace login
{
    public partial class 门诊挂号 : Form
    {
        dbOPT dataOpt = new dbOPT();

        public 门诊挂号()
        {
            InitializeComponent();
        }

        private void initAll()
        {
            this.tName.Text = "";
            this.tAge.Text = "";
            this.cSex.SelectedIndex = 0;
            this.cNation.SelectedIndex = 0;

            this.cMoneyType.SelectedIndex = 0;
            this.cGuahaoType.SelectedIndex = 0;

            this.cGuahaoOffice.SelectedIndex = -1;
            this.cDoctorName.SelectedIndex = -1;
        }

        private void Guahao()
        {
            if (this.tName.Text == "")
            {
                MessageBox.Show("请填写姓名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else if (this.cMoneyType.Text == "")
            {
                MessageBox.Show("请选择费用类型！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else if (this.cGuahaoType.Text == "")
            {
                MessageBox.Show("请选择挂号类型！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else if (this.cGuahaoOffice.Text == "")
            {
                MessageBox.Show("请选择挂号科室！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else if (this.cDoctorName.Text == "")
            {
                MessageBox.Show("请选择医生！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else {
                //MessageBox.Show("ok");
            }

            // 挂号编号自增
            String lastGuahaoId = dataOpt.GetTable("SELECT TOP (1) * FROM [EMR].[dbo].[门诊挂号] ORDER BY [编号] DESC;").Tables[0].Rows[0].ItemArray[0].ToString().Substring(4, 7);
            String latestGuahaoId = Convert.ToString(int.Parse(lastGuahaoId) + 1);
            latestGuahaoId = DateTime.Now.ToString("yyyy") + latestGuahaoId.PadLeft(7, '0');

            // 病人编号自增
            String lastPatientId = dataOpt.GetTable("SELECT TOP (1) * FROM [EMR].[dbo].[病人信息库] ORDER BY [编号] DESC;").Tables[0].Rows[0].ItemArray[0].ToString().Substring(4, 7);
            String latestPatientId = Convert.ToString(int.Parse(lastPatientId) + 1);
            latestPatientId = DateTime.Now.ToString("yyyy") + latestPatientId.PadLeft(7, '0');

            // 生成SQL语句
            String insertPatientStrSql = string.Format("INSERT INTO [dbo].[病人信息库]([编号],[姓名],[性别],[年龄],[民族],[费用类型],[电话],[拼音码]) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", latestPatientId, tName.Text, cSex.Text, int.Parse(tAge.Text), cNation.Text, cMoneyType.Text, null, NPinyin.Pinyin.GetInitials(tName.Text).ToUpper());
            String insertGuahaoStrSql = string.Format("INSERT INTO [dbo].[门诊挂号]([编号],[病人编号],[姓名],[性别],[挂号科室],[费用类型],[挂号类型],[挂号费用],[医生],[时间],[是否已划价]) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", latestGuahaoId, latestPatientId, tName.Text, cSex.Text, cGuahaoOffice.Text, cMoneyType.Text, cGuahaoType.Text, lTotal.Text, cDoctorName.Text, dGuahaoTime.Text, "否");

            // 执行SQL语句
            if (dataOpt.OperateData(insertPatientStrSql) + dataOpt.OperateData(insertGuahaoStrSql) >= 0)
            {
                MessageBox.Show("挂号成功！！！！！！！！");
                initAll();
            } else {
                MessageBox.Show("挂号失败！语句执行错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void 门诊挂号_Load(object sender, EventArgs e)
        {
            // 初始化绑定dropitem内容
            dataOpt.BindDropdownlist("门诊挂号类型","" , this.cGuahaoType, 1);
            dataOpt.BindDropdownlist("科室资料", "", this.cGuahaoOffice, 1);

            // 初始化显示item索引
            this.cSex.SelectedIndex = 0;
            this.cNation.SelectedIndex = 0;
            this.cMoneyType.SelectedIndex = 0;
            this.cGuahaoType.SelectedIndex = 0;
            // this.cGuahaoOffice.SelectedIndex = 0;
        }

        private void cGuahaoOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            String officeName = this.cGuahaoOffice.Text;
            dataOpt.BindDropdownlist("医生资料", "WHERE [科室] = '" + officeName + "';", this.cDoctorName, 1);
            if (this.cDoctorName.Items.Count > 0)
            {
                this.cDoctorName.SelectedIndex = 0;
            } else
            {
                this.cDoctorName.SelectedIndex = -1;
            }
        }

        private void cGuahaoType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = dataOpt.GetTable("SELECT * FROM [门诊挂号类型] WHERE [挂号类型] = '" + this.cGuahaoType.Text + "';");
            String guahaoMoney = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            this.lTotal.Text = guahaoMoney;
        }

        private void buttonCleanAll_Click(object sender, EventArgs e)
        {
            initAll();
        }

        private void buttonGuahao_Click(object sender, EventArgs e)
        {
            Guahao();
        }
    }
}
