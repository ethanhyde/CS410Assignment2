using UnityEngine;

public class ColorLerp : MonoBehaviour
{
    Color lerpedColor = Color.white;
    new Renderer renderer;

    void Start()
    {
        renderer = GetComponentInChildren<Renderer>();
    }

    void Update()
    {
        // Material flashes faster with time
        // Found here: https://docs.unity3d.com/ScriptReference/Color.Lerp.html
        float time = 1f / (1f + Time.time * 0.01f);
        lerpedColor = Color.Lerp(Color.white, Color.white * 1.5f, Mathf.PingPong(Time.time, time));

        renderer.material.color = lerpedColor;
    }
}