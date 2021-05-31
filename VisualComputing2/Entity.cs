using System.Drawing;
using System.Numerics;

namespace VisualComputing2
{
    public abstract class Entity
    {
        public Vector2 Position { get; set; }
        public string Name { get; set; }
        public Color color;

        public Entity(Vector2 pos, string name, Color color)
        {
            Position = pos;
            Name = name;
            this.color = color;
        }

        public Entity(Vector2 pos, string name)
        {
            Position = pos;
            Name = name;
            color = Color.Black;
        }



        public abstract void Update(float timerInterval);





    }
}
