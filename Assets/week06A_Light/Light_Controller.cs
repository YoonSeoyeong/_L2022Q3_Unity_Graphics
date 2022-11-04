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
        if (Input.GetKeyDown(KeyCode.L))    //Light. L키를 누르면 L down 출력
        {
            print("L down");
            print(Light.name);

            isOn = !isOn;   
            Light.SetActive(isOn);
        }
    }

    private void OnMouseDown()  // 게임 오브젝트 클릭 시 작동
    {
        print(gameObject.name + "mouse down");
        isOn = !isOn;
        Light.SetActive(isOn);
    }
}
