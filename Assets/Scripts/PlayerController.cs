using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction moveAction;
    public Vector2 moveInput;
    public float speed = 10f;
    public float xrange = 10f;
    public float zrange = 10f;

    public GameObject cookie;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        //Stay inbounds
       if(transform.position.x < -xrange)
       {
        transform.position = new Vector3(-xrange, transform.position.y, transform.position.z);
       }

       if(transform.position.x > xrange)
       {
        transform.position = new Vector3(xrange, transform.position.y, transform.position.z);
       }

       if(transform.position.z < -zrange)
       {
        transform.position = new Vector3(transform.position.x, transform.position.y, -zrange);
       }

       if(transform.position.z > zrange)
       {
        transform.position = new Vector3(transform.position.x, transform.position.y, zrange);
       }

        moveInput = moveAction.ReadValue<Vector2>();

        //Move about
        transform.Translate(Vector3.right * moveInput.x * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * moveInput.y * Time.deltaTime * speed);
    }
}
