using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStaffs();
        }

        //create a new instance of the clsStaffUser
        clsStaffUser AnUser = new clsStaffUser();
        //get data from the session object
        AnUser = (clsStaffUser)Session["AnUser"];
        //display the user name
        Response.Write("Logged in as: " + AnUser.UserName);
    }

    void DisplayStaffs()
    {
        //create an instance of the Staff collection
        clsStaffCollection Staffs = new clsStaffCollection();
        //set the data source to list of addresses in the collection
        lstStaffList.DataSource = Staffs.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffID";
        //set the field to display
        lstStaffList.DataTextField = "Email";
        //bind the data to the list
        lstStaffList.DataBind();
    }




    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else     //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the delete page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else     //if no record has been selected
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the staff object
        clsStaffCollection AnStaff = new clsStaffCollection();
        //retrieve the value of Last Name from the presentation layer
        AnStaff.ReportByEmail(txtEnterEmail.Text);
        //set the data source to the list of Staffs in the collection
        lstStaffList.DataSource = AnStaff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffID";
        //set the name of the field to display
        lstStaffList.DataTextField = "Email";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the staff object
        clsStaffCollection AnStaff = new clsStaffCollection();
        //set an empty string
        AnStaff.ReportByEmail("");
        //clear any existing filter to tidy up the interface
        txtEnterEmail.Text = "";
        //set the data source to the list of staffs in the collection
        lstStaffList.DataSource = AnStaff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffID";
        //set the name of the field to display
        lstStaffList.DataTextField = "Email";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnReturnToMainMenu2_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}