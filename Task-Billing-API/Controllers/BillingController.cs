using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task_Billing_API.Models;
using Task_Billing_API.Services;

namespace Task_Billing_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillingController : ControllerBase
    {
        public IBillingService BillingService { get;  }
        public BillingController(IBillingService billingService)
        {
            BillingService = billingService;
        }

        [HttpPost]
        public async Task<IActionResult> ProcessOrder(BillingModel billingPayload)
        {
            var receipt = BillingService.Process(billingPayload);
            return Ok(receipt);
        }
    }
}
