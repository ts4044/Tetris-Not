using UnityEngine;

public class Background : MonoBehaviour
{
    [Range(-1f,1f)]
    public float scrollSpeed = 0.05f;
    private Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Time.time * scrollSpeed;
        rend.material.mainTextureOffset = new Vector2(0, offset);
    }
}