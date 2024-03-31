using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float speed;
    public float extraspeed;
    public Animator animator;

    private void Start()
    {

    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        if (h != 0 || v != 0)
        {
            animator.SetBool("Walking", true);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("Running", true);
            }
            else
            {
                animator.SetBool("Running", false);
            }
        }
        else
        {
            animator.SetBool("Walking", false);
            animator.SetBool("Running", false);
        }
        // gameObject.transform.position = new Vector3(transform.position.x + (h * speed),0, transform.position.z + (v * speed));
        Vector3 movement = new Vector3(h, 0.0f, v);
        if (movement != new Vector3(0.0f, 0.0f, 0.0f))
        {
            transform.rotation = Quaternion.LookRotation(movement);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(movement * (speed + extraspeed) * Time.deltaTime, Space.World);
        }
        else
        {
            transform.Translate(movement * speed * Time.deltaTime, Space.World);
        }
    }
}