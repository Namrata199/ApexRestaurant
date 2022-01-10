using System;
namespace ApexRestaurant.Mvc.Models
{
    public class StaffViewModel
    {
        public int StaffId { get; set; }
        public int  StaffRoleCode { get; set; }
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        public string  OtherDetails { get; set; }

    }

}
