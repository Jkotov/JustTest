using UnityEngine;

[RequireComponent(typeof(SpineBoyAnimController))]
public class SpineBoyAnimControllerListenerOnMove : MonoBehaviour
{
    [SerializeField] private MoveController publisher;
    private SpineBoyAnimController animController;

    public void SetPublisher(MoveController newPublisher)
    {
        if (publisher)
            publisher.isMoving.RemoveListener(ChangeIsRunningState);
        publisher = newPublisher;
        publisher.isMoving.AddListener(ChangeIsRunningState);
    }

    private void ChangeIsRunningState(bool isMoving)
    {
        animController.ChangeIsRunningState(isMoving);
    }
    
    private void Awake()
    {
        animController = GetComponent<SpineBoyAnimController>();
    }
    
    private void OnEnable()
    {
        publisher.isMoving.AddListener(ChangeIsRunningState);
    }

    private void OnDisable()
    {
        publisher.isMoving.RemoveListener(ChangeIsRunningState);
    }
}
