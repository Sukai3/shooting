using UnityEngine;

public class Number : MonoBehaviour
{
    public GameObject[] number;
    public int one;
    public int ten;
    public int hund;
    public int thou;
    public int zurasi=0;
    public int i = 0;
    public float y = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        one = sponer.enemysum % 10;
        ten = (sponer.enemysum / 10) % 10;
        //if (i == 0)
        //{
        //    i++;
        //    Instantiate(number[thou], transform.position = new Vector3(-3, y, 0), transform.rotation);
        //    Instantiate(number[hund], transform.position = new Vector3(-2.3f, y, 0), transform.rotation);
        //    Instantiate(number[ten], transform.position = new Vector3(-1.5f, y, 0), transform.rotation);
        //    Instantiate(number[one], transform.position = new Vector3(-0.7f, y, 0), transform.rotation);
        //}
        if (Input.GetKeyDown(KeyCode.Space))
        {
            i++;
            Instantiate(number[thou], transform.position = new Vector3(-3, y, 0), transform.rotation);
            Instantiate(number[hund], transform.position = new Vector3(-2.3f, y, 0), transform.rotation);
            Instantiate(number[ten], transform.position = new Vector3(-1.5f, y, 0), transform.rotation);
            Instantiate(number[one], transform.position = new Vector3(-0.7f, y, 0), transform.rotation);
        }
    }
}
