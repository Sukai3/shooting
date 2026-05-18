using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;


//using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Audio;
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
    private float bomtimer=8.0f;
    public int kyokasuu = 0;
    public float time =1.0f;
    public static float atk=1;
    public static int bunnsinn = 0;
    public TextMeshProUGUI textMeshPro;
    public float interval = 1;
    public float bominterval = 7;
    private float shokiintrval;
    private int kougo=0;
    private int kyoka = 0;
    public int cost = 2;
    public int costpl = 1;
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    public AudioClip sound4;
    public AudioClip sound5;
    public AudioClip sound6;
    public static float bomdamage = 10;
    AudioSource audioSource;
    private float killtimer = 0.0f;
    private float killtime = 3.0f;
    public float hozonintrval;
    
    void Start()
    {
        //  animator =GetComponent<Animator>();
        interval  = hozonintrval;
        shokiintrval = hozonintrval;
        audioSource = GetComponent<AudioSource>();

        atk = 1;
        bunnsinn = 0;
        bomdamage = 10;
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        bomtimer += Time.deltaTime;
        kyokatimer += Time.deltaTime;
        if (bosatk.kill)
            killtimer += Time.deltaTime;
        if (killtimer >= killtime)
            SceneManager.LoadScene("Mresult");

        shot();

        if (Input.GetKeyDown(KeyCode.X) && bunnsinn >= 2 && bomtimer > bominterval)
        {
            audioSource.PlayOneShot(sound5);
            bomtimer = 0.0f;
            Instantiate(bom, ShotPoint.position, ShotPoint.rotation);
        }
        textMeshPro.text =""+bunnsinn;
        if (Input.GetKeyDown(KeyCode.B) && bunnsinn >= cost && kyoka<6)
        {
           
            bunnsinn -= cost;
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
            cost += costpl;
        }
        else if (Input.GetKeyDown(KeyCode.B)&&bunnsinn>=cost&&kyokasuu<6)
        {
            audioSource.PlayOneShot(sound4);
            bunnsinn -= cost;
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
            cost += costpl;
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
            audioSource.PlayOneShot(sound1);
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
                audioSource.PlayOneShot(sound2);
                SceneManager.LoadScene(i);
                Destroy(collision.gameObject);
            }
            else
            {
                audioSource.PlayOneShot(sound3);
                bunnsinn--;
                Destroy(collision.gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {

            if (bunnsinn <= 0)
            {
                audioSource.PlayOneShot(sound2);
                SceneManager.LoadScene(i);
                Destroy(collision.gameObject);
            }
            else
            {
                audioSource.PlayOneShot(sound3);
                bunnsinn--;
                sponer.enemysuu--;
                Destroy(collision.gameObject);
            }
           
        }
    }
}
  //切り替えるシーンの名前
    
    // Start is called before the first frame update
   
// Update is called once per frame

   
        
