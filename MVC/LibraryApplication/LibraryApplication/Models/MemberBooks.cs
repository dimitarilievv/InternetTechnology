using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryApplication.Models
{
    public class MemberBooks
    {
        public int MemberId { get; set; }
        public int BookId { get; set; }
        public Member Member { get; set; }
        public virtual List<Book> Books { get; set; }
        public MemberBooks() { 
            Books= new List<Book>();
        }
    }
}