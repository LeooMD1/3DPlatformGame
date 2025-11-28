using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class UpgradeBox : MonoBehaviour
{
    [Header("Referances")]
    public GameObject Player;
    public Swinging swinging;
    public Rigidbody rb;
    public GameObject upgradeBox;
    public Collider col;

    [Header("Variables")]
    public bool Touched;

    private void Start()
    {         
        rb = Player.GetComponent<Rigidbody>();
        swinging = Player.GetComponent<Swinging>(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == col)
        {
            print("this part is working");
            swinging.enabled = true;
            gameObject.SetActive(false);
        }
    }
}
