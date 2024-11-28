using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TintRedScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponentInChildren<Renderer>().material = Instantiate(GetComponentInChildren<Renderer>().material);
        //GetComponent<Renderer>().material = Instantiate(GetComponent<Renderer>().material);
    }

    // Update is called once per frame
    void Update()
    {
        float lifeTotalRatio = GetComponent<LifeTotalScript>().lifeTotal /
            GetComponent<LifeTotalScript>().initialLifeTotal;
        GetComponentInChildren<Renderer>().material.color = lifeTotalRatio * Color.white +
            (1f - lifeTotalRatio) * Color.red;

    }
}
