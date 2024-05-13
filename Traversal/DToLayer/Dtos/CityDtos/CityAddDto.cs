using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DToLayer.Dtos.CityDtos
{
    public class CityAddDto
    {
        public int CityId { get; set; }
        public string? CityName { get; set; }
        public string? CityCountry { get; set; }
    }
}
