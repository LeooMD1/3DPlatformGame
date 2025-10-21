using UnityEngine;

public class FovSlider : MonoBehaviour
{
    [Header("References")]

    public Camera camera;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
             camera.fieldOfView = 70;
        else if (Input.GetKeyUp(KeyCode.LeftShift))
            camera.fieldOfView = 60;
        
    }
}
