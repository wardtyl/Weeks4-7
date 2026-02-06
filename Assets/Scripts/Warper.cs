using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
public class Warper : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if we click and we are not hovering over UI (eslamation point makes it the inverse/opposite)
        bool shouldWarp = Mouse.current.leftButton.wasPressedThisFrame &&
                            !EventSystem.current.IsPointerOverGameObject();

        if (shouldWarp == true)
        {
            //get mouse position, transforms image to mouse click
            Vector3 currentMousePosition = Mouse.current.position.ReadValue();
            transform.position = currentMousePosition;
        }

    }
}
