using System;
using System.Numerics;

namespace VisualComputing2
{
    class Rectangle : Entity
    {
        public bool Rotating { get; set; }
        public float Rotationangle { get; set; }
        public float RotationSpeed { get; set; }
        public Vector2 Dimension { get; set; }
        public Vector2[] Points;
        public Vector2[] ShapeVectors;
        public Vector2[] Normals;

        public Rectangle(Vector2 pos, string name, float width, float height, float rotationangle, bool rotating, float rotationspeed)
            : base(pos, name)
        {
            Dimension = new Vector2(width, height);
            Rotationangle = rotationangle;
            Points = GetRectPoints();
            Normals = GetNormals(Points);
            ShapeVectors = getShapeVectors(Points);
        }

        public Rectangle(Vector2 pos, string name, float width, float height, float rotation)
          : base(pos, name)
        {
            Dimension = new Vector2(width, height);
            Rotationangle = rotation;
            Points = GetRectPoints();
            Normals = GetNormals(Points);
            ShapeVectors = getShapeVectors(Points);
        }

        public Vector2[] GetRectPoints()
        {
            Vector2[] arr = new Vector2[4];
            arr[0] = Position - 0.5f * Dimension;
            arr[1] = Position + 0.5f * Vector2.Reflect(Dimension, Vector2.UnitX);
            arr[2] = Position + 0.5f * Dimension;
            arr[3] = Position - 0.5f * Vector2.Reflect(Dimension, Vector2.UnitX);

            double angle = Rotationangle * Math.PI / 180;
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
                if (i == points.Length - 1)
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
                if (i == points.Length - 1)
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

        public override void Update(float timerInterval)
        {
            if (Rotating)
            {
                Rotationangle += RotationSpeed * timerInterval / 1000;
                Points = GetRectPoints();
                Normals = GetNormals(Points);
                ShapeVectors = getShapeVectors(Points);
            }
        }
    }
}
