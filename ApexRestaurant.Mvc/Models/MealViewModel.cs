using System;
namespace ApexRestaurant.Mvc.Models
{
    public class MealViewModel
    {
        public int StaffId { get; set; }
        public int  CusctomerId { get; set; }
        public DateTime  DateOfMeal { get; set; }
        public int  CostOfMeal { get; set; }
        public string  OtherDetails { get; set; }

    }

}
