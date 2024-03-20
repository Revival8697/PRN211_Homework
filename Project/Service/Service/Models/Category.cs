using System;
using System.Collections.Generic;

namespace Service.Models;

public partial class Category
{
    public int IdCategory { get; set; }

    public string NameCateGory { get; set; } = null!;

    public virtual ICollection<Merchandise> Merchandises { get; set; } = new List<Merchandise>();
}
