using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsWindow : BaseWindow
{
    public static SettingsWindow Instance;
    [SerializeField] private Button _closeButton;
    [SerializeField] private TMP_Dropdown _choiceLanguage;
    [SerializeField] private TextMeshProUGUI _settingsWindowHeader;
    [SerializeField] private TextMeshProUGUI _nickNameHeader;
    [SerializeField] private TextMeshProUGUI _nickNameDescription;
    [SerializeField] private TextMeshProUGUI _sound;
    [SerializeField] private TextMeshProUGUI _languageHeader;
    [SerializeField] private TextMeshProUGUI _socialHeader;
    [SerializeField] private TextMeshProUGUI _vkSocialButton;
    [SerializeField] private TextMeshProUGUI _discordSocialButton;
    [SerializeField] private TextMeshProUGUI _supportButton;

    private void AttachListeners()
    {
        _closeButton.onClick.AddListener(CloseWindow);
        _choiceLanguage.onValueChanged.AddListener(ChangeLanguage);
    }

    private void ChangeLanguage(int value)
    {
        _settingsWindowHeader.text = LanguageController._settingsWindowTextLanguage.settingsWindowHeader[value];
        _nickNameHeader.text = LanguageController._settingsWindowTextLanguage.nickNameHeader[value];
        _nickNameDescription.text = LanguageController._settingsWindowTextLanguage.nickNameDescription[value];
        _sound.text = LanguageController._settingsWindowTextLanguage.sound[value];
        _languageHeader.text = LanguageController._settingsWindowTextLanguage.languageHeader[value];
        _socialHeader.text = LanguageController._settingsWindowTextLanguage.socialHeader[value];
        _vkSocialButton.text = LanguageController._settingsWindowTextLanguage.VKSocialButton[value];
        _discordSocialButton.text = LanguageController._settingsWindowTextLanguage.discordSocialButton[value];
        _supportButton.text = LanguageController._settingsWindowTextLanguage.supportButton[value];
    }

    private void DettachListeners()
    {
        _closeButton.onClick.RemoveListener(CloseWindow);
        gameObject.SetActive(false);
    }
}