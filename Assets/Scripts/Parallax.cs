using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private float parallaxMultiplier = 0.1f;
    private Material parallaxMaterial;
    private Vector3 lastPlayerPosition;
    [SerializeField] private Transform player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        parallaxMaterial = GetComponent<Renderer>().material;
        lastPlayerPosition = player.position;
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = player.position.x - lastPlayerPosition.x;
        float deltaY = player.position.y - lastPlayerPosition.y;

        parallaxMaterial.mainTextureOffset += new Vector2(deltaX * parallaxMultiplier, deltaY * parallaxMultiplier);
        lastPlayerPosition = player.position;
    }
}
