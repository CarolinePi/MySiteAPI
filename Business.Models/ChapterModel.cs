using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class ChapterModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BookId { get; set; }
        public BookModel Book { get; set; }
    }
}
