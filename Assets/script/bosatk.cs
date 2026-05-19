using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.U2D.IK;

public class bosatk : MonoBehaviour
{
    public GameObject[] Danmaku;
    private float timer=0.0f;
    private  float Stimer = 0.0f;
    private float Ptimer=0.0f;
    public float Ptime = 20;
    public float Utime = 5;
    public bool kyukei = false;
    public float shokisponetime = 120;
    public static float sponetime = 20;
    public float time=0;
    public int pattern = 0;
    public float rnd;
    public float HP = 300;
    public float kakudo=0;
    public float sum=0;
    public static  bool kill=false;
    public int Maxpattern;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        kill = false;
        sponetime = shokisponetime;
       
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Stimer += Time.deltaTime;
      
        if (HP <= 0)
        {
           Destroy(gameObject);
           kill=true;
        }
       
        if (Stimer >= sponetime)
        {
            if (transform.position.y >= 2.57)
                transform.Translate(new Vector3(0, -2, 0) * Time.deltaTime);
        }
        if (transform.position.y <= 4)
        {

            Ptimer += Time.deltaTime;
            if (Ptimer > Ptime&&!kyukei) 
            {
                Ptimer = 0;
                pattern = -1;
                kyukei = true;
            }
            if (Ptimer > Utime && kyukei) 
            {
                Ptimer = 0;
                kyukei = false;
                pattern = Random.Range(0, Maxpattern+1);
            }

            if (time < timer && pattern == 0)
            {
                timer = 0;
                time = 0.4f;
                Instantiate(Danmaku[0], transform.position, Quaternion.Euler(0, 0, Random.Range(90f, 270f)));
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

