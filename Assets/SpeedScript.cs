using UnityEngine;
using TMPro;

public class SpeedScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI speedDisplay;
    
    public float playerSpeed;
    public PlayerMovement pm;
    public Rigidbody rb;
    public gameObject;
     void Start()
    {
        pm = GetComponent<PlayerMovement>();
        rb = GetComponent<Rigidbody>();
       
    }
    void Update()
    {
        speedDisplay.text = (rb.linearVelocity.magnitude.ToString());
    }
}
