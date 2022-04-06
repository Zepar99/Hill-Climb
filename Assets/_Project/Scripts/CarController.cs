using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CarController : MonoBehaviour
{

    [SerializeField] private float speed = 1500;
    [SerializeField] private float rotation = 10f;
    [SerializeField] private float fuelConsumption = 0.1f;
    [SerializeField] private Rigidbody2D backTire;
    [SerializeField] private Rigidbody2D frontTire;
    [SerializeField] private Rigidbody2D carBody;
    [SerializeField] private UnityEngine.UI.Image image;
    private float movement;
    public float fuel = 1f;

    void FixedUpdate()
    {
        ProcessCarPhysics();
        CarfuelConsumption();
    }
    void ProcessCarPhysics()
    {
        movement = Input.GetAxis("Horizontal");

        if (fuel > 0)
        {
            backTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            frontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            carBody.AddTorque(-movement * rotation * Time.fixedDeltaTime);
        }
    }
    void CarfuelConsumption()
    {
        if (fuel > 0)
        {
            fuel -= fuelConsumption * Time.fixedDeltaTime;
            image.fillAmount = fuel;
        }
    }

}