using UnityEngine;
using UnityEngine.UI;

public class UIUpper : MonoBehaviour
{
    [SerializeField] private SettingsWindowButton _settingsWindowButton;
    private void Start()
    {
        AttachListeners();
    }

    private void AttachListeners()
    {
        _settingsWindowButton.GetComponent<Button>().onClick.AddListener(_settingsWindowButton.ShowSettingsWindow);
    }
}