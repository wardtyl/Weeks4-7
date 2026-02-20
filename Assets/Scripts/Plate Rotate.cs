using UnityEngine;
using UnityEngine.UI;
public class PlateRotate : MonoBehaviour
{
    public float rotationSpeed;
    public float clockDuration;
    private float timeWaiting;

    public Slider rotationSlider;
    public GameObject food;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Allows for animation of rotation to occur smoothly along y-axis
        Vector3 rotatePlate = transform.eulerAngles;
        rotatePlate.y += rotationSpeed * Time.deltaTime;
        transform.eulerAngles = rotatePlate;
    }

    public void RotatePlate()
    {
        //Timer sets pace at which pizza appears/disappears
        timeWaiting += Time.deltaTime * 1;
        rotationSlider.value = timeWaiting;

        if (timeWaiting > clockDuration)
        {
            timeWaiting = 0f;

            bool TurnOn = !food.activeInHierarchy;
            bool TurnOff = food.activeInHierarchy;
            if (TurnOn == true)
            {
                
                food.SetActive(true);

            }

            if (TurnOff)
            {
                food.SetActive(false);
            }

        }

        
    }

    }


