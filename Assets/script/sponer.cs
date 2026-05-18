//using System;
using System.Threading;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class sponer : MonoBehaviour
{
    public GameObject[] enemy;
    public float timer=0.0f;
    public float Stimer = 0.0f;
    public float time = 5.0f;
    public static int enemysuu=0;
    public static int enemysum = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame      2,-8.5f
    void Update()
    {
        timer += Time.deltaTime;
        Stimer += Time.deltaTime;

        if ( Stimer < bosatk.sponetime - 15&&time < timer)
        {
            Instantiate(enemy[0], new Vector2(Random.Range(8f, -8.5f), 9), transform.rotation);
            enemysuu++;
            timer = 0.0f;
            enemysum++;
        }
        if (Stimer < bosatk.sponetime - 15 &&enemysuu < 2)
        {
            Instantiate(enemy[0], new Vector2(Random.Range(8f, -8.5f), 9), transform.rotation);
            enemysuu++;
            timer = 0.0f;
            enemysum++;
        }

        //Instantiate(tama, ShotPoint.position, ShotPoint.rotation);
    }
}
