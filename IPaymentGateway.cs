using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interfaces_Abstract_classes
{
    internal interface IPaymentGateway
    {
        // here we define the methods that must be implemented by any class that implements this interface

        void Pay(decimal amount);

        void Refund(decimal amount);
        //incase or interfgace allmethgods are abstract by defaulft,meaning they do not have a body.
        //intyerfaces cannot have fields or properties with implementation, only method signatures.
        //we can create reference to an interface type, but we cannot instantiate it directly.
        //ex IPaymentGateway paymentGateway = new IPaymentGateway(); // this will give an error

        //But we can create a reference to a class that implements the interface:
        //IPaymentGateway paymentGateway = new CreditCardPayment(); // this is valid
    }
    //define class that implements the interface
    public class PayPalGateway : IPaymentGateway // here we are implementing the interface
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("PayPal payment of INR :" +amount+"processed");
        }
        public void Refund(decimal amount)
        {
            Console.WriteLine("PayPal Refund of INR :" +amount+"processed");
        }

    }
}
