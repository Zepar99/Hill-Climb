using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    [SerializeField]
    private Transform checkpoint;
    [SerializeField]
    private Text distanceText;
    [SerializeField]
    private Slider slider;

    private float distance;

    void Update()
    {
        distance = (checkpoint.transform.position.x - transform.position.x);
        slider.value = distance;

        distanceText.text = slider.value++.ToString("F0");

        if (distance < 0)
        {
            distanceText.text = "Distance: Finish!!";
        }

    }
}
