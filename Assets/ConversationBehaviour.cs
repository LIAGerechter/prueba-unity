using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConversationBehaviour : MonoBehaviour {

    void Start()
    {
        GameObject newGO = new GameObject("myTextGO");
        newGO.transform.SetParent(this.transform);

        Text myText = newGO.AddComponent<Text>();

        Font ArialFont = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
        myText.font = ArialFont;
        myText.material = ArialFont.material;
        myText.transform.position = new Vector3(-170, 70, 0); 
        myText.fontSize = 25;
        myText.text = "Ta-dah!";
    }

    // Update is called once per frame
    void Update () {
		
	}

}
