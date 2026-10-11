using Unity.VisualScripting;
using UnityEngine;

public class RunningAnimation : MonoBehaviour
{
    [SerializeField] float runningSpeed = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * runningSpeed * Time.deltaTime);
    }
}
