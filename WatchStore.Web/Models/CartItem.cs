using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace WatchStore.Web.Models
{
    public class CartItem
    {
        public int Quantity { set; get; }
        public virtual Product Product { set; get; }
        public string Image { set; get; }
    }
}
