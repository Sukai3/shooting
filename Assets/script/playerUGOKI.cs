using UnityEngine;

public class playerUGOKI : MonoBehaviour
{
    public float gensoku = 2.0f;
    public float MoveSpeed = 3.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vec;
        vec.x = Input.GetAxis("Horizontal");
        vec.y = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.LeftShift))
            transform.Translate(vec * (MoveSpeed - gensoku) * Time.deltaTime);
        else
            transform.Translate(vec * MoveSpeed * Time.deltaTime);
        if (transform.position.y < -4)
            transform.position = new Vector2(transform.position.x, -4.0f);
        if (transform.position.y > 4)
            transform.position = new Vector2(transform.position.x, 4.0f);
        if (transform.position.x < -8.4)
            transform.position = new Vector2(-8.4f, transform.position.y);
        if (transform.position.x > 1.75)
            transform.position = new Vector2(1.75f, transform.position.y);

    }
}
