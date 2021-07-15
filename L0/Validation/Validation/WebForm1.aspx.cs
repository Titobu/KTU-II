using System;
using System.Collections.Generic;
using System.Data;
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
            //set CheckBoxList1 data
            if (CheckBoxList1.Items.Count == 0)
            {
                setDataToCheckBoxList1();
            }

            //set age list data
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

            //set languages field from session
            if (Session["languages"] != null)
            {
                setSelectedLanguages();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["name"] = TextBox1.Text;
            Session["surname"] = TextBox2.Text;
            Session["school"] = TextBox3.Text;
            Session["age"] = DropDownList1.SelectedValue;
            Session["languages"] = getSelectedLanguages();
        }

        private string[] getSelectedLanguages()
        {
            string[] result = new string[0];
            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected == true)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.GetUpperBound(0)] = item.Value;
                }
            }

            return result;
        }

        private void setSelectedLanguages()
        {
            string[] languages = (string[])Session["languages"];

            if (CheckBoxList1.Items.Count > 0)
            {
                foreach (ListItem li in CheckBoxList1.Items)
                {
                    if (Array.Exists(languages, element => element == li.Value))
                    {
                        li.Selected = true;
                    }
                }
            }
        }

        private void setDataToCheckBoxList1()
        {
            DataSet dsServices = new DataSet(); dsServices.ReadXml(MapPath("App_Data/languages.xml"));
            CheckBoxList1.DataSource = dsServices;

            CheckBoxList1.DataValueField = "pavadinimas";

            CheckBoxList1.DataTextField = "pavadinimas";
            CheckBoxList1.DataBind();
        }
    }
}