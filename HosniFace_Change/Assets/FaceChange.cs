using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceChange : MonoBehaviour
{
    public Color BeardColor;

    // Start is called before the first frame update
    void Start()
    {
        BeardColor = GameObject.Find("Beard").GetComponent<SpriteRenderer>().color = Color.red;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
