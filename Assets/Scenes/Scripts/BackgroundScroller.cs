using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [Range(-1f, 1f)]
    public float scrollSpeed = 0.5f;
    private Renderer render;

    void Start()
    {
        render = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        render.material.mainTextureOffset += new Vector2(scrollSpeed * Time.deltaTime, 0f);
    }
}
