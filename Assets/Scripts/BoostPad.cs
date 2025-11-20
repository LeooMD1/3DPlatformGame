using UnityEngine;

public class BoostPad : MonoBehaviour
{
    [Header("Variables")]
    public float boostVelocity;
    public float boostSpeed;
    public bool isTouched;
    private float horizontalInput;
    private float verticalInput;



    [Header("References")]
    public PlayerMovement pm;
    public Rigidbody rb;
    public Collider col;
    public Transform orientation;

    public GameObject player;
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pm = player.GetComponent<PlayerMovement>();
        rb = player.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void OnTriggerEnter(Collider other)
    {

       
        if (other == col)
        {
            Vector3 inputDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

            rb.AddForce(Vector3.up * boostVelocity, ForceMode.Impulse);
            rb.AddForce(inputDirection * boostSpeed, ForceMode.Impulse);
            
        }
    }
}

