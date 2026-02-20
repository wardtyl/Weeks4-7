using UnityEngine;
using UnityEngine.UI;
public class LightOnOff : MonoBehaviour
{
    public Vector3 lightColour;
    public bool Black = true;
    public Slider lightSlider;
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
        //sets colour values to go between yellow and black based on slider
        lightColour.x = lightSlider.value;
        lightColour.y = lightSlider.value;
        if(Black == false)
        {
            spriteRenderer.color = new Color(lightColour.x, lightColour.y, lightColour.z, 1f);
        }
    }

    public void LightOff()
    {
        //If button pressed turn light off and change colour
        Black = !Black;
        if (Black == true)
        {
            spriteRenderer.color = Color.black;
        }
      
    }

}
