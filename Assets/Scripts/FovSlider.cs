using JetBrains.Annotations;
using UnityEngine;
using static PlayerMovement;

public class FovSlider : MonoBehaviour
{
    [Header("References")]

    public new Camera camera;
    public PlayerMovement pm;
    public GameObject Player;
    

    public bool walking;
    public bool sprinting;
    public bool crouching;
    public bool sliding;
    
    public float walkFov;
    public float sprintFov;
    public float crouchFov;
    public float slideFov;

    public float targetFov;
    // Update is called once per frame

    private void Start()
    {
        pm = Player.GetComponent<PlayerMovement>();
    }
    void Update()
    {
        if (pm.state == PlayerMovement.MovementState.walking)
            targetFov = walkFov;

        if (pm.state == PlayerMovement.MovementState.sprinting)
            targetFov = sprintFov;

        if (pm.state == PlayerMovement.MovementState.crouching)
            targetFov = crouchFov;

        if (pm.state == PlayerMovement.MovementState.sliding)
            targetFov = slideFov;

        camera.fieldOfView = Mathf.Lerp(camera.fieldOfView, targetFov, 0.05f);

    }
}

