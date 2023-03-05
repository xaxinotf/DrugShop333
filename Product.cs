using System;
using System.Collections.Generic;

namespace DrugShop333;

public partial class Product
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public string RelaiseFromAndDosing { get; set; } = null!;

    public int Amount { get; set; }

    public string ShelfLife { get; set; } = null!;

    public int Count { get; set; }

    public int Price { get; set; }

    public virtual ICollection<Order> OrdersOrders { get; } = new List<Order>();
}
