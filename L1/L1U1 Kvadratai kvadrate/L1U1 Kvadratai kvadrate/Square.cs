using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L1U1_Kvadratai_kvadrate
{
    public class Square
    {
        private Point[] points = new Point[4];
        private int pointsCounter;

        public Point Get(int index)
        {
            return this.points[index];
        }

        public void Add(Point point)
        {
            this.points[pointsCounter++] = point;
        }
    }
}