using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class CharacterScript : MonoBehaviour
{
    // character speed
    [SerializeField] float playerSpeed = 3.0f;

    // movement varaibles
    private float movementX;
    private float movementY;

    // rigid body initialization
    private Rigidbody rb;

    // animation initilization
    private Animator animation;

    // count initialization
    private int count;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent <Rigidbody>();
        animation = GetComponent<Animator>();
        count = 0;

    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal");
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(xValue, yValue, zValue);
        bool isWalkinng = direction.magnitude > 0;

        animation.SetBool("isMoving", isWalkinng);

        if (direction.magnitude > 0.1f)
        {
            transform.rotation = Quaternion.LookRotation(direction);
            transform.Translate(direction.normalized * playerSpeed * Time.deltaTime, Space.World);
        }
    }

    void SetCount()
    {
        if (count >= 9)
        {
            SceneManager.LoadScene("ThirdScene");
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin")) {
            other.gameObject.SetActive(false);
            count++;
            SetCount();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("FirstScene");
        }
    }

}
