using UnityEngine;
using UnityEngine.InputSystem;

public class Test : MonoBehaviour
{
    public Camera gameCamera;

    public float rotationSpeed;

    public GameObject spawningPrefab;
    public float bulletSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        worldMousePosition.z = 0;

        transform.up = worldMousePosition - transform.position;

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            GameObject spawnedObject = Instantiate(spawningPrefab, transform.position, Quaternion.identity);
            Bullet spawnedBullet = spawnedObject.GetComponent<Bullet>();
            //spawnedBullet.speed = bulletSpeed;
        }
        }
    }

//class Bullet
//{
//    Bullet()
//    {

//    }

//}