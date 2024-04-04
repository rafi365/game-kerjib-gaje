using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody theRB;
    public float jumpForce;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        // theRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
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
        Vector3 movement = new Vector3(h, 0.0f, v);
        if (movement != new Vector3(0.0f, 0.0f, 0.0f))
        {
            transform.rotation = Quaternion.LookRotation(movement);
        }
        theRB.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, theRB.velocity.y, Input.GetAxis("Vertical") * moveSpeed);

        if (Input.GetButtonDown("Jump"))
        {
            theRB.velocity = new Vector3(theRB.velocity.x, jumpForce, theRB.velocity.z);
        }  
    }
}
