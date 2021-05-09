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
        bool runSimulation = false;
        Bitmap bufl;
        float timerInterval;
        public static float gravity = 9.81f;


        List<Entity> entities = new List<Entity>();
        List<Entity> resetCopy = new List<Entity>();
        Entity selectedEntity;

        bool enableDebug;
        bool isFirstStart = true;
        public static bool useGravity = true;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Application.Idle += HandleApplicationIdle;
            brush = new SolidBrush(Color.Black);
            pen = new Pen(brush);

            
            entities.Add(new Entity(new Vector2(200, 400), true, 10f));
            entities.Add(new Entity(new Vector2(200, 200), 50f, 30f, 20f));
            entities.Add(new Entity(new Vector2(pictureBox1.Width / 2, 0), pictureBox1.Width, 20f, 0f));
            entities.Add(new Entity(new Vector2(pictureBox1.Width / 2, pictureBox1.Height), pictureBox1.Width, 20f, 0f));
            entities.Add(new Entity(new Vector2(0, (pictureBox1.Height -20) / 2), 20f, pictureBox1.Height, 0f));
            entities.Add(new Entity(new Vector2(pictureBox1.Width, (pictureBox1.Height - 20) / 2), 20f, pictureBox1.Height, 0f));
            entities.Add(new Entity(new Vector2(300, 500), 300, 20f, 0f));

            entities[0].Velocity = new Vector2(100, -40);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            timerInterval = timer1.Interval;
            enableDebug = true; //enableDebugDrawCheck.Checked;
            bufl = new Bitmap(pictureBox1.Width, pictureBox1.Height);
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
            //if(selectedEntity == null) 
            //{
            //    posXBox.Clear();
            //    posYBox.Clear();
            //    velXBox.Clear();
            //    velYBox.Clear();
            //} else
            //{
            //    posXBox.Text = selectedEntity.Position.X.ToString();
            //    posYBox.Text = selectedEntity.Position.Y.ToString();
            //    velXBox.Text = selectedEntity.Velocity.X.ToString();
            //    velYBox.Text = selectedEntity.Velocity.Y.ToString();
            //}
        }

        void Render()
        {
            
            using (g = Graphics.FromImage(bufl))
            {
                //Clear Screen
                g.FillRectangle(Brushes.White, new Rectangle(0, 0, this.Width, this.Height));

                
                //Draw every Entity in the List
                foreach (Entity entity in entities)
                {
                    //Draw Spheres
                    if (entity.EShape == Entity.Shape.Sphere)
                    {
                        g.FillEllipse(Brushes.Black, entity.Position.X - entity.Radius, entity.Position.Y - entity.Radius, entity.Diameter(), entity.Diameter());
                    }

                    if(entity.EShape == Entity.Shape.Rectangle)
                    {
                        Vector2[] pointsVec = entity.Points;
                        PointF[] points = new PointF[pointsVec.Length];
                        for (int i = 0; i < pointsVec.Length; i++)
                        {
                            points[i] = new PointF(pointsVec[i].X, pointsVec[i].Y);
                        }
                        g.DrawPolygon(Pens.Gray, points);
                        if (enableDebug)
                        {
                            for (int i = 0; i < pointsVec.Length; i++)
                            {
                                g.DrawString(i.ToString(), DefaultFont, Brushes.Maroon, points[i]);
                                if(i == pointsVec.Length - 1)
                                {
                                    Vector2 middle = pointsVec[0] - pointsVec[i];
                                    g.DrawLine(Pens.Red, 
                                        pointsVec[i].X+middle.X * 0.5f,
                                        pointsVec[i].Y+middle.Y * 0.5f,
                                        (pointsVec[i].X + middle.X * 0.5f + entity.Normals[i].X*10),
                                        (pointsVec[i].Y + middle.Y * 0.5f + entity.Normals[i].Y*10));
                                }
                                else
                                {
                                    Vector2 middle = pointsVec[i+1] - pointsVec[i];
                                    g.DrawLine(Pens.Red,
                                        pointsVec[i].X + middle.X *0.5f,
                                        pointsVec[i].Y + middle.Y * 0.5f,
                                        (pointsVec[i].X + middle.X * 0.5f + entity.Normals[i].X*10),
                                        (pointsVec[i].Y + middle.Y * 0.5f + entity.Normals[i].Y*10));
                                }
                                
                            }
                        }
                    }

                    //Debug Drawing
                    if (entity.canMove && enableDebug) 
                    {
                        g.DrawLine(Pens.Magenta, entity.Position.X, entity.Position.Y, entity.Position.X + entity.Velocity.X, entity.Position.Y + entity.Velocity.Y);
                        g.DrawRectangle(Pens.LawnGreen, entity.Position.X - entity.Radius, entity.Position.Y - entity.Radius, entity.Diameter(), entity.Diameter());
                    }
                    
                }

                if (selectedEntity != null && selectedEntity.EShape == Entity.Shape.Sphere)
                {
                    g.DrawEllipse(Pens.Turquoise, selectedEntity.Position.X - selectedEntity.Radius, selectedEntity.Position.Y - selectedEntity.Radius, selectedEntity.Diameter(), selectedEntity.Diameter());
                }
                //Draw finished Image
                pictureBox1.CreateGraphics().DrawImageUnscaled(bufl, 0, 0);
            }

            //g.FillRectangle(new SolidBrush(Color.Red), new Rectangle(0,0, Size.Width, Size.Height));
            
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (runSimulation)
            {
                foreach (Entity entity in entities)
                {
                    entity.Update(timerInterval);
                    if (entity.canMove)
                    {
                        foreach (Entity rechteck in entities)
                        {
                            if (rechteck == entity) continue;
                            else
                            {
                                if (checkCollision(entity, rechteck))
                                {
                                    
                                    
                                    
                                }
                            }
                        }
                        
                    }
                }
            }
        }

        private bool checkCollision(Entity kreis, Entity rechteck)
        {
           
                
                if (rechteck.EShape == Entity.Shape.Rectangle) //Check for rectangles
                {
                    if(rechteck.rotation % 90 == 0) // Wenn das rechteck axenaligned ist
                    {



//                         Vector2 abstand = Vector2.Abs(kreis.Position - rechteck.Position );
//                         if (abstand.X > (rechteck.Dimension.X / 2 + kreis.Radius)) return false;
//                         if (abstand.Y > (rechteck.Dimension.Y / 2 + kreis.Radius)) return false;
//                         if (abstand.X <= (rechteck.Dimension.X / 2))
//                         {
//                         kreis.Velocity = new Vector2(-kreis.Velocity.X * 0.8f, kreis.Velocity.Y );
//                     }
//                         if (abstand.Y <= (rechteck.Dimension.Y / 2))
//                         {
//                         kreis.Velocity = new Vector2(kreis.Velocity.X, -kreis.Velocity.Y * 0.8f);
//                         }
//                         float kAbstand_qd = (abstand.X - rechteck.Dimension.X / 2) * (abstand.X - rechteck.Dimension.X / 2) + (abstand.Y - rechteck.Dimension.Y / 2) * (abstand.Y - rechteck.Dimension.Y / 2);
//                         return (kAbstand_qd <= kreis.Radius * kreis.Radius);
                    }
                else // Funktioniert noch nicht, dont bother
                {
                    for (int i = 0; i < rechteck.ShapeVectors.Length; i++)
                    {

                        Vector2 distanceToSphere = rechteck.Points[i] - kreis.Position;
                        float shapeVectorLength = rechteck.ShapeVectors[i].Length();

                        float dotProduct = Vector2.Dot(distanceToSphere, rechteck.Normals[i]);

                        Vector2 pointOnLine = rechteck.Normals[i] * dotProduct;
                        
                        Vector2 output = pointOnLine + rechteck.ShapeVectors[i];
                        if ((kreis.Position - output).Length() <= kreis.Radius)
                        {
                            Console.WriteLine("Collision!!!");
                            kreis.Velocity = Vector2.Zero;
                        }

                    }
                }


            }
            return false;
        }

        private void EnableDebugDraw_CheckedChanged(object sender, EventArgs e)
        {
            //enableDebug = enableDebugDrawCheck.Checked;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs me) 
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

        //start and pause simulation
        private void btnStartSimulation_Click(object sender, EventArgs e)
        {
            runSimulation = !runSimulation;
            if (runSimulation)
            {
                btnStartSimulation.Text = "Pause";
                if (isFirstStart)
                {
                    foreach (Entity entity in entities)
                    {
                        entity.startVelocity = entity.Velocity;
                        entity.startPosition = entity.Position;
                    }
                    isFirstStart = false;
                }
            }
            else
            {
                btnStartSimulation.Text = "Start";
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs me)
        {
            bool eFound = false;
            foreach (Entity entity in entities)
            {
                if (entity.Position.X - entity.Radius <= me.X && entity.Position.X + entity.Radius >= me.X)
                {
                    if (entity.Position.Y - entity.Radius <= me.Y && entity.Position.Y + entity.Radius >= me.Y)
                    {
                        //currentObjectLabel.Text = "Current Object: " + entity.ToString();
                        selectedEntity = entity;
                        eFound = true;
                        break;
                    }

                }
                continue;
            }
            if (!eFound)
            {
                selectedEntity = null;
                //currentObjectLabel.Text = "Current Object: None";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Entity entity in entities)
            {
                entity.Position = entity.startPosition;
                entity.Velocity = entity.startVelocity;
                entity.Acceleration = Vector2.Zero;
            }
            isFirstStart = true;
        }

        private void addSphere_Click(object sender, EventArgs e)
        { 
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void DropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
