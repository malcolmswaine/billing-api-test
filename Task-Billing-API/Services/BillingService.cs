using System.Text.Json;
using Task_Billing_API.Models;

namespace Task_Billing_API.Services
{
    public class BillingService : IBillingService
    {
        
        public ReceiptModel Process(BillingModel billingModel)
        {
            ReceiptModel receipt = null;
            try
            {
                var gateway = this.GetPaymentGatewayModel(billingModel);

                if (gateway != null)
                {
                    receipt = this.CallPaymentGateway(gateway);
                }
                
            }
            catch (Exception ex)
            { 
                // TODO - Set up logging and excecption handling

            }

            return receipt;
        }

        public ReceiptModel CallPaymentGateway(PaymentGatewayModel gateway)
        { 
            // TODO - make call
            return new ReceiptModel() { ReceiptId = 123 };

        }

        public PaymentGatewayModel GetPaymentGatewayModel(BillingModel billingModel)
        {
            var settings = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var gateways = settings.GetSection("PaymentGateways").Get<List<PaymentGatewayModel>>();
            var gateway = gateways?.FirstOrDefault(x => x.Id == billingModel.PaymentGatewayId);

            return gateway;
        }
    }
}
