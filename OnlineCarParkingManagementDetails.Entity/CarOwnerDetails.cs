using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCarParkingManagementDetails.Entity
{
    public enum Role
    {
        Customer,
        CarParkingSiteOwner
    }
    public class CarOwnerDetails
    {
        
        public string name { get; set; }
        public string gender { get; set; }
        public long mobileNo { get; set; }
        public string address { get; set; }
        public string emailId { get; set; }
        public string password { get; set; }
        public string conformPassword { get; set; }
        public Role UserRole { get; set; }
        public CarOwnerDetails()
        {

        }
        public CarOwnerDetails(string Name, string Gender,long MobileNo, string location,string EmailId,string Password,string conformpassword,Role userrole)
        {
            name = name;
            gender = Gender;
            mobileNo = MobileNo;
            address = location;
            emailId = EmailId;
            password = Password;
            conformPassword = conformpassword;
            UserRole = userrole;
        }
    }
}
