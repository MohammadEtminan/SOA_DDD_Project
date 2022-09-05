using System;

namespace OnlineStore.Domain.Frameworks.Bases
{
    public class Entity : Abstracts.IEntity<Guid>
    {
        public Guid Id { get; set; }
    }
}
