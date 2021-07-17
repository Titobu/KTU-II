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

            //create map
            int[][] map = new int[n][];

            //read map
            string[] line = new string[] { };
            for (int i = 0; i < n; i++)
            {
                line = lines[i + 1].Split(new string[] { " " }, StringSplitOptions.None);
                map[i] = Array.ConvertAll(line, s => int.Parse(s));

                for (int j = 0; j < n; j++)
                {                
                    //find point where value == 1
                    if(Int32.Parse(line[j]) == 1)
                    {
                        //create new Point object 
                        Point point = new Point(new int[] { i+1, j+1 }, new int[] { 0, 0 }, new int[] { 0, 0 }, 0);
                        //add created object to container Points class
                        points.Add(point);
                    }
                }
            }

            //set map
            points.Map = map;

            //set map size
            points.MapSize = n;

            //return Points class
            return points;
        }

        public static void PrintMap(string fileName, Points points)
        {
            string[] Lines = new string[points.MapSize + 1];

            Lines[0] = points.MapSize.ToString();

            int[][] map = points.Map;
            for(int i = 0; i < points.MapSize; i++)
            {

                Lines[i + 1] = string.Join(" ", map[i]);
            }

            File.AppendAllLines(fileName, Lines);
        }
    }
}