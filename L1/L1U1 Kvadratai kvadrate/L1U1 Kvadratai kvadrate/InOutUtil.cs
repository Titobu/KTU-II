using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace L1U1_Kvadratai_kvadrate
{
    public class InOutUtil
    {
        public static Points ReadPoints(string fileName)
        {
            Points points = new Points();
            // get n;
            string[] lines = File.ReadAllLines(fileName, Encoding.UTF8);
            int n = Int32.Parse(lines[0]);

            //foreach y = i
            string[] line = new string[] { };
            for (int i = 0; i < n; i++)
            {
                line = lines[i + 1].Split(new string[] { " " }, StringSplitOptions.None);
                
                for(int j = 0; j < n; j++)
                {
                    if(Int32.Parse(line[j]) == 1)
                    {
                        Point point = new Point(new int[] { i+1, j+1 }, new int[] { 0, 0 }, new int[] { 0, 0 }, 0);
                        points.Add(point);
                    }
                }
            }
            //foreach x = j
            //if j == 1
            //set to Point class
            //set Point class to Points class

            //return Points class
            return points;
        }
    }
}