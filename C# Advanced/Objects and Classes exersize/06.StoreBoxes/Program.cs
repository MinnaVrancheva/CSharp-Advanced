
List<Box> boxes = new List<Box>();
string command;

while ((command = Console.ReadLine()) != "end")
{
    Item item = new();
    item.Name = command.Split()[1];
    item.Price = double.Parse(command.Split()[3]);

    Box box = new Box();
    box.SerialNumber = int.Parse(command.Split()[0]);
    box.Item = item;
    box.ItemQuantity = int.Parse(command.Split()[2]);
    double priceForABox = Box.CalculatePrice(item.Price, box.ItemQuantity);
    box.PriceForABox = priceForABox;
    boxes.Add(box);
}

foreach (Box box in boxes.OrderByDescending(b => b.PriceForABox))
{
    Console.WriteLine($"{box.SerialNumber}{Environment.NewLine}" +
            $"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}{Environment.NewLine}" +
            $"-- ${box.PriceForABox:f2}");
}

public class Item
{
    public string Name { get; set; }
    public double Price { get; set; }

}


public class Box
{
    public Box()
    {
        Item = new Item();
    }
    public int SerialNumber { get; set; }
    public Item? Item { get; set; }
    public int ItemQuantity { get; set; }
    public double PriceForABox { get; set; }

    
    public static double CalculatePrice(double price, int itemQuantity)
    {
        double boxPrice = price * itemQuantity;
        return boxPrice;
    }

    //public override string ToString()
    //{
    //    string result =
    //        $"{SerialNumber}{Environment.NewLine}" +
    //        $"-- {Item.Name} - ${PriceForABox:f2}: {ItemQuantity}{Environment.NewLine}" +
    //        $"-- ${Item.Price}";

    //    return result;
    //}
}

