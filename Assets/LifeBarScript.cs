using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LifeBarScript : MonoBehaviour
{
    [SerializeField] GameObject player;
    private TextMeshProUGUI lifeBarText;
    // Start is called before the first frame update
    void Start()
    {
        lifeBarText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        lifeBarText.text = "HP: " + player.GetComponent<LifeTotalScript>().lifeTotal;
    }
}
