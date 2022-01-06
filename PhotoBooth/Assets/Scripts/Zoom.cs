using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public float speed;
    void Update() {
        Camera.main.fieldOfView -= Input.GetAxisRaw("Mouse ScrollWheel") * speed;
    }
}
