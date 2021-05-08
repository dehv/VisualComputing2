using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Drawing;

namespace VisualComputing2
{
    public class Entity
    {
        //Material material;
        public Vector2 Position { get; set; }
        public Vector2 Velocity { get; set; }
        public Vector2 Acceleration { get; set; }
        public float rotation;
        float mass = 1f;
        float drag = 0f;
        public bool canMove { get; set; }
        
        public Shape EShape { get; }

        public float Radius { get; }

        public Color color;

        public Vector2 Dimension { get; set; }
        public Vector2[] Points;
        public Vector2[] ShapeVectors;
        public Vector2[] Normals;


        public enum Shape 
        {
            Sphere,
            Rectangle
        }

        //Constructor for Sphere
        public Entity(Vector2 pos, bool canMove, float radius) 
        {
          
            Position = pos;
            this.canMove = canMove;
            EShape = Shape.Sphere;
            Radius = radius;
        }

        //Constructor for Rectangle
        public Entity(Vector2 pos, float width, float hight, float rotation)
        {
            Position = pos;
            this.canMove = false;
            EShape = Shape.Rectangle;
            Dimension = new Vector2(width, hight);
            this.rotation = rotation;
            Points = GetRectPoints();
            Normals = GetNormals(Points);
            ShapeVectors = getShapeVectors(Points);
        }

        public float Diameter() 
        {
            return Radius * 2;
        }

        public Vector2[] GetRectPoints()
        {
            Vector2[] arr = new Vector2[4];
            arr[0] = Position - 0.5f * Dimension;
            arr[1] = Position + 0.5f * Vector2.Reflect(Dimension, Vector2.UnitX);
            arr[2] = Position + 0.5f * Dimension;
            arr[3] = Position - 0.5f * Vector2.Reflect(Dimension, Vector2.UnitX);

            double angle = rotation * Math.PI / 180;
            for (int i = 0; i < arr.Length; i++) //Rotation der Punkte
            {
                arr[i].Y = (float)(arr[i].Y * Math.Cos(angle) - arr[i].X * Math.Sin(angle));
                arr[i].X = (float)(arr[i].Y * Math.Sin(angle) + arr[i].X * Math.Cos(angle));
            }
            return arr;
        }

        public Vector2[] GetNormals(Vector2[] points)
        {
            Vector2[] normals = new Vector2[points.Length];
            for (int i = 0; i < points.Length; i++)
            {
                if(i == points.Length - 1)
                {
                    normals[i] = new Vector2(-(points[0].Y - points[i].Y), points[0].X - points[i].X);
                }
                else
                {
                    normals[i] = new Vector2(-(points[i + 1].Y - points[i].Y), points[i + 1].X - points[i].X);
                }
                normals[i] = Vector2.Normalize(normals[i]);
            }
            return normals;
        }

        public Vector2[] getShapeVectors(Vector2[] points)
        {
            Vector2[] shapeVectors = new Vector2[points.Length]; // Vektoren der Form bestimmen
            for (int i = 0; i < points.Length; i++)
            {
                if (i == points.Length-1)
                {
                    shapeVectors[i] = points[0] - points[i];
                }
                else
                {
                    shapeVectors[i] = points[i + 1] - points[i];
                    
                }
            }
            return shapeVectors;
        }

        public void Update(float timerInterval) 
        {
            //Velocity Verlet Calculation
            timerInterval = 1 /timerInterval;
            if (!canMove) return;
            Vector2 newPosition = Position + Velocity * timerInterval + Acceleration * (timerInterval * timerInterval * 0.5f);
            Vector2 newAcceleration = ApplyForces();
            Vector2 newVelocity = Velocity + (Acceleration + newAcceleration) * (timerInterval * 0.5f);

            Position = newPosition;
            Velocity = newVelocity;
            Acceleration = newAcceleration;
        }

        private Vector2 ApplyForces()
        {
            Vector2 gravity = Vector2.Zero;
            if (Form1.useGravity)
            {
                gravity = new Vector2(0, Form1.gravity);
            }
            Vector2 drag_force = 0.5f * drag * (Velocity * Vector2.Abs(Velocity));
            Vector2 drag_acc = drag_force / mass;
            return gravity - drag_acc;
        }

    

    }
}
