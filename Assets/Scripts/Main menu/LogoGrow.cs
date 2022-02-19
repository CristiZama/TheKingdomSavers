using UnityEngine;

public class LogoGrow : MonoBehaviour
{
    [SerializeField] private float growFactor;
    [SerializeField] private float maxSize;
    private SpriteRenderer spriteRenderer;
    private Color color;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        color = spriteRenderer.color;
    }

    private void Update()
    {
        if(transform.localScale.x <= maxSize)
        {
            transform.localScale = new Vector3(transform.localScale.x + growFactor, transform.localScale.y + growFactor, 1.0f);
        }
        else
        {
            if(color.a >= 0)
            {
                color.a -= growFactor;
                spriteRenderer.color = color;
            }
        }
    }
}