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
            const string CFD1 = "~/App_Data/U1.txt";
            const string CFR = "~/App_Data/Rezultatai.txt";

            //Sukurti klasę Point

            //Sukurti konteinerinę klasę Points
            Points points = new Points();

            //Nuskaityti duomenis
            points = InOutUtil.ReadPoints(Server.MapPath(CFD1));

            //Įrašyti pradinius duomenis į failą
            InOutUtil.PrintMap(Server.MapPath(CFR), points);

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