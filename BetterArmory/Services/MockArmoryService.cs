using System.Collections.Generic;

namespace BetterArmory.Services;

public class MockArmoryService : IArmoryService
{
    public List<ArmoryItem> GetItems()
    {
        return new List<ArmoryItem>
        {
            new() { Name = "Excalibur", IconId = 100, ItemLevel = 50, Category = "Main Hand" },
            new() { Name = "Aegis Shield", IconId = 101, ItemLevel = 50, Category = "Off Hand" },
            new() { Name = "Iron Helm", IconId = 102, ItemLevel = 10, Category = "Head" },
            new() { Name = "Cotton Tabard", IconId = 103, ItemLevel = 15, Category = "Body" },
            new() { Name = "Leather Gloves", IconId = 104, ItemLevel = 5, Category = "Hands" },
            new() { Name = "Hempen Breeches", IconId = 105, ItemLevel = 1, Category = "Legs" },
            new() { Name = "Leather Shoes", IconId = 106, ItemLevel = 5, Category = "Feet" },
            // Add more to test scrolling
            new() { Name = "High Allagan Blade", IconId = 107, ItemLevel = 115, Category = "Main Hand" },
            new() { Name = "High Allagan Shield", IconId = 108, ItemLevel = 115, Category = "Off Hand" },
            new() { Name = "Dreadwyrm Claymore", IconId = 109, ItemLevel = 135, Category = "Main Hand" },
            new() { Name = "Gordian Greatsword", IconId = 110, ItemLevel = 210, Category = "Main Hand" },
            new() { Name = "Midan Metal Greatsword", IconId = 111, ItemLevel = 245, Category = "Main Hand" },
            new() { Name = "Alexandrian Metal Greatsword", IconId = 112, ItemLevel = 275, Category = "Main Hand" },
            new() { Name = "Genji Kakidate", IconId = 113, ItemLevel = 345, Category = "Main Hand" },
            new() { Name = "Diamond Greatsword", IconId = 114, ItemLevel = 375, Category = "Main Hand" },
            new() { Name = "Omega Claymore", IconId = 115, ItemLevel = 405, Category = "Main Hand" },
            new() { Name = "Edenchoir Greatsword", IconId = 116, ItemLevel = 505, Category = "Main Hand" },
            new() { Name = "Edenmorn Greatsword", IconId = 117, ItemLevel = 535, Category = "Main Hand" },
        };
    }
}
