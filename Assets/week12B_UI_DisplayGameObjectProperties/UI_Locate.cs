using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Locate : MonoBehaviour
{
    public Transform PosReference;  //cube의 transform 값을 받아옴
    Camera TargetCamera;
    // Start is called before the first frame update
    void Start()
    {
        // 메인카메라 태그를 갖고 있는 게임오브젝트를 찾고 해당 오브젝트 할당
        TargetCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayAtPoint();
    }

    void DisplayAtPoint()
    {
        Vector3 WorldPos = PosReference.position + Vector3.up;   // cube의 3D world 좌표값 할당
        Vector2 ScreenPos = TargetCamera.WorldToScreenPoint(WorldPos);  // vectr3값을 2D로 바꿔줌
        transform.position = ScreenPos;
    }
}
