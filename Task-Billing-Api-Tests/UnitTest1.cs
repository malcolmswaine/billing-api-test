using Task_Billing_API.Infrastructure;
using Task_Billing_API.Models;
using Task_Billing_API.Services;
using Xunit;

namespace Task_Billing_Api_Tests
{
    public class UnitTest1
    {
        // TODO: Mock gateway response
        
        
        BillingModel billingModel = new BillingModel()
        {
            UserId = 1,
            Description = "Test",
            OrderNumber = 1,
            PayableAmount = 20,
            PaymentGatewayId = 0
        };


        [Fact]
        public void Test1()
        {
            var billing = new BillingService();
            var recipt = billing.Process(billingModel);
            Assert.NotNull(recipt);
        }


        [Fact]
        public void Test2()
        {
            var testc = "asdad".IsGreaterThan(10);
            Assert.False(testc);
        }
    }
}