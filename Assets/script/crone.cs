using System.Threading;
using UnityEngine;

public class crone : MonoBehaviour
{
    private float timer=0.0f;
    public float time = 0.5f;
    public int banngou=1; 
    public GameObject tama;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(banngou<=player.bunnsinn)
            GetComponent<SpriteRenderer>().enabled = true;
        else
            GetComponent<SpriteRenderer>().enabled = false;
        if (GetComponent<SpriteRenderer>().enabled)
        {
            timer += Time.deltaTime;
            shot();
        }
    }
    void shot()
    {
        if (timer > time)
        {
            //Debug.Log("生成！");
            Instantiate(tama, transform.position,Quaternion.Euler(0, 0, 90));
            timer = 0;
        }


    }
}
