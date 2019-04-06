namespace login
{
    partial class 药房发药
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
            this.dDrugListTable = new System.Windows.Forms.DataGridView();
            this.dSelectHuajiaTable = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bSendDrug = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.dEndTime = new System.Windows.Forms.DateTimePicker();
            this.dStartTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dDrugListTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSelectHuajiaTable)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.label13.TabIndex = 17;
            this.label13.Text = "药 房 发 药";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.dDrugListTable.TabIndex = 35;
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
            this.dSelectHuajiaTable.TabIndex = 34;
            this.dSelectHuajiaTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dSelectHuajiaTable_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bSendDrug);
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
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "挂号信息";
            // 
            // bSendDrug
            // 
            this.bSendDrug.Font = new System.Drawing.Font("微软雅黑", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bSendDrug.Location = new System.Drawing.Point(742, 46);
            this.bSendDrug.Name = "bSendDrug";
            this.bSendDrug.Size = new System.Drawing.Size(432, 163);
            this.bSendDrug.TabIndex = 8;
            this.bSendDrug.Text = "发药";
            this.bSendDrug.UseVisualStyleBackColor = true;
            this.bSendDrug.Click += new System.EventHandler(this.bSendDrug_Click);
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
            // 药房发药
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
            this.Name = "药房发药";
            this.Text = "药房发药";
            this.Load += new System.EventHandler(this.药房发药_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dDrugListTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSelectHuajiaTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dDrugListTable;
        private System.Windows.Forms.DataGridView dSelectHuajiaTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bSendDrug;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.DateTimePicker dEndTime;
        private System.Windows.Forms.DateTimePicker dStartTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label label1;
    }
}