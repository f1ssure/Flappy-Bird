using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public Rigidbody2D rigged;
    public GameObject WingsUp;
    public GameObject WingsDown;
    public int flappingStrength;
    private float time = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        WingsDown.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        WingsUp.SetActive(true);
        WingsDown.SetActive(false);
        time += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) == true) {
            rigged.linearVelocity = Vector2.up * flappingStrength;
            time = 0;
	    }

        // Wing flap
        if (time < 0.25f) {
            WingsUp.SetActive(false);
            WingsDown.SetActive(true);
        }

        // Manage rotations
        float currentZ = transform.eulerAngles.z;

        if (currentZ > 180f) currentZ -= 360f;

        if (rigged.linearVelocity.y > 0 && currentZ < 10f) {
            currentZ += 175 * Time.deltaTime;
        }

        if (rigged.linearVelocity.y < 0 && currentZ > -10f) {
            currentZ -= 125 * Time.deltaTime;
        }

        currentZ = Mathf.Clamp(currentZ, -10f, 10f);

        transform.eulerAngles = new Vector3(0, 0, currentZ);
    }
}
