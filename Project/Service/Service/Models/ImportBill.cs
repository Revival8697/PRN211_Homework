using System;
using System.Collections.Generic;

namespace Service.Models;

public partial class ImportBill
{
    public int ImId { get; set; }

    public string ImName { get; set; } = null!;

    public string ImProvider { get; set; } = null!;

    public DateTime ImDate { get; set; }

    public int MerId { get; set; }

    public int ProId { get; set; }

    public virtual Merchandise Mer { get; set; } = null!;

    public virtual Provider Pro { get; set; } = null!;
}
