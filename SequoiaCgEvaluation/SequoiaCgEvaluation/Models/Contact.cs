using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SequoiaCgEvaluation.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Zip { get; set; }
        [Required]
        public string Email { get; set; }

        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
    }
}