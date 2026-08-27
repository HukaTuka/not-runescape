namespace NotRunescape;

public class Player
{
    public int CurrentHp { get; set; } = 35;
    public int MaxHp { get; set; } = 35;
    public int Gold { get; set; } = 50;
    public Dictionary<string, int> Inventory { get; set; } = new()
    {
        { "Lobster", 3 },
        { "Rune Scimitar", 1 }
    };

    public void AddItem(string item, int amount)
    {
        if (Inventory.ContainsKey(item))
            Inventory[item] += amount;
        else
            Inventory[item] = amount;
    }

    public void PrintInventory()
    {
        Console.WriteLine("\n--- Inventory ---");
        foreach (var item in Inventory)
        {
            Console.WriteLine($"- {item.Key}: {item.Value}");
        }
    }
}