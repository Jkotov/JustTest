using UnityEngine;
using UnityEngine.Events;

public class RampChecker : MonoBehaviour
{
    public UnityEvent<bool> onRamp;
    private int rampCollisions;
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.collider.TryGetComponent(out Ramp ramp))
            return;
        rampCollisions++;
        onRamp?.Invoke(true);
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        if (!col.collider.TryGetComponent(out Ramp ramp))
            return;
        rampCollisions--;
        if (rampCollisions == 0)
        {
            onRamp?.Invoke(false);
        }
    }
}
