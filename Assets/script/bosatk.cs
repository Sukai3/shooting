using System.Threading;
using UnityEngine;

public class bosatk : MonoBehaviour
{
    public GameObject[] Danmaku;
    private float timer=0.0f;
    private float Stimer = 0.0f;
    public float sponetime = 10;
    public float time=0;
    public int pattern = 0;
    public float rnd;
    public float HP = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Stimer += Time.deltaTime;
        if (HP <= 0)
        {
            Destroy(gameObject);
        }
        if (Stimer >= sponetime)
        {
            if (transform.position.y >= 4)
                transform.Translate(new Vector3(0, 2, 0) * Time.deltaTime);
        }
        if (transform.position.y <= 4)
        {
            if (time < timer && pattern == 0)
            {
                timer = 0;
                time = 1.4f;
                Instantiate(Danmaku[0], transform.position, Quaternion.Euler(0, 0, Random.Range(90f, 270f)));
                Instantiate(Danmaku[0], transform.position, Quaternion.Euler(0, 0, Random.Range(270, 450)));
            }
            if (time < timer && pattern == 1)
            {
                timer = 0;
                time = 3;
                rnd = Random.Range(2.0f, -8.5f);
                for (int i = 0; i <= 16; i++)
                {

                    Instantiate(Danmaku[1], new Vector2(rnd, 2f), Quaternion.Euler(0, 0, i * 22.5f));
                }
            }
            if (time < timer && pattern == 2)
            {
                timer = 0;
                time = 0.2f;
                Instantiate(Danmaku[2], new Vector2(Random.Range(-8.0f, 8.0f), 5f), transform.rotation);

            }
        }
    }
            private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Tama"))
        {
            HP -= player.atk;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Bom"))
        {
            HP -= player.bomdamage/3;

        }
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Tama"))
        {
            HP -= player.atk;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Bom"))
        {
            HP -= player.bomdamage/3;

        }
       
    }
}

