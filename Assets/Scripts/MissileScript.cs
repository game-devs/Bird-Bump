using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileScript : MonoBehaviour
{
    [SerializeField] private List<string> destroyTriggerTags;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * Time.deltaTime;
    }

  
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (destroyTriggerTags.Contains(other.gameObject.tag))
            Destroy(gameObject);
    }
}
