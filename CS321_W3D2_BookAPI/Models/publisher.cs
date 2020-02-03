using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CS321_W3D2_BookAPI.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FoundedYear { get; set; }
        public string CountryOfOrigin { get; set; }
        public string HeadQuartersLocation { get; set; }
        public ICollection<Publisher> publishers { get; set; }
        public int AuthorId { get; set; }
        //public ICollection<Book> Books { get; set; }
    }
}
