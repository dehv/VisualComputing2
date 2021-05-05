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
    public partial class ModSimWindow : Form
    {
        Graphics g;
        SolidBrush brush;
        Pen pen;

        List<Entity> entities = new List<Entity>();

        public ModSimWindow()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Application.Idle += HandleApplicationIdle;
            g = this.CreateGraphics();
            brush = new SolidBrush(Color.Black);
            pen = new Pen(brush);
            entities.Add(new Entity(new Vector2(30, 30), true, Entity.Shape.Sphere, 10f));
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
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
            Bitmap bufl = new Bitmap(this.Width, this.Height);
            using (Graphics g = Graphics.FromImage(bufl))
            {
                g.FillRectangle(Brushes.White, new Rectangle(0, 0, this.Width, this.Height));
                foreach (Entity entity in entities)
                {
                    if (entity.EShape == Entity.Shape.Sphere)
                    {
                        g.FillEllipse(new SolidBrush(Color.Black), entity.Position.X - entity.Radius, entity.Position.Y - entity.Radius, entity.Diameter(), entity.Diameter());
                    }
                }
                this.CreateGraphics().DrawImageUnscaled(bufl, 0, 0);
            }

            //g.FillRectangle(new SolidBrush(Color.Red), new Rectangle(0,0, Size.Width, Size.Height));
            
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Entity entity in entities) 
            {
                entity.Update();
            }
        }

        private void accelerationBar_Scroll(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startPosition_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void small_Click(object sender, EventArgs e)
        {

        }

        private void big_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void yAxis_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void sphere1_Click(object sender, EventArgs e)
        {

        }

        private void angle_Click(object sender, EventArgs e)
        {

        }

        private void wind_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
