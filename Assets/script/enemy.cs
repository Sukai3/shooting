using Unity.VisualScripting;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed = 2;
    public float HP = 3;
    private float timer = 0.0f;
    public float kirikaesitime = 2.5f;
    private float shottimer = 0.0f;
    public float shottime=2;
    public float yoko = 2;
    private float gendo;
    public GameObject[] tama;
    public int pattern=0;
    AudioSource audioSource;
    public AudioClip sound1;
    public int rand;
  
    //public GameObject item;
    void Start()
    {
        if (Random.Range(0, 5) == 1)
            pattern = 1;
        gendo = Random.Range(4.3f, 1.5f);
        if (Random.Range(0, 2) == 0)
            yoko *=-1;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= gendo)
            transform.Translate(new Vector3(0, 2, 0) * Time.deltaTime);
        else
        {
            timer += Time.deltaTime;
            shottimer += Time.deltaTime;
          
            transform.Translate(new Vector3(yoko, speed, 0) * Time.deltaTime);
            if(kirikaesitime < timer)
            {
                yoko *= -1;
                timer = 0;
            }
            if ( transform.position.x >= 8) 
            {
                transform.position=new Vector3(8f, transform.position.y,0);
                yoko *= -1;
                timer = 0;
            }
            if (transform.position.x <= -8.5) 
            {
                transform.position = new Vector3(-8.4f, transform.position.y, 0);
                yoko *= -1;
                timer = 0;
            }

            if (shottimer > shottime&&pattern==0)
            {
                Instantiate(tama[0], transform.position, Quaternion.Euler(0, 0,0));
                shottimer = 0;
            }
            if (shottimer > shottime && pattern == 1) 
            {
                for(int i=0;i<3;i++)
                    Instantiate(tama[1], transform.position, Quaternion.Euler(0, 0, i*45-45+180));
                shottimer = 0;
            }
        }
        if (HP <= 0)
        {
            rand = Random.Range(0, 10)+1;
            audioSource.PlayOneShot(sound1);
            Destroy(gameObject);
            if ( rand>= 4)
                player.bunnsinn += 1;
            else if ( rand>= 2)
                player.bunnsinn += 2;
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
        if (collision.gameObject.CompareTag("Bom"))
        {
            HP -= player.bomdamage;
           
        }
        if (collision.gameObject.CompareTag("Enemykill"))
        {
            Destroy(gameObject);
            sponer.enemysuu--;
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
            HP -= player.bomdamage;
           
        }
        if (collision.gameObject.CompareTag("Enemykill"))
        {
            Destroy(gameObject);
            sponer.enemysuu--;
        }
    }

}
