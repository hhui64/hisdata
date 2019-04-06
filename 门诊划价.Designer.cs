namespace login
{
    partial class 门诊划价
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bCleanAll = new System.Windows.Forms.Button();
            this.tDoctorName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tGuahaoOffice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bSelectGuahaoId = new System.Windows.Forms.Button();
            this.tGuahaoId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tSex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dPriceTable = new System.Windows.Forms.DataGridView();
            this.DrugId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrugName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guige = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Danwei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Danjia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSelectGuahaoTable = new System.Windows.Forms.DataGridView();
            this.dSelectDrugTable = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dPriceTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSelectGuahaoTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSelectDrugTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(22, 17);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1225, 55);
            this.label13.TabIndex = 15;
            this.label13.Text = "门 诊 划 价";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bSave);
            this.groupBox1.Controls.Add(this.bCleanAll);
            this.groupBox1.Controls.Add(this.tDoctorName);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tGuahaoOffice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bSelectGuahaoId);
            this.groupBox1.Controls.Add(this.tGuahaoId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tSex);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1228, 294);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "挂号信息";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(800, 201);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(370, 59);
            this.bSave.TabIndex = 7;
            this.bSave.Text = "保存";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bCleanAll
            // 
            this.bCleanAll.Location = new System.Drawing.Point(649, 201);
            this.bCleanAll.Name = "bCleanAll";
            this.bCleanAll.Size = new System.Drawing.Size(134, 59);
            this.bCleanAll.TabIndex = 6;
            this.bCleanAll.Text = "清空";
            this.bCleanAll.UseVisualStyleBackColor = true;
            this.bCleanAll.Click += new System.EventHandler(this.bCleanAll_Click);
            // 
            // tDoctorName
            // 
            this.tDoctorName.BackColor = System.Drawing.SystemColors.Control;
            this.tDoctorName.Location = new System.Drawing.Point(453, 222);
            this.tDoctorName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tDoctorName.Name = "tDoctorName";
            this.tDoctorName.ReadOnly = true;
            this.tDoctorName.Size = new System.Drawing.Size(154, 31);
            this.tDoctorName.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lTotal);
            this.groupBox2.Location = new System.Drawing.Point(649, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 118);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "金额合计";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10.71429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(443, 54);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 52);
            this.label11.TabIndex = 24;
            this.label11.Text = "元";
            // 
            // lTotal
            // 
            this.lTotal.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lTotal.ForeColor = System.Drawing.Color.Red;
            this.lTotal.Location = new System.Drawing.Point(9, 22);
            this.lTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(466, 88);
            this.lTotal.TabIndex = 23;
            this.lTotal.Text = "0.00";
            this.lTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "所属医生";
            // 
            // tGuahaoOffice
            // 
            this.tGuahaoOffice.BackColor = System.Drawing.SystemColors.Control;
            this.tGuahaoOffice.Location = new System.Drawing.Point(159, 222);
            this.tGuahaoOffice.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tGuahaoOffice.Name = "tGuahaoOffice";
            this.tGuahaoOffice.ReadOnly = true;
            this.tGuahaoOffice.Size = new System.Drawing.Size(154, 31);
            this.tGuahaoOffice.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "所属科室";
            // 
            // bSelectGuahaoId
            // 
            this.bSelectGuahaoId.Location = new System.Drawing.Point(453, 60);
            this.bSelectGuahaoId.Name = "bSelectGuahaoId";
            this.bSelectGuahaoId.Size = new System.Drawing.Size(154, 40);
            this.bSelectGuahaoId.TabIndex = 0;
            this.bSelectGuahaoId.Text = "选择编号";
            this.bSelectGuahaoId.UseVisualStyleBackColor = true;
            this.bSelectGuahaoId.Click += new System.EventHandler(this.bSelectGuahaoId_Click);
            // 
            // tGuahaoId
            // 
            this.tGuahaoId.BackColor = System.Drawing.Color.Yellow;
            this.tGuahaoId.Location = new System.Drawing.Point(159, 62);
            this.tGuahaoId.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tGuahaoId.Name = "tGuahaoId";
            this.tGuahaoId.ReadOnly = true;
            this.tGuahaoId.Size = new System.Drawing.Size(282, 31);
            this.tGuahaoId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "门诊编号";
            // 
            // tSex
            // 
            this.tSex.BackColor = System.Drawing.SystemColors.Control;
            this.tSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tSex.Location = new System.Drawing.Point(453, 147);
            this.tSex.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tSex.MaxLength = 3;
            this.tSex.Name = "tSex";
            this.tSex.ReadOnly = true;
            this.tSex.Size = new System.Drawing.Size(154, 31);
            this.tSex.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "性　　别";
            // 
            // tName
            // 
            this.tName.BackColor = System.Drawing.SystemColors.Control;
            this.tName.Location = new System.Drawing.Point(159, 147);
            this.tName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tName.Name = "tName";
            this.tName.ReadOnly = true;
            this.tName.Size = new System.Drawing.Size(154, 31);
            this.tName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "姓　　名";
            // 
            // dPriceTable
            // 
            this.dPriceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dPriceTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DrugId,
            this.DrugName,
            this.Guige,
            this.Danwei,
            this.Danjia,
            this.Num,
            this.Price});
            this.dPriceTable.Location = new System.Drawing.Point(20, 426);
            this.dPriceTable.Margin = new System.Windows.Forms.Padding(4);
            this.dPriceTable.Name = "dPriceTable";
            this.dPriceTable.RowTemplate.Height = 27;
            this.dPriceTable.Size = new System.Drawing.Size(1228, 453);
            this.dPriceTable.TabIndex = 28;
            this.dPriceTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dPriceTable_CellMouseDoubleClick);
            this.dPriceTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dPriceTable_CellValueChanged);
            // 
            // DrugId
            // 
            this.DrugId.HeaderText = "药品编号      (双击添加)";
            this.DrugId.Name = "DrugId";
            this.DrugId.ReadOnly = true;
            // 
            // DrugName
            // 
            this.DrugName.HeaderText = "药品名称";
            this.DrugName.Name = "DrugName";
            this.DrugName.ReadOnly = true;
            // 
            // Guige
            // 
            this.Guige.HeaderText = "规格";
            this.Guige.Name = "Guige";
            this.Guige.ReadOnly = true;
            // 
            // Danwei
            // 
            this.Danwei.HeaderText = "单位";
            this.Danwei.Name = "Danwei";
            this.Danwei.ReadOnly = true;
            // 
            // Danjia
            // 
            this.Danjia.HeaderText = "单价(元)";
            this.Danjia.Name = "Danjia";
            this.Danjia.ReadOnly = true;
            // 
            // Num
            // 
            this.Num.HeaderText = "数量        (双击修改)";
            this.Num.Name = "Num";
            // 
            // Price
            // 
            this.Price.HeaderText = "总计(元)";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // dSelectGuahaoTable
            // 
            this.dSelectGuahaoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dSelectGuahaoTable.Location = new System.Drawing.Point(20, 426);
            this.dSelectGuahaoTable.Margin = new System.Windows.Forms.Padding(4);
            this.dSelectGuahaoTable.Name = "dSelectGuahaoTable";
            this.dSelectGuahaoTable.ReadOnly = true;
            this.dSelectGuahaoTable.RowTemplate.Height = 27;
            this.dSelectGuahaoTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dSelectGuahaoTable.Size = new System.Drawing.Size(1228, 453);
            this.dSelectGuahaoTable.TabIndex = 29;
            this.dSelectGuahaoTable.Visible = false;
            this.dSelectGuahaoTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dSelectGuahaoTable_CellMouseDoubleClick);
            // 
            // dSelectDrugTable
            // 
            this.dSelectDrugTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dSelectDrugTable.Location = new System.Drawing.Point(20, 426);
            this.dSelectDrugTable.Margin = new System.Windows.Forms.Padding(4);
            this.dSelectDrugTable.Name = "dSelectDrugTable";
            this.dSelectDrugTable.ReadOnly = true;
            this.dSelectDrugTable.RowTemplate.Height = 27;
            this.dSelectDrugTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dSelectDrugTable.Size = new System.Drawing.Size(1228, 453);
            this.dSelectDrugTable.TabIndex = 30;
            this.dSelectDrugTable.Visible = false;
            this.dSelectDrugTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dSelectDrugTable_CellMouseDoubleClick);
            // 
            // 门诊划价
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 956);
            this.Controls.Add(this.dSelectDrugTable);
            this.Controls.Add(this.dSelectGuahaoTable);
            this.Controls.Add(this.dPriceTable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "门诊划价";
            this.Text = "门诊划价";
            this.Load += new System.EventHandler(this.门诊划价_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dPriceTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSelectGuahaoTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSelectDrugTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tSex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.TextBox tGuahaoId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bSelectGuahaoId;
        private System.Windows.Forms.DataGridView dPriceTable;
        private System.Windows.Forms.TextBox tGuahaoOffice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tDoctorName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bCleanAll;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.DataGridView dSelectGuahaoTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guige;
        private System.Windows.Forms.DataGridViewTextBoxColumn Danwei;
        private System.Windows.Forms.DataGridViewTextBoxColumn Danjia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridView dSelectDrugTable;
    }
}