using System.Collections.Generic;

namespace BetterArmory.Services;

public class ArmoryItem
{
    public string Name { get; set; } = string.Empty;
    public uint IconId { get; set; }
    public uint ItemLevel { get; set; }
    public string Category { get; set; } = string.Empty;
}

public interface IArmoryService
{
    List<ArmoryItem> GetItems();
}
