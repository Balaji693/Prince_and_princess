using System.Collections;

using UnityEngine;


public class Playermovement : MonoBehaviour
{

    public FixedJoystick leftjoystick;
   
    protected Joybutton button;
    protected CharacterController characterController;
    Vector3 Movedir = Vector3.zero;
    public Rigidbody rb;
    protected Animator animator;
    protected float cameraangleY = 2f;
    protected float cameraanglespeed = 2f;
    protected float cameraposY;
    protected float cameraposspeed = 2f;
  //  public FixedJoystick rightjoystick;
    public float rot;
    public float rotspeed = 2f;
    public float gravity = 20.0f;
    protected float Stop = 1f;
    protected float Runspeed = 4;
    public Enemycontroller enemy;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
      //  button = FindObjectOfType<Joybutton>();
        leftjoystick = FindObjectOfType<FixedJoystick>();
        
    }
    void Update()
    {
        Movement();


        





        //   rb.velocity = new Vector3(vel.x, rb.velocity.y, vel.z);

        //  cameraangleY += rightjoystick.Horizontal * cameraanglespeed ;
        transform.rotation = Quaternion.LookRotation(Movedir);
            transform.rotation = Quaternion.AngleAxis(cameraangleY + Vector3.SignedAngle(Vector3.forward, Movedir.normalized + Vector3.forward * 0.001f ,Vector3.up), Vector3.up);


        Movedir.y -= gravity * Time.deltaTime;
      characterController.Move(Movedir * Time.deltaTime);
    }

   public void Movement()
    {
        Movedir = new Vector3(leftjoystick.Horizontal * 1f, 0, leftjoystick.Vertical * 1f);
     var vel = Quaternion.AngleAxis(cameraangleY + 180, Vector3.up) * Movedir * 5f;


        if (leftjoystick.Vertical != 0f)
        {
            animator.SetBool("Isidle", false);
            animator.SetInteger("conditions", 1);
            animator.SetBool("Isrunning", true);
            transform.rotation = Quaternion.LookRotation(Movedir);
            

        }

        if (leftjoystick.Horizontal != 0f)
        {
            animator.SetBool("Isidle", false);
            animator.SetInteger("conditions", 1);
            animator.SetBool("Isrunning", true);

            transform.rotation = Quaternion.LookRotation(Movedir);
        


        }
       
        else
        {
            animator.SetBool("Isidle", true);
            animator.SetInteger("conditions", 0);
            animator.SetBool("Isrunning", false);
        }

        
        if (button.pressed)
        {


           

        }


    }

     
   




}


