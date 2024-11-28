using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimXScript : MonoBehaviour
{
    [SerializeField] private float x;
    [SerializeField] private float sensativityX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x += Input.GetAxis("Mouse X") * sensativityX ;
        transform.rotation = Quaternion.Euler(0, x, 0);
    }
}
