using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace LibraryApplication.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="This field is required!")]
        public string Name { get; set; }
        [Display(Name = "Member code")]
        [RegularExpression("^[0-9]{6}$", ErrorMessage = "Code must contains 6 characters")]
        public int MemberNumber { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}