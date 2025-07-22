using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interfaces_Abstract_classes
{
    abstract class Payment
    //an abstract class is a class that cannot create an instance of itself and it should have at least one abstract method
    {
        //defining class members like properties and methods specially one abstract method
        public string PaymentId { get; set; }

        public abstract void MakePayment(decimal amount);
        //here we are not defining the body of the method 
        //This is an abstract method that must be implemented by derived classes

        public void GenerateReceipt()
        {
            //This is a concrete method that can be used by derived classes
            Console.WriteLine($"Receipt generated for payment ID: {PaymentId}");
        }
    }

    //creating a derived class which inherits from the abstract class ie Payment

    class CreditCardPayment : Payment
    {
        //implementing the abstract method MakePayment

        public override void MakePayment(decimal amount)
        {
            //implementing the method
            Console.WriteLine($"payment of {amount} made using Credit Card. payment ID: {PaymentId}");
            PaymentId = Guid.NewGuid().ToString();//Generate a unique payment ID
            //Guid.NewGuid() generates a new globally unique identifier (GUID) ex" TXN13254 "
        }
    }
}

