namespace Oop01;

public struct Shipment
{
    private string description; 
    private double weight;
    private decimal deliveryFee;

    #region Q2
    public string Description
    {
        get
        {
            return description;
        }
        set
        {
            description = string.IsNullOrWhiteSpace(value) ? "Unknown" : value; ;
        }

    }
    public double Weight 
    {
        get
        {
            return weight;
        }
        set 
        {
            weight = value < 0 ? 0 : value;
        }
    }
    public decimal DeliveryFee
    {
        get
        {
            return deliveryFee;
        }
        set
        {
            deliveryFee = value < 0 ? 0 : value;
        }
    }
    #endregion

    }
