using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class BookEntity: BaseEntity
    {
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public int ReaderId { get; set; }
        public AuthorEntity Author { get; set; }
        public ReaderEntity? Reader { get; set; }

    }
}
