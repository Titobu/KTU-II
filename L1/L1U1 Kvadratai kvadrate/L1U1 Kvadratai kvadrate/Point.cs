using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L1U1_Kvadratai_kvadrate
{
    public class Point
    {
        private int[] locationCoordinates;
        private int[] beginCoordinates;
        private int[] fromCoordinates;

        private int counter;

        public Point()
        {
            this.locationCoordinates = new int[] { 0, 0 };
            this.beginCoordinates = new int[] { 0, 0 };
            this.fromCoordinates = new int[] { 0, 0 };
            this.counter = 0;
        }

        public Point(int[] locationCoordinates, int[] beginCoordinates, int[] fromCoordinates, int counter)
        {
            this.locationCoordinates = locationCoordinates;
            this.beginCoordinates = beginCoordinates;
            this.fromCoordinates = fromCoordinates;
            this.counter = counter;
        }

        public int[] BeginCoordinates { get; set; }
        public int[] FromCoordinates { get; set; }
        public int Counter { get; set; }
    }
}