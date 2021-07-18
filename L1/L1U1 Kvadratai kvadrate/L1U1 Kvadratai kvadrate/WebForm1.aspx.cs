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
            DisplayResult(points);

            //Sukurti klasę Square
            Square square = new Square();
            square.Add(points.Get(0));
            square.Add(points.Get(2));
            square.Add(points.Get(6));
            square.Add(points.Get(3));

            //Sukurti klasę Squares
            Squares squares = new Squares();
            squares.Add(square);

            //Sukurti funkciją findSquare()
            //Sukurti rekursinę funkciją checkNextPoint()

            //Įrašyti resultatus į failą
            //Atvaizduoti rezultatus ekrane
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        private void DisplayResult(Points points)
        {
            int[][] map = points.Map;

            //display map size
            TableCell cellN = new TableCell();
            cellN.Text =points.MapSize.ToString();
            TableRow rowN = new TableRow();
            rowN.Cells.Add(cellN);
            Table1.Rows.Add(rowN);

            //display map
            for (int i = 0; i < points.MapSize; i++)
            {
                TableRow row = new TableRow();

                for (int j = 0; j < points.MapSize; j++)
                {
                    TableCell cell = new TableCell();
                    cell.Text = map[i][j].ToString();

                    
                    row.Cells.Add(cell);
                }

                Table1.Rows.Add(row);
            }
        }
    }
}