using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    
    private void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.position += new Vector3(x, 0.0f);
    }
}