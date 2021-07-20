using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmTav_V2.Models.ViewModels
{
    public class CtoFraction
    {
        public int id { get; set; }
        public string Bank   { get; set; }
        public string Amount { get; set; }
        public string Date { get; set; }
        public string No { get; set; }


        public CtoFraction(int id, string bank, string amount, string date, string no)
        {
            this.id = id;
            Bank = bank;
            Amount = amount;
            Date = date;
            No = no;
        }

        public CtoFraction()
        {
            
        }
    }
}
