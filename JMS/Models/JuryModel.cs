using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JMS.Models
{
    public class JuryModel
    {
        public Int32 JuryId { get; set; }
        public bool CheckedIn { get; set; }
        public bool Completed { get; set; }
        public int DaysAvailable { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}