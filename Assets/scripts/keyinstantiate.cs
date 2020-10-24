
using UnityEngine;

public class keyinstantiate : MonoBehaviour
{

    public GameObject key;
     void Start()
    {
       
    }
    // Start is called before the first frame update

    // Update is called once per frame

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Prince")
        {
           
            Instantiate(key, transform.position, transform.rotation);
          
        }
       
    }

   public void dis()
    {
        key.SetActive(false);
    }
    public void ena()
    {
        key.SetActive(true);
    }
}
