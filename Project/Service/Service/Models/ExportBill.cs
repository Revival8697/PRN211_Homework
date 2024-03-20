using System;
using System.Collections.Generic;

namespace Service.Models;

public partial class ExportBill
{
    public int ExId { get; set; }

    public string ExManager { get; set; } = null!;

    public DateTime ExDate { get; set; }

    public int AccId { get; set; }

    public int CusId { get; set; }

    public virtual Account Acc { get; set; } = null!;

    public virtual Customer Cus { get; set; } = null!;
}
