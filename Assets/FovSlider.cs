using UnityEngine;

public class FovSlider : MonoBehaviour
{
    [Header("References")]

    public Camera camera;

    public float walkFov = 1f;
    public float sprintFov = 2f;
    
    static float startValue = 1f;
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.LeftShift))
            camera.fieldOfView = Mathf.Lerp(walkFov, sprintFov, startValue);
        else if (Input.GetKeyUp(KeyCode.LeftShift))
            camera.fieldOfView = Mathf.Lerp(sprintFov, walkFov, startValue);
    }
}

