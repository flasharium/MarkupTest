using System.IO;
using UnityEngine;

public class LanguageController : MonoBehaviour
{
    private string _json;
    public static SettingsWindowText _settingsWindowTextLanguage = new SettingsWindowText();

    private void Awake()
    {
        LoadLanguage();
    }

    private void LoadLanguage()
    {
        _json = File.ReadAllText(Application.streamingAssetsPath + "/Language/SettingsWindowText.json");
        _settingsWindowTextLanguage = JsonUtility.FromJson<SettingsWindowText>(_json);
    }
}

public class SettingsWindowText
{
    public string[] settingsWindowHeader;
    public string[] nickNameHeader;
    public string[] nickNameDescription;
    public string[] sound;
    public string[] languageHeader;
    public string[] socialHeader;
    public string[] VKSocialButton;
    public string[] discordSocialButton;
    public string[] supportButton;
}