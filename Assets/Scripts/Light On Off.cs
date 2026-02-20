using UnityEngine;
using UnityEngine.InputSystem;
public class LightOnOff : MonoBehaviour
{
    bool Black = true;

    SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //altering the sprite renderer rather than using it in the public inspector
      spriteRenderer = GetComponent<SpriteRenderer>();  
    }

    // Update is called once per frame
    void Update()
    {

       
    }

    public void LightOff()
    {
        Black = !Black;
        if (Black == true)
        {
            spriteRenderer.color = Color.black;

        }
        else { spriteRenderer.color = Color.yellow; }
    }


}
