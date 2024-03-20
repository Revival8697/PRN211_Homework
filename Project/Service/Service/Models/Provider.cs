using System;
using System.Collections.Generic;

namespace Service.Models;

public partial class Provider
{
    public int ProId { get; set; }

    public string ProName { get; set; } = null!;

    public int ProGender { get; set; }

    public string ProPhone { get; set; } = null!;

    public DateOnly ProDob { get; set; }

    public virtual ICollection<ImportBill> ImportBills { get; set; } = new List<ImportBill>();
}
