using TMPro;
using UnityEngine;

public class StateUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI stateDisplay;

    public PlayerMovement pm;
    public Rigidbody rb;

    public GameObject Player;
    void Start()
    {
        rb = Player.GetComponent<Rigidbody>();
        pm = Player.GetComponent<PlayerMovement>();
    }


    void Update()
    {
        stateDisplay.text = pm.state.ToString();

    }
}
