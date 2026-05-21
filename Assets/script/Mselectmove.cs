using UnityEngine;
using UnityEngine.SceneManagement;

public class Mselectmove : MonoBehaviour
{
    private int Snow=0; //現在選択されているステージを確認する変数。Slectnowの略。
    public int MAXS = 2;//ステージの最大数。
    public int MINS = 0;//ステージの最低数。
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    AudioSource audioSource;
    private float timenow=0.0f;
    private float Maxtime = 1.0f;
    private bool a=false;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)&& Snow != MAXS && a == false)
        {
            audioSource.PlayOneShot(sound1);
            Snow++;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && Snow != MINS&&a==false)
        {
            audioSource.PlayOneShot(sound1);
            Snow--;
        }
        selectplat();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //nextscenemane();
            switch (Snow)
            {
                case 0:
                    if (a == false)
                    {
                        a = true;
                        audioSource.PlayOneShot(sound2);
                        //for (; timenow == Maxtime; timenow += 0.1f) 
                    }
                    break;
                default:
                    audioSource.PlayOneShot(sound3);
                    break;
            }
        }
        if (a) 
        {
            timenow += Time.deltaTime;
        }
        if (timenow > Maxtime) 
        {
            switch (Snow)
            {
                case 0:

                    SceneManager.LoadScene("Samplescene");
                    //for (; timenow == Maxtime; timenow += 0.1f) 
                    break;
                default:
                   
                    break;
            }
        }
            //
    }
    void selectplat()//どのステージならどこに枠を置くのかを書いておいてる関数。名前は適当()
    {
        switch (Snow) {
            case 0:
                transform.position = new Vector2(-5.0f, -1.0f);
                break;
            case 1:
                transform.position = new Vector2(0.0f, -1.0f);
                break;
            case 2:
                transform.position = new Vector2(5.0f, -1.0f);
                break;
            default:
                transform.position = new Vector2(0.0f, 0.0f);
                break;
        }
        
    }
    void nextscenemane()
    {
        switch (Snow)
        {
            case 0:
                audioSource.PlayOneShot(sound2);
                //for (; timenow == Maxtime; timenow += 0.1f) ;
                SceneManager.LoadScene("Samplescene");
                break;
            default:
                audioSource.PlayOneShot(sound3);
                break;
        }
        
    }
}
