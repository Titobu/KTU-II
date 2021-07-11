using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String savedText = (string)Session["text"];
            PutText(savedText);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string newText = TextBox1.Text;
            PutText(newText);

            // saving value to session
            Session["text"] = newText;
        }

        private void PutText(string newText)
        {
            TableCell cell = new TableCell();
            cell.Text = newText;

            TableRow row = new TableRow();
            row.Cells.Add(cell);

            Table1.Rows.Add(row);
        }
    }
}