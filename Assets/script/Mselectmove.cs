using UnityEngine;
using UnityEngine.SceneManagement;

public class Mselectmove : MonoBehaviour
{
    private int Snow=0; //現在選択されているステージを確認する変数。Slectnowの略。
    public int MAXS = 2;//ステージの最大数。
    public int MINS = 0;//ステージの最低数。
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)&& Snow != MAXS)
        {
            Snow++;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && Snow != MINS)
        {
            Snow--;
        }
        selectplat();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            nextscenemane();
        }
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
                SceneManager.LoadScene("Samplescene");
                break;
            default:
                break;
        }
        
    }
}
