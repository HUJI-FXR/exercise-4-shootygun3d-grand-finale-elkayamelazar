using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTotalScript : MonoBehaviour
{
    [SerializeField] public float initialLifeTotal;
    public float lifeTotal;
    [SerializeField] private ScoreScript scoreScript;
    [SerializeField] private HighScoreScript highScoreScript;
    [SerializeField] private MonsterSpwanerScript monsterSpwanerScript;
    // Start is called before the first frame update
    void Start()
    {
        lifeTotal = initialLifeTotal;
    }

    // Update is called once per frame
    void Update()
    {
        if(lifeTotal <= 0)
        {
            if(tag == "monster")
            {
                scoreScript.AddScore();
                monsterSpwanerScript.MonsterCounterReduce();
                Destroy(gameObject);
            }
            if(tag == "player")
            {
                highScoreScript.SaveHighScore();
                highScoreScript.GameEndMassage(0);
                foreach (Transform child in transform)
                {
                    if (!child.tag.Equals("MainCamera"))
                    {
                        Destroy(child.gameObject);
                    }else
                    {
                        child.GetComponent<ShootyGunScript>().enabled = false;
                    }
                }

            }
            else if(monsterSpwanerScript.counter == 0)
            {
                highScoreScript.SaveHighScore();
                highScoreScript.GameEndMassage(1);
            }
        }
    }
}
