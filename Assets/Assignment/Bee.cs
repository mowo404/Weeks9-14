using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class BeeMovement : MonoBehaviour
{
    public float speed = 1.0f;
    public float distance;
    public Vector2 movement;
    public List<GameObject> flowers;
    public UnityEvent pollination;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //movement of bee using speed and time
        transform.position += (Vector3)movement * speed * Time.deltaTime;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
            //input action to make the bee move
            movement = context.ReadValue<Vector2>();
    }

    public void OnSpace(InputAction.CallbackContext context)
    {
        if (context.performed == true)
        {
            //call pollination event when space is pressed 
            pollination.Invoke();
        }
    }

    public void OnPollinate()
    {
      
        //looping through each flower in the list to check if the bee is near it, if it near one of the flowers then run the pollinate function called from the flower script.
        for (int i = 0; i < flowers.Count; i++)
        {
            //get flowerscript so we can run pollinate function in the flower script
            GameObject currentFlower = flowers[i];
            Flower flowerscript = currentFlower.GetComponent<Flower>();

            float distance = Vector3.Distance(transform.position, currentFlower.transform.position);
            //if the distance between the flower and bee is less than or equal to 2 then run pollinate function!
            if (distance <= 2f)
            {
                flowerscript.Pollinate();
            }

        }



    }
}
