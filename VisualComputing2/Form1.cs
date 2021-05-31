using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Windows.Forms;



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


            entities.Add(new Sphere(new Vector2(200, 400), 10f, "Test Kreis"));

            entities.Add(new Rectangle(new Vector2(200, 200), "rec1", 50f, 30f, 20f));
            entities.Add(new Rectangle(new Vector2(pictureBox1.Width / 2, 0), "rec2", pictureBox1.Width, 20f, 0f));
            entities.Add(new Rectangle(new Vector2(pictureBox1.Width / 2, pictureBox1.Height), "rec3", pictureBox1.Width, 20f, 0f));
            entities.Add(new Rectangle(new Vector2(0, (pictureBox1.Height - 20) / 2), "rec4", 20f, pictureBox1.Height, 0f));
            entities.Add(new Rectangle(new Vector2(pictureBox1.Width, (pictureBox1.Height - 20) / 2), "rec5", 20f, pictureBox1.Height, 0f));
            entities.Add(new Rectangle(new Vector2(300, 500), "rec6", 300, 20f, 0f));


            //windbox
            entities.Add(new Windbox(new Vector2(200, 400), "Wind1", 400f, 100f, 50f, new Vector2(4, 0)));


            Sphere s1 = (Sphere)entities[0];

            s1.Velocity = new Vector2(5, -40);
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

        bool IsApplicationIdle()
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
                g.FillRectangle(Brushes.White, new System.Drawing.Rectangle(0, 0, this.Width, this.Height));


                //Draw every Entity in the List
                foreach (Entity entity in entities)
                {
                    //Draw Spheres
                    if (entity.GetType() == typeof(Sphere))
                    {
                        Sphere s = (Sphere)entity; // Cast Entity To Sphere to access Fields
                        g.FillEllipse(Brushes.Black, s.Position.X - s.Radius, s.Position.Y - s.Radius, s.Diameter(), s.Diameter());
                        if (enableDebug)
                        {
                            g.DrawLine(Pens.Magenta, s.Position.X, s.Position.Y, s.Position.X + s.Velocity.X, s.Position.Y + s.Velocity.Y);
                            g.DrawRectangle(Pens.LawnGreen, s.Position.X - s.Radius, s.Position.Y - s.Radius, s.Diameter(), s.Diameter());
                        }
                    }

                    if (entity.GetType() == typeof(Rectangle))
                    {
                        Rectangle r = (Rectangle)entity;
                        Vector2[] pointsVec = r.Points;
                        PointF[] points = new PointF[pointsVec.Length];
                        for (int i = 0; i < pointsVec.Length; i++)
                        {
                            points[i] = new PointF(pointsVec[i].X, pointsVec[i].Y);
                        }
                        g.FillPolygon(Brushes.Gray, points);
                        if (enableDebug)
                        {
                            for (int i = 0; i < pointsVec.Length; i++)
                            {
                                g.DrawString(i.ToString(), DefaultFont, Brushes.Maroon, points[i]);
                                if (i == pointsVec.Length - 1)
                                {
                                    Vector2 middle = pointsVec[0] - pointsVec[i];
                                    g.DrawLine(Pens.Red,
                                        pointsVec[i].X + middle.X * 0.5f,
                                        pointsVec[i].Y + middle.Y * 0.5f,
                                        (pointsVec[i].X + middle.X * 0.5f + r.Normals[i].X * 10),
                                        (pointsVec[i].Y + middle.Y * 0.5f + r.Normals[i].Y * 10));
                                }
                                else
                                {
                                    Vector2 middle = pointsVec[i + 1] - pointsVec[i];
                                    g.DrawLine(Pens.Red,
                                        pointsVec[i].X + middle.X * 0.5f,
                                        pointsVec[i].Y + middle.Y * 0.5f,
                                        (pointsVec[i].X + middle.X * 0.5f + r.Normals[i].X * 10),
                                        (pointsVec[i].Y + middle.Y * 0.5f + r.Normals[i].Y * 10));
                                }

                            }
                        }
                    }

                    if (entity.GetType() == typeof(Windbox))
                    {
                        Windbox w = (Windbox)entity;
                        g.DrawRectangle(Pens.Aqua, w.Position.X - 0.5f * w.Dimension.X, w.Position.Y - 0.5f * w.Dimension.Y, w.Dimension.X, w.Dimension.Y);
                    }


                }

                if (selectedEntity != null && selectedEntity.GetType() == typeof(Sphere))
                {
                    Sphere s = (Sphere)selectedEntity;
                    g.DrawEllipse(Pens.Turquoise, s.Position.X - s.Radius, s.Position.Y - s.Radius, s.Diameter(), s.Diameter());
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
                //für jedes Objekt in der entity liste soll update abgeführt werden
                foreach (Entity outerLoop in entities)
                {
                    if (outerLoop.GetType() == typeof(Sphere))
                    {
                        Sphere sphere = (Sphere)outerLoop;
                        sphere.Update(timerInterval);
                        foreach (Entity innerLoop in entities)
                        {

                            if (innerLoop.GetType() == typeof(Windbox))
                            {
                                Windbox windbox = (Windbox)innerLoop;
                                sphere.windAcceleration = Vector2.Zero;
                                Vector2 abstand = Vector2.Abs(sphere.Position - windbox.Position);
                                bool inwindbox = false;
                                if (abstand.X <= (windbox.Dimension.X / 2) && abstand.Y <= (windbox.Dimension.Y / 2)) inwindbox = true;
                                float kAbstand_qd = (abstand.X - windbox.Dimension.X / 2) * (abstand.X - windbox.Dimension.X / 2) + (abstand.Y - windbox.Dimension.Y / 2) * (abstand.Y - windbox.Dimension.Y / 2);
                                if (kAbstand_qd <= sphere.Radius * sphere.Radius) inwindbox = true;
                                if (inwindbox)
                                {
                                    sphere.windAcceleration += windbox.Winddirection * windbox.Windspeed;
                                    Console.WriteLine("Inside!" + outerLoop.Position.ToString());
                                }
                            }
                            //wenn dasselbe Objekt ausgewählt wurde, dann ignorier das

                        }
                    }
                }
            }
        }

        //        private bool checkCollision(Entity kreis, Entity rechteck)
        //        {


        //                if (rechteck.EShape == Entity.Shape.Rectangle) //Check for rectangles
        //                {
        //                    if(rechteck.rotation % 90 == 0) // Wenn das rechteck axenaligned ist
        //                    {



        ////                         Vector2 abstand = Vector2.Abs(kreis.Position - rechteck.Position );
        ////                         if (abstand.X > (rechteck.Dimension.X / 2 + kreis.Radius)) return false;
        ////                         if (abstand.Y > (rechteck.Dimension.Y / 2 + kreis.Radius)) return false;
        ////                         if (abstand.X <= (rechteck.Dimension.X / 2))
        ////                         {
        ////                         kreis.Velocity = new Vector2(-kreis.Velocity.X * 0.8f, kreis.Velocity.Y );
        ////                     }
        ////                         if (abstand.Y <= (rechteck.Dimension.Y / 2))
        ////                         {
        ////                         kreis.Velocity = new Vector2(kreis.Velocity.X, -kreis.Velocity.Y * 0.8f);
        ////                         }
        ////                         float kAbstand_qd = (abstand.X - rechteck.Dimension.X / 2) * (abstand.X - rechteck.Dimension.X / 2) + (abstand.Y - rechteck.Dimension.Y / 2) * (abstand.Y - rechteck.Dimension.Y / 2);
        ////                         return (kAbstand_qd <= kreis.Radius * kreis.Radius);
        //                    }
        //                else // Funktioniert noch nicht, dont bother
        //                {
        //                    for (int i = 0; i < rechteck.ShapeVectors.Length; i++)
        //                    {

        //                        Vector2 distanceToSphere = rechteck.Points[i] - kreis.Position;
        //                        float shapeVectorLength = rechteck.ShapeVectors[i].Length();

        //                        float dotProduct = Vector2.Dot(distanceToSphere, rechteck.Normals[i]);

        //                        Vector2 pointOnLine = rechteck.Normals[i] * dotProduct;

        //                        Vector2 output = pointOnLine + rechteck.ShapeVectors[i];
        //                        if ((kreis.Position - output).Length() <= kreis.Radius)
        //                        {
        //                            Console.WriteLine("Collision!!!");
        //                            kreis.Velocity = Vector2.Reflect(kreis.Velocity, rechteck.Normals[i]);
        //                        }

        //                    }
        //                }


        //            }
        //            return false;
        //        }

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
                        if (entity.GetType() == typeof(Sphere))
                        {
                            Sphere s = (Sphere)entity;
                            s.StartVelocity = s.Velocity;
                            s.StartPosition = s.Position;
                        }

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
                if (entity.GetType() == typeof(Sphere))
                {
                    Sphere s = (Sphere)entity;
                    if (s.Position.X - s.Radius <= me.X && s.Position.X + s.Radius >= me.X)
                    {
                        if (s.Position.Y - s.Radius <= me.Y && s.Position.Y + s.Radius >= me.Y)
                        {
                            //currentObjectLabel.Text = "Current Object: " + entity.ToString();
                            selectedEntity = entity;
                            eFound = true;
                            break;
                        }

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

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Entity entity in entities)
            {
                if (entity.GetType() == typeof(Sphere))
                {
                    Sphere s = (Sphere)entity;
                    s.Position = s.StartPosition;
                    s.Velocity = s.StartVelocity;
                    s.Acceleration = Vector2.Zero;
                }
            }
            isFirstStart = true;
        }

        private void addObject_Click(object sender, EventArgs e)
        {
            if (DropDownList.SelectedItem.ToString() == "Kugel")
            {
                Sphere toAdd = new Sphere(new Vector2(float.Parse(startPosX.Text), float.Parse(startPosY.Text)),
                               new Vector2(float.Parse(startVelX.Text),
                               float.Parse(startVelY.Text)),
                               textboxObjectName.Text,
                               float.Parse(massBox.Text),
                               float.Parse(radiusBox.Text),
                               checkboxGravitation.Checked,
                               checkboxWind.Checked,
                               checkboxFriction.Checked);

                entities.Add(toAdd);
            }

            if (DropDownList.SelectedItem.ToString() == "Rechteck")
            {
                Console.WriteLine("Rechteck erzeugt");

                Rectangle toAdd = new Rectangle(new Vector2(float.Parse(recPosX.Text), float.Parse(recPosY.Text)),
                                  textboxObjectName.Text,
                                  float.Parse(recWidth.Text),
                                  float.Parse(recHeight.Text),
                                  float.Parse(recAngle.Text),
                                  recRotation.Checked,
                                  float.Parse(rotationSpeed.Text));


                entities.Add(toAdd);

            }


            if (DropDownList.SelectedItem.ToString() == "Windbox")
            {
                Console.WriteLine("Windbox erzeugt");

                Windbox toAdd = new Windbox(new Vector2(float.Parse(windPosX.Text), float.Parse(windPosY.Text)),
                               textboxObjectName.Text, 
                               float.Parse(windboxWidth.Text),
                               float.Parse(windboxHeight.Text),
                               float.Parse(windSpeed.Text),
                               new Vector2(float.Parse(directionX.Text), float.Parse(directionY.Text)));

                entities.Add(toAdd);
            }
        }

        private void DropDownList_SelectedValueChanged(object sender, EventArgs e)
        {
            
            switch (DropDownList.SelectedItem.ToString())
            {
                case "Kugel":
                    recControls.Visible = false;
                    windControls.Visible = false;
                    break;
                case "Rechteck":
                    recControls.Visible = true;
                    windControls.Visible = false;
                    break;
                case "Windbox":
                    recControls.Visible = false;
                    windControls.Visible = true;
                    break;
            }

        }

        
    }
 }
