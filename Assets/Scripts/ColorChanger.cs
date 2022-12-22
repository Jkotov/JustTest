using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color newColor;
    private Color defaultColor;
    private Material mat;
    
    public void ChangeColor(bool isNewColor)
    {
        mat.color = isNewColor ? newColor : defaultColor;
    }

    private void Awake()
    {
        mat = GetComponent<MeshRenderer>().material;
        defaultColor = mat.color;
    }
}
