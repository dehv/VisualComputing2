using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace VisualComputing2
{
    abstract class Entity
    {
        Vector2 position;
        Vector2 speed;
        Vector2 acceleration;
        float rotation;
        float mass;
        bool canMove;

        public abstract void Draw();

        public abstract void Update();


    }
}
