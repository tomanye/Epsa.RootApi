using System;
using System.Collections.Generic;
using RootApi.Domain.Common;

namespace Core.Domain.Entities
{
    public class Category:AuditableEntity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Event> Events { get; set; }
        
    }
}