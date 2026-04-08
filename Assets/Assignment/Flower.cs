using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class Flower : MonoBehaviour
{
    public float increase;
    public Slider pollinationbar;
    public SpriteRenderer thisSprite;
    public Sprite Bloom;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //assigns the spriterender to blooming flower variable
        thisSprite = GetComponent<SpriteRenderer>();

        
    }

    // Update is called once per frame
    void Update()
    {
        //our slider value changes to the value of our variable
        pollinationbar.value = increase;
    }
    //function that increases pollination bar when space is pressed...
    public void Pollinate()
    {
        if (increase  <= 1)
        {
            increase += 0.15f;
        }
        onBloom();
    }

    public void onBloom()
    {
        //if poliation bar is full then change the sprite to the bloom spire!
        if(increase >= 1)
        {
            thisSprite.sprite = Bloom;
        }
    }
   
    
}
