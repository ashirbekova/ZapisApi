using System;

namespace DB.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public virtual City Parent { get; set; }
    }
}
