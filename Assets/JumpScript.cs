using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public Rigidbody2D rigged;
    public int flappingStrength;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true) {
            rigged.linearVelocity = Vector2.up * flappingStrength;
	    }
    }
}
