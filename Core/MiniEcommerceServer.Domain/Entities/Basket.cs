using MiniEcommerceServer.Domain.Entities.Common;
using MiniEcommerceServer.Domain.Entities.Identity;

namespace MiniEcommerceServer.Domain.Entities
{
    public class Basket : BaseEntity
    {
        public string UserId { get; set; }

        public AppUser User { get; set; }
        public Order Order { get; set; }
        public ICollection<BasketItem> BasketItems { get; set; }
    }
}
