using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Modules
{
    class Edge
    {
        public Node node1;
        public Node node2;
        public float weight;

        public Edge(Node node1, Node node2, float weight)
        {
            this.node1 = node1;
            this.node2 = node2;
            this.weight = weight;
        }

        public void show()
        {

        }

        public void hide()
        {

        }

    }
}
