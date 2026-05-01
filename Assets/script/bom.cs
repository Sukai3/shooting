using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class bom : MonoBehaviour
{
    public float speed = 4f;
    public float x;
    public float y;
    public float rota;
    private float a;
    private float timer = 0.0f;
    public float time=5.0f;
    public int count = 0;
    //public GameObject tama;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //rota = Random.Range(-45f, 45f);
        rota = 0;
        transform.rotation = Quaternion.Euler(0, 0, rota);
      
        //if (transform.rotation.z > 0)
        //{
        //    y = 90;
        //}
        //else
        //    y = -90;
        // transform.localScale = new Vector3(1, 1, 1);//Quaternion.Euler(0, 0, 90)

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
      //  Instantiate(tama, transform.position, transform.rotation);
        //if (transform.rotation.z > 0)
        //{
        //    x = 90;
        //}
        //else
        //    x = -90;
        if(timer>=time)
            Destroy(gameObject);
        if (transform.localScale.x>0)
            transform.position += transform.up * speed * Time.deltaTime;
        else
            transform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime);







        if (transform.position.y < -4) {
           // transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            transform.position = new Vector2(transform.position.x, -4f);
            if (count == 0)
            {
                rota = Random.Range(-45f, 45f) + 180;
                count++;
            }
            else
            rota = rota - rota + 180 - rota;
            transform.rotation = Quaternion.Euler(0, 0, rota);
        }
        if (transform.position.y > 4) {
           // transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            transform.position = new Vector2(transform.position.x, 4f);
            if (count == 0)
            {
                rota = Random.Range(-45f, 45f) + 180;
                count++;
            }
            else
                rota = rota-rota + 180 - rota;
            transform.rotation = Quaternion.Euler(0, 0,rota);
        }
        if (transform.position.x < -8.4)
        {
           // transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            transform.position = new Vector2(-8.4f, transform.position.y);
            if (count == 0)
            {
                rota = Random.Range(-45f, 45f) + 180;
                count++;
            }
            else
                rota *=-1 ;
            transform.rotation = Quaternion.Euler(0, 0, rota);
        }
        if (transform.position.x > 1.75)
        {
           // transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            transform.position = new Vector2(1.75f, transform.position.y);
            if (count == 0)
            {
                rota = Random.Range(-45f, 45f)+180;
                count++;
            }
            else
                rota *= -1;
            transform.rotation = Quaternion.Euler(0, 0, rota);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ETama"))
        {
           
            Destroy(collision.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ETama"))
        {
            
            Destroy(collision.gameObject);
        }
    }
}
   

    

    

   