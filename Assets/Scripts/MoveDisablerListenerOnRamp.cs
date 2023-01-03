using UnityEngine;

[RequireComponent(typeof(MoveController))]
public class MoveDisablerListenerOnRamp : ListenerOnRamp
{
    private MoveController moveController;
    
    protected override void DoOnFire(bool onRamp)
    {
        moveController.DisableMove(onRamp);
    }

    private void Awake()
    {
        moveController = GetComponent<MoveController>();
    }
}
