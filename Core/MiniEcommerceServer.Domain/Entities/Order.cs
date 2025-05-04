using MiniEcommerceServer.Domain.Entities.Common;

namespace MiniEcommerceServer.Domain.Entities
{
    public class Order : BaseEntity
    {
        public string Description { get; set; }
        public string Address { get; set; }

        public Basket Basket { get; set; }
    }
}
