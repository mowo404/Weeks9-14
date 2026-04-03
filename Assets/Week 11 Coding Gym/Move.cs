using UnityEngine;


public class Move : MonoBehaviour
{
    public float speed = 0.2f;
    public float t = 0f;
    public AnimationCurve heartbeat;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        t += Time.deltaTime;

        if(t > 1)
        {
            t = 0;
        }

        Vector3 movement = transform.position;
        movement.y = Mathf.Lerp(5, -5, heartbeat.Evaluate(t));
        movement.x += speed * Time.deltaTime;
        
        Vector3 screenPos = Camera.main.WorldToScreenPoint(movement);
        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            movement.x = -9;
        }

        if (screenPos.x > 0 || screenPos.x < Screen.width)
        {
            speed = speed * 1;
        }

        transform.position = movement;

        
    }
}
