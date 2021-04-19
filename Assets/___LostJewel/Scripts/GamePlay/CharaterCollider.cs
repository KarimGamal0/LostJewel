using UnityEngine;

public class CharaterCollider : MonoBehaviour
{
    [SerializeField] OnCollectGameEvent collect;
    [SerializeField] PlayerData _vector;

    Rigidbody2D _rb2d;
    private void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            OnCollectGameEvent.onCollectEvent.CollectItems();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag ("Platform"))
        {
            _vector.isGrounded = true;
            var contacts = collision.contacts;
            foreach (var item in contacts)
            {
                if (item.normal == Vector2.up)
                {
                   _rb2d.gravityScale = 1;
                }
                else
                {
                    _rb2d.gravityScale = -1;
                }
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Platform"))
        {
            _vector.isGrounded = false;
        }
    }
}
