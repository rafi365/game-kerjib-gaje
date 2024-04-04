// https://stackoverflow.com/questions/65816546/unity-camera-follows-player-script
using UnityEngine;

public class Cam_Follow : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 locationOffset = new Vector3(0,10,-10);

    void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + locationOffset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}