using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 50f;

    void Update()
    {
        // Mavi halka (Z ekseni) etrafında döner
        transform.Rotate(new Vector3(0, 0, rotationSpeed) * Time.deltaTime);
    }
}