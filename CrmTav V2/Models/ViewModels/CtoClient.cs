using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmTav_V2.Models.ViewModels
{
    public class CtoClient
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string DateOfContract { get; set; }

        public CtoClient(int id)
        {
            this.id = id;
        }

        public CtoClient(int id, string name, string desc, string dateOfContract)
        {
            this.id = id;
            Name = name;
            Desc = desc;
            DateOfContract = dateOfContract;
        }

        public CtoClient(string name, string desc, string dateOfContract)
        {
            Name = name;
            Desc = desc;
            DateOfContract = dateOfContract;
        }

        public CtoClient()
        {

        }
    }
}
