using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Domain.Frameworks.Bases
{
    public class Entity : Abstracts.IEntity<Guid>
    {
        public Guid Id { get; set; }
    }
}
