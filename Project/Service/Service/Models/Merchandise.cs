using System;
using System.Collections.Generic;

namespace Service.Models;

public partial class Merchandise
{
    public int MerId { get; set; }

    public string MerName { get; set; } = null!;

    public string MerDescription { get; set; } = null!;

    public double MerPrice { get; set; }

    public int MerQuantity { get; set; }

    public string? MerUnit { get; set; }

    public int MerIdCategory { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual ICollection<ImportBill> ImportBills { get; set; } = new List<ImportBill>();

    public virtual Category MerIdCategoryNavigation { get; set; } = null!;
}
