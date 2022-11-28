using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Starter_Text : MonoBehaviour
{
    public GameObject myGameObject;
    // Start is called before the first frame update
    void Start()
    {
        string name = myGameObject.name;
        name += " made by Yoon seo yeong";
        GetComponent<Text>().text = name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
