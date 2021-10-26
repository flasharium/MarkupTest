using System;
using UnityEngine;

public class BaseWindow : MonoBehaviour
{
    private Animator _windowAnimator;

    private void Awake()
    {
        _windowAnimator = gameObject.GetComponent<Animator>();
    }

    public void ShowWindow()
    {
        gameObject.SetActive(true);
        UpdateScreenSize();
    }

    private void UpdateScreenSize()
    {
        var safeArea = Screen.safeArea;
        var rectTransform = GetComponent<RectTransform>();
        var anchorMin = safeArea.position;
        var anchorMax = safeArea.position + safeArea.size;

        anchorMin.x /= Screen.width;
        anchorMin.y /= Screen.height;

        anchorMax.x /= Screen.width;
        anchorMax.y /= Screen.height;

        rectTransform.anchorMax = anchorMax;
        rectTransform.anchorMin = anchorMin;
    }

    protected void CloseWindow()
    {
        _windowAnimator.Play("WindowClose");
    }
}
