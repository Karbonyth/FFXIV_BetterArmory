using System.Collections.Generic;
using BetterArmory.Services;

namespace BetterArmory.Windows;

public enum ArmorySortColumn
{
    None = 0,
    Icon,
    Name,
    ItemLevel,
    Category
}

public class ArmoryViewModel
{
    private readonly IArmoryService armoryService;

    public List<ArmoryItem> Items { get; private set; } = new();

    public ArmoryViewModel(IArmoryService armoryService)
    {
        this.armoryService = armoryService;
    }

    public void Refresh()
    {
        Items = armoryService.GetItems();
    }

    public void Sort(ArmorySortColumn column, bool ascending)
    {
        switch (column)
        {
            case ArmorySortColumn.ItemLevel:
                Items.Sort((a, b) => ascending 
                    ? a.ItemLevel.CompareTo(b.ItemLevel) 
                    : b.ItemLevel.CompareTo(a.ItemLevel));
                break;
            // Add other columns here if needed later
        }
    }
}
