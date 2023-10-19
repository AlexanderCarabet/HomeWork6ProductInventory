using System;
namespace HomeWorkLesson6;



class Inventory
{
    private List<Product> products;

    public Inventory()
    {
        products = new List<Product>();
    }

    // Метод для добавления продукта в инвентарь
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Метод для вычисления общей стоимости инвентаря
    public double GetTotalInventoryValue()
    {
        double totalValue = 0;
        foreach (Product product in products)
        {
            totalValue += product.GetTotalValue();
        }
        return totalValue;
    }
}
