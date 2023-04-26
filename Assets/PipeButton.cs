using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeButton : MonoBehaviour
{
    [SerializeField] GameObject topPipe;

    float topPipeBorder = 21f;
    bool isOpened;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isOpened)
        {
            topPipe.transform.position = Vector3.Lerp(topPipe.transform.position, new Vector3(topPipe.transform.position.x, topPipeBorder), Time.deltaTime * 5);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Missile")
        {
            Debug.Log("OnTriggerEnter2D");
            isOpened = true;
            GetComponent<Collider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }

}
