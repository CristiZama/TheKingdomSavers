using UnityEngine;
using TMPro;

public class FPS_Shower : MonoBehaviour
{
    private TMP_Text displayText;
    private int avgFrameRate;
 
    private void Start()
    {
        displayText = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        float current = 0;
        current = Time.frameCount / Time.time;
        avgFrameRate = (int)current;
        displayText.text = $"{avgFrameRate.ToString()} FPS";
    }
}