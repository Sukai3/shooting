using UnityEngine;

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
    public int pattern2 = -10;
    public float rnd;
    public float HP = 600;
    public float kakudo=0;
    public float sum=0;
    public static  bool kill=false;
    public int Maxpattern;
    private float count=1;
    float i = 0;
    public GameObject[] gage;
    private float timer2 = 0.0f;
    public float time2 = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        kill = false;
        sponetime = shokisponetime;
        pattern = Random.Range(0, Danmaku.Length);

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        timer2 += Time.deltaTime;
        Stimer += Time.deltaTime;
        if(HP <= 0)
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
                count = 1;
                i = 0;
                pattern = -1;
                kyukei = true;
            }
            if (Ptimer > Utime && kyukei) 
            {
                Ptimer = 0;
                kyukei = false;
               
                pattern = Random.Range(0, Danmaku.Length);
                if (pattern == pattern2)
                    pattern = Random.Range(0, Danmaku.Length);
                if (Ptimer > Utime - 2) 
                {
                    pattern2 = Random.Range(0, Danmaku.Length);
                    if(pattern2==pattern)
                        pattern2 = Random.Range(0, Danmaku.Length);
                    if (pattern2 == pattern)
                        pattern2 = Random.Range(0, Danmaku.Length);
                }
            }

            if (time < timer && pattern == 0)
            {
               
                timer = 0;
                time = 0.4f;
                Instantiate(Danmaku[0], transform.position, Quaternion.Euler(0, 0, Random.Range(90f, 270f)));
                Instantiate(Danmaku[0], transform.position, Quaternion.Euler(0, 0, Random.Range(90f, 270f)));
                Instantiate(Danmaku[0], transform.position, Quaternion.Euler(0, 0, Random.Range(270, 450)));
            }
            if (time/count < timer && pattern == 1)
            {
                timer = 0;
                time = 3;
                rnd = Random.Range(8.0f, -8.5f);
                for (int i = 0; i <= 16; i++)
                {

                    Instantiate(Danmaku[1], new Vector2(rnd, 4f), Quaternion.Euler(0, 0, i * 22.5f));
                }
                count+=0.5f;
            }
            if (time < timer && pattern == 2)
            {
              
                timer = 0;
                time = 0.2f;
                Instantiate(Danmaku[2], new Vector2(Random.Range(-8.0f, 8.0f), 5f), transform.rotation);


            }
            if (time < timer && pattern == 3)
            {
                
                timer = 0;
                time = 1.5f;
                Instantiate(Danmaku[3], transform.position, Quaternion.Euler(0, 0,0));


            }
            if (time < timer && pattern == 4)
            {
                timer = 0;
                time = 0.1f; 
                
                i += 17;

                    Instantiate(Danmaku[1], transform.position, Quaternion.Euler(0, 0, i));
                Instantiate(Danmaku[1], transform.position, Quaternion.Euler(0, 0, i+180));


            }










            //if (time2 < timer2 && pattern2 == 0)
            //{

            //    timer2 = 0;
            //    time2 = 0.4f;
            //    Instantiate(Danmaku[0], transform.position, Quaternion.Euler(0, 0, Random.Range(90f, 270f)));
            //    Instantiate(Danmaku[0], transform.position, Quaternion.Euler(0, 0, Random.Range(90f, 270f)));
            //    Instantiate(Danmaku[0], transform.position, Quaternion.Euler(0, 0, Random.Range(270, 450)));
            //}
            //if (time2 / count < timer2 && pattern2 == 1)
            //{
            //    timer2 = 0;
            //    time2 = 3;
            //    rnd = Random.Range(8.0f, -8.5f);
            //    for (int i = 0; i <= 16; i++)
            //    {

            //        Instantiate(Danmaku[1], new Vector2(rnd, 4f), Quaternion.Euler(0, 0, i * 22.5f));
            //    }
            //    count += 0.5f;
            //}
            //if (time2 < timer2 && pattern2 == 2)
            //{

            //    timer2 = 0;
            //    time2 = 0.2f;
            //    Instantiate(Danmaku[2], new Vector2(Random.Range(-8.0f, 8.0f), 5f), transform.rotation);


            //}
            //if (time2 < timer2 && pattern2 == 3)
            //{

            //    time2 = 0;
            //    time2 = 1.5f;
            //    Instantiate(Danmaku[3], transform.position, Quaternion.Euler(0, 0, 0));


            //}
            //if (time2 < timer2 && pattern2 == 4)
            //{
            //    timer2 = 0;
            //    time2 = 0.1f;

            //    i += 17;

            //    Instantiate(Danmaku[1], transform.position, Quaternion.Euler(0, 0, i));
            //    Instantiate(Danmaku[1], transform.position, Quaternion.Euler(0, 0, i + 180));


            //}



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

