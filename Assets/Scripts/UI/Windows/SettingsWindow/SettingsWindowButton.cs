using UnityEngine;

public class SettingsWindowButton : MonoBehaviour
{
    [SerializeField] private SettingsWindow _settingsWindow;

    public void ShowSettingsWindow()
    {
        _settingsWindow.ShowWindow();
    }
}