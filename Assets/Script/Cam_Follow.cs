using UnityEngine;

public class Cam_Follow : MonoBehaviour {

    public Transform player;
    public float distance_x = 0;
    public float distance_y = 5;
    public float distance_z = -10;

    // Update is called once per frame
    void Update () {
        transform.position = player.transform.position + new Vector3(distance_x, distance_y, distance_z);
    }
}