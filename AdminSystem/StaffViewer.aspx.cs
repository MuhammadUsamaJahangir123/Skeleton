using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create and instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //get the data from the session object
        AnStaff = (clsStaff)Session["AnStaff"];
        //display the First Name for this entry
        Response.Write(AnStaff.FirstName);
        //display the Last Name for this entry
        Response.Write(AnStaff.LastName);
        //display the Joined Date for this entry
        Response.Write(AnStaff.DateAdded);
        //display the Email for this entry
        Response.Write(AnStaff.Email);
        //display the Availability
        Response.Write(AnStaff.Availability);
    }
}