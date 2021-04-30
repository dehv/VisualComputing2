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
        float rotation;
        float mass = 1f;
        float drag = 0f;
        public bool canMove { get; set; }
        
        public Shape EShape { get; }

        public float Radius { get; }

        public Color color;


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

        public void Update(float timerInterval) 
        {
            //Velocity Verlet Calculation
            timerInterval = timerInterval / 1000;
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
            Vector2 gravity = new Vector2(0, Form1.gravity);
            Vector2 drag_force = 0.5f * drag * (Velocity * Vector2.Abs(Velocity));
            Vector2 drag_acc = drag_force / mass;
            return gravity - drag_acc;
        }

    }
}
