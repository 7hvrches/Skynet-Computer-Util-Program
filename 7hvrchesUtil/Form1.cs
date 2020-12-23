using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _7hvrchesUtil
{
    public partial class Form1 : Form
    {
        // 최초 한 번만 실행
        int count = 1;

        // Mutex Variable.
        bool CreateNew;

        // CPU Variable.
        private Thread addDataRunner;
        public delegate void AddDataDelegate();
        public AddDataDelegate addDataDel;

        // RAM Variable.
        private Thread addDataRunner1;
        public AddDataDelegate addDataDel1;

        Bunifu_Classes.moveform mf = new Bunifu_Classes.moveform();

        private PerformanceCounter cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private PerformanceCounter ram = new PerformanceCounter("Memory", "Available MBytes");

        private Object theLock = new Object();

        // 프로세스 목록 배열(이름)
        Process[] proList = Process.GetProcesses();

        public Form1()
        {
            InitializeComponent();
        }

        // CPU
        private void AddDataThreadLoop()
        {
            while (true)
            {
                cpuProgressbar.Invoke(addDataDel);
                Thread.Sleep(1000); // 1초에 한번 리셋
            }
        }
        public void AddData()
        {
            float usage = cpu.NextValue();
            cpuProgressbar.Value = ((int)usage);
        }

        // RAM
        private void AddDataThreadLoop1()
        {
            while (true)
            {
                ramProgressbar.Invoke(addDataDel1);
                Thread.Sleep(1000);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btntray.Checked = Properties.Settings.Default.ProStartTray; // 시작시 자동 트레이 설정했던 걸 보여줌
            btnautoprogram.Checked = Properties.Settings.Default.ProStartSave; // 시작시 자동실행 설정했던 걸 보여줌
            using (var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
            {
                this.btnautoprogram.Checked = (key.GetValue("7hvrches util") != null);
            }

            // 윈도우즈 폼을 화면 정중앙에 띄움
            this.Location = new Point(
                Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2,
                Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2);

            // CPU
            ThreadStart addDataThreadStart = new ThreadStart(AddDataThreadLoop);
            addDataRunner = new Thread(addDataThreadStart);
            addDataDel += new AddDataDelegate(AddData);
            cpuProgressbar.MaxValue = 100;
            addDataRunner.Start();

            // RAM
            ThreadStart addDataThreadStart1 = new ThreadStart(AddDataThreadLoop1);
            addDataRunner1 = new Thread(addDataThreadStart1);
            ramProgressbar.MaxValue = 100;
            addDataRunner1.Start();
            Int64 phav = PerformanceInfo.GetPhysicalAvailableMemoryInMiB();
            Int64 tot = PerformanceInfo.GetTotalMemoryInMiB();
            decimal percentFree = ((decimal)phav / (decimal)tot) * 100;
            decimal percentOccupied = 100 - percentFree;
            ramProgressbar.Value = (int)phav / 1024;

            // HDD ( byte * 1024 * 1024 * 1024 = GByte ) byte * 1024 = Kbyte
            DriveInfo drvC = new DriveInfo("C"); // C 드라이브
            DriveInfo drvD = new DriveInfo("D"); // D 드라이브

            // C드라이브 : 전체 용량 - 빈용량 = 현재 사용중인 용량(result)
            long resultC = drvC.TotalSize - drvC.AvailableFreeSpace;
            // D드라이브 : 전체 용량 - 빈용량 = 현재 사용중인 용량(result)
            long resultD = drvD.TotalSize - drvD.AvailableFreeSpace;

            hddCProgressbar.MaxValue = (int)(drvC.TotalSize / (1024 * 1024 * 1024)); // C드라이브 전체 용량
            hddCProgressbar.Value = (int)(resultC / (1024 * 1024 * 1024)); // C드라이브 현재 사용중인 용량
            hddDProgressbar.MaxValue = (int)(drvD.TotalSize / (1024 * 1024 * 1024)); // D드라이브 전체 용량
            hddDProgressbar.Value = (int)(resultD / (1024 * 1024 * 1024)); // D드라이브 현재 사용중인 용량


            timer1_Tick(sender, e);
            timer1.Interval = 10000; // 10초에 한번 리스트 리셋
            timer1.Start();

            // 중복 실행 방지
            Mutex m = new Mutex(true, "FIRST", out CreateNew);
            if (CreateNew)
            {

            }
            else
            {
                MessageBox.Show("이미 Skynet 프로그램이 실행중입니다.");
                Application.Exit();
            }
        }

        // Memory check class.
        public static class PerformanceInfo
        {
            [DllImport("psapi.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetPerformanceInfo([Out] out PerformanceInformation PerformanceInformation, [In] int Size);

            [StructLayout(LayoutKind.Sequential)]
            public struct PerformanceInformation
            {
                public int Size;
                public IntPtr CommitTotal;
                public IntPtr CommitLimit;
                public IntPtr CommitPeak;
                public IntPtr PhysicalTotal;
                public IntPtr PhysicalAvailable;
                public IntPtr SystemCache;
                public IntPtr KernelTotal;
                public IntPtr KernelPaged;
                public IntPtr KernelNonPaged;
                public IntPtr PageSize;
                public int HandlesCount;
                public int ProcessCount;
                public int ThreadCount;
            }

            public static Int64 GetPhysicalAvailableMemoryInMiB()
            {
                PerformanceInformation pi = new PerformanceInformation();
                if (GetPerformanceInfo(out pi, Marshal.SizeOf(pi)))
                {
                    return Convert.ToInt64((pi.PhysicalAvailable.ToInt64() * pi.PageSize.ToInt64() / 1048576));
                }
                else
                {
                    return -1;
                }

            }

            public static Int64 GetTotalMemoryInMiB()
            {
                PerformanceInformation pi = new PerformanceInformation();
                if (GetPerformanceInfo(out pi, Marshal.SizeOf(pi)))
                {
                    return Convert.ToInt64((pi.PhysicalTotal.ToInt64() * pi.PageSize.ToInt64() / 1048576));
                }
                else
                {
                    return -1;
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            processlistbox.Items.Clear();
            foreach (Process p in proList)
            {
                processlistbox.Items.Add(p.ProcessName + " (PID : " + p.Id + "\r\n)");
            }
            for (int i = 0; i < proList.Length; i++)
            {
                processlabel.Text = "Process Count : " + i;
            }
        }

        private void processlistbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (processlistbox.SelectedItems.Count == 1)
            {
                try
                {
                    if (MessageBox.Show("해당 프로세스를 종료하겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        proList[processlistbox.SelectedIndex].Kill();
                        processlistbox.Items.Remove(processlistbox.SelectedItems[0]);
                    }
                    else
                    {

                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show("이미 삭제된 프로세스입니다 프로그램 재실행시 해당 프로세스가 없어집니다.");
                }
            }
        }

        /* 버튼순서가 아래에서 위 순서일 경우 : 자기 자신 버튼과 위의 버튼은 전부 true로
         * 
         * 버튼순서가 위에서 아래 순서일 경우 : 1번째버튼-전부 true, 2번째버튼-1번만false, 3번째버튼-1,2번false, 4번째버튼-1,2,3false, 5번째버튼-1,2,3,4false 식으로 false라고 적힌것만 false하고 나머진 true 넣어주면됨
         * 
         * 
         * 
         */
        private void btnhome_Click(object sender, EventArgs e)
        {
            // Home
            homecontainer.Visible = true;
            usagecontainer.Visible = true;
            processcontainer.Visible = true;
            cominfocontainer.Visible = true;
            otherscontainer.Visible = true;
            settingcontainer.Visible = true;
            homecontainer.BringToFront();
        }

        private void btnusage_Click(object sender, EventArgs e)
        {
            // Usage
            homecontainer.Visible = false;
            usagecontainer.Visible = true;
            processcontainer.Visible = true;
            cominfocontainer.Visible = true;
            otherscontainer.Visible = true;
            settingcontainer.Visible = true;
            usagecontainer.BringToFront();
        }

        private void btnprocess_Click(object sender, EventArgs e)
        {
            // Process
            homecontainer.Visible = false;
            usagecontainer.Visible = false;
            processcontainer.Visible = true;
            cominfocontainer.Visible = true;
            otherscontainer.Visible = true;
            settingcontainer.Visible = true;
            processcontainer.BringToFront();
        }

        private void btncominfo_Click(object sender, EventArgs e)
        {
            // Com Info
            homecontainer.Visible = false;
            usagecontainer.Visible = false;
            processcontainer.Visible = false;
            cominfocontainer.Visible = true;
            otherscontainer.Visible = true;
            settingcontainer.Visible = true;
            cominfocontainer.BringToFront();

            cominfotxtbox.Text = "";
            string cpuresult = DeviceCPUInformation("Win32_Processor"); // CPU Informations Call
            string gpuresult = DeviceGPUInformation(); // GPU Informations Call
            string ipresult = Client_IP; // IP Address Call
            cominfotxtbox.Text = "IP Address : " + "\r\n" + ipresult + "\r\n\r\n\r\n" + "CPU Informations : " + "\r\n" + cpuresult + "\r\n" + "GPU Informations: " + "\r\n" + gpuresult;
        }

        private void btnothers_Click(object sender, EventArgs e)
        {
            // Others
            homecontainer.Visible = false;
            usagecontainer.Visible = false;
            processcontainer.Visible = false;
            cominfocontainer.Visible = false;
            otherscontainer.Visible = true;
            settingcontainer.Visible = true;
            otherscontainer.BringToFront();

        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            // Setting
            homecontainer.Visible = false;
            usagecontainer.Visible = false;
            processcontainer.Visible = false;
            cominfocontainer.Visible = false;
            otherscontainer.Visible = false;
            settingcontainer.Visible = true;
            settingcontainer.BringToFront();
        }

        // CPU Informations
        private string DeviceCPUInformation(string stringIn)
        {
            StringBuilder StringBuilder1 = new StringBuilder(string.Empty);
            ManagementClass ManagementClass1 = new ManagementClass(stringIn);
            //Create a ManagementObjectCollection to loop through
            ManagementObjectCollection ManagemenobjCol = ManagementClass1.GetInstances();
            //Get the properties in the class
            PropertyDataCollection properties = ManagementClass1.Properties;
            foreach (ManagementObject obj in ManagemenobjCol)
            {
                foreach (PropertyData property in properties)
                {
                    try
                    {
                        StringBuilder1.AppendLine(property.Name + ":  " +
                          obj.Properties[property.Name].Value.ToString());
                    }
                    catch
                    {
                        //Add codes to manage more informations
                    }
                }
                StringBuilder1.AppendLine();
            }
            return StringBuilder1.ToString();
        }

        // GPU Informations
        private string DeviceGPUInformation()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");

            string graphicsCard = string.Empty;
            foreach (ManagementObject mo in searcher.Get())
            {
                foreach (PropertyData property in mo.Properties)
                {
                    if (property.Name == "Description")
                    {
                        graphicsCard = property.Value.ToString();
                    }
                }
            }
            return graphicsCard;
        }

        // IP Address
        private static string Client_IP
        {
            get
            {
                IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
                string ClientIP = string.Empty;
                for (int i = 0; i < host.AddressList.Length; i++)
                {
                    if (host.AddressList[i].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        ClientIP = host.AddressList[i].ToString();
                }
                return ClientIP;
            }
        }

        private void btnautoprogram_Click(object sender, EventArgs e)
        {
            // 레지스트리 등록을 위한 registryKey 선언
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(
                                 @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            //레지스트리 등록할 때
            if (btnautoprogram.Checked == true)
            {
                registryKey.SetValue("7hvrches util", Application.ExecutablePath.ToString());
                // 부팅시 자동 실행되기 위해 true 값을 Properties 속성의 ProStartSave변수에 담는다. 담고나서 꼭 Save() 메서드를 호출
                btnautoprogram.Checked = true;
                Properties.Settings.Default.ProStartSave = btnautoprogram.Checked;
                Properties.Settings.Default.Save();
                MessageBox.Show("시작 프로그램에 등록되었습니다. 다음부터 컴퓨터 부팅시 자동으로 켜집니다.", "설정완료",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //레지스트리 삭제할 때
            else
            {
                registryKey.DeleteValue("7hvrches util", false);
                // 부팅시 자동 실행되기 위해 false 값을 Properties 속성의 ProStartSave변수에 담는다. 담고나서 꼭 Save() 메서드를 호출
                btnautoprogram.Checked = false;
                Properties.Settings.Default.ProStartSave = btnautoprogram.Checked;
                Properties.Settings.Default.Save();
                MessageBox.Show("시작 프로그램에서 삭제되었습니다. 이제 컴퓨터 부팅시 자동으로 켜지지 않습니다.", "설정해제",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Tray Exit function
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("잠시후 종료됩니다.", "잠시만 기다려주세요");
            Delay(3000);
            Application.Exit();
        }

        private void btntray_Click(object sender, EventArgs e)
        {
            if (btntray.Checked == true)
            {
                MessageBox.Show("프로그램 종료시 트레이됩니다.");
                btntray.Checked = true;
                Properties.Settings.Default.ProStartTray = btntray.Checked;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("프로그램 종료시 트레이 되지 않습니다.");
                btntray.Checked = false;
                Properties.Settings.Default.ProStartTray = btntray.Checked;
                Properties.Settings.Default.Save();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }

        private void btnminimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            // btntray가 true 라면

            if (btntray.Checked == true)
            {
                if (count == 1)
                {
                    count--;
                    MessageBox.Show("프로그램이 트레이 됩니다 백그라운드 프로세스를 확인해주세요.", "트레이 아이콘");
                }
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                this.Visible = false;
                this.notifyIcon1.Visible = true;
                notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            }

            // btntray가 false 라면
            else
            {
                MessageBox.Show("잠시후 종료됩니다.", "잠시만 기다려주세요");
                Delay(2000);
                // Thread Close and Program Exit.
                this.Close();
                addDataRunner.Abort();
                addDataRunner1.Abort();
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("잠시후 종료됩니다.", "잠시만 기다려주세요");
            Delay(3000);
            Application.Exit();
        }
    }
}
