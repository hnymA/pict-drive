using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleScript : MonoBehaviour
{
    public Material circleMaterial;

    private void Start()
    {
        int width = Screen.width;
        int height = Screen.height;

        float thetaScale = 0.01f;
        int size = (int)(2.0f * Mathf.PI / thetaScale);

        LineRenderer renderer = gameObject.GetComponent<LineRenderer>();
        renderer.material = circleMaterial;
        renderer.SetWidth(0.1f, 0.1f);
        renderer.SetVertexCount(size);

        int i = 0;
        float x, y;
        float r = 0.8f;
        for (float theta = 0f; theta < 2 * Mathf.PI; theta += 0.01f)
        {
            x = r * Mathf.Cos(theta);
            y = r * Mathf.Sin(theta);

            Vector3 pos = new Vector3(x, y, -5.0f);
            renderer.SetPosition(i, pos);
            i += 1;
        }
    }

    private void Update()
    {
        
    }
}
