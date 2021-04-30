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
        SolidBrush brush;
        Pen pen;
        Bitmap bufl;

        float timerInterval;
        public static float gravity = 9.81f;

        List<Entity> entities = new List<Entity>();
        Entity selectedEntity;

        bool enableDebug;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Application.Idle += HandleApplicationIdle;
            brush = new SolidBrush(Color.Black);
            pen = new Pen(brush);

            entities.Add(new Entity(new Vector2(30, 30), true, Entity.Shape.Sphere, 10f));

            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            timerInterval = timer1.Interval;
            enableDebug = enableDebugDrawCheck.Checked;
            bufl = new Bitmap(this.Width, this.Height);
        }

        // https://gamedev.stackexchange.com/questions/67651/what-is-the-standard-c-windows-forms-game-loop
        void HandleApplicationIdle(object sender, EventArgs e)
        {
            while (IsApplicationIdle())
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
            if(selectedEntity == null) 
            {
                posXBox.Clear();
                posYBox.Clear();
                velXBox.Clear();
                velYBox.Clear();
            } else
            {
                posXBox.Text = selectedEntity.Position.X.ToString();
                posYBox.Text = selectedEntity.Position.Y.ToString();
                velXBox.Text = selectedEntity.Velocity.X.ToString();
                velYBox.Text = selectedEntity.Velocity.Y.ToString();
            }
        }

        void Render()
        {
            
            using (g = Graphics.FromImage(bufl))
            {
                g.FillRectangle(Brushes.White, new Rectangle(0, 0, this.Width, this.Height));
                foreach (Entity entity in entities)
                {
                    if (entity.EShape == Entity.Shape.Sphere)
                    {
                        g.FillEllipse(Brushes.Black, entity.Position.X - entity.Radius, entity.Position.Y - entity.Radius, entity.Diameter(), entity.Diameter());
                    }
                    if (entity.canMove && enableDebug) 
                    {
                        g.DrawLine(Pens.Magenta, entity.Position.X, entity.Position.Y, entity.Position.X + entity.Velocity.X, entity.Position.Y + entity.Velocity.Y);
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
                entity.Update(timerInterval);
            }
        }

        private void EnableDebugDraw_CheckedChanged(object sender, EventArgs e)
        {
            enableDebug = enableDebugDrawCheck.Checked;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs me) 
        {
            bool eFound = false;
            foreach (Entity entity in entities)
            {
                if (entity.Position.X <= me.X && entity.Position.X + entity.Radius >= me.X) 
                {
                    if (entity.Position.Y <= me.Y && entity.Position.Y + entity.Radius >= me.Y)
                    {
                        currentObjectLabel.Text = "Current Object: " + entity.ToString();
                        selectedEntity = entity;
                        eFound = true;
                        break;
                    }
                    
                } continue;
            }
            if (!eFound) 
            {
                selectedEntity = null;
                currentObjectLabel.Text = "Current Object: None";
            }
        }
    }
}
