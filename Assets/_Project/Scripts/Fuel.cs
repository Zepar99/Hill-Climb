
using UnityEngine;

public class Fuel : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<CarController>(out CarController car))
        {
            car.fuel += 1 - car.fuel;
            Destroy(gameObject);
        }
    }
}