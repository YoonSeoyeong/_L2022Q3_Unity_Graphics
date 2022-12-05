using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quad : MonoBehaviour
{
    public Vector3[] newVertices;   // 3���� �����̱� ������
    public int[] newTriangles;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();

        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh; // meshFilter�� mesh �� = ���� ������ mesh �� �Ҵ�
        mesh.vertices = newVertices;
        mesh.triangles = newTriangles;

        Shader DefaultShader = Shader.Find("Standard");
        Material DeaultMaterial = new Material(DefaultShader);
        gameObject.GetComponent<Renderer>().material = DeaultMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
