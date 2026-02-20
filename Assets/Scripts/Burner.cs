using UnityEngine;
using UnityEngine.InputSystem;

public class Burner : MonoBehaviour
{
    public Camera gameCamera;
    public GameObject burnerPrefab;
    bool burnerActiveOnce = false;
    public bool Burning = true;
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
        burners();
    }

    public void SpawnBurner()
    {
        //Keeps the burner prefab from cloning repeatedley 
        Burning = !Burning;
        if( Burning)
        {
            burnerActiveOnce = true;
        }

    }
    void burners()
    {
        //spawns the burners at specified locations
        if (Burning == true && burnerActiveOnce == true)
        {
            Vector3 currentMousePosition = Mouse.current.position.ReadValue();
            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(currentMousePosition);
            worldMousePosition.z = 0;

            burner = Instantiate(burnerPrefab, new Vector3(-2.6f, 1.8f, 0), Quaternion.identity);


            burner1 = Instantiate(burnerPrefab, new Vector3(-0.3f, 1.8f, 0), Quaternion.identity);


            burner2 = Instantiate(burnerPrefab, new Vector3(2, 1.8f, 0), Quaternion.identity);
            burnerActiveOnce = false;
        }
        if (Burning == false)
        {
            //destroys the burners upon pressing button a second time
            Destroy(burner); Destroy(burner1); Destroy(burner2);
        }
    }

}


