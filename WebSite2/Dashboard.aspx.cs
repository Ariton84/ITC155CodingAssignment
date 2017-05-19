using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Dashboard : System.Web.UI.Page
{
    Notification n = new Notification();
    student s = new student();

    protected void Page_Load(object sender, EventArgs e)
    {
        n.date = DateTime.Today.ToString("MM/dd/yyyy");
        n.note = "This is your notification";

        s.credits = 25;
        s.firstName = "Griffin";
        s.lastName = "Dotson";
        s.major = "Programing";
        s.currentClasses = new string[2] { "class1", "class2" };
        s.completedClasses = new string[4] { "class3", "class4", "class5", "class6" };

        NameLabel.Text = s.display();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        NoteLabel.Text = n.getNote().ToString();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        NoteLabel.Text = s.viewCurClasses();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        NoteLabel.Text = s.viewCompClasses();
    }
}