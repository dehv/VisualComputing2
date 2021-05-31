﻿using System.Numerics;

namespace VisualComputing2
{
    class Sphere : Entity
    {
        public Vector2 Velocity { get; set; }
        public Vector2 Acceleration { get; set; }
        // Für das Reseten der Simulation werden beim Start die Startposition und Geschwindigkeit gespeichert.
        public Vector2 StartPosition { get; set; }
        public Vector2 StartVelocity { get; set; }
        public float Mass { get; set; }
        public float Drag { get; set; }
        public float Radius { get; private set; }
        public float Diameter() { return Radius * 2; }
        public bool CanMove { get; set; }
        public bool UsesGravity { get; set; }
        public bool UsesWind { get; set; }
        public bool UsesDrag { get; set; }

        public Sphere(Vector2 pos, Vector2 vel, string name, float mass, float radius, bool g, bool wind, bool drag)
            : base(pos, name)
        {

            Velocity = vel;
            Mass = mass;
            Radius = radius;
            UsesGravity = g;
            UsesWind = wind;
            UsesDrag = drag;
            CanMove = true;
        }

        public Sphere(Vector2 pos, float radius, string name)
            : base(pos, name)
        {
            Radius = radius;
            Mass = 1f;
            UsesGravity = true;
            UsesWind = true;
            UsesDrag = false;
            CanMove = true;
        }

        public override void Update(float timerInterval)
        {
            if (!CanMove) return;
            //Velocity Verlet Calculation
            timerInterval = timerInterval / 100;
            Vector2 newPosition = Position + Velocity * timerInterval + Acceleration * (timerInterval * timerInterval * 0.5f);
            Vector2 newAcceleration = ApplyForces();
            Vector2 newVelocity = Velocity + (Acceleration + newAcceleration) * (timerInterval * 0.5f);

            Position = newPosition;
            Velocity = newVelocity;
            Acceleration = newAcceleration;
        }


        public Vector2 windAcceleration = Vector2.Zero;
        private Vector2 ApplyForces()
        {
            Vector2 gravity = Vector2.Zero;
            if (UsesGravity)
            {
                gravity = new Vector2(0, Form1.gravity);
            }
            Vector2 drag_force = 0.5f * Drag * (Velocity * Vector2.Abs(Velocity));
            Vector2 drag_acc = drag_force / Mass;
            return gravity - drag_acc + windAcceleration;
        }
    }
}
