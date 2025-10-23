using UnityEngine;

public class ColourLerp : MonoBehaviour
{
    public Color[] colors;
    public float duration;

    private Renderer rend;
    private int currentColorIndex = 0;
    private float t = 0f;
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = colors[0];
    }

    void Update()
    {
        t += Time.deltaTime / duration;
        rend.material.color = Color.Lerp(colors[currentColorIndex], colors[(currentColorIndex + 1) % colors.Length], t);

        if (t >= 1f)
        {
            t = 0f;
            currentColorIndex = (currentColorIndex + 1) % colors.Length;
        }
    }
}
