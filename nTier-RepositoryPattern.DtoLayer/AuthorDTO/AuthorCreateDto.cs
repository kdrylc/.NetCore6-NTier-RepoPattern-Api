using nTier_RepositoryPattern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nTier_RepositoryPattern.DtoLayer.AuthorDTO
{
    public class AuthorCreateDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
