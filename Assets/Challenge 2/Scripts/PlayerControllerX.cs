using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public InputAction fireAction;

    // Start is called before the first frame update
    void Start()
    {
    fireAction.Enable();
    }
    

    // Update is called once per frame
    void Update()
    { 
        if (fireAction.triggered)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            fireAction.Disable();
            Invoke("Yodelo", 2.0f);

        }
    }
    void Yodelo()
    {
        fireAction.Enable();
    }
}
