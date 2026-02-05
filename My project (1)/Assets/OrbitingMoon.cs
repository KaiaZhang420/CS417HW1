using UnityEngine;

public class OrbitingMoon : MonoBehaviour
{
    public float degreesPerSecond = 30f;

    void Update()
    {
        transform.Rotate(0f, degreesPerSecond * Time.deltaTime, 0f);
    }
}
