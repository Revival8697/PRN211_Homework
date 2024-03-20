using System;
using System.Collections.Generic;

namespace Service.Models;

public partial class Account
{
    public int AccId { get; set; }

    public string AccName { get; set; } = null!;

    public string AccPass { get; set; } = null!;

    public DateTime AccCreatedTime { get; set; }

    public DateOnly AccDob { get; set; }

    public string AccPhone { get; set; } = null!;

    public int AccRole { get; set; }

    public string? AccAddress { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual ICollection<ExportBill> ExportBills { get; set; } = new List<ExportBill>();
}
