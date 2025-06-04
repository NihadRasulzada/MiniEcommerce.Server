using Microsoft.Extensions.Options;
using MiniEcommerceServer.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerceServer.Domain.Entities
{
    public class Menu : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Endpoint> Endpoints { get; set; }
    }
}
