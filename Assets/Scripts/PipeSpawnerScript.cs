using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public List<GameObject> pipes;
    public float spawnRate = 2;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(createPipes());
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

        GameObject pipe = pipes[Random.Range(0, pipes.Count)];
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
