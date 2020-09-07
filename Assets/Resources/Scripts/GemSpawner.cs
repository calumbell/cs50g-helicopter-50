using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSpawner : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnGem());
    }

    IEnumerator SpawnGem()
    {
        while (true)
        {
            // pause for 3-15 seconds
            yield return new WaitForSeconds(Random.Range(3, 15));

            // instantiate gem prefab
            Instantiate(prefab, new Vector3(26, Random.Range(-10, 10), 10), Quaternion.identity);
        }
    }
}
