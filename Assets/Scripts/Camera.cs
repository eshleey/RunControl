using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform Target;
    public Vector3 TargetOffset;

    void Start()
    {
        TargetOffset = transform.position - Target.position;
    }

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, Target.position + TargetOffset, .125f);
    }
}
