using UnityEngine;

public class TriggeredEffect : MonoBehaviour
{
    public CountScore logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("ScoreLogic").GetComponent<CountScore>();
    }

    void OnTriggerEnter2D(Collider2D other)  
    {
        if (other.gameObject.layer == 3) 
        {
            logic.increaseScore(1);
        }
    }
}
