using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Target;
    public GameObject CharacterPrefab;
    public GameObject Destination;
    public GameObject Source;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            Instantiate(CharacterPrefab, Source.transform.position, Quaternion.identity);
        }
    }
}
