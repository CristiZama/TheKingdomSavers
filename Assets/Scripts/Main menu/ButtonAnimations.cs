using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimations : MonoBehaviour
{
    private LogoGrow logoGrow;

    private void Start()
    {
        logoGrow = FindObjectOfType<LogoGrow>();
    }

    private void Update()
    {
        if(logoGrow.hasFinished && transform.position.y >= -121.9f)
        {
            transform.position = new Vector3(transform.position.x + 0.006f, transform.position.y, 0);
        }
    }
}
