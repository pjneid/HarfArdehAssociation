using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HarfArdehAssociation.Models
{
    public class Group
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Group Name is required")]
        public string Name { get; set; }
    }
}