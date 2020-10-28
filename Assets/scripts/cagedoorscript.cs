
using UnityEngine;

public class cagedoorscript : MonoBehaviour
{
    // Start is called before the first frame update
    public cagedoordestroy dest;
   

    // Update is called once per frame
    
  public void doors()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        if(dest.doordestroy == true)
        {
            
            Debug.Log("count 1");
        }
        if(dest.count == 1)
        {
            Destroy(gameObject);
        }
    }
}
