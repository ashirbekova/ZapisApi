using System.ComponentModel.DataAnnotations;

namespace DB.Entities
{
    public class Service
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int SubcategoryId { get; set; }

        public virtual Subcategory Subcategory { get; set; }
    }
}
