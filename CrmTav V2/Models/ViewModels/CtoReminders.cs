using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmTav_V2.Models.ViewModels
{
    public class CtoReminders
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Time { get; set; }
        public string AgentName { get; set; }

        public CtoReminders(int id, string title, string time, string agentName)
        {
            this.id = id;
            Title = title;
            Time = time;
            AgentName = agentName;
        }

        public CtoReminders()
        {
            
        }
    }
}
