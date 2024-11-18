using UnityEngine;
using UnityEngine.SceneManagement;

public class MapButton : MonoBehaviour
{
    private RectTransform rectTransform;

    [Header("Настройки сцены")]
    public Object sceneAsset; // Сцена для перехода

    [Header("Настройки кнопки (проценты)")]
    [Range(0, 100)] public float buttonSizePercent = 10f; // Размер кнопки в процентах от меньшей стороны экрана
    [Range(0, 100)] public float bottomOffsetPercent = 5f; // Отступ снизу в процентах от высоты экрана
    [Range(0, 100)] public float leftOffsetPercent = 5f; // Отступ слева в процентах от ширины экрана

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        SetupButton();
    }

    void SetupButton()
    {
        // Получаем размеры экрана
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;

        // Рассчитываем размер кнопки
        float buttonSize = Mathf.Min(screenWidth, screenHeight) * (buttonSizePercent / 100f);

        // Рассчитываем отступы
        float bottomOffset = screenHeight * (bottomOffsetPercent / 100f);
        float leftOffset = screenWidth * (leftOffsetPercent / 100f);

        // Настраиваем размеры и позицию кнопки
        rectTransform.sizeDelta = new Vector2(buttonSize, buttonSize);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        rectTransform.pivot = new Vector2(0, 0);
        rectTransform.anchoredPosition = new Vector2(leftOffset, bottomOffset);
    }

    public void SwitchScene()
    {
        if (sceneAsset != null)
        {
            SceneManager.LoadScene(sceneAsset.name);
        }
    }
}