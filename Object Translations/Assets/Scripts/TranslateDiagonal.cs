using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateDiagonal : MonoBehaviour
{

    /// <summary>
    /// The maximum global X and Y position that this GameObject can move to
    /// </summary>
    /// <remarks>[SerializeField] lets us see and set this value in the Unity Editor</remarks>
    [SerializeField]
    private Vector3 MinimumXY;

    /// <summary>
    /// The maximum global X and Y position that this GameObject can move to
    /// </summary>
    /// <remarks>[SerializeField] lets us see and set this value in the Unity Editor</remarks>
    [SerializeField]
    private Vector3 MaximumXY;

    /// <summary>
    /// The relative distance to increase/decrease the GameObject's global position by each frame
    /// </summary>
    /// <remarks>
    /// [SerializeField] lets us see and set this value in the Unity Editor
    /// </remarks>
    [SerializeField]
    private float StepXYDistance;

    /// <summary>
    /// The position we want the GameObject to move towards each frame.
    /// </summary>
    /// <remarks>We will swap this between the Maximum and Minimum values.</remarks>
    private Vector3 goalPosition;

    /// <summary>
    /// Run one time when the scene starts.
    /// </summary>
    private void Start()
    {
        // Set our first goal Position based on the maximum position
        goalPosition = MaximumXY;
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    private void Update()
    {
        // Use Vector3.Lerp to set the GameObject's position a step distance closer to the goal position
        // - when working with multiple dimensions, it's easier to use Vector math functions like Lerp
        transform.position = Vector3.MoveTowards(transform.position, goalPosition, StepXYDistance);

        // If we are at the maximum position
        if (transform.position == MaximumXY)
        {
            // Set the goal position to the minimum position
            goalPosition = MinimumXY;
        }
        // If we are at the minimum position
        else if (transform.position == MinimumXY)
        {
            // Set the goal position to the maximum position
            goalPosition = MaximumXY;
        }
    }
}
