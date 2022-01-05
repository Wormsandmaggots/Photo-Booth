using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCameraPosition : MonoBehaviour
{
    public GameObject model;
    private void Start() {
        transform.position = new Vector3(model.transform.position.x, 5, -5);
        //transform.Translate(5, 0, model.transform.position.z, 0);
    }
}
