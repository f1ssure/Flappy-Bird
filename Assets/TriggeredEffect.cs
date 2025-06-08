using UnityEngine;

public class TriggeredEffect : MonoBehaviour
{
    public ScoreManipulation logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("ScoreLogic").GetComponent<ScoreManipulation>();
    }

    void OnTriggerEnter2D(Collider2D other)  
    {
        if (other.gameObject.layer == 3) 
        {
            logic.increaseScore(1);
        }
    }
}
