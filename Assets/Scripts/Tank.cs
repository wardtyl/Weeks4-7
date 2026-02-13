using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Tank : MonoBehaviour
{
    public float moveSpeed;
    public float rotateSpeed;

    public List<Transform> controlledTransforms;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < controlledTransforms.Count; i++)
        {
            Transform currentTransform = controlledTransforms[i];
            bool leftArrowHeld = Keyboard.current.leftArrowKey.isPressed;
            bool rightArrowHeld = Keyboard.current.rightArrowKey.isPressed;

            if (leftArrowHeld)
            {
                currentTransform.position -= currentTransform.right * moveSpeed * Time.deltaTime;
            }
            if (rightArrowHeld)
            {
                currentTransform.position += currentTransform.right * moveSpeed * Time.deltaTime;
            }
        }
    }
}
