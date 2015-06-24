using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //what is has to validate on login
        //instruktører_id = what Table/DB to validate
        if (Session["instruktører_id"] != null)
        {
            //Login button
            Button_logout.Visible = true;
            //instruktører_navn = Validate the name 
            string navn = Session["instruktører_navn"].ToString();

            //Name on the loged person
            Label_navn.Text = "" + name + "";

            string billede = Session["instruktører_id"].ToString();
        }
        else
        {
            //If login failed 
            Response.Redirect("Code/login.aspx");
        }
    }

    protected void Button_logout_Click(object sender, EventArgs e)
    {
        //on click for Logout Button
        Session.Abandon();
        Response.Redirect("http://localhost:55153/Default.aspx");
    }
}
