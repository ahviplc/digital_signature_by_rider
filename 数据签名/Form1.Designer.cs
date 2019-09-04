namespace 数据签名
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_factoryKey = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tb_param = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2ByLC = new System.Windows.Forms.Label();
            this.button2ByLC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_factoryKey
            // 
            this.tb_factoryKey.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.tb_factoryKey.Location = new System.Drawing.Point(14, 73);
            this.tb_factoryKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_factoryKey.Multiline = true;
            this.tb_factoryKey.Name = "tb_factoryKey";
            this.tb_factoryKey.Size = new System.Drawing.Size(414, 27);
            this.tb_factoryKey.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.linkLabel1.Location = new System.Drawing.Point(14, 44);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 20);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "factoryKey";
            this.linkLabel1.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tb_param
            // 
            this.tb_param.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.tb_param.Location = new System.Drawing.Point(15, 157);
            this.tb_param.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_param.Multiline = true;
            this.tb_param.Name = "tb_param";
            this.tb_param.Size = new System.Drawing.Size(412, 144);
            this.tb_param.TabIndex = 3;
            // 
            // label1
            // 
     
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 372);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(413, 88);
            this.textBox2.TabIndex = 6;
            // 
            // label2ByLC
            // 
    
            // 
            // button2ByLC
            // 
            this.button2ByLC.Location = new System.Drawing.Point(226, 325);
            this.button2ByLC.Name = "button2ByLC";
            this.button2ByLC.Size = new System.Drawing.Size(133, 23);
            this.button2ByLC.TabIndex = 8;
            this.button2ByLC.Text = "LCRiderVerButton";
            this.button2ByLC.UseVisualStyleBackColor = true;
            this.button2ByLC.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 489);
            this.Controls.Add(this.button2ByLC);
            this.Controls.Add(this.label2ByLC);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_param);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tb_factoryKey);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tb_factoryKey;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox tb_param;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2ByLC;
        private System.Windows.Forms.Button button2ByLC;
    }
}

