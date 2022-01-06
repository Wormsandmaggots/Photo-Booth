using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragToRotate : MonoBehaviour
{
    public float rotationSpeed = 1f;
    public float distance;
    void OnMouseDrag() {
        Vector2 rotation = new Vector2(Input.GetAxis("Mouse X") * rotationSpeed, Input.GetAxis("Mouse Y") * rotationSpeed);
        transform.Rotate(Vector3.down, rotation.x);
        transform.Rotate(Vector3.right, rotation.y);
    }
}
