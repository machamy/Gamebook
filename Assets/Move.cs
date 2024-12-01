using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        
        Vector3 moveDirection = new Vector3(x, y, 0).normalized;
        
        transform.position += moveDirection * speed * Time.deltaTime;
        
        
    }
}
