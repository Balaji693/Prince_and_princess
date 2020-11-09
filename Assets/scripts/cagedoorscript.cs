
using UnityEngine;

public class cagedoorscript : MonoBehaviour
{
    // Start is called before the first frame update
  //  public cagedoordestroy dest;

    public Animator anim;
    // Update is called once per frame
     void Start()
    {
        anim = GetComponent<Animator>();
      //  anim.SetInteger("conditions", 0);
    }
    public void doors()
    {
        anim.SetInteger("conditions", 1);
        anim.SetBool("open", true);
    }

    void Update()
    {
     
       
    }
}
