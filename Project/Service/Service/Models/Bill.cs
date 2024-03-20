using System;
using System.Collections.Generic;

namespace Service.Models;

public partial class Bill
{
    public int BillId { get; set; }

    public DateTime BillCreatedTime { get; set; }

    public int AccId { get; set; }

    public int MerId { get; set; }

    public virtual Account Acc { get; set; } = null!;

    public virtual Merchandise Mer { get; set; } = null!;
}
