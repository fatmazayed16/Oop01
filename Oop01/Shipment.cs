namespace Oop01;

public struct Shipment
{
    #region Fields
    private string description; 
    private double weight;
    private decimal deliveryFee;
    private string trackingCode;
    #endregion

    #region Constructor
    public Shipment(string trackingCode)
    {
        Description = "Unknown";
        Weight = 1;
        DeliveryFee = 50;
        TrackingCode = trackingCode;
        Destination = new DeliveryAddress("Unknown", "Unknown",0);
    }

    public Shipment(string description, double weight, decimal deliveryFee, string trackingCode, DeliveryAddress destination) 
    {
        Description = description;
        Weight = weight;
        DeliveryFee = deliveryFee;
        TrackingCode = trackingCode;
        Destination = destination;
    }
    #endregion

    #region Properties
    public DeliveryAddress Destination { get; set; }
    #region Q2
    public string Description
    {
        get
        {
            return description;
        }
        set
        {
            description = string.IsNullOrWhiteSpace(value) ? description : value; 
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
            weight = value > 0 ? value : weight;
        }
    }
    public decimal DeliveryFee
    {
        get
        {
            return deliveryFee;
        }
        private set
        {
            deliveryFee = value > 0 ? value : deliveryFee  ;
        }
    }
    #endregion
    public string TrackingCode
    {
        get
        {
            return trackingCode;
        }
        private set
        {
            trackingCode = string.IsNullOrWhiteSpace(value) ? trackingCode : value;
        }
    }
    public decimal EstimatedCost
    {
        get
        {
            return DeliveryFee + ((decimal)Weight * 5m);
        }
    } // EstimatedCost has only a getter because it is a calculated property.
    #endregion

    public void UpdateDeliveryFee(decimal newFee)
    {
        DeliveryFee = newFee > 0 ? newFee : DeliveryFee;
    }


}
