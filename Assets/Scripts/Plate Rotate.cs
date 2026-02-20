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

        RotatePlate();;
        Vector3 rotatePlate = transform.eulerAngles;
           rotatePlate.y += rotationSpeed * Time.deltaTime;
        transform.eulerAngles = rotatePlate;



    }

    public void RotatePlate()
    {
        timeWaiting += Time.deltaTime * 1;
        rotationSlider.value = timeWaiting;

        if (timeWaiting > clockDuration)
        {
            timeWaiting = 0f;

            //WHEN TIMER IS UP:
            //EITHER:
            //Turn the warper object off when it is on
            //Turn the warper object on when it is off
            bool shouldTurnOn = !food.activeInHierarchy;
            bool shouldTurnOff = food.activeInHierarchy;
            if (shouldTurnOn == true)
            {
                food.SetActive(true);
                
            }

            if (shouldTurnOff)
            {
                food.SetActive(false);
            }

        }
    }

    }


