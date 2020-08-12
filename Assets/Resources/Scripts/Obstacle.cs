using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public bool destroyObstacleOnCollision;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        // trigger helicopter to explode when it collides with this
        other.transform.parent.gameObject.GetComponent<HeliController>().Explode();

        // if our obstacle is tagged to be destroyed on collision, destroy it
        if (destroyObstacleOnCollision)
        {
            Destroy(gameObject);
        }
    }
}
