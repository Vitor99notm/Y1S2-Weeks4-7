using UnityEngine;

public class ToggleSet : MonoBehaviour
{
    public void ToggleShape()
    {

        //Code allows to show hidden game objects through buttons
        gameObject.SetActive(!gameObject.activeInHierarchy);

        
        //Harder version

        //If game object is innactive (off): call setActive passing true
        /*if (gameObject.activeInHierarchy == false)
        {
            gameObject.SetActive(true);
        }
        else if(gameObject.activeInHierarchy == true) // dont need this but just to be sure
        {
            //otherwise if active (on): call setActive passing false
            gameObject.SetActive(false);
        }*/
        
        
    }
}
