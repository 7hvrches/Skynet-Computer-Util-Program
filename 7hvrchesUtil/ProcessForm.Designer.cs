namespace _7hvrchesUtil
{
    partial class ProcessForm
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
            this.processcontainer = new System.Windows.Forms.Panel();
            this.processlistbox = new System.Windows.Forms.ListBox();
            this.processlabel = new System.Windows.Forms.Label();
            this.processcontainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // processcontainer
            // 
            this.processcontainer.Controls.Add(this.processlistbox);
            this.processcontainer.Controls.Add(this.processlabel);
            this.processcontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processcontainer.Location = new System.Drawing.Point(0, 0);
            this.processcontainer.Name = "processcontainer";
            this.processcontainer.Size = new System.Drawing.Size(738, 492);
            this.processcontainer.TabIndex = 19;
            this.processcontainer.Paint += new System.Windows.Forms.PaintEventHandler(this.processcontainer_Paint_1);
            // 
            // processlistbox
            // 
            this.processlistbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.processlistbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processlistbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.processlistbox.FormattingEnabled = true;
            this.processlistbox.ItemHeight = 12;
            this.processlistbox.Location = new System.Drawing.Point(287, 35);
            this.processlistbox.Name = "processlistbox";
            this.processlistbox.Size = new System.Drawing.Size(380, 422);
            this.processlistbox.TabIndex = 28;
            // 
            // processlabel
            // 
            this.processlabel.AutoSize = true;
            this.processlabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processlabel.ForeColor = System.Drawing.Color.White;
            this.processlabel.Location = new System.Drawing.Point(72, 35);
            this.processlabel.Name = "processlabel";
            this.processlabel.Size = new System.Drawing.Size(143, 22);
            this.processlabel.TabIndex = 29;
            this.processlabel.Text = "Process Count :";
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(738, 492);
            this.Controls.Add(this.processcontainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcessForm";
            this.Text = "ProcessForm";
            this.processcontainer.ResumeLayout(false);
            this.processcontainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel processcontainer;
        private System.Windows.Forms.ListBox processlistbox;
        private System.Windows.Forms.Label processlabel;
    }
}