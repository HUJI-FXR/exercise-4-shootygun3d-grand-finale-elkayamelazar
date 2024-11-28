using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControlScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.zero;
        if (Input.GetKey(KeyCode.A) == true)
        {
            direction = Vector3.left;
        }
        else if (Input.GetKey(KeyCode.D) == true)
        {
            direction = Vector3.right;
        }
        else if (Input.GetKey(KeyCode.W) == true)
        {
            direction = Vector3.forward;
        }
        else if (Input.GetKey(KeyCode.S) == true)
        {

            direction = Vector3.back;
        }
        else if (Input.GetKey(KeyCode.Space) == true)
        {
            GetComponent<MovmentScript>().jump();
        }
        GetComponent<MovmentScript>().direction = direction;

    }
}
