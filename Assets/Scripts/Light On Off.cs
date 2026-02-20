using UnityEngine;
using UnityEngine.InputSystem;
public class LightOnOff : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      spriteRenderer = GetComponent<SpriteRenderer>();  
    }

    // Update is called once per frame
    void Update()
    {

       
    }

    public void LightOff()
    {
        spriteRenderer.color = Color.black;
    }

    public void LightOn()
    {
        spriteRenderer.color = Color.yellow;
    }
}
