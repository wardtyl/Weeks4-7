using UnityEngine;
using UnityEngine.UI;

public class SushiClock : MonoBehaviour
{
    public Slider sushiSlider;
    public GameObject warperObject;

    public float clockDuration;
    private float timeWaiting = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Sets sushi slider max value to sushi clock clockDuration
       sushiSlider.maxValue = clockDuration;
    }

    // Update is called once per frame
    void Update()
    {
        //Timer + slider
        timeWaiting += Time.deltaTime * 1;
        sushiSlider.value = timeWaiting;

        if(timeWaiting > clockDuration)
        {
            timeWaiting = 0f;
            Debug.Log("Time is up");

            //WHEN TIMER IS UP
            //EITHER:
            //Turn the warper object off when it is on
            //Turn the warper object on when it is off

            bool shouldTurnOn = !warperObject.activeInHierarchy;
            bool shouldTurnOff = warperObject.activeInHierarchy;
            if (shouldTurnOn == true)
            {
                Debug.Log("Test");
                warperObject.SetActive(true);
            }

            if(shouldTurnOff)
            {
                Debug.Log("Test2");
                warperObject.SetActive(false);  
            }

        }
    }
}
