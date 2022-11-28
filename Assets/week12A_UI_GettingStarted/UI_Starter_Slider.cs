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
        myMaterial = myGameObject.GetComponent<Renderer>().material;  // render���� material�� �����ؾ���
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnValueChanged_SetColor()   // ����� �Լ�
    {
        float val = GetComponent<Slider>().value;   // �����̴��� ������ ���� �� ���
        print(val);
        Color c = new Color(val, val, val, 1);
        myMaterial.SetColor("_Color", c);
    }
}
