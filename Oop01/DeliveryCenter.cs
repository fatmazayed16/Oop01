namespace Oop01;

internal struct DeliveryCenter
{
    private Shipment[] shipments;

    public DeliveryCenter()
    {
        shipments = new Shipment[10];
    }

    public bool AddShipment(Shipment shipment)
    {
        for (int i = 0; i < shipments.Length; i++)
        {
            if (shipments[i].TrackingCode == null)
            {
                shipments[i] = shipment;
                return true;
            }
        }
        return false;
    }

}
