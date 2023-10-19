using System;
namespace HomeWorkLesson6;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    // Первый конструктор
    public Product(int id, string name, double price, int quantity)
    {
        Id = id;
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    // Второй конструктор
    public Product(int id, double price, int quantity)
    {
        Id = id;
        Price = price;
        Quantity = quantity;
    }

    // Третий конструктор
    public Product(int id, double price)
    {
        Id = id;
        Price = price;
        Quantity = 1;
    }

    // Метод для вычисления стоимости продукта
    public double GetTotalValue()
    {
        return Price * Quantity;
    }
}
