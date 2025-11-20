using UnityEngine;
using UnityEngine.SceneManagement;

public class Nextlevel : MonoBehaviour
{
    private int currentScene;
    
    public PlayerMovement pm;
    public Rigidbody rb;
    public Collider col;

    public GameObject Player;
    
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        
        pm = Player.GetComponent<PlayerMovement>();
        rb = Player.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == col)
        {
            print("portal touched");
            SceneManager.LoadScene(currentScene + 1);
        }
    }
}
