using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class StatusDataModel
    {
        public string ContactName { get; set; }

        public Uri Contact { get; set; }

        public string StatusMessage { get; set; }

        public Uri StatusImage { get; set; }

        //if we want to add our status

        public bool IsMeAddStatus { get; set; }
    }
}
