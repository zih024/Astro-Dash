using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float pipeOffset = 10;
    public bool birdIsAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (birdIsAlive){

            if (timer < spawnRate) {
                timer = timer + Time.deltaTime;
        }   else {
                spawnPipe();
            timer = 0;
        }

        }

    }
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - pipeOffset;
        float highestPoint = transform.position.y + pipeOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
    public void StopSpawning()
    {
        birdIsAlive = false;
    }
}
