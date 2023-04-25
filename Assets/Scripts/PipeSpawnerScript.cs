using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate = 2;
    public float heightOffset = 10;





    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(createPipes());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator createPipes()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            createPipe();
        }
    }

    void createPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}