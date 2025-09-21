using TMPro;
using UnityEngine;

public class Clickscript : MonoBehaviour
{
    public int ClickCount = 0;
    //public bool isDown = true;
    public TextMeshProUGUI scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        addScore();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            /*Debug.Log("Our beloved" + gameObject.name + "was clicked");
            print("Our beloved" + gameObject.name + "was clicked");
            isDown = false;*/
        }
    }

    void OnMouseDown()
    {
        //isDown = true;
        Debug.Log("Our beloved" +gameObject.name + "was clicked");
        print("Our beloved" + gameObject.name + "was clicked");
        ClickCount++;
        addScore();
    }

    void addScore()
    {
        if (scoreText != null)
        {
            scoreText.text = "Coins: " + ClickCount.ToString();
        }
    }

}
