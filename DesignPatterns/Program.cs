using DesignPatterns.Creational.Credit_Card_Details;
using DesignPatterns.Creational.Payment_Gateway_Integration;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var CreditCardGareway = new CreditCardGateway();
            var handler = new PaymentHandler(CreditCardGareway);
            handler.ExecutePaument(124.32);

            var paypalGareway = new PaypalGateway();
            handler = new PaymentHandler(paypalGareway);
            handler.ExecutePaument(293.45);

            var stripeGareway = new StripeGateway();
            handler = new PaymentHandler(stripeGareway);
            handler.ExecutePaument(345.32);


            Console.ReadLine();

        }
    }
}
