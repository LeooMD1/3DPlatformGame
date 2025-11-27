using UnityEngine;

public class Stickyplatform : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(transform);
            print("enter");
        }
            
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Player")
            collision.gameObject.transform.SetParent(null);
    }
}
