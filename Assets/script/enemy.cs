using Unity.VisualScripting;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int speed = 2;
    public float HP = 3;
    public float timer = 0.0f;
    private float time = 2.5f;
    private float shottimer = 0.0f;
    public float shottime=2;
    private int yoko = 2;
    private float gendo;
    public GameObject tama;
    //public GameObject item;
    void Start()
    {
        gendo = Random.Range(4.3f, 1.5f);
        if (Random.Range(0, 2) == 0)
            yoko *=-1;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= gendo)
            transform.Translate(new Vector3(0, speed, 0) * Time.deltaTime);
        else
        {
            timer += Time.deltaTime;
            shottimer += Time.deltaTime;
          
            transform.Translate(new Vector3(yoko, 0, 0) * Time.deltaTime);
            if(time < timer)
            {
                yoko *= -1;
                timer = 0;
            }
            if ( transform.position.x >= 2) 
            {
                transform.position=new Vector3(1.9f, transform.position.y,0);
                yoko *= -1;
                timer = 0;
            }
            if (transform.position.x <= -8.5) 
            {
                transform.position = new Vector3(-8.4f, transform.position.y, 0);
                yoko *= -1;
                timer = 0;
            }

            if (shottimer > shottime)
            {
                Instantiate(tama, transform.position, transform.rotation);
                shottimer = 0;
            }
        }
        if (HP <= 0)
        {
            Destroy(gameObject);
            if (Random.Range(0, 2) == 0)
                player.bunnsinn += 1;
            sponer.enemysuu--;
            //Instantiate(item, transform.position, transform.rotation);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Tama")) 
        {
            HP-=player.atk;
            Destroy(collision.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Tama"))
        {
            HP -= player.atk;
            Destroy(collision.gameObject);
        }
    }

}
