using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipes : MonoBehaviour
{
    public float speed = 5f;
    public float destroyPosition = -10f;
    
    // Update is called once per frame
    void Update()
    {
        // Move the pipe to the left
        transform.position += Vector3.left * speed * Time.deltaTime;
        
        // Destroy the pipe if it reaches the destroy position
        if (transform.position.x <= destroyPosition)
        {
            Destroy(gameObject);
        }
    }
}
