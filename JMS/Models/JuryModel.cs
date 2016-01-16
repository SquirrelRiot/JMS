using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JMS.Models
{
    public class JuryModel
    {
        public int JuryId { get; set; }
        public bool CheckedIn { get; set; }
        public bool Completed { get; set; }
        public int DaysAvailable { get; set; }
    }
}