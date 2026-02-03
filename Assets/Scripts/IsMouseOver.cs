using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class IsMouseOver : MonoBehaviour
{
    public Text des;
    public TextMeshProUGUI spriteDes;
    public float check = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        float distance = Vector2.Distance(transform.position, mousePos);

        if (distance < 1) //Remember transform is set to Vector3 so use Vector2 to change it
        {
            spriteDes.text = "A pirate";
            check = 1;
        }
        else
        {
            check = 0;
            spriteDes.text = " ";
        }
    }
}
