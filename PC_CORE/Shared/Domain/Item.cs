using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_CORE.Shared.Domain
{
    public class Item : BaseDomainModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; } = "https://via.placeholder.com/300x300";
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public bool IsPublic { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}
