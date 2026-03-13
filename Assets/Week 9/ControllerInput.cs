using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerInput : MonoBehaviour
{
    public float speed;
    //player direction
    public Vector2 directionalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //directionInput is representing the direction the character wants to move in 
        //force directionInput to be a vector3 componenet as we declared it as a vector2 above but transform.position is vector 3
        transform.position += (Vector3)directionalInput * speed * Time.deltaTime;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        //boolean type statement that reads the system controllers movements
        directionalInput = context.ReadValue<Vector2>();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {

        //context phase tells us what the system is registering from held, released and pressed button...s
        Debug.Log("Attack Time!( " + context.phase +" )!");

    }

    public void OnPoint(InputAction.CallbackContext context)
    {
        Vector2 mousePosition = context.ReadValue<Vector2>();
        Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Debug.Log("On point: " + worldMousePosition);
    }
}
