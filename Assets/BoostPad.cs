using UnityEngine;

public class BoostPad : MonoBehaviour
{
    [Header("Variables")]
    public float boostVelocity;
    public bool isTouched;


    [Header("References")]
    public PlayerMovement pm;
    public Rigidbody rb;
    public Collider col;

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

    }

    private void OnTriggerEnter(Collider other)
    {

        print("reached on trigger");
        if (other == col)
        {
            rb.AddForce(Vector3.up * boostVelocity, ForceMode.Impulse);
            print("if statement works");
        }
    }
}

