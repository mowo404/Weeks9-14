using UnityEngine;
using UnityEngine.InputSystem;

public class ControllLook : MonoBehaviour
{
    public float speed;
    //player direction
    public Vector2 directionalInput;
    public Vector2 pointInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

       
        //set rotation of z

        transform.position += (Vector3)directionalInput * speed * Time.deltaTime;
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(pointInput);
        mousePosition.z = 0;
        transform.up = mousePosition - transform.position;

    }

    public void OnLook(InputAction.CallbackContext context)
    {
        pointInput = context.ReadValue<Vector2>();
    }
}
