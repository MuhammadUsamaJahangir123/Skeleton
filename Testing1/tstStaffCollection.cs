using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing1
{

    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //test to see if that exists
            Assert.IsNotNull(AllStaffs);
        }


        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an Item to the list
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Availability = true;
            TestItem.StaffID = 1;
            TestItem.FirstName = "Jenson";
            TestItem.LastName = "Button";
            TestItem.JoinedDate = DateTime.Now;
            TestItem.Email = "Jen.Butt12@gmail.com";
            TestItem.PhoneNo = "07812645801";

            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffs.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.StaffList, TestList);
        }

        

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.Availability = true;
            TestStaff.StaffID = 1;
            TestStaff.FirstName = "Jenson";
            TestStaff.LastName = "Button";
            TestStaff.JoinedDate = DateTime.Now;
            TestStaff.Email = "Jen.Butt12@gmail.com";
            TestStaff.PhoneNo = "07812645801";

            //assign the data to the property
            AllStaffs.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);
        }


        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Availability = true;
            TestItem.StaffID = 1;
            TestItem.FirstName = "Jenson";
            TestItem.LastName = "Button";
            TestItem.JoinedDate = DateTime.Now;
            TestItem.Email = "Jen.Butt12@gmail.com";
            TestItem.PhoneNo = "07812645801";

            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffs.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.Count, TestList.Count);

        }

        


    }
}
