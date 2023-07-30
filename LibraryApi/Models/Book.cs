using System.ComponentModel.DataAnnotations;

namespace LibraryApi.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        // Foreign key properties
        public int Cat_id { get; set; }
        public int Publisher_id { get; set; }
        public int Shelf_code { get; set; }

    }
}
