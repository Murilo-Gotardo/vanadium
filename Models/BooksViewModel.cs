using System.ComponentModel.DataAnnotations.Schema;

namespace vanadium.Models
{

    [Table("Books")]
    public class BooksViewModel
	{
		public int Id { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public string Author { get; set; }

        public int TagsId { get; set; }
        public TagsViewModel Tags { get; set; }

    }
}
