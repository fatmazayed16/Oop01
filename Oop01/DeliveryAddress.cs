namespace Oop01;

public struct DeliveryAddress
{
    public string city;
    public string street;
    public int buildingNumber;

    public DeliveryAddress(string city, string street, int buildingNumber)
    {
        this.city = city;
        this.street = street;
        this.buildingNumber = buildingNumber;
    }
    public string GetFullAddress()
    {
        string fullAddress = city + ", " + street + ", " + buildingNumber;
        return fullAddress;
    }
}
