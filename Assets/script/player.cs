using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;

//using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class player : MonoBehaviour
{

   
    public GameObject tama;
    public Transform ShotPoint;
    public float timer = 0.0f;
    public float kyokatime = 30;
    public float kyokatimer = 0.0f;
    public int kyokasuu = 0;
    public float time =1.0f;
    public static float atk=1;
    public static int bunnsinn = 0;
    public TextMeshProUGUI textMeshPro;
    public float interval = 1;
    private float shokiintrval;

    void Start()
    {
        //  animator =GetComponent<Animator>();
        shokiintrval = interval;

    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        kyokatimer += Time.deltaTime;
          
            shot();
        textMeshPro.text =""+bunnsinn;
        if (Input.GetKeyDown(KeyCode.B)&&bunnsinn>=2&&kyokasuu<6)
        {
            atk++;
            bunnsinn -= 2;
            kyokatimer = 0;
            interval += 0.4f;
            kyokasuu++;
        }
        if (kyokatimer >= kyokatime) 
        {
            kyokasuu = 0;
            atk = 1;
            interval = shokiintrval;
        }
    }


    
       
    
    void shot()
    {
        if (timer > time/interval)
        {
            Instantiate(tama, ShotPoint.position, ShotPoint.rotation);
            timer = 0;
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ETama"))
        {
            bunnsinn--;
            Destroy(collision.gameObject);
        }
    }
}