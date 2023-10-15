using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    public float jumpSpeed = 5;
    Rigidbody2D rb;
    public int score;

    public TMP_Text scoreText;

    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Pipe.speed = speed;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.velocity = Vector2.up * jumpSpeed;
        }

        transform.eulerAngles = new Vector3(0, 0, rb.velocity.y * 3f);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Die();
    }

    public void Die()
    {
        Pipe.speed = 0;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        scoreText.text = score.ToString();
    }
}