using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterControlScript : MonoBehaviour
{
    [SerializeField] private float monsterTimer;
    [SerializeField] private float monsterTime;
    [SerializeField] private float chasePlayerChance;
    [SerializeField] private GameObject player;
    [SerializeField] private bool chasePlayer;
    [SerializeField] private float rotationSpeed;
    private float chance;
    // Start is called before the first frame update
    void Start()
    {
        //chasePlayer = true;
    }

    // Update is called once per frame
    void Update()
    {
        monsterTimer += Time.deltaTime;
        if (monsterTimer >= monsterTime)
        {
            monsterTimer = 0;
            chance = Random.Range(0, 1f);

        }

        if( chance < chasePlayerChance)
        {
            chasePlayer = true;
        }
        else
        {
            chasePlayer = false;
        }

        if (chasePlayer == true)
        {

            Vector3 playerPosition = (player.transform.position - transform.position);
            //float angle = Vector3.Angle(playerPosition, transform.forward);
            //transform.Rotate(0, angle, 0);
           
            GetComponent<MovmentScript>().direction = transform.forward;
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(playerPosition.x, 0, playerPosition.z));
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * rotationSpeed); ;
            GetComponent<MovmentScript>().direction = transform.forward;
        }
        else if(chasePlayer == false)
        {
            float x = Random.Range(0,180);
            float z = Random.Range(0, 180);
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(x, 0, z));
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * rotationSpeed); ;
            GetComponent<MovmentScript>().direction = transform.forward;
        }

    }
}
