using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Payment_Gateway_Integration
{
    public class PaymentHandler 
    {
        private readonly IPaymentGateway _payment;

        public PaymentHandler(IPaymentGateway payment)
        {
            _payment = payment;
        }

        public void ExecutePaument(double amount)
        {
            _payment.ProcessPayment(amount);
        }
    }
}
