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
