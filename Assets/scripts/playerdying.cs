
using UnityEngine;

public class playerdying : MonoBehaviour
{
    public Rigidbody rb;
    protected Animator animator;
    public Playermovement movements;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            animator.SetInteger("conditions", 2);
            animator.SetBool("Isdying", true);
            animator.SetBool("Isidle", false);
            animator.SetBool("Isrunning", false);
            movements.enabled = false;
            Debug.Log("die");
        }
    }
}
