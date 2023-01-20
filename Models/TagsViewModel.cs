using System.ComponentModel.DataAnnotations.Schema;

namespace vanadium.Models
{
    [Table("Tags")]
    public class TagsViewModel
	{
		public int Id { get; set; }
		public string Type { get; set; }
	}
}
