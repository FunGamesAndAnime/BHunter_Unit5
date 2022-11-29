using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    //gamefileS
    private const float spawnrate = 2.0f;
    public List<GameObject> prefabs;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnTarget());
    }

    IEnumerator spawnTarget()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnrate);
            Instantiate(prefabs[Random.Range(0, prefabs.Count)]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
