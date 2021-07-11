using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
    
        protected void Page_Load(object sender, EventArgs e)
        {
            //set age list
            if (DropDownList1.Items.Count == 0)
            {
                DropDownList1.Items.Add("---------- ");
            
                for (int i = 14; i < 25; i++)
                {
                    DropDownList1.Items.Add(i.ToString());
                }

                //set age field from session
                if (Session["age"] != null)
                {
                    DropDownList1.Items.FindByValue((string)Session["age"]).Selected = true;
                }
            }

            //set name field from session
            if (Session["name"] != null)
            {
                TextBox1.Text = (string)Session["name"];
            }

            //set surname field from session
            if (Session["surname"] != null)
            {
                TextBox2.Text = (string)Session["surname"];
            }

            //set school field from session
            if (Session["school"] != null)
            {
                TextBox3.Text = (string)Session["school"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["name"] = TextBox1.Text;
            Session["surname"] = TextBox2.Text;
            Session["school"] = TextBox3.Text;
            Session["age"] = DropDownList1.SelectedValue;
        }
    }
}