using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PostEffects_Rev : MonoBehaviour
{
    // 카메라에 이미지 효과를 주기위함 
    Shader myShader;
    Material myMaterial;
    // Start is called before the first frame update
    void Start()
    {
        // myShader 초기화
        myShader = Shader.Find("My/PostEffects/Rev");  
        myMaterial = new Material(myShader);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // source의 영상을 destination에서 보여지게 함
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
