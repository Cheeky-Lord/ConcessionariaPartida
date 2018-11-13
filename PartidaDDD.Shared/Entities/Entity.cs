using FluentValidator;
using System;

namespace PartidaDDD.Shared.Entities
{
    public abstract class Entity : Notifiable
    {
        public int ID { get; set; }
    }
}
