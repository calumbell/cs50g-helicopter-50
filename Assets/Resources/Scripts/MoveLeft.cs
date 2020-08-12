using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// MoveLeft: moves attached object to the left and handles clean-up
// once it is safely offscreen

public class MoveLeft : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // despawn object if it goes past the left edge of the screen
        if (transform.position.x < -25)
        {
            Destroy(gameObject);
        }

        else
        {
            // scroll based on SkyscraperSpawner static variable, speed
            transform.Translate(-SkyscraperSpawner.speed * speed * Time.deltaTime, 0, 0, Space.World);
        }
    }
}
