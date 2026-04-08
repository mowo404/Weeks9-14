using UnityEngine;
using UnityEngine.Events;

public class Honeycomb : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //hide the starting position of this hoenycomb so it's offscreen
        transform.position = new Vector3(0, 10, 0);
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void SpawnHoneycomb()
    {
        transform.position = new Vector3(0, 3, 0);
    }
}
