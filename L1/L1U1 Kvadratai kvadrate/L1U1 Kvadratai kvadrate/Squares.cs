using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L1U1_Kvadratai_kvadrate
{
    public class Squares
    {
        private Square[] squares = new Square[10];
        private int counter;

        public Square Get(int index)
        {
            return this.squares[index];
        }

        public void Add(Square squares)
        {
            this.squares[counter++] = squares;
        }
    }
}