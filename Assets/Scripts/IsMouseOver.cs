using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class IsMouseOver : MonoBehaviour
{
 
    //public Image
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        if (mousePos == (Vector2)transform.position) //Remember transform is set to Vector3 so use Vector2 to change it
        {

        }
    }
}
