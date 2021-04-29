using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace VisualComputing2
{
    public class Entity
    {
        //Material material;
        public Vector2 Position { get; set; }
        Vector2 velocity;
        public Vector2 Acceleration { get; set; }
        float rotation;
        float mass;
        bool canMove;
        public Shape EShape { get; }

        public float Radius { get; }


        public enum Shape 
        {
            Sphere,
            Rectangle
        }

        public Entity(Vector2 pos, bool canMove, Shape shape, float radius) 
        {
            Position = pos;
            this.canMove = canMove;
            EShape = shape;
            Radius = radius;
        }

        public float Diameter() 
        {
            return Radius * 2;
        }

        public void Update() 
        {
            
            velocity += Acceleration * 0.1f;
            Position += velocity * 0.1f;
        }

    }
}
