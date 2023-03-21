using UnityEngine;
using UnityEngine.Events;

public class MouseEventBehaviour : MonoBehaviour
{
    public UnityEvent MouseEnterEvent, MouseExitEvent, MouseDownEvent, MouseUpEvent, MouseOverEvent;

    private void OnMouseEnter()
    {
        MouseEnterEvent.Invoke();
    }
    
    private void OnMouseExit()
    {
        MouseExitEvent.Invoke();
    }
    
    private void OnMouseDown()
    {
        MouseDownEvent.Invoke();
    }
    
    private void OnMouseUp()
    {
        MouseUpEvent.Invoke();
    }
    
    private void OnMouseOver()
    {
        MouseOverEvent.Invoke();
    }
    
    
    
    
}
