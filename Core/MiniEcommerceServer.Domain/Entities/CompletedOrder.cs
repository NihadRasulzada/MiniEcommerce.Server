using MiniEcommerceServer.Domain.Entities.Common;

namespace MiniEcommerceServer.Domain.Entities
{
    public class CompletedOrder : BaseEntity
    {
        public Guid OrderId { get; set; }

        public Order Order { get; set; }
    }
}
