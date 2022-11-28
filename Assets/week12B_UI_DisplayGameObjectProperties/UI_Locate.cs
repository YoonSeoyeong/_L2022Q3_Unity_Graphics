using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Locate : MonoBehaviour
{
    public Transform PosReference;  //cube�� transform ���� �޾ƿ�
    Camera TargetCamera;
    // Start is called before the first frame update
    void Start()
    {
        // ����ī�޶� �±׸� ���� �ִ� ���ӿ�����Ʈ�� ã�� �ش� ������Ʈ �Ҵ�
        TargetCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayAtPoint();
    }

    void DisplayAtPoint()
    {
        Vector3 WorldPos = PosReference.position + Vector3.up;   // cube�� 3D world ��ǥ�� �Ҵ�
        Vector2 ScreenPos = TargetCamera.WorldToScreenPoint(WorldPos);  // vectr3���� 2D�� �ٲ���
        transform.position = ScreenPos;
    }
}
