using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float steerSpeed;

    void Update()
    {

        float move = 0f;
        float steer = 0f;


        if (Keyboard.current.wKey.isPressed)
        {
            move = .5f;
        }

        else if (Keyboard.current.sKey.isPressed)
        {
            move = -.5f;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            steer = .5f;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            steer = -.5f;
        }

        transform.Translate(0, moveSpeed * move, 0);
        transform.Rotate(0, 0, steerSpeed * steer);
    }
}
