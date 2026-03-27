using UnityEngine;

public class Pulse : MonoBehaviour
{
    public float speed;
    public AnimationCurve pulse;
    public float CurveDuration = 2f;
    public float CurveAmplitutde = 3f;

    private Camera mainCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        float movementSpeed = speed * Time.deltaTime;

        Vector3 movement = new Vector3(movementSpeed, 0, 0);
        transform.position += movement;

        if (transform.position.x > 9)
        {
            transform.position -= movement * -1;
        }

        if (transform.position.x > -9)
        {
            transform.position += movement * 1;
        }
    }
}
