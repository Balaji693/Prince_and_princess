
using UnityEngine;

public class playerdying : MonoBehaviour
{
    public Rigidbody rb;
    public Animator animator;
    public Playermovement movements;
    
    // Start is called before the first frame update
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
      movements = FindObjectOfType<Playermovement>();
        animator = GetComponent<Animator>();
       
    }

    public void OnTriggerEnter(Collider others)
    {
        if (others.gameObject.tag == "Enemy")
        {
            animator.SetBool("Isdying", true);
            animator.SetInteger("conditions", 2);
            animator.SetBool("Isidle", false);
            animator.SetBool("Isrunning", false);
            movements.enabled = false;





        }
       
    }

}
