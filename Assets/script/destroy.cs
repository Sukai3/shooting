using UnityEngine;


public class destroy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ETama"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Tama"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Bom"))
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
        if (collision.gameObject.CompareTag("Tama"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Bom"))
        {
            Destroy(collision.gameObject);
        }

    }
}
