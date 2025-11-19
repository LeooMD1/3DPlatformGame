using UnityEngine;

public class SpeedPad : MonoBehaviour
{
    [Header("variables")]
    public float speedVelocity;
    public float speedSpeed;
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
        rb = player.GetComponent<Rigidbody>();
        pm = player.GetComponent<PlayerMovement>();
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

            rb.AddForce(inputDirection * speedSpeed, ForceMode.Impulse);
        }
    }
}
