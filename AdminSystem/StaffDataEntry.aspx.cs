using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the priamry key withpage level scope
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            //if tere is not a new record
            if (StaffID != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }
    }

    void DisplayStaff()
    {
        //create an instance of the staff
        clsStaffCollection Staff = new clsStaffCollection();
        //find the record to update
        Staff.ThisStaff.Find(StaffID);



        //////////////////////////////////////////////////////////

        //////      Missing code        ///////

        /////////////////////////////////////////////////////////////
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //capture the FirstName
        string FirstName = txtFirstName.Text;
        //capture the LastName
        string LastName = txtLastName.Text;
        //capture the JoinedDate
        string JoinedDate = txtJoinedDate.Text;
        //capture the email
        string Email = txtEmail.Text;
        //capture the Phone No
        string PhoneNo = txtPhoneNo.Text;
        //capture the availability checkBox
        string Availability = chkAvailability.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnStaff.Valid(FirstName, LastName, Email, PhoneNo, JoinedDate);
        if (Error == "")
        {
            //capture the FIRSTNAME
            AnStaff.FirstName = FirstName;
            //capture the LASTNAME
            AnStaff.LastName = LastName;
            //capture the EMAIL
            AnStaff.Email = Email;
            //capture the PHONE NO
            AnStaff.PhoneNo = PhoneNo;
            AnStaff.JoinedDate = Convert.ToDateTime(JoinedDate);
            AnStaff.Availability = chkAvailability.Checked;
            //create a new instance of the address collection
            clsStaffCollection StaffList = new clsStaffCollection();
            //set the ThisStaff property
            StaffList.ThisStaff = AnStaff;
            //add the new record
            StaffList.Add();
            //redirect back to the list page
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff AnStaff = new clsStaff();
        //create a variable to store the primary key
        Int32 StaffID;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffID = Convert.ToInt32(txtStaffID.Text);
        //find the record
        Found = AnStaff.Find(StaffID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtFirstName.Text = AnStaff.FirstName;
            txtLastName.Text = AnStaff.LastName;
            txtJoinedDate.Text = AnStaff.JoinedDate.ToString();
            chkAvailability.Checked = AnStaff.Availability;
            txtEmail.Text = AnStaff.Email;
            txtPhoneNo.Text = AnStaff.PhoneNo;
        }

    }

}