using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class UIDemo : MonoBehaviour
{
    SpriteRenderer sr;
    public Image imageUI;
    public int countClick = 0;
    public TextMeshProUGUI score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
           
        {
            changeColor();
        }
    }

    public void changeColor()
    {
        Color col = Random.ColorHSV();
        sr.color = col;
        imageUI.color = sr.color;
    }

    public void SetScale(float scale)
    {
        transform.localScale = Vector3.one * scale;
    }

    public void AddNum()
    {
        countClick += 1;
        score.text = countClick.ToString();
    }
}
