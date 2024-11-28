using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentScript : MonoBehaviour
{
    [SerializeField] public Vector3 direction;
    [SerializeField] private float speed;
    [SerializeField] private bool onGround;
    [SerializeField] private float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        onGround = true;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0) * direction * speed
            + GetComponent<Rigidbody>().velocity.y * Vector3.up;
    }

    public void jump()
    {
        if (onGround)
        {
            GetComponent<Rigidbody>().AddForce(jumpForce * Vector3.up, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            onGround = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            onGround = false;
        }
    }
}
