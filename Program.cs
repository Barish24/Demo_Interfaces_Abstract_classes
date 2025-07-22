using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interfaces_Abstract_classes
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Getting started with Abstract Class and Interface");
            Console.WriteLine("_________________________________________________");
            //makesound class which with predefined methods which can derived in child classes
            //step 1. create an abstract class
            //step 2. create an interface
            //step 3. implement the abstract class and interface in a derived classes( why? because abstract classes cannot be instatantiated directly)
            //step 4. create objects of the derived classes and call the methods

            Console.WriteLine("here is an abstract class Demo...!!!");
            Payment payment = new CreditCardPayment();//creating an instance of the derived class
            payment.MakePayment(1000.00m); //calling the abstract method implemented in the derived class
            payment.GenerateReceipt(); //calling the concrete method from the abstract class

            Console.WriteLine("implementing Interface");
            IPaymentGateway paymentGateway = new PayPalGateway(); //creating an instance of the class that implements the interface
            paymentGateway.Pay(500.00m); //calling the Pay method from the interface
            paymentGateway.Refund(200.00m); //calling the Refund method from the interface
            Console.WriteLine("_________________________________________________"); 

        }
    }
}
