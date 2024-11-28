using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemageScript : MonoBehaviour
{
    [SerializeField] private float minDamage;
    [SerializeField] private float maxDamage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "player" && gameObject.tag != "bullet")
        {
            collision.gameObject.GetComponent<LifeTotalScript>().lifeTotal -=
                Random.Range(minDamage, maxDamage);
            Destroy(gameObject);
        }
        else if(collision.gameObject.tag == "monster" && gameObject.tag != "monster")
        {
            collision.gameObject.GetComponent<LifeTotalScript>().lifeTotal -=
                Random.Range(minDamage, maxDamage);
            Destroy(gameObject);
        }
    }
}
