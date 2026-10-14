using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterScript : MonoBehaviour
{
    [SerializeField] float playerSpeed = 3.0f;
    private float movementX;
    private float movementY;

    private Rigidbody rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //rb = GetComponent <Rigidbody>();

    }
/*
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;

    }
*/

    // Update is called once per frame
    void Update()
    {
        //float xValue = Input.GetAxis("Horizontal") * Time.deltaTime
    }

/*
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * playerSpeed);
    }
*/

}
