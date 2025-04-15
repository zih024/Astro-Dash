using UnityEngine;

public class PipeMoves : MonoBehaviour
{
    public float moveSpeed = 15;
    public float deadZone = -45;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone) {
            Destroy(gameObject);
        }
    }
}
