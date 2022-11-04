using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Controller : MonoBehaviour
{
    public GameObject Light;
    bool isOn;

    void Start()
    {
        isOn = false;
        Light.SetActive(isOn);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))    //Light. LŰ�� ������ L down ���
        {
            print("L down");
            print(Light.name);

            isOn = !isOn;   
            Light.SetActive(isOn);
        }
    }

    private void OnMouseDown()  // ���� ������Ʈ Ŭ�� �� �۵�
    {
        print(gameObject.name + "mouse down");
        isOn = !isOn;
        Light.SetActive(isOn);
    }
}
