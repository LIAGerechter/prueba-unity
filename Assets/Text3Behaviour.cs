using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text3Behaviour : MonoBehaviour
{

    public float time = 11; //Seconds to read the text

    void Start()
    {
        gameObject.SetActive(false);
        Invoke("Show", time);
    }

    void Show()
    {
        gameObject.SetActive(true);
    }
}