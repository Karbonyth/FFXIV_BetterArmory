using System;
using System.Numerics;
using BetterArmory.Services;
using Dalamud.Interface.Utility;
using Dalamud.Interface.Windowing;
using Dalamud.Bindings.ImGui;

namespace BetterArmory.Windows;

public class ArmoryWindow : Window, IDisposable
{
    private readonly ArmoryViewModel viewModel;

    public ArmoryWindow(ArmoryViewModel viewModel) : base("Armory Chest##BetterArmory")
    {
        this.viewModel = viewModel;
        
        SizeConstraints = new WindowSizeConstraints
        {
            MinimumSize = new Vector2(375, 330),
            MaximumSize = new Vector2(float.MaxValue, float.MaxValue)
        };
    }

    public void Dispose() { }

    public override void Draw()
    {
        if (ImGui.BeginTable("ArmoryItems", 4, ImGuiTableFlags.Borders | ImGuiTableFlags.RowBg | ImGuiTableFlags.Resizable | ImGuiTableFlags.Sortable))
        {
            ImGui.TableSetupColumn("Icon", ImGuiTableColumnFlags.WidthFixed | ImGuiTableColumnFlags.NoSort, 30, (uint)ArmorySortColumn.Icon);
            ImGui.TableSetupColumn("Name", ImGuiTableColumnFlags.WidthStretch | ImGuiTableColumnFlags.NoSort, 0, (uint)ArmorySortColumn.Name);
            ImGui.TableSetupColumn("iLvl", ImGuiTableColumnFlags.WidthFixed, 40, (uint)ArmorySortColumn.ItemLevel); 
            ImGui.TableSetupColumn("Category", ImGuiTableColumnFlags.WidthFixed | ImGuiTableColumnFlags.NoSort, 100, (uint)ArmorySortColumn.Category);
            ImGui.TableHeadersRow();

            var sortSpecs = ImGui.TableGetSortSpecs();
            if (sortSpecs.SpecsDirty)
            {
                // No manual index mapping needed! We use the ID we assigned.
                var sortColumnId = (ArmorySortColumn)sortSpecs.Specs.ColumnUserID;
                viewModel.Sort(sortColumnId, sortSpecs.Specs.SortDirection == ImGuiSortDirection.Ascending);
                
                sortSpecs.SpecsDirty = false;
            }

            foreach (var item in viewModel.Items)
            {
                ImGui.TableNextRow();
                
                ImGui.TableSetColumnIndex(0);
                // Placeholder for icon, just printing ID for now
                ImGui.Text(item.IconId.ToString());

                ImGui.TableSetColumnIndex(1);
                ImGui.Text(item.Name);

                ImGui.TableSetColumnIndex(2);
                ImGui.Text(item.ItemLevel.ToString());
                
                ImGui.TableSetColumnIndex(3);
                ImGui.Text(item.Category);
            }

            ImGui.EndTable();
        }
    }
}
