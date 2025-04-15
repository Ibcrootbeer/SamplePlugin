using System;
using System.Numerics;

using Dalamud.Interface.Windowing;

using ImGuiNET;
namespace RetainerAlerts.Windows;

public class ConfigWindow : Window, IDisposable
{
    private Plugin plugin;
    private Configuration configuration;

    public ConfigWindow(Plugin plugin) : base("Retainer Alerts Configuration###RetainerAlerts")
    {
        SizeConstraints = new WindowSizeConstraints
        {
            MinimumSize = new Vector2(375, 330),
            MaximumSize = new Vector2(float.MaxValue, float.MaxValue)
        };

        Flags = ImGuiWindowFlags.NoCollapse | ImGuiWindowFlags.NoScrollbar |
                ImGuiWindowFlags.NoScrollWithMouse | ImGuiWindowFlags.AlwaysAutoResize;

        this.plugin = plugin;
        this.configuration = plugin.Configuration;
    }

    public void Dispose() { }

    public override void Draw()
    {
        if (ImGui.Button("Reposition Popup"))
        {
            plugin.ToggleAlertMovement();
        }
    }
}
