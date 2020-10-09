using UnityEngine;
using UnityEngine.EventSystems;

public class Joybutton : MonoBehaviour , IPointerClickHandler , IPointerUpHandler
{
    [HideInInspector]
public bool pressed;

   void Update()
    {

    }
  public void OnPointerClick(PointerEventData eventData)
    {
        pressed = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        pressed = false;
    }

   
}


    
    


