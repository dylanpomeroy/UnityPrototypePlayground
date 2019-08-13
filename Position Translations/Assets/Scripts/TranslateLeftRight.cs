using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateLeftRight : MonoBehaviour
{
    /// <summary>
    /// The maximum global X position that this GameObject can move to
    /// </summary>
    /// <remarks>[SerializeField] lets us see and set this value in the Unity Editor</remarks>
    [SerializeField]
    private float MinimumX;

    /// <summary>
    /// The maximum global X position that this GameObject can move to
    /// </summary>
    /// <remarks>[SerializeField] lets us see and set this value in the Unity Editor</remarks>
    [SerializeField]
    private float MaximumX;

    /// <summary>
    /// The relative X position to increase/decrease the GameObject's global position by each frame
    /// </summary>
    /// <remarks>
    /// This value will be negated when we need to move in the opposite direction.
    /// [SerializeField] lets us see and set this value in the Unity Editor
    /// </remarks>
    [SerializeField]
    private float StepX;

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    /// <remarks>This function is special and will be automatically run by Unity</remarks>
    private void Update()
    {
        // Get a vector reprsentation of our step amount
        var stepVector = new Vector3(StepX, 0, 0);

        // Add the step vector to this GameObject's transform's global position
        transform.position += stepVector;

        // If the new position is too low
        if (transform.position.x < MinimumX)
        {
            // Set the position to the minimum position
            // - This will prevent the position from ever being below the minimum height
            transform.position = new Vector3(MinimumX, transform.position.y, transform.position.z);

            // Negate the value of the step amount
            // This will make the next frame calculate the new step in the opposite direction
            StepX *= -1;
        }
        // If the new position is too high
        else if (transform.position.x > MaximumX)
        {
            // Set the position to the maximum position
            // - This will prevent the position from ever being above the maximum height
            transform.position = new Vector3(MaximumX, transform.position.y, transform.position.z);

            // Negate the value of the step amount
            // This will make the next frame calculate the new step in the opposite direction
            StepX *= -1;
        }
    }
}
