using Microsoft.EntityFrameworkCore.ChangeTracking;



namespace WinFormEF.CatPro;

public class Category
{
    public int CategoryId { get; set; }

    public string? Name { get; set; }

    public virtual ObservableCollectionListSource<Product> Products { get; } = new();
}

