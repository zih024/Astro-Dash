using UnityEngine;

public class Blackhole : MonoBehaviour
{
    public float spiralDuration = 5;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 3)
        {
            Debug.Log("Blackhole touched!");
            SpiralCamera cam = Camera.main.GetComponent<SpiralCamera>();
            if (cam != null)
            {
                cam.StartCoroutine(cam.TemporarySpiral(spiralDuration));
            }
            Destroy(gameObject);
        }
    }
}
