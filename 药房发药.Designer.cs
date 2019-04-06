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
            // 药房发药
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 956);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "药房发药";
            this.Text = "药房发药";
            this.Load += new System.EventHandler(this.药房发药_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
    }
}