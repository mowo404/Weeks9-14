using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class Flower : MonoBehaviour
{
    public float increase;
    public Slider pollinationbar;
    public UnityEvent pollination;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pollinationbar.value = increase;
    }

    public void Pollinate()
    {

        if (increase  <= 1)
        {
            increase += 0.5f;
        }
    }

    //function that increases pollination bar when space is pressed...
    
}
