using UnityEngine;

public class SpineBoyAnimController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private string hoverboardVarName;
    [SerializeField] private string runVarName;
    private bool isOnHoverboard;
    private bool isRunning;
    private int hoverboardVarHash;
    private int runVarHash;
    
    public void ChangeIsOnHoverboardState(bool value)
    {
        animator.SetBool(hoverboardVarHash, value);
    }

    public void ChangeIsRunningState(bool value)
    {
        animator.SetBool(runVarHash, value);
    }
    
    private void Awake()
    {
        hoverboardVarHash = Animator.StringToHash(hoverboardVarName);
        runVarHash = Animator.StringToHash(runVarName);
    }
}
