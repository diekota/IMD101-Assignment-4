using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform character;
    [SerializeField] float rotationSpeed = 50.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (character != null)
        {
            transform.RotateAround(character.position, Vector3.up, rotationSpeed * Time.deltaTime);
            transform.LookAt(character);
        }
    }
}
