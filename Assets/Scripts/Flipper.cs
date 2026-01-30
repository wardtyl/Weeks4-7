using UnityEngine;

public class Flipper : MonoBehaviour
{
    public float speed;
    private bool isMoving = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving == true)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

    }

    void OnMoveClick()
    {
        isMoving = true;
    }

    void OnStopClick()
    {
        isMoving = false;
    }


}
