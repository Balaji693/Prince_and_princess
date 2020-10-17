using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemycontroller : MonoBehaviour
{
    // Start is called before the first frame update

    public Camera cam;
    public GameObject target;
    public Transform player;
    public NavMeshAgent agent;
    Animator animator;
   protected float Playerdistance;
    // Update is called once per frame

    void Start()
    {
        animator = GetComponent<Animator>();
        

    }
    void FixedUpdate()
    {
        Playerdistance = Vector3.Distance(player.position, transform.position);
        if(Playerdistance < 12)
        {
            agent.SetDestination(target.transform.position);
            animator.SetInteger("conditions", 1);
            animator.SetBool("running", true);
            animator.SetBool("attacking", false);
        }
        if(Playerdistance > 12)
        {
            animator.SetInteger("conditions", 0);


        }
        if (Playerdistance < 1)
        {
            if (animator.GetBool("running") == true)
            {

                animator.SetBool("running", false);
                animator.SetBool("attacking", true);
                animator.SetInteger("conditions", 2);

            }
        }
        if(animator.GetBool("attacking") == true)
        {
            if(Playerdistance < 0.6)
            {
                Debug.Log("Hit");
            }
        }
        
       

      
        

    }
}

