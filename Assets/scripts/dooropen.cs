using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dooropen : MonoBehaviour
{
    public Animator anims;
    // Start is called before the first frame update
    void Start()
    {
        anims = GetComponent<Animator>();
        anims.SetInteger("condition", 0);
    }

    // Update is called once per frame
   
    public  void opendoor()
    {
        anims.SetInteger("condition", 1);
        anims.SetBool("open", true);
        Debug.Log("open");
    }
}
