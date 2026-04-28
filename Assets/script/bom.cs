using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class bom : MonoBehaviour
{
    public float speed = 4;
    public float a;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a = transform.rotation.z;
        transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);

        if (transform.position.y < -4) {
            transform.rotation =Quaternion.Euler(transform.rotation.x, transform.rotation.y, -a);
            transform.position = new Vector2(transform.position.x, -3.0f);
        }
        if (transform.position.y > 4) {
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, -a);
            transform.position = new Vector2(transform.position.x, 3.0f);
        }
        if (transform.position.x < -8.4)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, -a);
            transform.position = new Vector2(-7f, transform.position.y);
        }
        if (transform.position.x > 1.75)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, -a);
            transform.position = new Vector2(1.3f, transform.position.y);
        }
    }
}
   

    

    

   