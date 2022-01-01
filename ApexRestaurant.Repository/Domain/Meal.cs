using System;
namespace ApexRestaurant.Repository.Domain
{
    public class Meal
    {
        public int StaffId { get; set; }
        public int  CusctomerId { get; set; }
        public DateTime  DateOfMeal { get; set; }
        public int  CostOfMeal { get; set; }
        public string  OtherDetails { get; set; }

    }

}
