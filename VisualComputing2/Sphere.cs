using System.Numerics;

namespace VisualComputing2
{
    class Sphere : Entity , ICloneable
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
            Vector2 newVelocity = Velocity + (newAcceleration + newAcceleration) * (timerInterval * 0.5f);

            Position = newPosition;
            Velocity = newVelocity;
            Acceleration = newAcceleration;
        }


        public Vector2 windAcceleration = Vector2.Zero;
        public bool IsRolling {get; set;}
        public Vector2 RollingNormal {get;set;}
        public Rectangle PlattformRollingOn;
        public bool JustStartedRolling { get; set; }
        private Vector2 ApplyForces()
        {
            Vector2 gravity = Vector2.Zero;
            if (UsesGravity)
            {
                gravity = new Vector2(0, Form1.gravity);
            }
            
            if(IsRolling)
            {

                float winkel = (float) (PlattformRollingOn.Rotation * Math.PI / 180f);
                Vector2 V_GH = new Vector2((float)Math.Cos(winkel),(float)Math.Cos(90-winkel));
                //if (Velocity.X < 0) V_GH = -V_GH;
                V_GH = Vector2.Reflect(-V_GH, Vector2.UnitX);
                float F_GH = gravity.Length()*(float)Math.Sin(winkel);
                gravity = F_GH * V_GH;
                if (!JustStartedRolling)
                {
                    JustStartedRolling = true;
                    Velocity = gravity;
                    Acceleration = gravity;
                }
                
            }
            Vector2 drag_force = 0.5f * Drag * (Velocity * Vector2.Abs(Velocity));
            Vector2 drag_acc = drag_force / Mass;
            return gravity - drag_acc + windAcceleration;
        }

        public object Clone()
        {
            Sphere returnS = new Sphere(new Vector2(Position.X, Position.Y), new Vector2(Velocity.X, Velocity.Y), (string)Name.Clone(), Mass, Radius, UsesGravity, UsesWind, UsesDrag);
            returnS.Acceleration = new Vector2(Acceleration.X, Acceleration.Y);
            return returnS;
        }
    }
}
