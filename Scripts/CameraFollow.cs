using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Reference to the player's transform
    public float smoothSpeed = 0.125f; // Speed at which the camera follows the player
    public Vector3 offset; // Offset between the camera and the player

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = new Vector3(target.position.x, target.position.y, transform.position.z) + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            // No need to make the camera look at the player in 2D top-down view
            // Remove this line if you want the camera to follow player's rotation
            // transform.LookAt(target);
        }
    }
}
