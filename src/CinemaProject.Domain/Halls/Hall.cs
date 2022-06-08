using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace CinemaProject.Halls
{
    public class Hall : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        protected Hall()
        {
        }

        internal Hall(Guid id, string name) : base(id)
        {
            SetName(name);
        }

        internal void SetName(string name) =>
            Name = Check.NotNullOrWhiteSpace(name, nameof(name));
    }
}
