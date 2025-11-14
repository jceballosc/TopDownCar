using UnityEngine;

public class SlowArea : MonoBehaviour
{

    string targetTag = "Player";

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(targetTag))
        {
            Debug.Log("You are in");
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(targetTag))
        {
            Debug.Log("You are OUT");
        }
    }

}
