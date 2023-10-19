using System;
using HomeWorkLesson6;

class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Product Inventory Project");

        // Создаем несколько продуктов с помощью различных конструкторов
        Product apple = new Product(1, "Apple", 1.2, 10);
        Product banana = new Product(2, "Banana", 0.8, 20);

        // Создаем инвентарь и добавляем продукты
        Inventory myInventory = new Inventory();
        myInventory.AddProduct(apple);
        myInventory.AddProduct(banana);

        // Выводим стоимость всего инвентаря
        Console.WriteLine($"Total Inventory Value: {myInventory.GetTotalInventoryValue()}");
    }

}
    




