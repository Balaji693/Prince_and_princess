
using UnityEngine;

public class cagedoordestroy : MonoBehaviour
{
    // Start is called before the first frame update

   
   public bool doordestroy;
    public cagedoorscript door;
    public int count = 0;
    public GameObject script;
    public dooropen open;
    
     void Start()
    {
        count = 0;
        door = FindObjectOfType<cagedoorscript>();
        open = FindObjectOfType<dooropen>();
        // cagedoorscript door = gameObject.GetComponent("cagedoorscript") as cagedoorscript;
      

    }
   
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Prince")
        {
            count = count + 1;
            doordestroy = true;
            open.opendoor();
            Destroy(gameObject);
            door.doors();
            open.opendoor();
            

        }
      
        
    }
}
