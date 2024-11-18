using UnityEngine;

public class ResponsiveUI : MonoBehaviour
{
    [Header("Иконки ресурсов")]
    public RectTransform moneyIcon;
    public RectTransform foodIcon;
    public RectTransform waterIcon;
    public RectTransform menuButton;

    [Header("Отступы и размеры (%)")]
    [Range(0, 1)] public float statusBarHeight = 0.25f;    // Высота верхней панели
    [Range(0, 1)] public float leftPadding = 0.05f;        // Отступ слева
    [Range(0, 1)] public float rightPadding = 0.05f;       // Отступ справа
    [Range(0, 1)] public float verticalSpacing = 0.05f;    // Отступ между иконками

    void Start()
    {
        InitializeStatusBar();
        AdjustUI();
    }

    void InitializeStatusBar()
    {
        RectTransform statusBarRect = GetComponent<RectTransform>();
        statusBarRect.anchorMin = new Vector2(0, 1);
        statusBarRect.anchorMax = new Vector2(1, 1);
        statusBarRect.pivot = new Vector2(0.5f, 1);
        statusBarRect.anchoredPosition = Vector2.zero;
        statusBarRect.sizeDelta = new Vector2(0, Screen.height * statusBarHeight);
    }

    void AdjustUI()
    {
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        float statusBarSize = screenHeight * statusBarHeight;
        float leftOffset = screenWidth * leftPadding;
        float rightOffset = screenWidth * rightPadding;
        float iconSizePixels = statusBarSize * 0.2f; // Размер иконок

        // Настройка всех иконок
        SetupIcon(moneyIcon, leftOffset, iconSizePixels, 0.8f);
        SetupIcon(foodIcon, leftOffset, iconSizePixels, 0.5f);
        SetupIcon(waterIcon, leftOffset, iconSizePixels, 0.2f);

        // Настройка кнопки меню
        SetupMenuButton(menuButton, rightOffset, iconSizePixels);
    }

    void SetupIcon(RectTransform icon, float leftOffset, float iconSize, float verticalPosition)
    {
        icon.sizeDelta = new Vector2(iconSize, iconSize);
        icon.anchorMin = new Vector2(0, verticalPosition);
        icon.anchorMax = new Vector2(0, verticalPosition);
        icon.pivot = new Vector2(0, 0.5f);
        icon.anchoredPosition = new Vector2(leftOffset, 0);
    }

    void SetupMenuButton(RectTransform button, float rightOffset, float iconSize)
    {
        button.sizeDelta = new Vector2(iconSize, iconSize);
        button.anchorMin = new Vector2(1, 0.5f);
        button.anchorMax = new Vector2(1, 0.5f);
        button.pivot = new Vector2(1, 0.5f);
        button.anchoredPosition = new Vector2(-rightOffset, 0);
    }

    void Update()
    {
        if (Screen.width != 0 && Screen.height != 0)
        {
            AdjustUI();
        }
    }
}
