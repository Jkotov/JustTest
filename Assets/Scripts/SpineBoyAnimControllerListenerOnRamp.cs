using UnityEngine;

[RequireComponent(typeof(SpineBoyAnimController))]
public class SpineBoyAnimControllerListenerOnRamp : ListenerOnRamp
{
    private SpineBoyAnimController animController;

    protected override void DoOnFire(bool onRamp)
    {
        animController.ChangeIsOnHoverboardState(onRamp);
    }

    private void Awake()
    {
        animController = GetComponent<SpineBoyAnimController>();
    }
}