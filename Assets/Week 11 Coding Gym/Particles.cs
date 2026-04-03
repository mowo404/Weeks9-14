using UnityEngine;
using UnityEngine.InputSystem;

public class Particles : MonoBehaviour
{
    public ParticleSystem particles;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("Jump!" + context.phase);

        if (context.performed == true)
        {
            particles.Play();
        }
    }
}
