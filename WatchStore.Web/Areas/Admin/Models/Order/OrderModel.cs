using WatchStore.Web.Models.Enums;

namespace WatchStore.Web.Areas.Admin.Models.Order
{
    public class OrderModel
    {
        public Status Status { get; set; }
        public DateTime? DeliveryDate { get; set; }
    }
}
