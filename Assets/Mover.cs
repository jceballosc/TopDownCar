using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float rotateSpeed;
    [SerializeField] float accelerationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rotateSpeed = .8f;
        accelerationSpeed = .05f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotateSpeed);
        transform.Translate(0, accelerationSpeed, 0);
    }
}
