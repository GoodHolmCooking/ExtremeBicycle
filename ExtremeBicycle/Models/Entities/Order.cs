using System;

public class Order
{
    public int OrderId { get; set; }

    public double OrderAmount { get; set; }

    public int CustomerId { get; set; }

    public int EmployeeId { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime RequiredDate { get; set; }

    public DateTime ShipDate { get; set; }

    public string CourierWebsite { get; set; }

    public string Shipped { get; set; }

    public string PO { get; set; }

    public bool PaymentReceived{ get; set; }
}
