using System;
using System.Collections.Generic;

namespace Service.Models;

public partial class BillDetail
{
    public int BillDetailId { get; set; }

    public int BillId { get; set; }

    public int MerId { get; set; }

    public int BillMerQuanity { get; set; }

    public double BillMerPrice { get; set; }

    public virtual Bill Bill { get; set; } = null!;

    public virtual Merchandise Mer { get; set; } = null!;
}
