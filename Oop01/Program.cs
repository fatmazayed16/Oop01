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

            #region Q2
            /* (A) 4 Problems :
                * Anyone can modify the data in the struct 
                * No validation in Weight and DeliveryFee
                * fialds ar public 
                * if we change the name of any field in struct,If we change the name of any field in the struct, 
                   we also have to change every place that uses that field in the Main class.
                   This makes the code less maintainable and tightly coupled.
            (B) The fields are changed from public to private to improve encapsulation.
                Public properties are used to control access to the private fields.
                Validation is added to prevent negative values for Weight and DeliveryFee (If a negative value is entered, it is set to 0)
            */
            #endregion
        }
    }
}
    
 