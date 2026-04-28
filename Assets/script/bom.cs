using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class bom : MonoBehaviour
{
    public float speed = 4;
    public float a;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // transform.localScale = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        a = transform.rotation.z;
        transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);

        if (transform.position.y < -4) {
            transform.localScale = new Vector3(-transform.localScale.x, 1, 1);
            transform.position = new Vector2(transform.position.x, -4.0f);
        }
        if (transform.position.y > 4) {
            transform.localScale = new Vector3(-transform.localScale.x, 1, 1);
            transform.position = new Vector2(transform.position.x, 4.0f);
        }
        if (transform.position.x < -8.4)
        {
            transform.localScale = new Vector3(-transform.localScale.x, 1, 1);
            transform.position = new Vector2(-8f, transform.position.y);
        }
        if (transform.position.x > 1.75)
        {
            transform.localScale = new Vector3(-transform.localScale.x, 1, 1);
            transform.position = new Vector2(1.7f, transform.position.y);
        }
    }
}
   

    

    

   