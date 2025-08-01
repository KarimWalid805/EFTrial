﻿using System.ComponentModel;

namespace WinFormEF.CatPro;

public class Product
{
    public int ProductId { get; set; }

    public string? Name { get; set; }

    public int CategoryId { get; set; }
    public virtual Category Category { get; set; } = null!;

    
}