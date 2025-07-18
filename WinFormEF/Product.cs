﻿using System.ComponentModel;
using WinFormEF;

namespace WinFormEF;

public class Product
{
    public int ProductId { get; set; }

    public string? Name { get; set; }

    public int CategoryId { get; set; }
    public virtual Category Category { get; set; } = null!;

    public string Items => $"{ProductId}, {Name}";
    public override string ToString()
    {
        return Name;
    }
}