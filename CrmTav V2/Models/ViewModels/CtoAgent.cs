using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmTav_V2.Models.ViewModels
{
    public class CtoAgent
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string TellNo { get; set; }
        public string DateCome { get; set; }

        public CtoAgent(int id, string name, string username, string tellNo, string dateCome)
        {
            this.id = id;
            Name = name;
            Username = username;
            TellNo = tellNo;
            DateCome = dateCome;
        }
    }
}
