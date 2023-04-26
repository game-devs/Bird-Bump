using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movment : MonoBehaviour
{

    [SerializeField] InputAction horizontalMovment = new InputAction(type: InputActionType.Button);

    private void OnEnable()
    {
        horizontalMovment.Enable();
    }
    private void OnDisable()
    {
        horizontalMovment.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int m = horizontalMovment.ReadValue<int>();

        transform.position = new Vector3();


    }
}
