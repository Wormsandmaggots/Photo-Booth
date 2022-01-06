using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TakeAPhoto : MonoBehaviour
{
    public void TakePhoto()
    {
        string date = DateTime.Now.ToString();
        date = date.Replace("/", "-");
        date = date.Replace(" ", "_");
        date = date.Replace(":", "-");
        ScreenCapture.CaptureScreenshot("Assets/Resources/Output/" + date + ".png");
    }
}
