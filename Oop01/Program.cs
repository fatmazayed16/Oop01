namespace Oop01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
             A: What happens when a DeliveryAddress variable is copied into another variable
            and the copy is modified?
            Code:
            public struct DeliveryAddress
            {
                 public string City;
                 public string Street;
            }

            Answer:

            DeliveryAddress is a struct, which is a value type.
            When a DeliveryAddress variable is copied, a separate copy of the value is created.
            If the copy is modified, the original variable is not 
           */

            /*
            B: What happens when a Customer variable is copied into another variable
            and one variable modifies the object?
            Code:
            public class Customer
            {
                public string Name;
            }

            Answer:

            Customer is a class, which is a reference type.
            When a Customer variable is copied, both variables reference the same object.
            If one variable modifies the object, the change is visible through the other variable.
            */
            #endregion


        }


    }
}
    
 