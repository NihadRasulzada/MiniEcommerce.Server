using MiniEcommerceServer.Domain.Entities.Common;

namespace MiniEcommerceServer.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
