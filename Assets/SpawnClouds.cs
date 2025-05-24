using UnityEngine;

public class SpawnCloud : MonoBehaviour
{
    public GameObject cloud;
    public float spawnTime = 2f;
    private float verticalOffset = 15f;
    private float time = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        
        if (time > spawnTime) {
            spawnCloud();
            time = 0;
        }
    }

    void spawnCloud() {
        float upperBound = transform.position.y + verticalOffset;
        float lowerBound = transform.position.y - verticalOffset;
        float randomY = Random.Range(lowerBound, upperBound);
        Vector3 pos = new Vector3(transform.position.x, randomY, 0f);
        Instantiate(cloud, pos, transform.rotation);
    }
}
