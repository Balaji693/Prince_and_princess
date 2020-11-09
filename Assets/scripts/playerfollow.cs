
using UnityEngine;

public class playerfollow : MonoBehaviour
{
    public Vector3 offset;
    public Vector3 offsets;
    public Transform player;
    public float smoothspeed = 0.125f;


    public void Start()
    {

    }
    public void FixedUpdate()
    {
        transform.position = player.position + offset;
     //  Vector3 desiredposition = player.position + offset;
      //  Vector3 smoothposition = Vector3.Lerp(transform.position, desiredposition, smoothspeed);
      //  transform.position = smoothposition;
       // transform.LookAt(player);
    
    }
}
