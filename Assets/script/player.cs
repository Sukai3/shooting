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

    public string i = "SampleScene";
    public GameObject tama;
    public GameObject bom;
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
    private int kougo=0;
    private int kyoka = 0;

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
        if (Input.GetKeyDown(KeyCode.X))// && bunnsinn >= 2 && kyoka < 6)
            Instantiate(bom, ShotPoint.position, ShotPoint.rotation);
        textMeshPro.text =""+bunnsinn;
        if (Input.GetKeyDown(KeyCode.B) && bunnsinn >= 2 && kyoka<6)
        {
            bunnsinn -= 2;
            kyoka++;
            if (kougo == 0)
            {
                kougo++;
                atk++;
            }
            else
            {
                kougo = 0;
                interval += 0.4f;
                shokiintrval += 0.4f;
            }
        }
        else if (Input.GetKeyDown(KeyCode.B)&&bunnsinn>=2&&kyokasuu<6)
        {
            
            bunnsinn -= 2;
            kyokatimer = 0;
            kyokasuu++;
            if (kougo == 0)
            {
                kougo++;
                atk++;
            }
            else
            {
                kougo=0;
                interval += 0.4f;
            }

        }
        if (kyokatimer >= kyokatime) 
        {
            kyokasuu = 0;
            atk = 1;
            interval = shokiintrval;
        }
        if (Input.GetKeyDown(KeyCode.K))
            bunnsinn -= 6;
        if (Input.GetKeyDown(KeyCode.J))
            bunnsinn += 6;
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
            if (bunnsinn <= 0)
            {
                SceneManager.LoadScene(i);
                Destroy(collision.gameObject);
            }
            else
            {
                bunnsinn--;
                Destroy(collision.gameObject);
            }
        }
    }
}
  //切り替えるシーンの名前
    
    // Start is called before the first frame update
   
// Update is called once per frame

   
        
