using UnityEngine;
//初期値
public class BallController : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // 最初に右上方向へ発射！
        rb.linearVelocity = new Vector2(1f, 1f).normalized * speed; // linearVelocityを使う
    }
        void FixedUpdate()
    {
        // ボールの速度を一定に保つ
        if (rb.linearVelocity.magnitude < speed)
        {
            rb.linearVelocity = rb.linearVelocity.normalized * speed;
        }
    }
//当たり判定
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Wall")) // 壁に当たった時
        {
            Vector2 reflectDirection = Vector2.Reflect(rb.linearVelocity, col.contacts[0].normal);
            rb.linearVelocity = reflectDirection; // 反射方向で再設定
        }
    }
}
