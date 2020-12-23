namespace _7hvrchesUtil
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.header = new System.Windows.Forms.Panel();
            this.btnminimized = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnexit = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sidebar = new System.Windows.Forms.Panel();
            this.btnsetting = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnothers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btncominfo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnprocess = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnusage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnhome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.settingcontainer = new System.Windows.Forms.Panel();
            this.otherscontainer = new System.Windows.Forms.Panel();
            this.cominfocontainer = new System.Windows.Forms.Panel();
            this.processcontainer = new System.Windows.Forms.Panel();
            this.usagecontainer = new System.Windows.Forms.Panel();
            this.homecontainer = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.hddDProgressbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label2 = new System.Windows.Forms.Label();
            this.hddCProgressbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.ramProgressbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cpuProgressbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.processlistbox = new System.Windows.Forms.ListBox();
            this.processlabel = new System.Windows.Forms.Label();
            this.cominfotxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.profile = new System.Windows.Forms.PictureBox();
            this.madelabel = new System.Windows.Forms.Label();
            this.btnautoprogram = new MetroFramework.Controls.MetroToggle();
            this.label5 = new System.Windows.Forms.Label();
            this.btntray = new MetroFramework.Controls.MetroToggle();
            this.label8 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidebar.SuspendLayout();
            this.settingcontainer.SuspendLayout();
            this.otherscontainer.SuspendLayout();
            this.cominfocontainer.SuspendLayout();
            this.processcontainer.SuspendLayout();
            this.usagecontainer.SuspendLayout();
            this.homecontainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.header.Controls.Add(this.btnminimized);
            this.header.Controls.Add(this.btnexit);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Controls.Add(this.bunifuCustomLabel1);
            this.header.Location = new System.Drawing.Point(0, -1);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(800, 45);
            this.header.TabIndex = 1;
            // 
            // btnminimized
            // 
            this.btnminimized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnminimized.Image = global::_7hvrchesUtil.Properties.Resources.Minimize_Window_32px;
            this.btnminimized.ImageActive = global::_7hvrchesUtil.Properties.Resources.Minimize_Window_32px;
            this.btnminimized.Location = new System.Drawing.Point(718, 6);
            this.btnminimized.Name = "btnminimized";
            this.btnminimized.Size = new System.Drawing.Size(32, 32);
            this.btnminimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimized.TabIndex = 5;
            this.btnminimized.TabStop = false;
            this.btnminimized.Zoom = 20;
            this.btnminimized.Click += new System.EventHandler(this.btnminimized_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnexit.Image = global::_7hvrchesUtil.Properties.Resources.Shutdown_32px;
            this.btnexit.ImageActive = global::_7hvrchesUtil.Properties.Resources.Shutdown_32px1;
            this.btnexit.Location = new System.Drawing.Point(756, 6);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(32, 32);
            this.btnexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnexit.TabIndex = 4;
            this.btnexit.TabStop = false;
            this.btnexit.Zoom = 20;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pictureBox1.Image = global::_7hvrchesUtil.Properties.Resources.Globe_32px;
            this.pictureBox1.Location = new System.Drawing.Point(14, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(52, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(58, 18);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Skynet";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sidebar.Controls.Add(this.btnsetting);
            this.sidebar.Controls.Add(this.btnothers);
            this.sidebar.Controls.Add(this.btncominfo);
            this.sidebar.Controls.Add(this.btnprocess);
            this.sidebar.Controls.Add(this.btnusage);
            this.sidebar.Controls.Add(this.btnhome);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(177, 456);
            this.sidebar.TabIndex = 0;
            // 
            // btnsetting
            // 
            this.btnsetting.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnsetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnsetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsetting.BorderRadius = 0;
            this.btnsetting.ButtonText = "              Setting";
            this.btnsetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsetting.DisabledColor = System.Drawing.Color.Gray;
            this.btnsetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsetting.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsetting.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsetting.Iconimage = global::_7hvrchesUtil.Properties.Resources.Settings_32px;
            this.btnsetting.Iconimage_right = null;
            this.btnsetting.Iconimage_right_Selected = null;
            this.btnsetting.Iconimage_Selected = null;
            this.btnsetting.IconMarginLeft = 0;
            this.btnsetting.IconMarginRight = 0;
            this.btnsetting.IconRightVisible = true;
            this.btnsetting.IconRightZoom = 0D;
            this.btnsetting.IconVisible = true;
            this.btnsetting.IconZoom = 40D;
            this.btnsetting.IsTab = true;
            this.btnsetting.Location = new System.Drawing.Point(0, 380);
            this.btnsetting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnsetting.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnsetting.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnsetting.selected = false;
            this.btnsetting.Size = new System.Drawing.Size(177, 76);
            this.btnsetting.TabIndex = 6;
            this.btnsetting.Text = "              Setting";
            this.btnsetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsetting.Textcolor = System.Drawing.Color.Silver;
            this.btnsetting.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsetting.Click += new System.EventHandler(this.btnsetting_Click);
            // 
            // btnothers
            // 
            this.btnothers.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnothers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnothers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnothers.BorderRadius = 0;
            this.btnothers.ButtonText = "              Others";
            this.btnothers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnothers.DisabledColor = System.Drawing.Color.Gray;
            this.btnothers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnothers.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnothers.Iconcolor = System.Drawing.Color.Transparent;
            this.btnothers.Iconimage = global::_7hvrchesUtil.Properties.Resources.Search_32px;
            this.btnothers.Iconimage_right = null;
            this.btnothers.Iconimage_right_Selected = null;
            this.btnothers.Iconimage_Selected = null;
            this.btnothers.IconMarginLeft = 0;
            this.btnothers.IconMarginRight = 0;
            this.btnothers.IconRightVisible = true;
            this.btnothers.IconRightZoom = 0D;
            this.btnothers.IconVisible = true;
            this.btnothers.IconZoom = 40D;
            this.btnothers.IsTab = true;
            this.btnothers.Location = new System.Drawing.Point(0, 304);
            this.btnothers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnothers.Name = "btnothers";
            this.btnothers.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnothers.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnothers.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnothers.selected = false;
            this.btnothers.Size = new System.Drawing.Size(177, 76);
            this.btnothers.TabIndex = 5;
            this.btnothers.Text = "              Others";
            this.btnothers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnothers.Textcolor = System.Drawing.Color.Silver;
            this.btnothers.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnothers.Click += new System.EventHandler(this.btnothers_Click);
            // 
            // btncominfo
            // 
            this.btncominfo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btncominfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btncominfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncominfo.BorderRadius = 0;
            this.btncominfo.ButtonText = "             Com Info";
            this.btncominfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncominfo.DisabledColor = System.Drawing.Color.Gray;
            this.btncominfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncominfo.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncominfo.Iconcolor = System.Drawing.Color.Transparent;
            this.btncominfo.Iconimage = global::_7hvrchesUtil.Properties.Resources.Circled_User_Male_32px;
            this.btncominfo.Iconimage_right = null;
            this.btncominfo.Iconimage_right_Selected = null;
            this.btncominfo.Iconimage_Selected = null;
            this.btncominfo.IconMarginLeft = 0;
            this.btncominfo.IconMarginRight = 0;
            this.btncominfo.IconRightVisible = true;
            this.btncominfo.IconRightZoom = 0D;
            this.btncominfo.IconVisible = true;
            this.btncominfo.IconZoom = 40D;
            this.btncominfo.IsTab = true;
            this.btncominfo.Location = new System.Drawing.Point(0, 228);
            this.btncominfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncominfo.Name = "btncominfo";
            this.btncominfo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btncominfo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btncominfo.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btncominfo.selected = false;
            this.btncominfo.Size = new System.Drawing.Size(177, 76);
            this.btncominfo.TabIndex = 4;
            this.btncominfo.Text = "             Com Info";
            this.btncominfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncominfo.Textcolor = System.Drawing.Color.Silver;
            this.btncominfo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncominfo.Click += new System.EventHandler(this.btncominfo_Click);
            // 
            // btnprocess
            // 
            this.btnprocess.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnprocess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnprocess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnprocess.BorderRadius = 0;
            this.btnprocess.ButtonText = "              Process";
            this.btnprocess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprocess.DisabledColor = System.Drawing.Color.Gray;
            this.btnprocess.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnprocess.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprocess.Iconcolor = System.Drawing.Color.Transparent;
            this.btnprocess.Iconimage = global::_7hvrchesUtil.Properties.Resources.Processor_32px;
            this.btnprocess.Iconimage_right = null;
            this.btnprocess.Iconimage_right_Selected = null;
            this.btnprocess.Iconimage_Selected = null;
            this.btnprocess.IconMarginLeft = 0;
            this.btnprocess.IconMarginRight = 0;
            this.btnprocess.IconRightVisible = true;
            this.btnprocess.IconRightZoom = 0D;
            this.btnprocess.IconVisible = true;
            this.btnprocess.IconZoom = 40D;
            this.btnprocess.IsTab = true;
            this.btnprocess.Location = new System.Drawing.Point(0, 152);
            this.btnprocess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnprocess.Name = "btnprocess";
            this.btnprocess.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnprocess.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnprocess.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnprocess.selected = false;
            this.btnprocess.Size = new System.Drawing.Size(177, 76);
            this.btnprocess.TabIndex = 3;
            this.btnprocess.Text = "              Process";
            this.btnprocess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprocess.Textcolor = System.Drawing.Color.Silver;
            this.btnprocess.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprocess.Click += new System.EventHandler(this.btnprocess_Click);
            // 
            // btnusage
            // 
            this.btnusage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnusage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnusage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnusage.BorderRadius = 0;
            this.btnusage.ButtonText = "              Usage";
            this.btnusage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnusage.DisabledColor = System.Drawing.Color.Gray;
            this.btnusage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnusage.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusage.Iconcolor = System.Drawing.Color.Transparent;
            this.btnusage.Iconimage = global::_7hvrchesUtil.Properties.Resources.Recycling_symbol_32px;
            this.btnusage.Iconimage_right = null;
            this.btnusage.Iconimage_right_Selected = null;
            this.btnusage.Iconimage_Selected = null;
            this.btnusage.IconMarginLeft = 0;
            this.btnusage.IconMarginRight = 0;
            this.btnusage.IconRightVisible = true;
            this.btnusage.IconRightZoom = 0D;
            this.btnusage.IconVisible = true;
            this.btnusage.IconZoom = 40D;
            this.btnusage.IsTab = true;
            this.btnusage.Location = new System.Drawing.Point(0, 76);
            this.btnusage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnusage.Name = "btnusage";
            this.btnusage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnusage.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnusage.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnusage.selected = false;
            this.btnusage.Size = new System.Drawing.Size(177, 76);
            this.btnusage.TabIndex = 2;
            this.btnusage.Text = "              Usage";
            this.btnusage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnusage.Textcolor = System.Drawing.Color.Silver;
            this.btnusage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusage.Click += new System.EventHandler(this.btnusage_Click);
            // 
            // btnhome
            // 
            this.btnhome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhome.BorderRadius = 0;
            this.btnhome.ButtonText = "              Home";
            this.btnhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhome.DisabledColor = System.Drawing.Color.Gray;
            this.btnhome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnhome.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnhome.Iconimage = global::_7hvrchesUtil.Properties.Resources.Home_32px;
            this.btnhome.Iconimage_right = null;
            this.btnhome.Iconimage_right_Selected = null;
            this.btnhome.Iconimage_Selected = null;
            this.btnhome.IconMarginLeft = 0;
            this.btnhome.IconMarginRight = 0;
            this.btnhome.IconRightVisible = true;
            this.btnhome.IconRightZoom = 0D;
            this.btnhome.IconVisible = true;
            this.btnhome.IconZoom = 40D;
            this.btnhome.IsTab = true;
            this.btnhome.Location = new System.Drawing.Point(0, 0);
            this.btnhome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnhome.Name = "btnhome";
            this.btnhome.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnhome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnhome.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnhome.selected = true;
            this.btnhome.Size = new System.Drawing.Size(177, 76);
            this.btnhome.TabIndex = 1;
            this.btnhome.Text = "              Home";
            this.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Textcolor = System.Drawing.Color.Silver;
            this.btnhome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // settingcontainer
            // 
            this.settingcontainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.settingcontainer.Controls.Add(this.otherscontainer);
            this.settingcontainer.Controls.Add(this.sidebar);
            this.settingcontainer.Controls.Add(this.btnautoprogram);
            this.settingcontainer.Controls.Add(this.label5);
            this.settingcontainer.Controls.Add(this.btntray);
            this.settingcontainer.Controls.Add(this.label8);
            this.settingcontainer.Location = new System.Drawing.Point(0, 44);
            this.settingcontainer.Name = "settingcontainer";
            this.settingcontainer.Size = new System.Drawing.Size(800, 456);
            this.settingcontainer.TabIndex = 2;
            // 
            // otherscontainer
            // 
            this.otherscontainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.otherscontainer.Controls.Add(this.cominfocontainer);
            this.otherscontainer.Controls.Add(this.pictureBox4);
            this.otherscontainer.Controls.Add(this.pictureBox3);
            this.otherscontainer.Controls.Add(this.label7);
            this.otherscontainer.Controls.Add(this.label6);
            this.otherscontainer.Controls.Add(this.profile);
            this.otherscontainer.Controls.Add(this.madelabel);
            this.otherscontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otherscontainer.Location = new System.Drawing.Point(177, 0);
            this.otherscontainer.Name = "otherscontainer";
            this.otherscontainer.Size = new System.Drawing.Size(623, 456);
            this.otherscontainer.TabIndex = 28;
            // 
            // cominfocontainer
            // 
            this.cominfocontainer.Controls.Add(this.processcontainer);
            this.cominfocontainer.Controls.Add(this.cominfotxtbox);
            this.cominfocontainer.Controls.Add(this.label1);
            this.cominfocontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cominfocontainer.Location = new System.Drawing.Point(0, 0);
            this.cominfocontainer.Name = "cominfocontainer";
            this.cominfocontainer.Size = new System.Drawing.Size(623, 456);
            this.cominfocontainer.TabIndex = 26;
            // 
            // processcontainer
            // 
            this.processcontainer.Controls.Add(this.usagecontainer);
            this.processcontainer.Controls.Add(this.processlistbox);
            this.processcontainer.Controls.Add(this.processlabel);
            this.processcontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processcontainer.Location = new System.Drawing.Point(0, 0);
            this.processcontainer.Name = "processcontainer";
            this.processcontainer.Size = new System.Drawing.Size(623, 456);
            this.processcontainer.TabIndex = 29;
            // 
            // usagecontainer
            // 
            this.usagecontainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.usagecontainer.Controls.Add(this.homecontainer);
            this.usagecontainer.Controls.Add(this.hddDProgressbar);
            this.usagecontainer.Controls.Add(this.label2);
            this.usagecontainer.Controls.Add(this.hddCProgressbar);
            this.usagecontainer.Controls.Add(this.ramProgressbar);
            this.usagecontainer.Controls.Add(this.label4);
            this.usagecontainer.Controls.Add(this.label3);
            this.usagecontainer.Controls.Add(this.label9);
            this.usagecontainer.Controls.Add(this.cpuProgressbar);
            this.usagecontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usagecontainer.Location = new System.Drawing.Point(0, 0);
            this.usagecontainer.Name = "usagecontainer";
            this.usagecontainer.Size = new System.Drawing.Size(623, 456);
            this.usagecontainer.TabIndex = 19;
            // 
            // homecontainer
            // 
            this.homecontainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.homecontainer.Controls.Add(this.label10);
            this.homecontainer.Controls.Add(this.pictureBox2);
            this.homecontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homecontainer.Location = new System.Drawing.Point(0, 0);
            this.homecontainer.Name = "homecontainer";
            this.homecontainer.Size = new System.Drawing.Size(623, 456);
            this.homecontainer.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(212, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 29);
            this.label10.TabIndex = 10;
            this.label10.Text = "Welcome to Skynet";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_7hvrchesUtil.Properties.Resources.Globe_Earth_96px;
            this.pictureBox2.Location = new System.Drawing.Point(260, 175);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
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
            this.hddDProgressbar.Location = new System.Drawing.Point(367, 262);
            this.hddDProgressbar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.hddDProgressbar.MaxValue = 100;
            this.hddDProgressbar.Name = "hddDProgressbar";
            this.hddDProgressbar.ProgressBackColor = System.Drawing.Color.White;
            this.hddDProgressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(152)))), ((int)(((byte)(226)))));
            this.hddDProgressbar.Size = new System.Drawing.Size(140, 140);
            this.hddDProgressbar.TabIndex = 30;
            this.hddDProgressbar.Value = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(389, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "D : HDD";
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
            this.hddCProgressbar.Location = new System.Drawing.Point(121, 262);
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
            this.ramProgressbar.Location = new System.Drawing.Point(367, 70);
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
            this.label4.Location = new System.Drawing.Point(143, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "C : HDD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(160, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "CPU";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(405, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "RAM";
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
            this.cpuProgressbar.Location = new System.Drawing.Point(121, 70);
            this.cpuProgressbar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cpuProgressbar.MaxValue = 100;
            this.cpuProgressbar.Name = "cpuProgressbar";
            this.cpuProgressbar.ProgressBackColor = System.Drawing.Color.White;
            this.cpuProgressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.cpuProgressbar.Size = new System.Drawing.Size(140, 140);
            this.cpuProgressbar.TabIndex = 23;
            this.cpuProgressbar.Value = 0;
            // 
            // processlistbox
            // 
            this.processlistbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.processlistbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processlistbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.processlistbox.FormattingEnabled = true;
            this.processlistbox.ItemHeight = 12;
            this.processlistbox.Location = new System.Drawing.Point(231, 22);
            this.processlistbox.Name = "processlistbox";
            this.processlistbox.Size = new System.Drawing.Size(380, 422);
            this.processlistbox.TabIndex = 18;
            this.processlistbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.processlistbox_MouseDoubleClick);
            // 
            // processlabel
            // 
            this.processlabel.AutoSize = true;
            this.processlabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processlabel.ForeColor = System.Drawing.Color.White;
            this.processlabel.Location = new System.Drawing.Point(16, 22);
            this.processlabel.Name = "processlabel";
            this.processlabel.Size = new System.Drawing.Size(143, 22);
            this.processlabel.TabIndex = 27;
            this.processlabel.Text = "Process Count :";
            // 
            // cominfotxtbox
            // 
            this.cominfotxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.cominfotxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cominfotxtbox.ForeColor = System.Drawing.Color.White;
            this.cominfotxtbox.Location = new System.Drawing.Point(233, 22);
            this.cominfotxtbox.Multiline = true;
            this.cominfotxtbox.Name = "cominfotxtbox";
            this.cominfotxtbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cominfotxtbox.Size = new System.Drawing.Size(378, 422);
            this.cominfotxtbox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Computer Infomation : ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::_7hvrchesUtil.Properties.Resources.TCPIPChatimage;
            this.pictureBox4.Location = new System.Drawing.Point(255, 242);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(233, 160);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::_7hvrchesUtil.Properties.Resources.Smartfileimage;
            this.pictureBox3.Location = new System.Drawing.Point(47, 242);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(188, 160);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(42, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "  7hvrches  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(42, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(468, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Made Programs list (and more program is blog) :";
            // 
            // profile
            // 
            this.profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profile.Image = global::_7hvrchesUtil.Properties.Resources.profiler;
            this.profile.Location = new System.Drawing.Point(47, 22);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(110, 107);
            this.profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.profile.TabIndex = 8;
            this.profile.TabStop = false;
            // 
            // madelabel
            // 
            this.madelabel.AutoSize = true;
            this.madelabel.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.madelabel.ForeColor = System.Drawing.Color.Silver;
            this.madelabel.Location = new System.Drawing.Point(194, 22);
            this.madelabel.Name = "madelabel";
            this.madelabel.Size = new System.Drawing.Size(380, 150);
            this.madelabel.TabIndex = 7;
            this.madelabel.Text = "Program is Beta Ver.0.1\r\nBugs and errors pleas report to this\r\nEmail : 7hvrches@n" +
    "aver.com\r\nand my blog : blog.naver.com/7hvrches\r\nⓒ 2017.  7hvrches all rights re" +
    "served.\r\n\r\n";
            // 
            // btnautoprogram
            // 
            this.btnautoprogram.AutoSize = true;
            this.btnautoprogram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnautoprogram.Location = new System.Drawing.Point(326, 35);
            this.btnautoprogram.Name = "btnautoprogram";
            this.btnautoprogram.Size = new System.Drawing.Size(80, 16);
            this.btnautoprogram.TabIndex = 33;
            this.btnautoprogram.Text = "Off";
            this.btnautoprogram.UseVisualStyleBackColor = true;
            this.btnautoprogram.Click += new System.EventHandler(this.btnautoprogram_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(233, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 34;
            this.label5.Text = "자동실행 : ";
            // 
            // btntray
            // 
            this.btntray.AutoSize = true;
            this.btntray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntray.Location = new System.Drawing.Point(374, 107);
            this.btntray.Name = "btntray";
            this.btntray.Size = new System.Drawing.Size(80, 16);
            this.btntray.TabIndex = 35;
            this.btntray.Text = "Off";
            this.btntray.UseVisualStyleBackColor = true;
            this.btntray.Click += new System.EventHandler(this.btntray_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(233, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 22);
            this.label8.TabIndex = 36;
            this.label8.Text = "프로그램 최소화 :";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Skynet";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(94, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.header);
            this.Controls.Add(this.settingcontainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "7hvrches util";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.settingcontainer.ResumeLayout(false);
            this.settingcontainer.PerformLayout();
            this.otherscontainer.ResumeLayout(false);
            this.otherscontainer.PerformLayout();
            this.cominfocontainer.ResumeLayout(false);
            this.cominfocontainer.PerformLayout();
            this.processcontainer.ResumeLayout(false);
            this.processcontainer.PerformLayout();
            this.usagecontainer.ResumeLayout(false);
            this.usagecontainer.PerformLayout();
            this.homecontainer.ResumeLayout(false);
            this.homecontainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel header;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton btnexit;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel sidebar;
        private Bunifu.Framework.UI.BunifuFlatButton btnsetting;
        private Bunifu.Framework.UI.BunifuFlatButton btnothers;
        private Bunifu.Framework.UI.BunifuFlatButton btncominfo;
        private Bunifu.Framework.UI.BunifuFlatButton btnprocess;
        private Bunifu.Framework.UI.BunifuFlatButton btnusage;
        private Bunifu.Framework.UI.BunifuFlatButton btnhome;
        private System.Windows.Forms.Panel settingcontainer;
        private System.Windows.Forms.Panel otherscontainer;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox profile;
        private System.Windows.Forms.Label madelabel;
        private System.Windows.Forms.Panel cominfocontainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cominfotxtbox;
        private System.Windows.Forms.Panel processcontainer;
        private System.Windows.Forms.ListBox processlistbox;
        private System.Windows.Forms.Panel usagecontainer;
        private Bunifu.Framework.UI.BunifuCircleProgressbar hddDProgressbar;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCircleProgressbar hddCProgressbar;
        private Bunifu.Framework.UI.BunifuCircleProgressbar ramProgressbar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cpuProgressbar;
        private System.Windows.Forms.Panel homecontainer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuImageButton btnminimized;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MetroFramework.Controls.MetroToggle btnautoprogram;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroToggle btntray;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label processlabel;
    }
}

