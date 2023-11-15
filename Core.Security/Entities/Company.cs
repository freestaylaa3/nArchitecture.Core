using Core.Persistence.Repositories;
using Core.Security.Enums;

namespace Core.Security.Entities;
public class Company : Entity<int>
{
    public string Name { get; set; }
    public string SchemaName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string District { get; set; }
    public string Language { get; set; }
    public string Currency { get; set; }
    public int TableCount { get; set; }
    public bool CanOrder { get; set; }
    public OnlinePayState CanOnlinePay { get; set; }
    public bool CanPosConnection { get; set; }
    public int ExpireTime { get; set; }
    public DateTime SubscriptionEndDate { get; set; }
    public int? UserLimit { get; set; }
    public int CoverageArea { get; set; }
    public int SessionDuration { get; set; }
    public string? Location { get; set; }
    public bool Status { get; set; } = true;

    public Company()
    {
    }

    public Company(string name, string schemaName, string address, string city, string district, string language, string currency, int tableCount, bool canOrder, OnlinePayState canOnlinePay, bool canPosConnection, int expireTime, DateTime subscriptionEndDate, int? userLimit, int coverageArea, int sessionDuration, string? location, bool status)
    {
        Name = name;
        SchemaName = schemaName;
        Address = address;
        City = city;
        District = district;
        Language = language;
        Currency = currency;
        TableCount = tableCount;
        CanOrder = canOrder;
        CanOnlinePay = canOnlinePay;
        CanPosConnection = canPosConnection;
        ExpireTime = expireTime;
        SubscriptionEndDate = subscriptionEndDate;
        UserLimit = userLimit;
        CoverageArea = coverageArea;
        SessionDuration = sessionDuration;
        Location = location;
        Status = status;
    }
    public Company(int id ,string name, string schemaName, string address, string city, string district, string language, string currency, int tableCount, bool canOrder, OnlinePayState canOnlinePay, bool canPosConnection, int expireTime, DateTime subscriptionEndDate, int? userLimit, int coverageArea, int sessionDuration, string? location, bool status) : base(id)
    {
        Name = name;
        SchemaName = schemaName;
        Address = address;
        City = city;
        District = district;
        Language = language;
        Currency = currency;
        TableCount = tableCount;
        CanOrder = canOrder;
        CanOnlinePay = canOnlinePay;
        CanPosConnection = canPosConnection;
        ExpireTime = expireTime;
        SubscriptionEndDate = subscriptionEndDate;
        UserLimit = userLimit;
        CoverageArea = coverageArea;
        SessionDuration = sessionDuration;
        Location = location;
        Status = status;
    }
}
