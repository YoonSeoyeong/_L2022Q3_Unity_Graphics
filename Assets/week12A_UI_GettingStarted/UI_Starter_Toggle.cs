using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Starter_Toggle : MonoBehaviour
{
    Material myMaterial;
    public GameObject myGameObject; // inspecter�� �����ϱ� ���� public Ÿ������
    bool isOn;
    Color c1, c2;   //c1�� ���, c2�� ������
    // Start is called before the first frame update
    void Start()
    {
        myMaterial = myGameObject.GetComponent<Renderer>().material;

        c1 = new Color(1, 1, 1, 1);
        c2 = new Color(1, 0, 0, 1);
    }

    public void OnValueChanged_SetColor()
    {
        isOn = GetComponent<Toggle>().isOn; // isOn�� Toggle�� isOn���� �� �Ҵ�
        if (isOn)
        {
            myMaterial.SetColor("_Color", c1);
        }
        else myMaterial.SetColor("_Color", c2);
    }
}
