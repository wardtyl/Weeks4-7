using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
public class Burner : MonoBehaviour
{
    public Camera gameCamera;
    public GameObject burnerPrefab;

    public float waitDuration;
    private float waitProgress = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector3 currentMousePosition = Mouse.current.position.ReadValue();
            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(currentMousePosition);
            worldMousePosition.z = 0;

            Instantiate(burnerPrefab, new Vector3 (-2.6f, 1.8f, 0), Quaternion.identity);
        }

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector3 currentMousePosition = Mouse.current.position.ReadValue();
            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(currentMousePosition);
            worldMousePosition.z = 0;

            Instantiate(burnerPrefab, new Vector3(-0.3f, 1.8f, 0), Quaternion.identity);
        }

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector3 currentMousePosition = Mouse.current.position.ReadValue();
            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(currentMousePosition);
            worldMousePosition.z = 0;

            Instantiate(burnerPrefab, new Vector3(2, 1.8f, 0), Quaternion.identity);
        }
       
    }

}
