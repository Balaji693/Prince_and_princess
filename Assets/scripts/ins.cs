
using UnityEngine;

public class ins : MonoBehaviour

   
{
    public GameObject spawn;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(spawn, transform.position, transform.rotation);
    }

   
}
