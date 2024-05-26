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


        ///////////////////     PRACTICAL 13A       ////////////////////////
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instane of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Availability = true;
            TestItem.StaffID = 1;
            TestItem.FirstName = "Jenson";
            TestItem.LastName = "Button";
            TestItem.JoinedDate = DateTime.Now;
            TestItem.Email = "Jen.Butt12@gmail.com";
            TestItem.PhoneNo = "07812645801";

            //set ThisAddress to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);

        }


        ///////////////////     Practical 13B       //////////////////
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Availability = true;
            TestItem.FirstName = "Jenson";
            TestItem.LastName = "Button";
            TestItem.JoinedDate = DateTime.Now;
            TestItem.Email = "Jen.Butt12@gmail.com";
            TestItem.PhoneNo = "07812645801";

            //set ThisStaff to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;

            //modify the test record
            TestItem.Availability = false;
            TestItem.FirstName = "Muhammad";
            TestItem.LastName = "Usama";
            TestItem.JoinedDate = DateTime.Now;
            TestItem.Email = "Muh_Us11@yahoo.com";
            TestItem.PhoneNo = "04985456321";

            //set the record based on the new test data
            AllStaffs.ThisStaff = TestItem;
            //update the record
            AllStaffs.Update();
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see if ThisStaff matches the test data
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);


        }



        /////////////////////       Practical 14A       /////////////
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Availability = true;
            TestItem.StaffID = 1;
            TestItem.FirstName = "Jenson";
            TestItem.LastName = "Button";
            TestItem.JoinedDate = DateTime.Now;
            TestItem.Email = "Jen.Butt12@gmail.com";
            TestItem.PhoneNo = "07812645801";

            //set ThisStaff to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaffs.Delete();
            //now find the record
            Boolean Found = AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }



        ///////////////////     PRACTICAL 14B       //////////////////
        [TestMethod]
        public void ReportByEmailMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //apply a blank string (should return all record)
            FilteredStaffs.ReportByEmail("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.Count, FilteredStaffs.Count);
        }


        [TestMethod]
        public void ReportByEmailNoneFound()
        {
            //create an instance of the class we want to create
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //apply an Email that doesn't exist
            FilteredStaffs.ReportByEmail("gam1l.com");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaffs.Count);
        }



        [TestMethod]
        public void ReportByEmailTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply an Email 
            FilteredStaffs.ReportByEmail("Muh_Us11@yahoo.com");
            //check that the correct number of records are found
            if (FilteredStaffs.Count == 2)
            {
                //check to see that the first record is 115
                if (FilteredStaffs.StaffList[0].StaffID != 115)
                {
                    OK = false;
                }
                //check to see that the first record is 116
                if (FilteredStaffs.StaffList[1].StaffID != 116)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }

        


    }
}
