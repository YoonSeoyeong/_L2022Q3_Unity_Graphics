using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PostEffects_Rev : MonoBehaviour
{
    // ī�޶� �̹��� ȿ���� �ֱ����� 
    Shader myShader;
    Material myMaterial;
    // Start is called before the first frame update
    void Start()
    {
        // myShader �ʱ�ȭ
        myShader = Shader.Find("My/PostEffects/Rev");  
        myMaterial = new Material(myShader);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // source�� ������ destination���� �������� ��
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, myMaterial, 0);
    }

    private void OnDisable()
    {
        if(myMaterial)
        {
            DestroyImmediate(myMaterial);
        }
    }
}
