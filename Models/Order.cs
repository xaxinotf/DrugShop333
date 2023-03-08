using System;
using System.Collections.Generic;

namespace DrugShop333.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int Status { get; set; }

    public int ShipType { get; set; }

    public int PaymentTypeId { get; set; }

    public int UserId { get; set; }

    public string? DeliveryAddress { get; set; }

    public virtual PaymentType PaymentType { get; set; } = null!;

    public virtual ShipType ShipTypeNavigation { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    public virtual ICollection<Product> NameProducts { get; } = new List<Product>();
}
