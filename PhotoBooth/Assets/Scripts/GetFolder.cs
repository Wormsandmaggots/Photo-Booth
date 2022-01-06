using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Linq;
using UnityEngine.SceneManagement;

public class GetFolder : MonoBehaviour
{
    public List<Mesh> models = new List<Mesh>();
    int iterator; 
    public GameObject currentModel;

    //load models from resources
    void Start()
    {
        var temp = Resources.LoadAll("Input", typeof(Mesh)).Cast<Mesh>();
        foreach(var loaded in temp)
        {
            models.Add(loaded);
        }
        iterator = 0;
        SetModel(iterator);
    }

    //next model
    public void Forward()
    {
        iterator++;
        if(iterator >= models.Count)
            iterator = 0;
        SetModel(iterator);
    }

    //previous model
    public void Back()
    {
        iterator--;
        if(iterator < 0)
            iterator = models.Count - 1;
        SetModel(iterator);
    }
    
    public void SetModel(int i)
    {
        currentModel.GetComponent<MeshFilter>().sharedMesh = models[i];
        Destroy(currentModel.GetComponent<Collider>());
        currentModel.AddComponent<BoxCollider>();
    }
}
