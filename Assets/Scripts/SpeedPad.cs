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

            pm.speedMult = 10f;
            rb.AddForce(inputDirection * 20, ForceMode.Impulse);
        }
    }
}
