using Task_Billing_API.Models;

namespace Task_Billing_API.Services
{
    public interface IBillingService
    {
        ReceiptModel Process(BillingModel billingModel); 
    }
}
