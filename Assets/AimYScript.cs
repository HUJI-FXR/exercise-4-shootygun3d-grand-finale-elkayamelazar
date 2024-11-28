using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimYScript : MonoBehaviour
{
    [SerializeField] private float y;
    [SerializeField] private float sensativityY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        y = Mathf.Clamp(y + Input.GetAxis("Mouse Y") * sensativityY  , -90, 90);
        transform.rotation = Quaternion.Euler(-y, transform.rotation.eulerAngles.y, 0);
    }
}
