using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MissileSpawnerScript : MonoBehaviour
{
    [SerializeField] private GameObject missile;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            Instantiate(missile, new Vector3(transform.position.x, transform.position.y, transform.position.z), missile.transform.rotation);
        }

    }
}
