using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JMS.Models
{
    public class AttendeesEmail : JuryModel
    {
        [Required]
        public string Email { get; set; }
    }
}