using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class whiteclown : MonoBehaviour
{
    public Camera cam;
    public GameObject target;
    public Transform player;
    public NavMeshAgent agent;
    Animator animator;
    protected float Playerdistance;
 
    // Start is called before the first frame update
    void Start()
    {
      
        animator = GetComponent<Animator>();
        animator.SetInteger("conditions", 0);
        animator.SetBool("idle", true);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Playerdistance = Vector3.Distance(player.position, transform.position);

    
    }
    
     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            entered();
            if(Playerdistance > 8)
            {
                far();
            }
            else
            {
                far();
            }
        }
    }
     void OnTriggerExit(Collider other)
    {
        if (Playerdistance > 8)
        {
            far();
            Debug.Log("out");
        }
        else
        {
            far();
        }
    }


    void entered()
    {
       
            agent.SetDestination(target.transform.position);
            animator.SetInteger("conditions", 1);
            animator.SetBool("crawl", true);
            animator.SetBool("idle", false);
        
        
      
    }
    void far()
    {
            agent.SetDestination(target.transform.position);
            animator.SetInteger("conditions", 1);
            animator.SetBool("crawl", true);
            animator.SetBool("idle", false);

    



    }
}
