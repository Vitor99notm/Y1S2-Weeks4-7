using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class MoveToMouse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        //Was mouse pressed this frame? && Mouse isn't over the UI
        if (Mouse.current.leftButton.wasPressedThisFrame == true && !EventSystem.current.IsPointerOverGameObject())
        {
            //Y: move to that position
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            transform.position = mousePos;
        }
    }
}
