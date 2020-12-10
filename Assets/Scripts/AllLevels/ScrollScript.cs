using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollScript : MonoBehaviour
{
    public GameObject planeGameObject;
    private Renderer planeRenderer;

    float scrollSpeed = 0.1f;

    void Start()
    {
        planeRenderer = planeGameObject.GetComponent<Renderer>();
    }

    void Update()
    {
        Vector2 textureOffset = new Vector2(Time.time * scrollSpeed, 0);
        planeRenderer.material.mainTextureOffset = textureOffset;
    }
}
