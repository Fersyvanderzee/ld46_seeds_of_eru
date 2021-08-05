using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour
{
    public Text winText;

    private CountdownTimer ct;


    void Start()
    {
        winText.text = "";
        ct = GameObject.FindObjectOfType(typeof(CountdownTimer)) as CountdownTimer;
    }

    void Update()
    {
        if(Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("Level1");
        }
    }


    public void GameOver()
    {
        winText.text = "GAME OVER! Press 'R' to try again.";
        ct.countdownText.text = "";
        ct.TimeLeftIndicator.text = "";
        ct.timer = false;
    }

    public void GameWon()
    {
        winText.text = "YOU WIN!";
        Invoke("EndOfGameScene", 2f);
        ct.countdownText.text = "";
        ct.TimeLeftIndicator.text = "";
        ct.timer = false;
    }

    public void EndOfGameScene()
    {
        SceneManager.LoadScene("EndGame");
    }
}
