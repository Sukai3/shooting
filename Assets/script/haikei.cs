using TreeEditor;
using UnityEngine;

public class haikei : MonoBehaviour
{
    public float speed;
    public Transform[] basho;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, speed, 0) * Time.deltaTime);
        if (transform.position.y <= -10.8f) 
        {
            transform.position = basho[0].position;
        }

    }
}
