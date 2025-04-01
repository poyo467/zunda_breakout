using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // 最初に右上方向へ発射！
        rb.linearVelocity = new Vector2(1f, 1f).normalized * speed;
    }
}
