using System;
using System.Collections.Generic;

namespace Service.Models;

public partial class Customer
{
    public int CusId { get; set; }

    public string CusName { get; set; } = null!;

    public int CusGender { get; set; }

    public DateOnly CusDob { get; set; }

    public string? CusPhone { get; set; }

    public virtual ICollection<ExportBill> ExportBills { get; set; } = new List<ExportBill>();
}
