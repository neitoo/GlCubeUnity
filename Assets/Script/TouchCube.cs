using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchCube : MonoBehaviour
{
   private Renderer cubeRenderer;
    private Color[] colors = { 
        Color.red,
        Color.green,
        Color.blue,
        Color.yellow,
        Color.magenta,
        Color.cyan,
        Color.white
    }; 

    private void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
    }

    private void OnMouseDown()
    {
        ChangeCubeColor();
    }

    private void ChangeCubeColor()
    {
        Color newColor = colors[Random.Range(0, colors.Length)];

        cubeRenderer.material.color = newColor;
    }
}
