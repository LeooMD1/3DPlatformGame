using UnityEngine;
using TMPro;

public class SpeedScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI speedDisplay;
    
    public float playerSpeed;
    public PlayerMovement pm;
    public Rigidbody rb;

    public GameObject player;
     void Start()
     {
        pm = player.GetComponent<PlayerMovement>();
        rb = player.GetComponent<Rigidbody>();
       
     }
    void Update()
    {
        speedDisplay.text = (Mathf.RoundToInt(rb.linearVelocity.magnitude).ToString());
    }
}
