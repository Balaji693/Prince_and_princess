
using UnityEngine;

public class fireworks : MonoBehaviour
{

    public GameObject firework;
    public bool done;
    public float count;
    public Enemycontroller movement;
   
    // Start is called before the first frame update

    // Update is called once per frame
    public void Start()
    {
        movement = FindObjectOfType<Enemycontroller>();
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Prince")
        {
            
            done = true;
            count = count + 1;
            
            

        }
       if(count == 1)
        {
            Instantiate(firework, new Vector3(8.08f, -10f, 21.15f), Quaternion.Euler(-90f, 90f, 0f));

            movement.enabled = false;
        }
       if(count >= 1)
        {
            movement.enabled = false;
        }
    }
}
