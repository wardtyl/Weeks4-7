using UnityEngine;
using UnityEngine.InputSystem;
public class Burner : MonoBehaviour
{
    public Camera gameCamera;
    public GameObject burnerPrefab;

    public float waitDuration;

    bool Burning = true;
    GameObject burner;
    GameObject burner1;
    GameObject burner2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnBurner()
    {
        Burning = !Burning;
        if (Burning == true)
        {
            Vector3 currentMousePosition = Mouse.current.position.ReadValue();
            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(currentMousePosition);
            worldMousePosition.z = 0;

            GameObject burner = Instantiate(burnerPrefab, new Vector3(-2.6f, 1.8f, 0), Quaternion.identity);


            GameObject burner1 = Instantiate(burnerPrefab, new Vector3(-0.3f, 1.8f, 0), Quaternion.identity);


            GameObject burner2 = Instantiate(burnerPrefab, new Vector3(2, 1.8f, 0), Quaternion.identity);
        }
        else { Destroy(burner); Destroy(burner1); Destroy(burner2);}

    }

}


