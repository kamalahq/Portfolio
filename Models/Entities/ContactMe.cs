using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ryan.Web.UI.Models.Entities
{
    public class ContactMe
    {
        public int Id{ get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Comment { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime ?AnswerDate { get; set; }
        public int? AnswerByUserId { get; set; }
    }
}
