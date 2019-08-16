using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modifyCube : MonoBehaviour
{

    Mesh mesh;
    Vector3[] vertices;

    void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;
        vertices = mesh.vertices;

        Debug.Log(vertices.Length);
        for (int i = 0; i < vertices.Length; i++)
        {
            Debug.Log(vertices[i]);
        }
    }

    void Update()
    {
        for (int i = 0; i < 3; i++)
        {
            vertices[i] += Vector3.up * Time.deltaTime * 0.1f;
        }
        mesh.vertices = vertices;
        mesh.RecalculateBounds();
    }

    private void OnDrawGizmos()
    {
        if (vertices == null) return;

        for (int i = 0; i < vertices.Length; i++)
        {
            Gizmos.DrawSphere(vertices[i], .05f);
        }
    }
}
