using UnityEngine;

public class ScaleObject : MonoBehaviour
{

    public void scaleObject(float scale)
    {
        //Gets current scale value from the slider and applies it to the object
        transform.localScale = Vector3.one * scale;
    }
}
