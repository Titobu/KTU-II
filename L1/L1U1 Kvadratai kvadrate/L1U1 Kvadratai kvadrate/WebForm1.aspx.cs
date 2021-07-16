using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace L1U1_Kvadratai_kvadrate
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Sukurti klasę Point
            Point point2 = new Point(new int[] { 1, 1 }, new int[] { 2, 2 }, 3);

            //Sukurti konteinerinę klasę Points
            Points points = new Points();
            points.Add(point2);

            //Nuskaityti duomenis

            //Įrašyti pradinius duomenis į failą
            //Atvaizduoti pradinius duomenis ekrane

            //Sukurti klasę Square
            //Sukurti klasę Squares

            //Sukurti funkciją findSquare()
            //Sukurti rekursinę funkciją checkNextPoint()

            //Įrašyti resultatus į failą
            //Atvaizduoti rezultatus ekrane
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}