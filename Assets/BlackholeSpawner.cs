using UnityEngine;

public class BlackholeSpawner : MonoBehaviour
{
    public GameObject blackholePrefab;
    public float spawnChance = 0.1f;
    public float xPos = 5f;
    public float yMin = -2f;
    public float yMax = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void TrySpawnBlackhole()
    {
        if (Random.value < spawnChance)
        {
            Vector3 spawnPos = new Vector3(xPos, Random.Range(yMin, yMax),0);
            Instantiate(blackholePrefab, spawnPos, Quaternion.identity);
        }
    }
}
