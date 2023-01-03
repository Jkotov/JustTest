using UnityEngine;

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
