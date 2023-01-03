using UnityEngine;

[RequireComponent(typeof(ColorChanger))]
public class ColorChangerListenerOnRamp : ListenerOnRamp
{
    private ColorChanger colorChanger;
    
    protected override void DoOnFire(bool onRamp)
    {
        ChangeColor(onRamp);
    }
    
    private void ChangeColor(bool onRamp)
    {
        colorChanger.ChangeColor(onRamp);
    }

    private void Awake()
    {
        colorChanger = GetComponent<ColorChanger>();
    }
}