using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Book : IEntity
    {
        public int Id { get; set; }
        public int BookCategoryId { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 UnitsInStock  { get; set; }
        public string WriterName { get; set; }
        public int BooksPage { get; set; }
    }
}
