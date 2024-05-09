using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance
        clsSupplier ASupplier = new clsSupplier();
        //get the data from session
        ASupplier = (clsSupplier)Session["ASupplier"];
        //Display the name
        Response.Write(ASupplier.SupplierName);
        //Display ID
        Response.Write(ASupplier.SupplierId);
        //Display contact information
        Response.Write(ASupplier.ContactInfo);
        //Display date joined
        Response.Write(ASupplier.DateAdded);
        //Display Active
        Response.Write(ASupplier.Active);

    }
}