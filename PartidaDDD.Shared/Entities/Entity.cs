using FluentValidator;
using System;

namespace PartidaDDD.Shared.Entities
{
    public abstract class Entity : Notifiable
    {
        public Guid ID { get; private set; }

        public Entity()
        {
            ID = Guid.NewGuid();
        }
    }
}
