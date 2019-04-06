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
    public partial class select : Form
    {
        public select()
        {
            InitializeComponent();
        }

        public bool isOpenThisForm(Form thisForm) // 判断form是否已打开, 如果打开则激活
        {
            foreach (Form forms in Application.OpenForms)
            {
                if (forms.Name.ToUpper() == thisForm.Name.ToUpper())
                {
                    forms.Activate();
                    return true;
                }
            }
            return false;
        }

        private void select_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void 退出xitongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void 门诊挂号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            门诊挂号 detail = new 门诊挂号();
            if (isOpenThisForm(detail)) return;
            detail.TopLevel = false;
            detail.MdiParent = this;
            detail.Show();
        }

        private void 门诊划价ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            门诊划价 detail = new 门诊划价();
            if (isOpenThisForm(detail)) return;
            detail.TopLevel = false;
            detail.MdiParent = this;
            detail.Show();
        }

        private void 门诊收费ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            门诊收费 detail = new 门诊收费();
            if (isOpenThisForm(detail)) return;
            detail.TopLevel = false;
            detail.MdiParent = this;
            detail.Show();
        }

        private void 药房发药ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            药房发药 detail = new 药房发药();
            if (isOpenThisForm(detail)) return;
            detail.TopLevel = false;
            detail.MdiParent = this;
            detail.Show();
        }

        private void 科室挂号量ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            科室挂号量 detail = new 科室挂号量();
            if (isOpenThisForm(detail)) return;
            detail.TopLevel = false;
            detail.MdiParent = this;
            detail.Show();
        }

        private void 药房库存量ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            药房库存量 detail = new 药房库存量();
            if (isOpenThisForm(detail)) return;
            detail.TopLevel = false;
            detail.MdiParent = this;
            detail.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

    }
}
