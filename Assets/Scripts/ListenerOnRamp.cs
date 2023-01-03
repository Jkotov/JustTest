using UnityEngine;

public abstract class ListenerOnRamp : MonoBehaviour
{
    [SerializeField] protected RampChecker publisher;
    
    public void SetPublisher(RampChecker newPublisher)
    {
        if (publisher)
            publisher.onRamp.RemoveListener(DoOnFire);
        publisher = newPublisher;
        publisher.onRamp.AddListener(DoOnFire);
    }

    protected abstract void DoOnFire(bool onRamp);
    
    private void OnEnable()
    {
        publisher.onRamp.AddListener(DoOnFire);
    }

    private void OnDisable()
    {
        publisher.onRamp.RemoveListener(DoOnFire);
    }
}
