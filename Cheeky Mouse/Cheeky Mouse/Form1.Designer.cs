namespace Cheeky_Mouse
{
    partial class frmmain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.labstart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pBoxmouse = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxmouse)).BeginInit();
            this.SuspendLayout();
            // 
            // labstart
            // 
            this.labstart.AutoSize = true;
            this.labstart.BackColor = System.Drawing.Color.Transparent;
            this.labstart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labstart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labstart.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labstart.Location = new System.Drawing.Point(83, 338);
            this.labstart.Name = "labstart";
            this.labstart.Size = new System.Drawing.Size(108, 26);
            this.labstart.TabIndex = 1;
            this.labstart.Text = "开始游戏";
            this.labstart.Click += new System.EventHandler(this.labstart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(625, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "退出游戏";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pBoxmouse
            // 
            this.pBoxmouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBoxmouse.Image = global::Cheeky_Mouse.Properties.Resources.pic;
            this.pBoxmouse.Location = new System.Drawing.Point(0, 0);
            this.pBoxmouse.Name = "pBoxmouse";
            this.pBoxmouse.Size = new System.Drawing.Size(823, 445);
            this.pBoxmouse.TabIndex = 0;
            this.pBoxmouse.TabStop = false;
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(823, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labstart);
            this.Controls.Add(this.pBoxmouse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打老鼠游戏";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxmouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxmouse;
        private System.Windows.Forms.Label labstart;
        private System.Windows.Forms.Label label1;
    }
}

