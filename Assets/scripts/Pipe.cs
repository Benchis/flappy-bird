using UnityEngine;

public class Pipe : MonoBehaviour
{
    public static float speed;

    public float minX;
    public float maxX;

    void Start()
    {
        minX = Camera.main.ViewportToWorldPoint(new Vector3(0, 0)).x - 1;
        maxX = Camera.main.ViewportToWorldPoint(new Vector3(1, 0)).x + 1;
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        // teleport pipe back
        if (transform.position.x < minX)
        {
            transform.position = new Vector3(maxX, transform.position.y, 0);
        }
    }
}