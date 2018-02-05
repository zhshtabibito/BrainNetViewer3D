using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Modules
{
    class Node
    {
        public readonly float x;
        public readonly float y;
        public readonly float z;
        public readonly int color;
        public readonly float size;
        public readonly string label;
        
        public Node(float x, float y, float z, int color, float size, string label)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.color = color;
            this.size = size;
            this.label = label;
        }

        public void show()
        {

        }

        public void hide()
        {

        }

    }
}
