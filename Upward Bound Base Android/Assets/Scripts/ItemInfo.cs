public class ItemInfo
{
    public string ID { get; set; }
    public string Name { get; set; }
    public Description Description { get; set; }
}

public class Description
{
    public string BackgroundInfo { get; set; }
    public Location Location { get; set; }
}

public class Location
{
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZIP { get; set; }
}


