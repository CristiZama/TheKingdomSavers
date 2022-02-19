using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonsFade : MonoBehaviour
{
    [SerializeField] private float fadeValue;
    private LogoGrow logoGrow;
    private Image img;
    private TMP_Text textRenderer;
    Color color;
    Color colorText;

    private void Start()
    {
        logoGrow = FindObjectOfType<LogoGrow>();
        img = GetComponent<Image>();
        textRenderer = transform.GetChild(0).GetComponent<TMP_Text>();

        // The next lines are asigning the alpha values for each of the components
        Color c = img.color;
        Color cT = textRenderer.color;
        c.a = 0;
        cT.a = 0;
        img.color = c;
        textRenderer.color = cT;
        color = c;
        colorText = cT;
    }

    private void Update()
    {
        if(logoGrow.hasFinished && color.a <= 255 && colorText.a <= 255)
        {
            color.a += fadeValue;
            colorText.a += fadeValue;
            img.color = color;
            textRenderer.color = colorText;
        }
    }
}
