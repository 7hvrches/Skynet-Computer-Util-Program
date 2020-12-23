namespace _7hvrchesUtil
{
    partial class ComInfoForm
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
            this.cominfocontainer = new System.Windows.Forms.Panel();
            this.cominfotxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cominfocontainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // cominfocontainer
            // 
            this.cominfocontainer.Controls.Add(this.cominfotxtbox);
            this.cominfocontainer.Controls.Add(this.label1);
            this.cominfocontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cominfocontainer.Location = new System.Drawing.Point(0, 0);
            this.cominfocontainer.Name = "cominfocontainer";
            this.cominfocontainer.Size = new System.Drawing.Size(858, 543);
            this.cominfocontainer.TabIndex = 25;
            // 
            // cominfotxtbox
            // 
            this.cominfotxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.cominfotxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cominfotxtbox.ForeColor = System.Drawing.Color.White;
            this.cominfotxtbox.Location = new System.Drawing.Point(349, 60);
            this.cominfotxtbox.Multiline = true;
            this.cominfotxtbox.Name = "cominfotxtbox";
            this.cominfotxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cominfotxtbox.Size = new System.Drawing.Size(378, 422);
            this.cominfotxtbox.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Computer Infomation : ";
            // 
            // ComInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(858, 543);
            this.Controls.Add(this.cominfocontainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComInfoForm";
            this.Text = "ComInfoForm";
            this.cominfocontainer.ResumeLayout(false);
            this.cominfocontainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cominfocontainer;
        private System.Windows.Forms.TextBox cominfotxtbox;
        private System.Windows.Forms.Label label1;
    }
}