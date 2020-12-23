namespace _7hvrchesUtil
{
    partial class UsageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsageForm));
            this.usagecontainer = new System.Windows.Forms.Panel();
            this.hddDProgressbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label5 = new System.Windows.Forms.Label();
            this.hddCProgressbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.ramProgressbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cpuProgressbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.usagecontainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // usagecontainer
            // 
            this.usagecontainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.usagecontainer.Controls.Add(this.hddDProgressbar);
            this.usagecontainer.Controls.Add(this.label5);
            this.usagecontainer.Controls.Add(this.hddCProgressbar);
            this.usagecontainer.Controls.Add(this.ramProgressbar);
            this.usagecontainer.Controls.Add(this.label4);
            this.usagecontainer.Controls.Add(this.label2);
            this.usagecontainer.Controls.Add(this.label3);
            this.usagecontainer.Controls.Add(this.cpuProgressbar);
            this.usagecontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usagecontainer.Location = new System.Drawing.Point(0, 0);
            this.usagecontainer.Name = "usagecontainer";
            this.usagecontainer.Size = new System.Drawing.Size(784, 540);
            this.usagecontainer.TabIndex = 3;
            // 
            // hddDProgressbar
            // 
            this.hddDProgressbar.animated = false;
            this.hddDProgressbar.animationIterval = 5;
            this.hddDProgressbar.animationSpeed = 300;
            this.hddDProgressbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.hddDProgressbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hddDProgressbar.BackgroundImage")));
            this.hddDProgressbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.hddDProgressbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(152)))), ((int)(((byte)(226)))));
            this.hddDProgressbar.LabelVisible = true;
            this.hddDProgressbar.LineProgressThickness = 8;
            this.hddDProgressbar.LineThickness = 2;
            this.hddDProgressbar.Location = new System.Drawing.Point(445, 309);
            this.hddDProgressbar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.hddDProgressbar.MaxValue = 100;
            this.hddDProgressbar.Name = "hddDProgressbar";
            this.hddDProgressbar.ProgressBackColor = System.Drawing.Color.White;
            this.hddDProgressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(152)))), ((int)(((byte)(226)))));
            this.hddDProgressbar.Size = new System.Drawing.Size(140, 140);
            this.hddDProgressbar.TabIndex = 30;
            this.hddDProgressbar.Value = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(467, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "D : HDD";
            // 
            // hddCProgressbar
            // 
            this.hddCProgressbar.animated = false;
            this.hddCProgressbar.animationIterval = 5;
            this.hddCProgressbar.animationSpeed = 300;
            this.hddCProgressbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.hddCProgressbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hddCProgressbar.BackgroundImage")));
            this.hddCProgressbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.hddCProgressbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(146)))), ((int)(((byte)(108)))));
            this.hddCProgressbar.LabelVisible = true;
            this.hddCProgressbar.LineProgressThickness = 8;
            this.hddCProgressbar.LineThickness = 2;
            this.hddCProgressbar.Location = new System.Drawing.Point(199, 309);
            this.hddCProgressbar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.hddCProgressbar.MaxValue = 100;
            this.hddCProgressbar.Name = "hddCProgressbar";
            this.hddCProgressbar.ProgressBackColor = System.Drawing.Color.White;
            this.hddCProgressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(146)))), ((int)(((byte)(108)))));
            this.hddCProgressbar.Size = new System.Drawing.Size(140, 140);
            this.hddCProgressbar.TabIndex = 28;
            this.hddCProgressbar.Value = 0;
            // 
            // ramProgressbar
            // 
            this.ramProgressbar.animated = false;
            this.ramProgressbar.animationIterval = 5;
            this.ramProgressbar.animationSpeed = 300;
            this.ramProgressbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ramProgressbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ramProgressbar.BackgroundImage")));
            this.ramProgressbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.ramProgressbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(155)))), ((int)(((byte)(45)))));
            this.ramProgressbar.LabelVisible = true;
            this.ramProgressbar.LineProgressThickness = 8;
            this.ramProgressbar.LineThickness = 2;
            this.ramProgressbar.Location = new System.Drawing.Point(445, 117);
            this.ramProgressbar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.ramProgressbar.MaxValue = 100;
            this.ramProgressbar.Name = "ramProgressbar";
            this.ramProgressbar.ProgressBackColor = System.Drawing.Color.White;
            this.ramProgressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(155)))), ((int)(((byte)(45)))));
            this.ramProgressbar.Size = new System.Drawing.Size(140, 140);
            this.ramProgressbar.TabIndex = 24;
            this.ramProgressbar.Value = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(221, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "C : HDD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(238, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "CPU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(483, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "RAM";
            // 
            // cpuProgressbar
            // 
            this.cpuProgressbar.animated = false;
            this.cpuProgressbar.animationIterval = 5;
            this.cpuProgressbar.animationSpeed = 300;
            this.cpuProgressbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.cpuProgressbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cpuProgressbar.BackgroundImage")));
            this.cpuProgressbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cpuProgressbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.cpuProgressbar.LabelVisible = true;
            this.cpuProgressbar.LineProgressThickness = 8;
            this.cpuProgressbar.LineThickness = 2;
            this.cpuProgressbar.Location = new System.Drawing.Point(199, 117);
            this.cpuProgressbar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cpuProgressbar.MaxValue = 100;
            this.cpuProgressbar.Name = "cpuProgressbar";
            this.cpuProgressbar.ProgressBackColor = System.Drawing.Color.White;
            this.cpuProgressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.cpuProgressbar.Size = new System.Drawing.Size(140, 140);
            this.cpuProgressbar.TabIndex = 23;
            this.cpuProgressbar.Value = 0;
            // 
            // UsageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(784, 540);
            this.Controls.Add(this.usagecontainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsageForm";
            this.Text = "UsageForm";
            this.usagecontainer.ResumeLayout(false);
            this.usagecontainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel usagecontainer;
        private Bunifu.Framework.UI.BunifuCircleProgressbar hddDProgressbar;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCircleProgressbar hddCProgressbar;
        private Bunifu.Framework.UI.BunifuCircleProgressbar ramProgressbar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cpuProgressbar;
    }
}