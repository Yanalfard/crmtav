using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmTav_V2.Models.ViewModels
{
    public class CTOProvincesAndCities
    {
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string province { get; set; }
        public string state { get; set; }
        public string city { get; set; }

        public CTOProvincesAndCities(string latitude, string longitude, string province, string state, string city)
        {
            this.latitude = latitude;
            this.longitude = longitude;
            this.province = province;
            this.state = state;
            this.city = city;
        }

        public CTOProvincesAndCities()
        {
            
        }
    }
}
