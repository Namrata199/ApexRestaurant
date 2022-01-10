using System;
namespace ApexRestaurant.Mvc.Models
{
    public class MenuViewModel
    {
        public int MenuId { get; set; }
        public string  MenuName { get; set; }
        public DateTime AvailableDateFrom { get; set; }
        public DateTime AvailableDateTo {get; set; }
        public string OtherDetails {get; set; }

    }

}
