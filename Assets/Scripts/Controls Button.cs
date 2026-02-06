using UnityEngine;

public class ControlsButton : MonoBehaviour
{
    public Color triangleColour;
    private bool isPressed = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed == true)
        {
            transform.position = GetComponent<Rigidbody>().position;
            triangleColour = Color.red;
        }
    }

    void onPress()
    {
        isPressed = true;
    }

}
