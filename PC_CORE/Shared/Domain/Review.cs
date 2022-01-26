using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_CORE.Shared.Domain
{
    public class Review :BaseDomainModel
    {
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public int Rating { get; set; }
    }
}
