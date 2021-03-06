using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI2.Models
{
    public class CreateRestaurantDto
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Category { get; set; }
        public bool HasDelivery { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNumber { get; set; }

        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
    }
}
