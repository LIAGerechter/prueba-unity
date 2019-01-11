using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public float time = 5; //Seconds to read the text

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
