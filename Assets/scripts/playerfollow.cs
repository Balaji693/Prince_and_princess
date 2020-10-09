
using UnityEngine;

public class playerfollow : MonoBehaviour
{
    public Vector3 offset;
    public Transform player;



    public void Update()
    {
        transform.position = player.position + offset;
    
    }
}
