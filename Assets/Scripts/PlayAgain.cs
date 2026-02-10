using UnityEngine;

public class PlayAgain : MonoBehaviour
{
    public GameObject textSprite;
    public GameObject button;
    public Transform charPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame()
    {

        Vector2 startPos = transform.position;
        startPos.x = 0;
        startPos.y = -4.35f;

        textSprite.SetActive(false);
        button.SetActive(false);
        charPos.position = startPos;
    }
}
