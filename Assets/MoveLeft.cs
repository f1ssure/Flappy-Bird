using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float bound = -40f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        
        if (transform.position.x < bound) {
            Destroy(gameObject);
        }
    }
}
