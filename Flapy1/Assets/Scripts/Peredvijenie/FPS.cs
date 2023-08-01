using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPS : MonoBehaviour
{
    [SerializeField] private float fps;
    [SerializeField] private Text fpsText;

    void Update()
    {


        fps = 1.0f / Time.deltaTime;
        fpsText.text = "тоя:" + (int)fps;

    }
}
