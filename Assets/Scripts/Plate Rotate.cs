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
        //Calls function in update
        RotatePlate();

    }

    public void RotatePlate()
    {
        //timeWaiting += Time.deltaTime * 1;
        //rotationSlider.value = timeWaiting;

        //if (timeWaiting > clockDuration)
        //{
        //    timeWaiting = 0f;

        //    //WHEN TIMER IS UP:
        //    //EITHER:
        //    //Turn the warper object off when it is on
        //    //Turn the warper object on when it is off
        //    bool TurnOn = !food.activeInHierarchy;
        //    bool TurnOff = food.activeInHierarchy;
        //    if (TurnOn == true)
        //    {
        //        food.SetActive(true);

        //    }

        //    if (TurnOff)
        //    {
        //        food.SetActive(false);
        //    }

        //}

        //Allows for animation of rotation to occur smoothly along y-axis
        Vector3 rotatePlate = transform.eulerAngles;
        rotatePlate.y += rotationSpeed * Time.deltaTime;
        transform.eulerAngles = rotatePlate;
    }

    }


