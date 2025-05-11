using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public GameObject pipe;
    public float spawnTime = 3;
    public float verticalOffset = 10f;
    private float time = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        
        if (time > spawnTime) {
            SpawnPipe();
            time = 0f;
        }
    }

    void SpawnPipe() {
        float upperBound = transform.position.y + verticalOffset;
        float lowerBound = transform.position.y - verticalOffset;
        float randomY = Random.Range(lowerBound, upperBound);
        Vector3 pos = new Vector3(transform.position.x, randomY, 0f);
        Instantiate(pipe, pos, transform.rotation);
    }
}
