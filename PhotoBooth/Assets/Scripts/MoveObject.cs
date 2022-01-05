using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    Vector2 movement;

    private float x, y;
    public float speed;

    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        transform.Translate(x * speed * Time.deltaTime,0,y * speed * Time.deltaTime,0);
    }
    
}
