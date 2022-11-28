using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Starter_Toggle : MonoBehaviour
{
    Material myMaterial;
    public GameObject myGameObject; // inspecter로 접근하기 위해 public 타입으로
    bool isOn;
    Color c1, c2;   //c1은 흰색, c2는 빨간색
    // Start is called before the first frame update
    void Start()
    {
        myMaterial = myGameObject.GetComponent<Renderer>().material;

        c1 = new Color(1, 1, 1, 1);
        c2 = new Color(1, 0, 0, 1);
    }

    public void OnValueChanged_SetColor()
    {
        isOn = GetComponent<Toggle>().isOn; // isOn에 Toggle의 isOn변수 값 할당
        if (isOn)
        {
            myMaterial.SetColor("_Color", c1);
        }
        else myMaterial.SetColor("_Color", c2);
    }
}
