using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //capture the FirstName
        AnStaff.FirstName = txtFIrstName.Text;
        //capture the LastName
        AnStaff.LastName = txtLastName.Text;
        //capture the JoinedDate
        AnStaff.DateAdded = Convert.ToDateTime(DateTime.Now);
        //capture the email
        AnStaff.Email = txtEmail.Text;
        //capture the availability checkBox
        AnStaff.Availability = chkAvailability.Checked;
        //store the staff in the session object
        Session["AnStaff"] = AnStaff;
        //navigate to the view page
        Response.Redirect("StaffViewer.aspx");
    }
}