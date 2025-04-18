using UnityEngine;
using System.Collections;

public class SpiralCamera : MonoBehaviour
{
    private bool isSpinning = false;

    public IEnumerator TemporarySpiral(float duration)
    {
        if (isSpinning)
            yield break;
        isSpinning = true;
        float spinTime = 5f;
        float speed = 360f / spinTime;
        float totalRotation = 0f;
        while (totalRotation < 360f)
        {
            float step = speed * Time.deltaTime;
            transform.Rotate(0f,0f,step);
            totalRotation += step;
            yield return null;
        }
        transform.rotation = Quaternion.identity;
        isSpinning = false;

    }
    public bool IsSpinning()
    {
        return isSpinning;
    }

}
