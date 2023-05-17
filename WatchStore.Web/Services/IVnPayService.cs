using WatchStore.Web.Models;

namespace WatchStore.Web.Services
{
    public interface IVnPayService
    {
        string CreatePaymentUrl(Order model, HttpContext context);
        Order PaymentExecute(IQueryCollection collections);
    }
}
