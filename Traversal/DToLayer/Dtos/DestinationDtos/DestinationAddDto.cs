using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DToLayer.Dtos.DestinationDtos
{
    public class DestinationAddDto
    {
        public string City { get; set; }
        public string DayNighy { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }
    }
}
