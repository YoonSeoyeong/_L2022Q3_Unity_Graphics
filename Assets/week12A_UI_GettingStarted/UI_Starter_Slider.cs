using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Starter_Slider : MonoBehaviour
{
    public GameObject myGameObject;
    Material myMaterial;
    // Start is called before the first frame update
    void Start()
    {
        myMaterial = myGameObject.GetComponent<Renderer>().material;  // render에서 material에 접근해야함
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnValueChanged_SetColor()   // 사용자 함수
    {
        float val = GetComponent<Slider>().value;   // 슬라이더를 움직일 때만 값 출력
        print(val);
        Color c = new Color(val, val, val, 1);
        myMaterial.SetColor("_Color", c);
    }
}
