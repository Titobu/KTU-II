using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validation
{

    public class Student
    {
        private string name;
        private string surname;
        private string school;
        private int age;
        private string[] languages;

        public Student(string name, string surname, string school, int age, string[] languages)
        {
            this.name = name;
            this.surname = surname;
            this.school = school;
            this.age = age;
            this.languages = languages;
        }

        public string Name { get { return name; } set { name = value; } }

        public string Surname { get { return surname; } set { surname = value; } }

        public string School { get { return school; } set { school = value; } }

        public int Age { get { return age; } set { age = value; } }

        public string[] Languages { get { return languages; } set { languages = value; } }

    }
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

            displayDataOfRegisteredStudents();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            save();

            displayDataOfRegisteredStudents();
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

        private void save()
        {

            if (validateInputs())
            {
                var students = new List<Student>();
                string[] languages = getSelectedLanguages();
                if (Session["savedDataOfRegisteredStudents"] != null)
                {
                    students = (List<Student>)Session["savedDataOfRegisteredStudents"];
                }

                students.Add(new Student(TextBox1.Text, TextBox2.Text, TextBox3.Text, Int32.Parse(DropDownList1.SelectedValue), languages));

                Session["savedDataOfRegisteredStudents"] = students;
            }
        }

        private void displayDataOfRegisteredStudents()
        {
            int nrCount = 0;
            Table1.Rows.Clear();

            if (Session["savedDataOfRegisteredStudents"] != null)
            {
                var students = (List<Student>)Session["savedDataOfRegisteredStudents"];

                foreach (Student student in students)
                {
                    nrCount++;
                    TableRow row = new TableRow();

                    TableCell nr = new TableCell();
                    nr.Text = nrCount.ToString();
                    row.Cells.Add(nr);

                    TableCell surname = new TableCell();
                    surname.Text = student.Surname;
                    row.Cells.Add(surname);

                    TableCell school = new TableCell();
                    school.Text = student.School;
                    row.Cells.Add(school);

                    TableCell age = new TableCell();
                    age.Text = student.Age.ToString();
                    row.Cells.Add(age);

                    TableCell languages = new TableCell();
                    string str = String.Join(", ", student.Languages);
                    languages.Text = str;
                    row.Cells.Add(languages);

                    Table1.Rows.Add(row);
                }
                
            }
            
            Label7.Text = "Viso dalyvių: " + (nrCount);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Contents.RemoveAll();

            displayDataOfRegisteredStudents();
        }

        private bool validateInputs()
        {
            //validate name
            if ((TextBox1.Text == null) || (TextBox1.Text == ""))
            {
                return false;
            }

            if ((TextBox1.Text.Count() > 20) || (TextBox1.Text.Count() < 2))
            {
                return false;
            }

            //validate surname
            if ((TextBox2.Text == null) || (TextBox2.Text == ""))
            {
                return false;
            }

            if ((TextBox2.Text.Count() > 30) || (TextBox2.Text.Count() < 2))
            {
                return false;
            }

            //validate school
            if ((TextBox3.Text == null) || (TextBox3.Text == ""))
            {
                return false;
            }

            if ((TextBox3.Text.Count() > 40) || (TextBox3.Text.Count() < 2))
            {
                return false;
            }

            //validate age
            if ((DropDownList1.SelectedValue == null) || (DropDownList1.SelectedValue == ""))
            {
                return false;
            }

            if ((Int32.Parse(DropDownList1.SelectedValue) < 14) || (Int32.Parse(DropDownList1.SelectedValue) > 24))
            {
                return false;
            }


            return true;
        }
    }
}