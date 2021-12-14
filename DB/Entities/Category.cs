using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DB.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual List<Subcategory> Subcategories { get; set; }
    }
}
