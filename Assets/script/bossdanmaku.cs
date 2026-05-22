using UnityEngine;

public class bossdanmaku : MonoBehaviour
{
    float rota ;
    public float xspeed = 5.0f;
    public float yspeed = 0;
    private float timer = 0.0f;
    public float time=10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rota = Random.Range(-180.0f, 180.0f);
        transform.rotation = Quaternion.Euler(0, 0, rota);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > time)
            Destroy(gameObject);
        transform.Translate(new Vector3(xspeed, yspeed, 0) * Time.deltaTime);

        if (transform.position.y < -4.5)
        {
            // transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            transform.position = new Vector2(transform.position.x, -4.5f);
          
                rota = rota - rota + 180 - rota;
            transform.rotation = Quaternion.Euler(0, 0, rota);
        }
        if (transform.position.y > 4.5)
        {
            // transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            transform.position = new Vector2(transform.position.x, 4.5f);
          
                rota = rota - rota + 180 - rota;
            transform.rotation = Quaternion.Euler(0, 0, rota);
        }
        if (transform.position.x < -8.4)
        {
            // transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            transform.position = new Vector2(-8.4f, transform.position.y);
           
                rota *= -1;
            transform.rotation = Quaternion.Euler(0, 0, rota);
        }
        if (transform.position.x > 8.3)
        {
            // transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            transform.position = new Vector2(8.3f, transform.position.y);
           
                rota *= -1;
            transform.rotation = Quaternion.Euler(0, 0, rota);
        }
    }
}
