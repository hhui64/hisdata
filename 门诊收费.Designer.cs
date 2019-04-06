namespace login
{
    partial class 门诊收费
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
            this.bSetPrice = new System.Windows.Forms.Button();
            this.GetPrice = new System.Windows.Forms.TextBox();
            this.SetPrice = new System.Windows.Forms.TextBox();
            this.TotalPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bSearch = new System.Windows.Forms.Button();
            this.dEndTime = new System.Windows.Forms.DateTimePicker();
            this.dStartTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dSelectHuajiaTable = new System.Windows.Forms.DataGridView();
            this.dDrugListTable = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSelectHuajiaTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDrugListTable)).BeginInit();
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
            this.label13.TabIndex = 16;
            this.label13.Text = "门 诊 收 费";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bSetPrice);
            this.groupBox1.Controls.Add(this.GetPrice);
            this.groupBox1.Controls.Add(this.SetPrice);
            this.groupBox1.Controls.Add(this.TotalPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bSearch);
            this.groupBox1.Controls.Add(this.dEndTime);
            this.groupBox1.Controls.Add(this.dStartTime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1228, 236);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "挂号信息";
            // 
            // bSetPrice
            // 
            this.bSetPrice.Location = new System.Drawing.Point(1115, 110);
            this.bSetPrice.Name = "bSetPrice";
            this.bSetPrice.Size = new System.Drawing.Size(75, 99);
            this.bSetPrice.TabIndex = 8;
            this.bSetPrice.Text = "收款";
            this.bSetPrice.UseVisualStyleBackColor = true;
            this.bSetPrice.Click += new System.EventHandler(this.bSetPrice_Click);
            // 
            // GetPrice
            // 
            this.GetPrice.BackColor = System.Drawing.SystemColors.Control;
            this.GetPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GetPrice.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GetPrice.ForeColor = System.Drawing.Color.Blue;
            this.GetPrice.Location = new System.Drawing.Point(907, 167);
            this.GetPrice.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.GetPrice.MaxLength = 3;
            this.GetPrice.Name = "GetPrice";
            this.GetPrice.ReadOnly = true;
            this.GetPrice.Size = new System.Drawing.Size(186, 31);
            this.GetPrice.TabIndex = 7;
            this.GetPrice.Text = "0.00";
            this.GetPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SetPrice
            // 
            this.SetPrice.BackColor = System.Drawing.SystemColors.Info;
            this.SetPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SetPrice.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SetPrice.ForeColor = System.Drawing.Color.Red;
            this.SetPrice.Location = new System.Drawing.Point(907, 110);
            this.SetPrice.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SetPrice.MaxLength = 0;
            this.SetPrice.Name = "SetPrice";
            this.SetPrice.Size = new System.Drawing.Size(186, 31);
            this.SetPrice.TabIndex = 6;
            this.SetPrice.Text = "0";
            this.SetPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SetPrice.TextChanged += new System.EventHandler(this.SetPrice_TextChanged);
            // 
            // TotalPrice
            // 
            this.TotalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.TotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalPrice.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TotalPrice.Location = new System.Drawing.Point(907, 47);
            this.TotalPrice.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TotalPrice.MaxLength = 3;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Size = new System.Drawing.Size(283, 31);
            this.TotalPrice.TabIndex = 5;
            this.TotalPrice.Text = "0.00";
            this.TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(747, 174);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 21);
            this.label7.TabIndex = 33;
            this.label7.Text = "找　　零(元):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(747, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "收　　款(元):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(747, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "合计金额(元):";
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(639, 46);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 163);
            this.bSearch.TabIndex = 4;
            this.bSearch.Text = "搜索";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // dEndTime
            // 
            this.dEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dEndTime.Location = new System.Drawing.Point(157, 167);
            this.dEndTime.Name = "dEndTime";
            this.dEndTime.Size = new System.Drawing.Size(448, 31);
            this.dEndTime.TabIndex = 3;
            // 
            // dStartTime
            // 
            this.dStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dStartTime.Location = new System.Drawing.Point(159, 110);
            this.dStartTime.Name = "dStartTime";
            this.dStartTime.Size = new System.Drawing.Size(448, 31);
            this.dStartTime.TabIndex = 2;
            this.dStartTime.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "结束时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "开始时间";
            // 
            // tId
            // 
            this.tId.BackColor = System.Drawing.SystemColors.Info;
            this.tId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tId.Location = new System.Drawing.Point(453, 46);
            this.tId.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tId.MaxLength = 3;
            this.tId.Name = "tId";
            this.tId.Size = new System.Drawing.Size(154, 31);
            this.tId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "编　　号";
            // 
            // tName
            // 
            this.tName.BackColor = System.Drawing.SystemColors.Info;
            this.tName.Location = new System.Drawing.Point(159, 46);
            this.tName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(154, 31);
            this.tName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "姓　　名";
            // 
            // dSelectHuajiaTable
            // 
            this.dSelectHuajiaTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dSelectHuajiaTable.Location = new System.Drawing.Point(20, 337);
            this.dSelectHuajiaTable.Margin = new System.Windows.Forms.Padding(4);
            this.dSelectHuajiaTable.Name = "dSelectHuajiaTable";
            this.dSelectHuajiaTable.ReadOnly = true;
            this.dSelectHuajiaTable.RowTemplate.Height = 27;
            this.dSelectHuajiaTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dSelectHuajiaTable.Size = new System.Drawing.Size(1228, 316);
            this.dSelectHuajiaTable.TabIndex = 31;
            this.dSelectHuajiaTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dSelectHuajiaTable_CellClick);
            // 
            // dDrugListTable
            // 
            this.dDrugListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dDrugListTable.Location = new System.Drawing.Point(20, 662);
            this.dDrugListTable.Margin = new System.Windows.Forms.Padding(4);
            this.dDrugListTable.Name = "dDrugListTable";
            this.dDrugListTable.ReadOnly = true;
            this.dDrugListTable.RowTemplate.Height = 27;
            this.dDrugListTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dDrugListTable.Size = new System.Drawing.Size(1228, 234);
            this.dDrugListTable.TabIndex = 32;
            // 
            // 门诊收费
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 956);
            this.Controls.Add(this.dDrugListTable);
            this.Controls.Add(this.dSelectHuajiaTable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "门诊收费";
            this.Text = "0";
            this.Load += new System.EventHandler(this.门诊收费_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSelectHuajiaTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDrugListTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dEndTime;
        private System.Windows.Forms.DateTimePicker dStartTime;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox GetPrice;
        private System.Windows.Forms.TextBox SetPrice;
        private System.Windows.Forms.TextBox TotalPrice;
        private System.Windows.Forms.DataGridView dSelectHuajiaTable;
        private System.Windows.Forms.DataGridView dDrugListTable;
        private System.Windows.Forms.Button bSetPrice;
    }
}