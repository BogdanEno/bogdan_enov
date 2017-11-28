using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        private const int WH_KEYBOARD_LL = 13;

        private const int WM_KEYDOWN = 0x0100;
        private const int WM_SYSKEYDOWN = 0x0104;

        private static LowLevelKeyboardProc _proc = HookCallback;

        private static IntPtr _hookID = IntPtr.Zero;

        public static string text;

        private static IntPtr SetHook(LowLevelKeyboardProc proc)

        {

            using (Process curProcess = Process.GetCurrentProcess())

            using (ProcessModule curModule = curProcess.MainModule)

            {

                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,

                    GetModuleHandle(curModule.ModuleName), 0);

            }

        }


        private delegate IntPtr LowLevelKeyboardProc(

            int nCode, IntPtr wParam, IntPtr lParam);

        static Queue qq = new Queue(10);
        static Array myTargetArray = Array.CreateInstance(typeof(String), 10);
        private static IntPtr HookCallback(

            int nCode, IntPtr wParam, IntPtr lParam)

        {

            if (nCode >= 0 && wParam == (IntPtr)WM_SYSKEYDOWN)

            {
                int vkCode = Marshal.ReadInt32(lParam);

                if((Keys)vkCode == Keys.V)
                {
                    if (qq.Count == 10)
                    {
                        qq.Dequeue();
                        qq.TrimToSize();
                    }
                    qq.Enqueue(Clipboard.GetText());
                    qq.CopyTo(myTargetArray, 0);
                    text = qq.Count.ToString();
                    Clipboard.Clear();
                }

                if ((Keys)vkCode == Keys.D1)
                {
                    text += myTargetArray.GetValue(0);
                }

                if ((Keys)vkCode == Keys.D2)
                {
                    text += myTargetArray.GetValue(1);
                }

                if ((Keys)vkCode == Keys.D3)
                {
                    text += myTargetArray.GetValue(2);
                }

                if ((Keys)vkCode == Keys.D4)
                {
                    text += myTargetArray.GetValue(3);
                }

                if ((Keys)vkCode == Keys.D5)
                {
                    text += myTargetArray.GetValue(4);
                }

                if ((Keys)vkCode == Keys.D6)
                {
                    text += myTargetArray.GetValue(5);
                }

                if ((Keys)vkCode == Keys.D7)
                {
                    text += myTargetArray.GetValue(6);
                }

                if ((Keys)vkCode == Keys.D8)
                {
                    text += myTargetArray.GetValue(7);
                }

                if ((Keys)vkCode == Keys.D9)
                {
                    text += myTargetArray.GetValue(8);
                }

                if ((Keys)vkCode == Keys.D0)
                {
                    text += myTargetArray.GetValue(9);
                }

                //text += ' '  + Convert.ToString((Keys)vkCode);

            }

            return CallNextHookEx(_hookID, nCode, wParam, lParam);

        }
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        private static extern IntPtr SetWindowsHookEx(int idHook,

            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);


        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        [return: MarshalAs(UnmanagedType.Bool)]

        private static extern bool UnhookWindowsHookEx(IntPtr hhk);


        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,

            IntPtr wParam, IntPtr lParam);


        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        private static extern IntPtr GetModuleHandle(string lpModuleName);
        public Form2()
        {
            InitializeComponent();
            qq.Clear();
            Clipboard.Clear();
        }
        private static string POST(string Url, string Data)
        {
            System.Net.WebRequest req = System.Net.WebRequest.Create(Url);
            req.Method = "POST";
            req.Timeout = 100000;
            req.ContentType = "application/x-www-form-urlencoded";
            byte[] sentData = Encoding.GetEncoding(1251).GetBytes(Data);
            req.ContentLength = sentData.Length;
            System.IO.Stream sendStream = req.GetRequestStream();
            sendStream.Write(sentData, 0, sentData.Length);
            sendStream.Close();
            System.Net.WebResponse res = req.GetResponse();
            System.IO.Stream ReceiveStream = res.GetResponseStream();
            System.IO.StreamReader sr = new System.IO.StreamReader(ReceiveStream, Encoding.UTF8);
            //Кодировка указывается в зависимости от кодировки ответа сервера
            Char[] read = new Char[256];
            int count = sr.Read(read, 0, 256);
            string Out = String.Empty;
            while (count > 0)
            {
                String str = new String(read, 0, count);
                Out += str;
                count = sr.Read(read, 0, 256);
            }
            return Out;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            int count_char;
            label3.Text = POST("http://www.zapomnika.zzz.com.ua/Lab4.php", "user=" + textBox1.Text + "&pass=" + textBox2.Text);
            count_char = label3.Text.IndexOf('<');
            MessageBox.Show(label3.Text.Remove(count_char));
        }

        private void Form2_DoubleClick(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Clipboard.Clear();
            UnhookWindowsHookEx(_hookID);
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _hookID = SetHook(_proc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "dsadasd";
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //for(int i = 0; i <= qq.Count; i++)
            //{
              
            //}
            label3.Text = text;
        }
    }
}
