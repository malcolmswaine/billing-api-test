namespace Task_Billing_API.Models
{
    public class BillingModel
    {
        public int OrderNumber { get; set; }
        public int UserId { get; set; }
        public int PayableAmount { get; set; }
        public int PaymentGatewayId { get; set; }
        public string Description { get; set; } = "";
    }
}
