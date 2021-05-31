using System.Numerics;

namespace VisualComputing2
{
    class Windbox : Entity
    {
        public Vector2 Dimension { get; set; }
        public Vector2 Winddirection { get; set; }
        public float Windspeed { get; set; }
        public Windbox(Vector2 pos, string name, float width, float height, float windspeed, Vector2 winddirection)
            : base(pos, name)
        {
            Position = pos;
            Dimension = new Vector2(width, height);
            Winddirection = Vector2.Normalize(winddirection);
            Windspeed = windspeed;

        }

        public override void Update(float timerInterval)
        {
            return;
        }
    }
}
