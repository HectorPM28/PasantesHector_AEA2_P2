using UnityEngine;

public class FakePlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private Transform player;
    void Update()
    {
        transform.rotation = player.rotation;

        transform.position += player.up * speed * Time.deltaTime;
    }
}
