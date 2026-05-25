using UnityEngine;

public class haikei : MonoBehaviour
{
    public float speed;
    public Transform[] basho;
    public int bangou;
    public int jougenn;
    public bool owari=false;
    public bool kurayami=false;
    public GameObject kakusi;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (statichaikei.kaisuu >= bangou)
        { 
            if (kurayami)
            {
                yami.key = true;
            }
            if (transform.position.y >= 0f && owari)
            {

                transform.Translate(new Vector3(0, speed, 0) * Time.deltaTime);
            }
        

        if (transform.position.y >= -11.8f&&!owari)
            {
                
                transform.Translate(new Vector3(0, speed, 0) * Time.deltaTime);
            }
        }
        if (transform.position.y <= -10.8f && statichaikei.kaisuu >= jougenn && !owari)
        {
            statichaikei.kaisuu++;
            Destroy(gameObject);
        }
        if (transform.position.y <= -10.8f&&statichaikei.kaisuu>=bangou&&!owari) 
        {
           
                statichaikei.kaisuu ++;
            transform.position = basho[0].position;
        }
       
    }
}

