using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 4.0f; //The f at the end of the number says it is a floating-point number
    public float rotateSpeed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player started!");
    }

    // Update is called once per frame
    // void Update()
    // {
    //     float speed = Input.GetAxis("Vertical");

    //     if (speed != 0) // Player moving
    //     {
    //         Debug.Log(speed);
    //     }
    // }
    void Update()
    {
        float speed = Input.GetAxis("Vertical");

        // Rotate around y-axis
        // transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

        // Forward is the forward direction for this character
        Vector3 forward = transform.TransformDirection(Vector3.forward);

        // You need the Character Controller so you can use SimpleMove
        CharacterController controller = GetComponent<CharacterController>();
        controller.SimpleMove(forward * speed * moveSpeed);
    }
}
