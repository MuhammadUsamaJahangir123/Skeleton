﻿using System;
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
        AnStaff.FirstName = txtFirstName.Text;
        //capture the LastName
        AnStaff.LastName = txtLastName.Text;
        //capture the JoinedDate
        AnStaff.JoinedDate = Convert.ToDateTime(DateTime.Now);
        //capture the email
        AnStaff.Email = txtEmail.Text;
        //capture the Phone No
        AnStaff.PhoneNo = txtPhoneNo.Text;
        //capture the availability checkBox
        AnStaff.Availability = chkAvailability.Checked;
      
        //store the staff in the session object
        Session["AnStaff"] = AnStaff;
        //navigate to the view page
        Response.Redirect("StaffViewer.aspx");
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