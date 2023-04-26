using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMover : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Transform tip;
    [SerializeField] float speed;
    [SerializeField] float triggerDistance = 2f;

    int direction = 1;
    Vector3 originalPosition;
    float distToTip;

    // Start is called before the first frame update
    void Start()
    {
        distToTip = Mathf.Abs(tip.position.y - transform.position.y);
        originalPosition = transform.position;
        Debug.Log("distToTip " + distToTip);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 t;
        float dist;
        if (direction == 1)
        {
            t = new Vector3(transform.position.x, target.position.y);
            dist = Mathf.Abs(transform.position.y - t.y) - distToTip;
        }
        else
        {
            t = new Vector3(transform.position.x, originalPosition.y);
            dist = Mathf.Abs(transform.position.y - t.y);
        }


        transform.position = Vector3.Lerp(transform.position, t, Time.deltaTime * speed);
        Debug.Log(dist + "  " + triggerDistance + "     " + t + "   " + direction);


        if ((direction == 1 && dist < triggerDistance) || (direction == -1 && dist < .1))
        {
            direction *= -1;
        }


    }





}
