namespace NotRunescape;

public class BossLog
{
    public string BossName { get; set; } = "";
    public string DropName { get; set; } = "";
    public bool IsUnique { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.Now;
}