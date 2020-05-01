using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public int ReaderId { get; set; }
        public AuthorModel Author { get; set; }
        public ReaderModel? Reader { get; set; }
    }
}
