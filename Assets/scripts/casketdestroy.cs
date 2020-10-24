
using UnityEngine;

public class casketdestroy : MonoBehaviour
{
    public keyinstantiate keyins;
    public Material mat;
    public Renderer rend;
    public Color reds = Color.red;


    private void Start()
    {
        rend = GetComponent<Renderer>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Prince")
        {
            rend.material.color = reds;
            Destroy(gameObject, 5f);
            Debug.Log("destroy");
            keyins.ena();
        }
       
    }
}
