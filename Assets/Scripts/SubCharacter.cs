using UnityEngine;
using UnityEngine.AI;

public class SubCharacter : MonoBehaviour
{
    GameObject Target;
    NavMeshAgent NavMesh;

    void Start()
    {
        NavMesh = GetComponent<NavMeshAgent>();
        Target = GameObject.FindWithTag("GameManager").GetComponent<GameManager>().Destination;
    }

    void LateUpdate()
    {
        NavMesh.SetDestination(Target.transform.position);
    }
}
