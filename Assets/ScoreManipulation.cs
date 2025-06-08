using UnityEngine;
using UnityEngine.UI;

public class ScoreManipulation : MonoBehaviour
{
    public Text scoreCount;
    private int scoreValue = 0;

    [ContextMenu ("Increment Score")]
    public void increaseScore(int val) 
    {
        scoreValue += val;
        scoreCount.text = scoreValue.ToString();
    }
}
