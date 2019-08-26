namespace uuid2cpp
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.buttontrans = new System.Windows.Forms.Button();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(12, 12);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(409, 21);
            this.textBoxSource.TabIndex = 0;
            // 
            // buttontrans
            // 
            this.buttontrans.Location = new System.Drawing.Point(427, 10);
            this.buttontrans.Name = "buttontrans";
            this.buttontrans.Size = new System.Drawing.Size(75, 23);
            this.buttontrans.TabIndex = 1;
            this.buttontrans.Text = "转换";
            this.buttontrans.UseVisualStyleBackColor = true;
            this.buttontrans.Click += new System.EventHandler(this.Buttontrans_Click);
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.Location = new System.Drawing.Point(12, 39);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.Size = new System.Drawing.Size(490, 21);
            this.textBoxTarget.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 99);
            this.Controls.Add(this.textBoxTarget);
            this.Controls.Add(this.buttontrans);
            this.Controls.Add(this.textBoxSource);
            this.Name = "Form1";
            this.Text = "UUID2CPP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.Button buttontrans;
        private System.Windows.Forms.TextBox textBoxTarget;
    }
}

