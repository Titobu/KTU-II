using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L1U1_Kvadratai_kvadrate
{
    public class Points
    {
        private Point[] allPoints = new Point[10];
        private int pointCounter;

        private int[][] map;
        private int mapSize;
    
    
        public void Add(Point point)
        {
            this.allPoints[pointCounter++] = point;
        }

        public Point Get(int index)
        {
            return this.allPoints[index];
        }

        public int[][] Map { get; set; }

        public int MapSize { get; set; }

    }
}