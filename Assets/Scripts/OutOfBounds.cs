using UnityEngine;
using UnityEngine.SceneManagement;

public class OutOfBounds : MonoBehaviour
{
    public float threshold;
    private int currentScene;

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
    }

    private void FixedUpdate()
    {
        if (transform.position.y < threshold)
            SceneManager.LoadScene(currentScene);
    }
}
