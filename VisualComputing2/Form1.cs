using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Numerics;
using System.Runtime.InteropServices;



namespace VisualComputing2
{
    public partial class Form1 : Form
    {
        Graphics g; 

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Application.Idle += HandleApplicationIdle;
            g = this.CreateGraphics();
        }

        // https://gamedev.stackexchange.com/questions/67651/what-is-the-standard-c-windows-forms-game-loop
        void HandleApplicationIdle (object sender, EventArgs e) 
        {
            while(IsApplicationIdle()) 
            {
                Update();
                Render();
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct NativeMessage
        {
            public IntPtr Handle;
            public uint Message;
            public IntPtr WParameter;
            public IntPtr LParameter;
            public uint Time;
            public Point Location;
        }

        [DllImport("user32.dll")]
        public static extern int PeekMessage(out NativeMessage message, IntPtr window, uint filterMin, uint filterMax, uint remove);

        bool IsApplicationIdle () 
        {
            NativeMessage result;
            return PeekMessage(out result, IntPtr.Zero, (uint)0, (uint)0, (uint)0) == 0;
        }

        new void Update()
        {
        
        }

        void Render()
        {
        
        }

    }
}
