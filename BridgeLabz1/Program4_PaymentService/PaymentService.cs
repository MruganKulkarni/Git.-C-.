public class PaymentService
{
    public bool ProcessPayment(Payment payment)
    {
        if (payment == null)
            return false;

        return payment.Amount > 0;
    }
}
