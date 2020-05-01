using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class ChapterEntity: BaseEntity
    {
        public string Name { get; set; }
        public int BookId { get; set; }
        public BookEntity Book { get; set; }
    }
}
